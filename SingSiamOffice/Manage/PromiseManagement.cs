using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SingSiamOffice.Models;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using static MudBlazor.CategoryTypes;

namespace SingSiamOffice.Manage
{
    public class PromiseManagement
    {
        SingsiamdbContext db = new SingsiamdbContext();
        Models.SingSiamOld._01singsiamContext db_nv = new Models.SingSiamOld._01singsiamContext();
        Models.SingSiamOld2._02singsiamContext db_v = new Models.SingSiamOld2._02singsiamContext();
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
        public async Task AddPromiseTransaction(TransactionHistory items) 
        {
     
            int next_no = 0;
            string result = "";

            var branch_info = db.Branches.AsNoTracking().Where(s => s.Id == items.BranchId).FirstOrDefault();

            next_no = (int)branch_info.Accdocno + 1;
            string numberPart = branch_info.Code + "." + next_no.ToString("D7");
            result = numberPart;

            TransactionHistory toAdd = new TransactionHistory()
            {
                BranchId = items.BranchId,
                TransectionRef = result,
                SubjectId = 36,
                Price = items.Price,
                CreateAt = DateTime.Now,
                Receiptname = items.Receiptname,
                LoginId = items.LoginId,
                Detial = items.Detial,
                PaymentMethod = 1,
            };
            db.TransactionHistories.Add(toAdd);

           
            await db.SaveChangesAsync();


            var permitInfo = db.Promises.Where(s => s.Id == items.promise_id).FirstOrDefault();
            permitInfo.TransectionIdRef = toAdd.TransactionId;
            db.Entry(permitInfo).State = EntityState.Modified;
            await db.SaveChangesAsync();
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
                Receiptname = items.Receiptname,
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
      

            var to_edit = db.TransectionSlips.Where(s=>s.PromiseId == promiseId).FirstOrDefault();
            if (to_edit == null)
            {
                var promise_Id = db.Promises.Where(s=>s.Id == promiseId).FirstOrDefault();
                var to_del_transactiohistory = db.TransactionHistories.Where(s => s.TransactionId == promise_Id.TransectionIdRef).FirstOrDefault();
                if (to_del_transactiohistory != null)
                {
                    db.Entry(to_del_transactiohistory).State = EntityState.Deleted;
                    db.Entry(to_edit).State = EntityState.Deleted;
                }
            }
            else 
            {
                var promise_Id = db.Promises.Where(s => s.Id == promiseId).FirstOrDefault();
                var to_del_trans = db.TransactionHistories.Where(s => s.TransactionId == promise_Id.TransectionIdRef && s.SubjectId == 36).FirstOrDefault();
                if (to_del_trans != null)
                {
                    db.Entry(to_del_trans).State = EntityState.Deleted;
                    db.Entry(to_edit).State = EntityState.Deleted;
                }
                var to_del_transactiohistory = db.TransactionHistories.Where(s => s.TransactionId == to_edit.TransactionHistoryId).FirstOrDefault();
                if (to_del_transactiohistory != null)
                {
                    db.Entry(to_del_transactiohistory).State = EntityState.Deleted;
                    db.Entry(to_edit).State = EntityState.Deleted;
                }
            }
          
          
            var to_del = db.Promises.Where(s => s.Id == promiseId).FirstOrDefault();
            to_del.IsDelete = true;
            db.Entry(to_del).State = EntityState.Modified;
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
        //public async Task UpdateRunningNo(int branchId,string type)
        //{
        //    var toEdit = db.RunningNos.Where(s => s.BranchId == branchId && s.Type == type).FirstOrDefault();
        //    if (toEdit != null) 
        //    {
        //        toEdit.CurrentNo = toEdit.NextNo;
        //        toEdit.NextNo = toEdit.NextNo + 1;
        //        db.Entry(toEdit).State = EntityState.Modified;
        //        await db.SaveChangesAsync();
        //    }
        //}
        public async Task UpdateRunningNo(int branchId, string type)
        {
            var toEdit = await db.RunningNos
                .Where(s => s.BranchId == branchId && s.Type == type)
                .FirstOrDefaultAsync();

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
        //public async Task addReceipdesc(List<Receiptdesc> receiptdesc)
        //{
        //    try
        //    {

        //        foreach(var items in receiptdesc) 
        //        {
        //            db.Receiptdescs.Add(items);
        //            await db.SaveChangesAsync();


        //            decimal amount_receipdesc = 0;
        //            decimal amount_remain = 0;
        //           var  to_edit = db.Periodtrans.Include(s => s.Receiptdescs).Where(s => s.Id == items.PeriodtranId).FirstOrDefault();
        //            if (to_edit != null)
        //            {
        //                if (items.payment_method != 4)
        //                {
        //                    if (to_edit.Receiptdescs.Count > 0)
        //                    {
        //                        var amountPaid = to_edit.Receiptdescs.OrderByDescending(s => s.Id).ToList();
        //                        amount_receipdesc = (decimal)amountPaid.Sum(s => s.Amount) * -1;

        //                         amount_remain = (decimal)items.Periodtran.Amount;
        //                    }
        //                    else 
        //                    {
        //                        amount_receipdesc = (decimal)to_edit.Amount *-1;
        //                        amount_remain = (decimal)items.Amount;
        //                    }


        //                    if (amount_receipdesc == (amount_remain))
        //                    {

        //                        to_edit.Cappaid = Math.Abs((decimal)to_edit.Receiptdescs.Sum(s=>s.Cappaid));
        //                        to_edit.Intpaid = Math.Abs((decimal)to_edit.Receiptdescs.Sum(s => s.Intpaid));
        //                        to_edit.Paidamount = Math.Abs((decimal)to_edit.Receiptdescs.Sum(s => s.Amount));
        //                        to_edit.Ispaid = true;
        //                        to_edit.Status = 1;
        //                    }
        //                    else
        //                    {
        //                        to_edit.Cappaid = Math.Abs((decimal)items.Cappaid);
        //                        to_edit.Intpaid = Math.Abs((decimal)items.Intpaid);
        //                        to_edit.Paidamount = Math.Abs((decimal)items.Amount);
        //                        to_edit.Ispaid = false;
        //                    }


        //                    to_edit.Paidremain = items.pending_amount;
        //                }
        //                else 
        //                {
        //                    to_edit.Deposit = to_edit.Deposit + items.Deposit;
        //                    to_edit.Paidremain = items.pending_amount;
        //                }


        //                db.Entry(to_edit).State = EntityState.Modified;
        //                await db.SaveChangesAsync();

        //            }
        //        }


        //    }
        //    catch (Exception ex)
        //    {

        //    }


        //}

        public async Task addReceipdesc(List<Receiptdesc> receiptdesc)
        {
            try
            {
                foreach (var items in receiptdesc)
                {
                    db.Receiptdescs.Add(items);

                    decimal amount_receipdesc = 0;
                    decimal amount_remain = 0;
                    var to_edit = await db.Periodtrans
                        .Include(s => s.Receiptdescs)
                        .FirstOrDefaultAsync(s => s.Id == items.PeriodtranId);

                    if (to_edit != null)
                    {
                        if (items.payment_method != 4)
                        {
                            var receiptdescs = to_edit.Receiptdescs ?? new List<Receiptdesc>();
                            if (receiptdescs.Count > 0)
                            {
                                var amountPaid = receiptdescs.OrderByDescending(s => s.Id).ToList();
                                amount_receipdesc = (decimal)amountPaid.Sum(s => s.Amount) * -1;
                                amount_remain = (decimal)items.Periodtran.Amount;
                            }
                            else
                            {
                                amount_receipdesc = (decimal)to_edit.Amount * -1;
                                amount_remain = (decimal)items.Amount;
                            }

                            if (amount_receipdesc == amount_remain)
                            {
                                to_edit.Cappaid = Math.Abs((decimal)receiptdescs.Sum(s => s.Cappaid));
                                to_edit.Intpaid = Math.Abs((decimal)receiptdescs.Sum(s => s.Intpaid));
                                to_edit.Paidamount = Math.Abs((decimal)receiptdescs.Sum(s => s.Amount));
                                to_edit.Ispaid = true;
                                to_edit.Status = 1;
                            }
                            else
                            {
                                to_edit.Cappaid = Math.Abs((decimal)items.Cappaid);
                                to_edit.Intpaid = Math.Abs((decimal)items.Intpaid);
                                to_edit.Paidamount = Math.Abs((decimal)items.Amount);
                                to_edit.Ispaid = false;
                            }

                            to_edit.Paidremain = items.pending_amount;
                        }
                        else
                        {
                            to_edit.Deposit = to_edit.Deposit + items.Deposit;
                            to_edit.Paidremain = items.pending_amount;
                        }

                        db.Entry(to_edit).State = EntityState.Modified;
                    }
                }

                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Consider logging the exception here
            }
        }



        public async Task<bool> addReceipdesc_nv(List<Models.SingSiamOld.Receiptdesc> receiptdesc)
        {
            try
            {

                foreach (var items in receiptdesc)
                {
                    db_nv.Receiptdescs.Add(items);
                    await db_nv.SaveChangesAsync();


                    decimal amount_receipdesc = 0;
                    decimal amount_remain = 0;
                    var to_edit = db_nv.Periodtrans.Where(s => s.Promiseno == items.Promiseno && s.Period == items.Period).FirstOrDefault();
                  
                    if (to_edit != null)
                    {
                        if (items.receipt_desc != "รับฝากเงินล่วงหน้า")
                        {
                            to_edit.Cappaid = (double)items.Cappaid * -1;
                            to_edit.Intpaid = (double)items.Intpaid * -1;
                            to_edit.Paidamount = (double)items.Amount * -1;

                            if (to_edit.Amount == ((items.Amount) * -1))
                            { 
                                to_edit.ck_paid = true;
                                to_edit.Status = 0;
                            }
                            else
                            {
                                to_edit.ck_paid = false;
                            }


                         //   to_edit.Paidremain = items.pending_amount;
                        }
                        else
                        {
                            to_edit.Deposit = to_edit.Deposit + items.Deposit;
                        }


                        db_nv.Entry(to_edit).State = EntityState.Modified;
                        await db_nv.SaveChangesAsync();

                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }
        public async Task<bool> addReceipdesc_v(List<Models.SingSiamOld2.Receiptdesc> receiptdesc)
        {
            try
            {

                foreach (var items in receiptdesc)
                {
                    db_v.Receiptdescs.Add(items);
                    await db_v.SaveChangesAsync();


                    decimal amount_receipdesc = 0;
                    decimal amount_remain = 0;
                    var to_edit = db_v.Periodtrans.Where(s => s.Promiseno == items.Promiseno && s.Period == items.Period).FirstOrDefault();

                    if (to_edit != null)
                    {
                        if (items.receipt_desc != "รับฝากเงินล่วงหน้า")
                        {
                            to_edit.Cappaid = (double)items.Cappaid * -1;
                            to_edit.Intpaid = (double)items.Intpaid * -1;
                            to_edit.Paidamount = (double)items.Amount * -1;

                            if (to_edit.Amount == ((items.Amount) * -1))
                            {
                                to_edit.ck_paid = true;
                                to_edit.Status = 0;
                            }
                            else
                            {
                                to_edit.ck_paid = false;
                            }


                            //   to_edit.Paidremain = items.pending_amount;
                        }
                        else
                        {
                            to_edit.Deposit = to_edit.Deposit + items.Deposit;
                        }


                        db_v.Entry(to_edit).State = EntityState.Modified;
                        await db_v.SaveChangesAsync();

                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
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
                toEdit.UpdatedOn = DateTime.Now;
                foreach (var periodTrans in toEdit.Periodtrans)
                {
                    periodTrans.Status = 2;
                }

                db.Entry(toEdit).State = EntityState.Modified;

             
                foreach (var periodTrans in toEdit.Periodtrans)
                {
                    db.Entry(periodTrans).State = EntityState.Modified;
                }
                await db.SaveChangesAsync();

            }
        }
        public async Task updateClosePromiseNV(string promise_no)
        {
            var data = db_nv.Periodtrans.AsNoTracking().Where(s => s.Promiseno == promise_no).ToList();
            var cnt_finish = data.Where(s => s.ck_paid == true).Count();
            var cnt_period = data.FirstOrDefault().Periods;
            var toEdit = db_nv.Promises.Where(s => s.Promiseno == promise_no).FirstOrDefault();
            toEdit.Status = 2;

            foreach (var periodTrans in data)
            {
                periodTrans.Status = 2;
            }

            db_nv.Entry(toEdit).State = EntityState.Modified;


            foreach (var periodTrans in data)
            {
                db_nv.Entry(periodTrans).State = EntityState.Modified;
            }
            await db_nv.SaveChangesAsync();
            //if (cnt_period == cnt_finish)
            //{
            //    var toEdit = db_nv.Promises.Where(s => s.Promiseno == promise_no).FirstOrDefault();
            //    toEdit.Status = 2;
             
            //    foreach (var periodTrans in data)
            //    {
            //        periodTrans.Status = 2;
            //    }

            //    db_nv.Entry(toEdit).State = EntityState.Modified;


            //    foreach (var periodTrans in data)
            //    {
            //        db_nv.Entry(periodTrans).State = EntityState.Modified;
            //    }
            //    await db_nv.SaveChangesAsync();

            //}
        }
        public async Task updateClosePromiseV(string promise_no)
        {
            var data = db_v.Periodtrans.AsNoTracking().Where(s => s.Promiseno == promise_no).ToList();
            var cnt_finish = data.Where(s => s.ck_paid == true).Count();
            var cnt_period = data.FirstOrDefault().Periods;

            var toEdit = db_v.Promises.Where(s => s.Promiseno == promise_no).FirstOrDefault();
            toEdit.Status = 2;

            foreach (var periodTrans in data)
            {
                periodTrans.Status = 2;
            }

            db_v.Entry(toEdit).State = EntityState.Modified;


            foreach (var periodTrans in data)
            {
                db_v.Entry(periodTrans).State = EntityState.Modified;
            }
            await db_v.SaveChangesAsync();
            //if (cnt_period == cnt_finish)
            //{
            //    var toEdit = db_v.Promises.Where(s => s.Promiseno == promise_no).FirstOrDefault();
            //    toEdit.Status = 2;

            //    foreach (var periodTrans in data)
            //    {
            //        periodTrans.Status = 2;
            //    }

            //    db_v.Entry(toEdit).State = EntityState.Modified;


            //    foreach (var periodTrans in data)
            //    {
            //        db_v.Entry(periodTrans).State = EntityState.Modified;
            //    }
            //    await db_v.SaveChangesAsync();

            //}
        }

        #region addReceipttrans no vat

        public async Task<Models.SingSiamOld.Receipttran> addReceipttran_nv(Models.SingSiamOld.Receipttran receipttrans)
        {
            try
            {

                db_nv.Receipttrans.Add(receipttrans);
                await db_nv.SaveChangesAsync();

                var receiptNo = db_nv.Stations.Where(s => s.Ipaddress == receipttrans.Branch).FirstOrDefault();
                receiptNo.Receiptno = receiptNo.Receiptno + 1;
                db_nv.Entry(receiptNo).State = EntityState.Modified;
                await db_nv.SaveChangesAsync();

                var branchId = db.Branches.AsNoTracking().Where(s => s.BranchCode == receipttrans.Branch).FirstOrDefault().Id;
                int payment_method = 0;
                 if (receipttrans.Cashpaid == 1)
                {
                    payment_method = 1;
                }
                else if (receipttrans.Transferpaid == 1)
                {
                    payment_method = 2;
                }
                int totalAmount = 0;
                if (receipttrans.Receiptdesc == "ปิดสัญญาก่อนกำหนด")
                {
                    totalAmount = (int)receipttrans.Netamount;
                }
                else 
                {
                    totalAmount = (int)receipttrans.Amount;
                }
               
                TransactionHistory Add_expren = new TransactionHistory()
                {
                    BranchId = branchId,
                    TransectionRef = receipttrans.Receiptno,
                    SubjectId = 31,
                    Price = totalAmount,
                    CreateAt = DateTime.Now,
                    Receiptname = receipttrans.Usercode,
                 
                    Detial = receipttrans.Receiptno,
                    PaymentMethod = payment_method,
                };
                db.TransactionHistories.Add(Add_expren);
                await db.SaveChangesAsync();

                return receipttrans;


            }
            catch (Exception ex)
            {
                return null;
            }


        }
        public async Task<Models.SingSiamOld2.Receipttran> addReceipttran_v(Models.SingSiamOld2.Receipttran receipttrans)
        {
            try
            {

                db_v.Receipttrans.Add(receipttrans);
                await db_v.SaveChangesAsync();

                var receiptNo = db_v.Stations.Where(s => s.Ipaddress == receipttrans.Branch).FirstOrDefault();
                receiptNo.Receiptno = receiptNo.Receiptno + 1;
                db_v.Entry(receiptNo).State = EntityState.Modified;
                await db_v.SaveChangesAsync();

                var branchId = db.Branches.AsNoTracking().Where(s => s.BranchCode == receipttrans.Branch).FirstOrDefault().Id;
                int payment_method = 0;
                if (receipttrans.Cashpaid == 1)
                {
                    payment_method = 1;
                }
                else if (receipttrans.Transferpaid == 1)
                {
                    payment_method = 2;
                }
                int totalAmount = 0;
                if (receipttrans.Receiptdesc == "ปิดสัญญาก่อนกำหนด")
                {
                    totalAmount = (int)receipttrans.Netamount;
                }
                else
                {
                    totalAmount = (int)receipttrans.Amount;
                }
                TransactionHistory Add_expren = new TransactionHistory()
                {
                    BranchId = branchId,
                    TransectionRef = receipttrans.Receiptno,
                    SubjectId = 31,
                    Price = totalAmount,
                    CreateAt = DateTime.Now,
                    Receiptname = receipttrans.Usercode,

                    Detial = receipttrans.Receiptno,
                    PaymentMethod = payment_method,
                };
                db.TransactionHistories.Add(Add_expren);
                await db.SaveChangesAsync();

                return receipttrans;


            }
            catch (Exception ex)
            {
                return null;
            }


        }

        #endregion
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
                        update_periodtrans(item.Id,item.PeriodtranId);
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

                var toEdit_Promise = db.Promises.Where(s => s.Id == toEdit.PromiseId).FirstOrDefault();
                toEdit_Promise.Status = 0;
                db.Entry(toEdit_Promise).State = EntityState.Modified;

                db.Receipttrans.Remove(toEdit);
                await db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task update_periodtrans(int receiptId, int periodtransId)
        {
            var Receipttran_info = db.Receiptdescs.Where(s => s.PeriodtranId == periodtransId && s.Id != receiptId).ToList();



            var toEdit = db.Periodtrans.Where(s => s.Id == periodtransId).FirstOrDefault();



            toEdit.Cappaid = Receipttran_info.Sum(s => s.Cappaid) * -1;


            toEdit.Intpaid = Receipttran_info.Sum(s => s.Intpaid) * -1;


            toEdit.Deposit = Receipttran_info.Sum(s => s.Deposit);


            var paidamount = Receipttran_info.Sum(s => s.Amount);

            if (paidamount != toEdit.Amount)
            {
                toEdit.Status = 0;
                toEdit.Ispaid = false;
                toEdit.Paidamount = 0;
            }




            db.Entry(toEdit).State = EntityState.Modified;
            //  await db.SaveChangesAsync();
        }


        //SingsiamOld
        public async Task<bool> delete_receiptdescNV(string receipttransno)
        {
            try
            {


                var toEdit = db_nv.Receiptdescs.Where(s => s.Receiptno == receipttransno).ToList();
                foreach (var item in toEdit)
                {
                  
                       // update_periodtrans(item.Id, item.PeriodtranId);
                        Models.SingSiamOld.ReceiptdescCancel toAdd = new Models.SingSiamOld.ReceiptdescCancel();

                        toAdd.Promiseno = item.Promiseno;
                        toAdd.Branch = item.Branch;
                        toAdd.Customer = item.Customer;
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
                   
                        db_nv.ReceiptdescCancels.Add(toAdd);
                        // await db.SaveChangesAsync();
                    
                }
                db_nv.Receiptdescs.RemoveRange(toEdit);
                await db_nv.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<bool> delete_receipttransNV(string receipttransNo)
        {
            try
            {

                var toDel = db.TransactionHistories.Where(s => s.TransectionRef == receipttransNo).FirstOrDefault();
                db.TransactionHistories.Remove(toDel);
                //  await db.SaveChangesAsync();

                var toEdit = db_nv.Receipttrans.Where(s => s.Receiptno == receipttransNo).FirstOrDefault();
               Models.SingSiamOld.ReceipttranCancel toAdd = new Models.SingSiamOld.ReceipttranCancel();
                toAdd.Promiseno = toEdit.Promiseno;
                toAdd.Branch = toEdit.Branch;
                toAdd.Customer = toEdit.Customer;
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
                db_nv.ReceipttranCancels.Add(toAdd);
                //  await db.SaveChangesAsync();

                var toEdit_Promise = db_nv.Promises.Where(s => s.Promiseno == toEdit.Promiseno).FirstOrDefault();
                toEdit_Promise.Status = 0;
                db_nv.Entry(toEdit_Promise).State = EntityState.Modified;

                db_nv.Receipttrans.Remove(toEdit);
                await db_nv.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task update_periodtransNV(string promise_no,string receipt_no, int period)
        {
            var Receipttran_info = db_nv.ReceiptdescCancels.Where(s => s.Receiptno == receipt_no).ToList();

            foreach(var items in Receipttran_info) 
            {
                var toEdit = db_nv.Periodtrans.Where(s => s.Promiseno == items.Promiseno && s.Period == period).FirstOrDefault();
                toEdit.Cappaid = toEdit.Cappaid - items.Cappaid;
                toEdit.Intpaid = toEdit.Intpaid - items.Intpaid;
                toEdit.Deposit = toEdit.Deposit - items.Deposit;
                toEdit.Paidamount = toEdit.Paidamount - items.Amount;
                db_nv.Entry(toEdit).State = EntityState.Modified;
            }
            await db_nv.SaveChangesAsync();
        }


        //SingsiamOld2

        #endregion
    }
}
