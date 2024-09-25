﻿using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SingSiamOffice.Models;
using System.Diagnostics.Eventing.Reader;
using System.Linq;

namespace SingSiamOffice.Manage
{
    public class PromiseManagement
    {
        SingsiamdbContext db = new SingsiamdbContext();
        public async Task<Promise> addPromise(Promise promise) 
        {
       
            try
            {
                var obj = JsonConvert.SerializeObject(promise);
                db.Promises.Add(promise);
                await db.SaveChangesAsync();



                return promise;
            }
            catch (Exception ex)
            {
                var tt = ex.InnerException.Message;
                return null;
            }
        }
        public async Task<bool> addTaxPromise(TransactionHistory items) 
        {

           TransactionHistory Add_expren = new TransactionHistory()
            {
                BranchId = items.BranchId,
                TransectionRef = items.TransectionRef,
                SubjectId = 7,
                Price = items.Price,
                CreateAt = DateTime.Now,
                LoginId = items.LoginId,
                Detial = items.Detial,
                PaymentMethod = 1,
            };
            db.TransactionHistories.Add(Add_expren);
            await db.SaveChangesAsync();
            var data = new
            {
                refcode = items.TransectionRef,
                tdec = DateTime.Now.ToString("dd/MM/yyyy"),
                price = items.Price,
                detail = items.Detial,
                refcodetrans = items.refcodetrans,
            };
            string jsonString = JsonConvert.SerializeObject(data);
            var new_add = new TransectionSlip();
            new_add.TransactionHistoryId = Add_expren.TransactionId;
            new_add.Doc = jsonString;
            new_add.PromiseId = items.promise_id;
            db.TransectionSlips.Add(new_add);
            return true;
        }
        public async Task<bool> Delete_Promise(int promiseId) 
        {
            var to_del = db.Promises.Where(s=>s.Id == promiseId).FirstOrDefault();
            to_del.IsDelete = true;
            db.Entry(to_del).State = EntityState.Modified;

            var to_edit = db.TransectionSlips.Where(s=>s.PromiseId == promiseId).FirstOrDefault();

            var to_del_transactiohistory = db.TransactionHistories.Where(s => s.TransactionId == to_edit.TransactionHistoryId).FirstOrDefault();
            if (to_del_transactiohistory != null)
            {
                db.Entry(to_del_transactiohistory).State = EntityState.Deleted;

            }
            if (to_edit != null)
            {
                db.Entry(to_edit).State = EntityState.Deleted;
              
            }
            await db.SaveChangesAsync();
            return true;
        }
        public async Task addGuarantor(List<Guarantor> guarantor)
        {
            try
            {
                foreach (Guarantor guarantor1 in guarantor)
                {
                    db.Guarantors.Add(guarantor1);
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception ex) {}
        }
        public async Task<bool> addPeriodtran(List<Periodtran> periodtrans)
        {
            try
            {
                foreach (Periodtran periodtran in periodtrans) 
                {
                    db.Periodtrans.Add(periodtran);
                    await db.SaveChangesAsync();

                }

                return true;
            }
            catch (Exception ex) { return false; }
        }
        public async Task UpdateRunningNo(int branchId,string type)
        {
            var toEdit = db.RunningNos.Where(s => s.BranchId == branchId && s.Type == type).FirstOrDefault();
            if (toEdit != null) 
            {
                toEdit.CurrentNo = toEdit.NextNo;
                toEdit.NextNo = toEdit.NextNo + 1;
                db.Entry(toEdit).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
        }


        public async Task<Receipttran> addReceipttran(Receipttran receipttrans)
        {
            try
            {
               
                    db.Receipttrans.Add(receipttrans);
                    await db.SaveChangesAsync();

                return receipttrans;


            }
            catch (Exception ex) 
            {
                return null;
            }

   
        }
        public async Task addReceipdesc(List<Receiptdesc> receiptdesc)
        {
            try
            {
                foreach(var items in receiptdesc) 
                {
                    db.Receiptdescs.Add(items);
                    await db.SaveChangesAsync();


                    var to_edit = db.Periodtrans.Where(s => s.Id == items.PeriodtranId).FirstOrDefault();
                    if (to_edit != null)
                    {
                        if (items.payment_method != 4)
                        {
                            var amount_remain = items.Amount;
                            if (to_edit.Amount == (amount_remain * -1))
                            {
                                to_edit.Ispaid = true;
                                to_edit.Status = 1;
                            }
                            else
                            {
                                to_edit.Ispaid = false;
                            }

                            to_edit.Cappaid = Math.Abs((decimal)items.Cappaid);
                            to_edit.Intpaid = Math.Abs((decimal)items.Intpaid);
                            to_edit.Paidamount = Math.Abs((decimal)items.Amount);
                            to_edit.Paidremain = items.pending_amount;
                        }
                        else 
                        {
                            to_edit.Deposit = to_edit.Deposit + items.Deposit;
                        }
                     
                     
                        db.Entry(to_edit).State = EntityState.Modified;
                        await db.SaveChangesAsync();

                    }
                }
               

            }
            catch (Exception ex)
            {
               
            }


        }

        public async Task updateClosePromise(int promiseId) 
        {
            var data = db.Periodtrans.AsNoTracking().Include(s=>s.Promise).Where(s => s.PromiseId == promiseId).ToList();
            var cnt_finish = data.Where(s=>s.Ispaid == true).Count();
            var cnt_period = data.FirstOrDefault().Promise.Periods;
            if (cnt_period == cnt_finish)
            { 
                var toEdit = db.Promises.Include(s=>s.Periodtrans).Where(s=>s.Id ==promiseId).FirstOrDefault();
                toEdit.Status = 2;
                foreach (var periodTrans in toEdit.Periodtrans)
                {
                  
                    periodTrans.Status = 2;
                }

              
                db.Entry(toEdit).State = EntityState.Modified;

             
                foreach (var periodTrans in toEdit.Periodtrans)
                {
                    db.Entry(periodTrans).State = EntityState.Modified;
                }

             
            }
        }
        #region DeletePayment
        public async Task<bool> delete_receiptdesc(int receipttransId) 
        {
            try
            {


                var toEdit = db.Receiptdescs.Where(s => s.ReceipttranId == receipttransId).ToList();
                foreach (var item in toEdit)
                {
                    if (item.ReceipttranId != null)
                    {
                        update_periodtrans(item.PeriodtranId);
                        Models.ReceiptdescCancle toAdd = new ReceiptdescCancle();
                        toAdd.PromiseId = item.PromiseId;
                        toAdd.BranchId = item.BranchId;
                        toAdd.CustomerId = item.CustomerId;
                        toAdd.Receiptno = item.Receiptno;
                        toAdd.Tdate = item.Tdate;
                        toAdd.Tdateformat = item.Tdateformat;
                        toAdd.Tdatecal = item.Tdatecal;
                        toAdd.Tdatecalformat = item.Tdatecalformat;
                        toAdd.Period = item.Period;
                        toAdd.Perioddate = item.Perioddate;
                        toAdd.Cappaid = item.Cappaid;
                        toAdd.Intpaid = item.Intpaid;
                        toAdd.Amount = item.Amount;
                        toAdd.Usercode = item.Usercode;
                        toAdd.Clientno = item.Clientno;
                        toAdd.Clientbranch = item.Clientbranch;
                        toAdd.Loanplus = item.Loanplus;
                        toAdd.Loanminus = item.Loanminus;
                        toAdd.Oldint = item.Oldint;
                        toAdd.Newint = item.Newint;
                        toAdd.Periodchg = item.Periodchg;
                        toAdd.Deposit = item.Deposit;
                        toAdd.Chargeamt = item.Chargeamt;
                        toAdd.Lateamt = item.Lateamt;
                        toAdd.Srvpaid = item.Srvpaid;
                        toAdd.Inspaid = item.Inspaid;
                        db.ReceiptdescCancles.Add(toAdd);
                       // await db.SaveChangesAsync();
                    }
                }
                db.Receiptdescs.RemoveRange(toEdit);
                await db.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                return false;   
            }
        }

        public async Task<bool> delete_receipttrans(int receipttransId) 
        {
            try
            {

                var toDel = db.TransactionHistories.Where(s => s.ReceiopttranId == receipttransId).FirstOrDefault();
                db.TransactionHistories.Remove(toDel);
              //  await db.SaveChangesAsync();

                var toEdit = db.Receipttrans.Where(s => s.Id == receipttransId).FirstOrDefault();
                ReceipttranCancle toAdd = new ReceipttranCancle();
                toAdd.PromiseId = toEdit.PromiseId;
                toAdd.BranchId = toEdit.BranchId;
                toAdd.CustomerId = toEdit.CustomerId;
                toAdd.Taxpromise = toEdit.Taxpromise;
                toAdd.Specialtaxpromise = toEdit.Specialtaxpromise;
                toAdd.Ptype = toEdit.Ptype;
                toAdd.Receiptno = toEdit.Receiptno;
                toAdd.Receiptdesc = toEdit.Receiptdesc;
                toAdd.Tdate = toEdit.Tdate;
                toAdd.Tdateformat = toEdit.Tdateformat;
                toAdd.Tdatecal = toEdit.Tdatecal;
                toAdd.Tdatecalformat = toEdit.Tdatecalformat;
                toAdd.Amount = toEdit.Amount;
                toAdd.Deposit = toEdit.Deposit;
                toAdd.Charge1amt = toEdit.Charge1amt;
                toAdd.Charge2amt = toEdit.Charge2amt;
                toAdd.Arbalance = toEdit.Arbalance;
                toAdd.Arperiod = toEdit.Arperiod;
                toAdd.Cappaid = toEdit.Cappaid;
                toAdd.Intpaid = toEdit.Intpaid;
                toAdd.Arremain = toEdit.Arremain;
                toAdd.Capremain = toEdit.Capremain;
                toAdd.Intremain = toEdit.Intremain;
                toAdd.Closefee = toEdit.Closefee;
                toAdd.Intdiscamt = toEdit.Intdiscamt;
                toAdd.Periodremain = toEdit.Periodremain;
                toAdd.Intplus = toEdit.Intplus;
                toAdd.Discount = toEdit.Discount;
                toAdd.Netamount = toEdit.Netamount;
                toAdd.Resultamount = toEdit.Resultamount;
                toAdd.Usercode = toEdit.Usercode;
                toAdd.Clientno = toEdit.Clientno;
                toAdd.Cashpaid = toEdit.Cashpaid;
                toAdd.Transferpaid = toEdit.Transferpaid;
                toAdd.Transferdate = toEdit.Transferdate;
                toAdd.Otherpaid = toEdit.Otherpaid;
                toAdd.Clientbranch = toEdit.Clientbranch;
                toAdd.Loanplus = toEdit.Loanplus;
                toAdd.Loanminus = toEdit.Loanminus;
                toAdd.Oldint = toEdit.Oldint;
                toAdd.Newint = toEdit.Newint;
                toAdd.Periodchg = toEdit.Periodchg;
                toAdd.Srvpaid = toEdit.Srvpaid;
                toAdd.Inspaid = toEdit.Inspaid;
                toAdd.Currentperiod = toEdit.Currentperiod;
                toAdd.Closecase = toEdit.Closecase;
                db.ReceipttranCancles.Add(toAdd);
               //  await db.SaveChangesAsync();


                db.Receipttrans.Remove(toEdit);
                await db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) 
            {
                return false;
            }
        }
        public async Task update_periodtrans(int periodtransId) 
        {
            var toEdit = db.Periodtrans.Where(s => s.Id == periodtransId).FirstOrDefault();
            toEdit.Cappaid = 0;
            toEdit.Intpaid = 0;
            toEdit.Paidamount = 0;
            toEdit.Status = 0;
            toEdit.Ispaid = false;
            toEdit.Deposit = 0;
            toEdit.Paidremain = 0;
            db.Entry(toEdit).State = EntityState.Modified;
          //  await db.SaveChangesAsync();
        }

        #endregion
    }
}
