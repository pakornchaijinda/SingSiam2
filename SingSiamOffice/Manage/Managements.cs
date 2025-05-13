using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SingSiamOffice.Helpers;
using SingSiamOffice.Models;
using SingSiamOffice.Models.SingSiamOld;
using SingSiamOffice.Models.SingSiamOld2;
using System.ComponentModel;
using System.Globalization;
using static MudBlazor.CategoryTypes;

namespace SingSiamOffice.Manage
{
    public class Managements
    {
        SingsiamdbContext db = new SingsiamdbContext();
        _01singsiamContext db_nv = new _01singsiamContext();
        _02singsiamContext db_v = new _02singsiamContext(); 
        NumberToText text = new NumberToText();
        public async Task<List<Models.Promise>> GetPromisebyCustomerId(int customer_id)
        {
            var data = db.Promises.AsNoTracking().Include(s=>s.Receipttrans).Include(s => s.Customer).Include(s => s.Branch).Include(s => s.Product).Include(s => s.Periodtrans).Include(s => s.Province)
                .Where(s => s.CustomerId == customer_id && s.IsDelete == false).OrderBy(s=>s.Status).ThenByDescending(s=>s.UpdatedOn).ThenByDescending(s => s.Tdatetime).ToList();
           
            foreach (var promise in data) 
            {
                promise.StatusName = await text.PromiseStatus((int)promise.Status);
                promise.FormatCapital = promise.Capital.Value.ToString("N0");
                promise.FormatAmount = promise.Amount.Value.ToString("N0");
                promise.FormatInterest = promise.Intrate.Value.ToString("N0");
                promise.FormatChargeamt = promise.Chargeamt.Value.ToString("N0");
            }
            return data;
        }
        public async Task<List<Models.SingSiamOld.Getpromise>> GetPromiseNVbyCustomerId(string customer_natid)
        {
            var list_data = db_nv.Getpromises.Where(s => s.Customer == customer_natid).ToList();

            return list_data;
        }
        public async Task<List<Models.SingSiamOld2.Getpromise>> GetPromiseVbyCustomerId(string customer_natid)
        {
            var list_data = db_v.Getpromises.Where(s => s.Customer == customer_natid).ToList();

            return list_data;
        }
        public async Task<Models.SingSiamOld.Promise> GetPromiseDetailNVbyPermiseNo(string permiseNo)
        {
            var list_data = db_nv.Promises.Where(s => s.Promiseno == permiseNo).FirstOrDefault();
        
          list_data.ProductName = db_nv.Products.Where(s => s.Code == list_data.Product).FirstOrDefault().Name;
            return list_data;
        }
        public async Task<Models.SingSiamOld2.Promise> GetPromiseDetailVbyPermiseNo(string permiseNo)
        {
            var list_data = db_v.Promises.Where(s => s.Promiseno == permiseNo).FirstOrDefault();

            list_data.ProductName = db_nv.Products.Where(s => s.Code == list_data.Product).FirstOrDefault().Name;
            return list_data;
        }
        public async Task<List<Models.SingSiamOld.Periodtran>> GetPromiseDetailNVbyPermiseNoDetail(string permiseNo)
        {
            var list_data = db_nv.Periodtrans.Where(s => s.Promiseno == permiseNo).ToList();

            foreach (var items in list_data)
            {
                items.ck_deposit = items.Deposit != 0 ? true : false;
                items.ck_paid = items.Cappaid != 0 || items.Intpaid != 0 ? true : false;
                items.Receiptdescs = db_nv.Receiptdescs.Where(s => s.Promiseno == items.Promiseno && s.Period == items.Period).ToList();
            }
            return list_data;
        }
        public async Task<Models.Promise> GetPromisebyPromiseId(int promise_id)
        {
            var data = db.Promises.AsNoTracking().Include(s => s.Customer).Include(s => s.Branch).Include(s => s.Product).Include(s => s.Periodtrans).Include(s => s.Province)
                .Where(s => s.Id == promise_id && s.IsDelete == false).FirstOrDefault();

            data.FormatCapital = data.Capital.Value.ToString("N0");
            data.FormatAmount = data.Amount.Value.ToString("N0");
            data.FormatInterest = data.Periodtrans.FirstOrDefault().Interest.Value.ToString("N0");
            data.FormatChargeamt = data.Chargeamt.Value.ToString("N0");
            
            return data;
        }
        public async Task<Models.Promise> GetClosePromisebyPromiseId(int promise_id)
        {
            var data = db.Promises.AsNoTracking().Include(s => s.Customer).Include(s => s.Branch).Include(s => s.Product).Include(s => s.Periodtrans).Include(s => s.Province)
                .Where(s => s.Id == promise_id && s.Status == 2 && s.IsDelete == false).FirstOrDefault();

            data.FormatCapital = data.Capital.Value.ToString("N0");
            data.FormatAmount = data.Amount.Value.ToString("N0");
            data.FormatInterest = data.Periodtrans.FirstOrDefault().Interest.Value.ToString("N0");
            data.FormatChargeamt = data.Chargeamt.Value.ToString("N0");

            return data;
        }

        #region SingSiamOld
        public async Task<int?> GetPeriodNumber(List<Models.SingSiamOld.Periodtran> periods, DateTime paymentDate)
        {
            foreach (var period in periods)
            {
                if (DateTime.TryParseExact(period.Tdateformat, "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out DateTime periodDate))
                {
                    if (paymentDate >= periodDate)
                    {
                        return period.Period;
                    }
                }
                else
                {
                    // กรณี parse ไม่ได้ จะทำยังไงดี? (เช่น Log error ไว้)
                }
            }

            return 0; // ถ้าไม่เจอให้อยู่ก่อนงวดแรก
        }
        public async Task<int?> GetPeriodNumberV(List<Models.SingSiamOld2.Periodtran> periods, DateTime paymentDate)
        {
            foreach (var period in periods)
            {
                if (DateTime.TryParseExact(period.Tdateformat, "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out DateTime periodDate))
                {
                    if (paymentDate >= periodDate)
                    {
                        return period.Period;
                    }
                }
                else
                {
                    // กรณี parse ไม่ได้ จะทำยังไงดี? (เช่น Log error ไว้)
                }
            }

            return 0; // ถ้าไม่เจอให้อยู่ก่อนงวดแรก
        }
        public async Task<int?> Calarperiod(string promise_on)
        {
            var datetopay = db_nv.Periodtrans.AsNoTracking().Where(s => s.ck_paid == true).LastOrDefault().Tdate;
            var Paymentduedate = DateTime.ParseExact(datetopay, "yyyyMMdd", null);
            var currentdate = DateTime.ParseExact(DateTime.Now.ToString("yyyyMMdd"), "yyyyMMdd", null);
            TimeSpan diffdate = currentdate - Paymentduedate;
           
            return diffdate.Days;
        }
        public async Task<int?> Calperiodremain(string promise_on,decimal totalpay)
        {
            var amount = db_nv.Periodtrans.AsNoTracking().Where(s => s.ck_paid == true).LastOrDefault().Amount;
            var totalremain = db_nv.Periodtrans.AsNoTracking().Where(s => s.ck_paid == false).Count();
            decimal cal_period_pay = totalpay / (decimal)amount;
            var period_pay_qty = (int)Math.Ceiling(cal_period_pay);

            int remainingInstallments = (int)totalremain - (int)Math.Floor(cal_period_pay);

            return remainingInstallments;
        }
        #endregion
        public async Task<int?> GetCurrentPeriod(int promise_id) 
        {
            var data = db.Promises.AsNoTracking().Include(s => s.Customer).Include(s => s.Branch).Include(s => s.Product).Include(s => s.Periodtrans).Include(s => s.Province)
                .Where(s => s.Id == promise_id && s.Status != 2 && s.IsDelete == false ).FirstOrDefault();
           var current_period = data.Periodtrans.Where(s=>s.Ispaid == false).FirstOrDefault();
            
            return current_period.Period;
        }
        public async Task<List<Models.Receipttran>> GetReceipttran(int promise_id)
        {
            var data = db.Receipttrans.Include(s=>s.Promise).ThenInclude(s=>s.Customer).Include(s=>s.Branch).Where(s => s.PromiseId == promise_id).AsNoTracking().OrderByDescending(s=>s.Id).ToList();
                
            

            return data;
        }
        public async Task<List<Models.SingSiamOld.Receipttran>> GetReceipttranNV(string promise_no)
        {
            var data = db_nv.Receipttrans.Where(s => s.Promiseno == promise_no).AsNoTracking().OrderByDescending(s => s.Id).ToList();
            return data;
        }
        public async Task<List<Models.SingSiamOld2.Receipttran>> GetReceipttranV(string promise_no)
        {
            var data = db_v.Receipttrans.Where(s => s.Promiseno == promise_no).AsNoTracking().OrderByDescending(s => s.Id).ToList();
            return data;
        }
        public async Task<List<Models.Receipttran>> GetReceipttran_ById(int Receipttran_Id)
        {
            var data = db.Receipttrans.Include(s => s.Promise).ThenInclude(s => s.Customer).Include(s => s.Branch).Where(s => s.Id == Receipttran_Id).AsNoTracking().OrderByDescending(s => s.Id).ToList();
            return data;
        }
        public async Task<Models.Receipttran?> GetReceipttran_bypromiseId(int promiseId)
        {

            var data = db.Receipttrans.Include(s => s.Promise).ThenInclude(s=> s.Periodtrans).ThenInclude(s => s.Customer).Include(s => s.Branch).Where(s => s.PromiseId == promiseId).AsNoTracking().OrderByDescending(s => s.Id).FirstOrDefault();
            
            return data;
        }
        public async Task<Models.SingSiamOld.Receipttran?> GetReceipttranNV_bypromiseNo(string promise_no)
        {
            var data = db_nv.Receipttrans.AsNoTracking().Where(s=>s.Promiseno == promise_no).OrderByDescending(s => s.Id).FirstOrDefault();
            return data;
        }
        public async Task<Models.SingSiamOld2.Receipttran?> GetReceipttranV_bypromiseNo(string promise_no)
        {
            var data = db_v.Receipttrans.AsNoTracking().Where(s => s.Promiseno == promise_no).OrderByDescending(s => s.Id).FirstOrDefault();
            return data;
        }
        public async Task<List<Models.Periodtran>> GetPeriodtransbyPromiseId(int promise_id)
        {
            var config = db.Configs.AsNoTracking().Where(s => s.Id == 1).FirstOrDefault();
            var data = db.Periodtrans.AsNoTracking().Include(s=>s.Promise).ThenInclude(s=>s.Receipttrans).Include(s => s.Customer).Include(s => s.Branch).Include(s=>s.Receiptdescs).Where(s => s.PromiseId == promise_id && s.Status != 2 && s.Promise.IsDelete == false).ToList();
            var receipt = db.Receiptdescs.AsNoTracking().Include(s=>s.Receipttran).Where(s=>s.PromiseId == promise_id).ToList();
            int cnt_overpayment = 0;
            foreach (var periodtran in data)
            {
                //  periodtran.amount_remain = (decimal)periodtran.Amount - (decimal)periodtran.Paidamount;
                periodtran.tdate_pay = DateTime.ParseExact(periodtran.Tdateformat, "yyyyMMdd", null);
                periodtran.currentdate = DateTime.ParseExact(DateTime.Now.ToString("yyyyMMdd"), "yyyyMMdd", null);
                periodtran.ck_receipt = receipt.Any(s => s.PeriodtranId == periodtran.Id);
              
                if (periodtran.Deposit != 0)
                { periodtran.ck_deposit = true; }
                else 
                {
                    periodtran.ck_deposit= false;   
                }
                if (periodtran.Ispaid == true)
                {
                    periodtran.style_color = "color: blue;";

                }
                else
                {
                    if (periodtran.currentdate > periodtran.tdate_pay)
                    {

                        TimeSpan diffdate = periodtran.currentdate.Date - periodtran.tdate_pay;
                        periodtran.latedate = diffdate.Days;
                        if (periodtran.latedate > config.Daylate)
                        {
                            periodtran.total_fee = (decimal)CalculateAmountFee(periodtran.Amount, periodtran.latedate,(decimal)config.Taxrate);
                        }
                        periodtran.style_color = "color: red;";
                      
                        periodtran.check_overpay = true;
                        periodtran.amount_remain = (decimal)periodtran.Amount;
                        cnt_overpayment += 1;
                        periodtran.OverPayQty = cnt_overpayment;
                      
                        if (periodtran.latedate >= 30)
                        {
                            if (cnt_overpayment >0)
                            {
                                periodtran.total_charge_follow = (decimal)config.Followamt;
                            }
                          
                        }
                        periodtran.total_amount_per_period = (decimal)periodtran.Amount + periodtran.total_fee + periodtran.total_charge_follow;

                      
                    }
                    else
                    {
                        periodtran.latedate = 0;
                        periodtran.style_color = "color: black;";
                        periodtran.check_overpay = false;
                      
                    }

                    try
                    {
                        if (receipt.Any(s => s.PeriodtranId == periodtran.Id))
                        {
                            periodtran.Paidremain = receipt.Where(s => s.PeriodtranId == periodtran.Id).FirstOrDefault().Amount;
                            //var total_follow_charge = (decimal)receipt.Where(s => s.PeriodtranId == periodtran.Id).Select(s => s.Receipttran.Charge2amt).FirstOrDefault();
                            //var total_fee = (decimal)receipt.Where(s => s.PeriodtranId == periodtran.Id).Select(s => s.Receipttran.Charge1amt).FirstOrDefault();

                            //if (periodtran.total_charge_follow != 0 && periodtran.total_fee != 0)
                            //{
                            //    periodtran.total_charge_follow = periodtran.total_charge_follow - total_follow_charge;
                            //    periodtran.total_fee = periodtran.total_fee - total_fee;
                            //}


                        }

                    }
                    catch (Exception ex) { periodtran.Paidremain = 0; }

                    if (periodtran.Paidremain != 0)
                    {
                        periodtran.amount_remain = ((decimal)periodtran.Amount + (decimal)periodtran.Paidremain ) - (decimal)periodtran.Deposit;
                        periodtran.total_deptAmount = (decimal)periodtran.amount_remain;

                        periodtran.Paidamount =  (decimal)periodtran.Deposit + ((decimal)periodtran.Paidremain *-1);


                    }
                }
    
            }

            return data;
        }

        public async Task<List<Models.SingSiamOld.Periodtran>> GetPeriodtransbyPromise_NV(string promise_no)
        {
            var config = db_nv.Configs.AsNoTracking().Where(s => s.Id == 3).FirstOrDefault();
            var data = db_nv.Periodtrans.AsNoTracking().Where(s => s.Promiseno == promise_no && s.Status != 2).ToList();
            var receipt = db_nv.Receipttrans.AsNoTracking().Where(s => s.Promiseno == promise_no).ToList();
            var receipt_desc = db_nv.Receiptdescs.AsNoTracking().Where(s => s.Promiseno == promise_no).ToList();
            int cnt_overpayment = 0;
            foreach (var periodtran in data)
            {
                //  periodtran.amount_remain = (decimal)periodtran.Amount - (decimal)periodtran.Paidamount;
                periodtran.tdate_pay = DateTime.ParseExact(periodtran.Tdateformat, "yyyyMMdd", null);
                periodtran.currentdate = DateTime.ParseExact(DateTime.Now.ToString("yyyyMMdd"), "yyyyMMdd", null);
                periodtran.ck_receipt = receipt.Any(s => s.Promiseno == periodtran.Promiseno);

                if (periodtran.Deposit != 0)
                { periodtran.ck_deposit = true; }
                else
                {
                    periodtran.ck_deposit = false;
                }
                if (periodtran.Ptype == 2)
                {
                    if (periodtran.Intpaid != 0)
                    {
                        periodtran.style_color = "color: blue;";
                        periodtran.ck_paid = true;
                        // periodtran.amount_remain = (decimal)periodtran.Amount - (decimal)periodtran.Paidamount;

                    }
                    else
                    {
                        if (periodtran.currentdate > periodtran.tdate_pay)
                        {
                            periodtran.amount_remain = (decimal)periodtran.Amount - (decimal)periodtran.Paidamount;
                            TimeSpan diffdate = periodtran.currentdate.Date - periodtran.tdate_pay;
                            periodtran.latedate = diffdate.Days;
                            if (periodtran.latedate > config.Daylate)
                            {
                                periodtran.total_fee = (decimal)CalculateAmountFee((decimal)periodtran.amount_remain, periodtran.latedate, (decimal)config.Taxrate);
                            }
                            periodtran.style_color = "color: red;";
                            periodtran.ck_paid = false;
                            periodtran.check_overpay = true;

                            cnt_overpayment += 1;
                            periodtran.OverPayQty = cnt_overpayment;

                            if (periodtran.latedate >= 30)
                            {
                                if (cnt_overpayment > 0)
                                {
                                    //  periodtran.total_charge_follow = (decimal)config.Followamt;
                                    periodtran.total_charge_follow = 100;
                                }

                            }
                            periodtran.total_amount_per_period = (decimal)periodtran.Amount + periodtran.total_fee + periodtran.total_charge_follow;


                        }
                        else
                        {
                            periodtran.latedate = 0;
                            periodtran.style_color = "color: black;";
                            periodtran.check_overpay = false;
                            periodtran.ck_paid = false;
                        }

                        //try
                        //{
                        //    if (receipt.Any(s => s.PeriodtranId == periodtran.Id))
                        //    {
                        //        periodtran.Paidremain = receipt.Where(s => s.PeriodtranId == periodtran.Id).FirstOrDefault().Amount;
                        //        //var total_follow_charge = (decimal)receipt.Where(s => s.PeriodtranId == periodtran.Id).Select(s => s.Receipttran.Charge2amt).FirstOrDefault();
                        //        //var total_fee = (decimal)receipt.Where(s => s.PeriodtranId == periodtran.Id).Select(s => s.Receipttran.Charge1amt).FirstOrDefault();

                        //        //if (periodtran.total_charge_follow != 0 && periodtran.total_fee != 0)
                        //        //{
                        //        //    periodtran.total_charge_follow = periodtran.total_charge_follow - total_follow_charge;
                        //        //    periodtran.total_fee = periodtran.total_fee - total_fee;
                        //        //}


                        //    }

                        //}
                        //catch (Exception ex) { periodtran.Paidremain = 0; }

                        //if (periodtran.Paidremain != 0)
                        //{
                        //    periodtran.amount_remain = ((decimal)periodtran.Amount + (decimal)periodtran.Paidremain) - (decimal)periodtran.Deposit;
                        //    periodtran.total_deptAmount = (decimal)periodtran.amount_remain;

                        //    periodtran.Paidamount = (decimal)periodtran.Deposit + ((decimal)periodtran.Paidremain * -1);


                        //}


                    }
                }
                else 
                {
                    if (periodtran.Cappaid != 0 && periodtran.Intpaid != 0)
                    {
                        periodtran.style_color = "color: blue;";
                        periodtran.ck_paid = true;
                        // periodtran.amount_remain = (decimal)periodtran.Amount - (decimal)periodtran.Paidamount;

                    }
                    else
                    {
                        if (periodtran.currentdate > periodtran.tdate_pay)
                        {
                            periodtran.amount_remain = (decimal)periodtran.Amount - (decimal)periodtran.Paidamount;
                            TimeSpan diffdate = periodtran.currentdate.Date - periodtran.tdate_pay;
                            periodtran.latedate = diffdate.Days;
                            if (periodtran.latedate > config.Daylate)
                            {
                                periodtran.total_fee = (decimal)CalculateAmountFee((decimal)periodtran.amount_remain, periodtran.latedate, (decimal)config.Taxrate);
                            }
                            periodtran.style_color = "color: red;";
                            periodtran.ck_paid = false;
                            periodtran.check_overpay = true;

                            cnt_overpayment += 1;
                            periodtran.OverPayQty = cnt_overpayment;

                            if (periodtran.latedate >= 30)
                            {
                                if (cnt_overpayment > 0)
                                {
                                    //  periodtran.total_charge_follow = (decimal)config.Followamt;
                                    periodtran.total_charge_follow = 100;
                                }

                            }
                            periodtran.total_amount_per_period = (decimal)periodtran.Amount + periodtran.total_fee + periodtran.total_charge_follow;


                        }
                        else
                        {
                            periodtran.latedate = 0;
                            periodtran.style_color = "color: black;";
                            periodtran.check_overpay = false;
                            periodtran.ck_paid = false;
                        }

                        //try
                        //{
                        //    if (receipt.Any(s => s.PeriodtranId == periodtran.Id))
                        //    {
                        //        periodtran.Paidremain = receipt.Where(s => s.PeriodtranId == periodtran.Id).FirstOrDefault().Amount;
                        //        //var total_follow_charge = (decimal)receipt.Where(s => s.PeriodtranId == periodtran.Id).Select(s => s.Receipttran.Charge2amt).FirstOrDefault();
                        //        //var total_fee = (decimal)receipt.Where(s => s.PeriodtranId == periodtran.Id).Select(s => s.Receipttran.Charge1amt).FirstOrDefault();

                        //        //if (periodtran.total_charge_follow != 0 && periodtran.total_fee != 0)
                        //        //{
                        //        //    periodtran.total_charge_follow = periodtran.total_charge_follow - total_follow_charge;
                        //        //    periodtran.total_fee = periodtran.total_fee - total_fee;
                        //        //}


                        //    }

                        //}
                        //catch (Exception ex) { periodtran.Paidremain = 0; }

                        //if (periodtran.Paidremain != 0)
                        //{
                        //    periodtran.amount_remain = ((decimal)periodtran.Amount + (decimal)periodtran.Paidremain) - (decimal)periodtran.Deposit;
                        //    periodtran.total_deptAmount = (decimal)periodtran.amount_remain;

                        //    periodtran.Paidamount = (decimal)periodtran.Deposit + ((decimal)periodtran.Paidremain * -1);


                        //}


                    }
                }
              
                periodtran.Receiptdescs = db_nv.Receiptdescs.Where(s => s.Promiseno == periodtran.Promiseno && s.Period == periodtran.Period).ToList();
            }
            return data;
        }

        public async Task<List<Models.SingSiamOld2.Periodtran>> GetPeriodtransbyPromise_V(string promise_no)
        {
            var config = db_v.Configs.AsNoTracking().Where(s => s.Id == 3).FirstOrDefault();
            var data = db_v.Periodtrans.AsNoTracking().Where(s => s.Promiseno == promise_no && s.Status != 2).ToList();
            var receipt = db_v.Receipttrans.AsNoTracking().Where(s => s.Promiseno == promise_no).ToList();
            var receipt_desc = db_v.Receiptdescs.AsNoTracking().Where(s => s.Promiseno == promise_no).ToList();
            int cnt_overpayment = 0;
            foreach (var periodtran in data)
            {
                //  periodtran.amount_remain = (decimal)periodtran.Amount - (decimal)periodtran.Paidamount;
                periodtran.tdate_pay = DateTime.ParseExact(periodtran.Tdateformat, "yyyyMMdd", null);
                periodtran.currentdate = DateTime.ParseExact(DateTime.Now.ToString("yyyyMMdd"), "yyyyMMdd", null);
                periodtran.ck_receipt = receipt.Any(s => s.Promiseno == periodtran.Promiseno);

                if (periodtran.Deposit != 0)
                { periodtran.ck_deposit = true; }
                else
                {
                    periodtran.ck_deposit = false;
                }
                if (periodtran.Ptype == 2)
                {
                    if (periodtran.Intpaid != 0)
                    {
                        periodtran.style_color = "color: blue;";
                        periodtran.ck_paid = true;
                        // periodtran.amount_remain = (decimal)periodtran.Amount - (decimal)periodtran.Paidamount;

                    }
                    else
                    {
                        if (periodtran.currentdate > periodtran.tdate_pay)
                        {
                            periodtran.amount_remain = (decimal)periodtran.Amount - (decimal)periodtran.Paidamount;
                            TimeSpan diffdate = periodtran.currentdate.Date - periodtran.tdate_pay;
                            periodtran.latedate = diffdate.Days;
                            if (periodtran.latedate > config.Daylate)
                            {
                                periodtran.total_fee = (decimal)CalculateAmountFee((decimal)periodtran.amount_remain, periodtran.latedate, (decimal)config.Taxrate);
                            }
                            periodtran.style_color = "color: red;";
                            periodtran.ck_paid = false;
                            periodtran.check_overpay = true;

                            cnt_overpayment += 1;
                            periodtran.OverPayQty = cnt_overpayment;

                            if (periodtran.latedate >= 30)
                            {
                                if (cnt_overpayment > 0)
                                {
                                    //  periodtran.total_charge_follow = (decimal)config.Followamt;
                                    periodtran.total_charge_follow = 100;
                                }

                            }
                            periodtran.total_amount_per_period = (decimal)periodtran.Amount + periodtran.total_fee + periodtran.total_charge_follow;


                        }
                        else
                        {
                            periodtran.latedate = 0;
                            periodtran.style_color = "color: black;";
                            periodtran.check_overpay = false;
                            periodtran.ck_paid = false;
                        }

                        //try
                        //{
                        //    if (receipt.Any(s => s.PeriodtranId == periodtran.Id))
                        //    {
                        //        periodtran.Paidremain = receipt.Where(s => s.PeriodtranId == periodtran.Id).FirstOrDefault().Amount;
                        //        //var total_follow_charge = (decimal)receipt.Where(s => s.PeriodtranId == periodtran.Id).Select(s => s.Receipttran.Charge2amt).FirstOrDefault();
                        //        //var total_fee = (decimal)receipt.Where(s => s.PeriodtranId == periodtran.Id).Select(s => s.Receipttran.Charge1amt).FirstOrDefault();

                        //        //if (periodtran.total_charge_follow != 0 && periodtran.total_fee != 0)
                        //        //{
                        //        //    periodtran.total_charge_follow = periodtran.total_charge_follow - total_follow_charge;
                        //        //    periodtran.total_fee = periodtran.total_fee - total_fee;
                        //        //}


                        //    }

                        //}
                        //catch (Exception ex) { periodtran.Paidremain = 0; }

                        //if (periodtran.Paidremain != 0)
                        //{
                        //    periodtran.amount_remain = ((decimal)periodtran.Amount + (decimal)periodtran.Paidremain) - (decimal)periodtran.Deposit;
                        //    periodtran.total_deptAmount = (decimal)periodtran.amount_remain;

                        //    periodtran.Paidamount = (decimal)periodtran.Deposit + ((decimal)periodtran.Paidremain * -1);


                        //}


                    }
                }
                else
                {
                    if (periodtran.Cappaid != 0 && periodtran.Intpaid != 0)
                    {
                        periodtran.style_color = "color: blue;";
                        periodtran.ck_paid = true;
                        // periodtran.amount_remain = (decimal)periodtran.Amount - (decimal)periodtran.Paidamount;

                    }
                    else
                    {
                        if (periodtran.currentdate > periodtran.tdate_pay)
                        {
                            periodtran.amount_remain = (decimal)periodtran.Amount - (decimal)periodtran.Paidamount;
                            TimeSpan diffdate = periodtran.currentdate.Date - periodtran.tdate_pay;
                            periodtran.latedate = diffdate.Days;
                            if (periodtran.latedate > config.Daylate)
                            {
                                periodtran.total_fee = (decimal)CalculateAmountFee((decimal)periodtran.amount_remain, periodtran.latedate, (decimal)config.Taxrate);
                            }
                            periodtran.style_color = "color: red;";
                            periodtran.ck_paid = false;
                            periodtran.check_overpay = true;

                            cnt_overpayment += 1;
                            periodtran.OverPayQty = cnt_overpayment;

                            if (periodtran.latedate >= 30)
                            {
                                if (cnt_overpayment > 0)
                                {
                                    //  periodtran.total_charge_follow = (decimal)config.Followamt;
                                    periodtran.total_charge_follow = 100;
                                }

                            }
                            periodtran.total_amount_per_period = (decimal)periodtran.Amount + periodtran.total_fee + periodtran.total_charge_follow;


                        }
                        else
                        {
                            periodtran.latedate = 0;
                            periodtran.style_color = "color: black;";
                            periodtran.check_overpay = false;
                            periodtran.ck_paid = false;
                        }

                        //try
                        //{
                        //    if (receipt.Any(s => s.PeriodtranId == periodtran.Id))
                        //    {
                        //        periodtran.Paidremain = receipt.Where(s => s.PeriodtranId == periodtran.Id).FirstOrDefault().Amount;
                        //        //var total_follow_charge = (decimal)receipt.Where(s => s.PeriodtranId == periodtran.Id).Select(s => s.Receipttran.Charge2amt).FirstOrDefault();
                        //        //var total_fee = (decimal)receipt.Where(s => s.PeriodtranId == periodtran.Id).Select(s => s.Receipttran.Charge1amt).FirstOrDefault();

                        //        //if (periodtran.total_charge_follow != 0 && periodtran.total_fee != 0)
                        //        //{
                        //        //    periodtran.total_charge_follow = periodtran.total_charge_follow - total_follow_charge;
                        //        //    periodtran.total_fee = periodtran.total_fee - total_fee;
                        //        //}


                        //    }

                        //}
                        //catch (Exception ex) { periodtran.Paidremain = 0; }

                        //if (periodtran.Paidremain != 0)
                        //{
                        //    periodtran.amount_remain = ((decimal)periodtran.Amount + (decimal)periodtran.Paidremain) - (decimal)periodtran.Deposit;
                        //    periodtran.total_deptAmount = (decimal)periodtran.amount_remain;

                        //    periodtran.Paidamount = (decimal)periodtran.Deposit + ((decimal)periodtran.Paidremain * -1);


                        //}


                    }
                }
                periodtran.Receiptdescs = db_v.Receiptdescs.Where(s => s.Promiseno == periodtran.Promiseno && s.Period == periodtran.Period).ToList();
            }
            return data;
        }
        public async Task<List<Models.Receiptdesc>> GetReceipttran(int peroidtran_id,string type) 
        {
            int receiptran_id = 0;
            List<Models.Receiptdesc> lst_receiptdesc = new List<Models.Receiptdesc>();
            // lst_receiptdesc = db.Receiptdescs.AsNoTracking().Include(s => s.Promise).ThenInclude(s => s.Product).Include(s => s.Customer).Include(s => s.Branch).Include(s => s.Receipttran).Include(s => s.Periodtran).Where(s => s.ReceipttranId == peroidtran_id).ToList();

            if (type != "D")
            {
                receiptran_id = db.Receiptdescs.AsNoTracking().Include(s => s.Receipttran).Where(s => s.PeriodtranId == peroidtran_id).FirstOrDefault().ReceipttranId;
                lst_receiptdesc = db.Receiptdescs.AsNoTracking().Include(s => s.Promise).ThenInclude(s => s.Product).Include(s => s.Customer).Include(s => s.Branch).Include(s => s.Receipttran).Include(s => s.Periodtran).Where(s => s.ReceipttranId == receiptran_id).ToList();
            }
            else
            {
                lst_receiptdesc = db.Receiptdescs.AsNoTracking().Include(s => s.Promise).ThenInclude(s => s.Product).Include(s => s.Customer).Include(s => s.Branch).Include(s => s.Receipttran).Include(s => s.Periodtran).Where(s => s.ReceipttranId == peroidtran_id).ToList();
            }

            foreach (var items in lst_receiptdesc) 
            {
                items.Amount = items.Amount * -1;
            }
            return lst_receiptdesc;
        }
        public async Task<List<Models.Receiptdesc>> GetReceipttran_PeroidtranId(int peroidtran_id, string type)
        {
            int receiptran_id = 0;
            List<Models.Receiptdesc> lst_receiptdesc = new List<Models.Receiptdesc>();
            lst_receiptdesc = db.Receiptdescs.AsNoTracking().Include(s => s.Promise).ThenInclude(s => s.Product).Include(s => s.Customer).Include(s => s.Branch).Include(s => s.Receipttran).Include(s => s.Periodtran).Where(s => s.PeriodtranId == peroidtran_id).ToList();

            //if (type != "D")
            //{
            //    receiptran_id = db.Receiptdescs.AsNoTracking().Where(s => s.PeriodtranId == peroidtran_id).FirstOrDefault().ReceipttranId;
            //    lst_receiptdesc = db.Receiptdescs.AsNoTracking().Include(s => s.Promise).ThenInclude(s => s.Product).Include(s => s.Customer).Include(s => s.Branch).Include(s => s.Receipttran).Include(s => s.Periodtran).Where(s => s.ReceipttranId == receiptran_id).ToList();
            //}
            //else 
            //{
            //    lst_receiptdesc = db.Receiptdescs.AsNoTracking().Include(s => s.Promise).ThenInclude(s => s.Product).Include(s => s.Customer).Include(s => s.Branch).Include(s => s.Receipttran).Include(s => s.Periodtran).Where(s => s.ReceipttranId == peroidtran_id).ToList();
            //}

            foreach (var items in lst_receiptdesc)
            {
                items.Amount = items.Amount * -1;
            }
            return lst_receiptdesc;
        }
        public async Task<List<Models.Receiptdesc>> GetReceipttran_Close(int promiseId, string type)
        {
            int receiptran_id = 0;
            List<Models.Receiptdesc> lst_receiptdesc = new List<Models.Receiptdesc>();
            lst_receiptdesc = db.Receiptdescs.AsNoTracking().Include(s => s.Promise).ThenInclude(s => s.Product).Include(s => s.Customer).Include(s => s.Branch).Include(s => s.Receipttran).Include(s => s.Periodtran).Where(s => s.PromiseId == promiseId && s.Receipttran.Receiptdesc == "ปิดสัญญาก่อนกำหนด").ToList();

            //if (type != "D")
            //{
            //    receiptran_id = db.Receiptdescs.AsNoTracking().Where(s => s.PeriodtranId == peroidtran_id).FirstOrDefault().ReceipttranId;
            //    lst_receiptdesc = db.Receiptdescs.AsNoTracking().Include(s => s.Promise).ThenInclude(s => s.Product).Include(s => s.Customer).Include(s => s.Branch).Include(s => s.Receipttran).Include(s => s.Periodtran).Where(s => s.ReceipttranId == receiptran_id).ToList();
            //}
            //else 
            //{
            //    lst_receiptdesc = db.Receiptdescs.AsNoTracking().Include(s => s.Promise).ThenInclude(s => s.Product).Include(s => s.Customer).Include(s => s.Branch).Include(s => s.Receipttran).Include(s => s.Periodtran).Where(s => s.ReceipttranId == peroidtran_id).ToList();
            //}

            foreach (var items in lst_receiptdesc)
            {
                items.Amount = items.Amount * -1;
            }
            return lst_receiptdesc;
        }
        private decimal RoundToNearest(decimal value)
        {
            // ปัดเศษทศนิยม 1 ตำแหน่งและใช้ MidpointRounding.AwayFromZero
            return Math.Round(value, 0, MidpointRounding.AwayFromZero);
        }
        private decimal? CalculateAmountFee(decimal? amount, int latedate,decimal ratetax)
        {
            var percentage = ((decimal)amount * ratetax)/ 100;
            var a = (percentage * latedate);
            var b = (a / 30);
            var result = RoundToNearest((decimal)b);
            return result;
        }
        public async Task<List<Guarantor>> GetGurantorbyPromiseId(int promise_id)
        {
            var data = db.Guarantors.AsNoTracking().Where(s => s.PromiseId == promise_id).ToList();
            return data;
        }
        public async Task<List<Models.Customer>> GetCustomerbyBranch(int branch_id)
        {
            var customer = db.Customers.AsNoTracking().Include(s => s.Branch).Where(s => s.BranchId == branch_id && s.Status == 1).ToList();

            return customer;
        }
        public async Task<List<Models.Customer>> GetCustomerAll()
        {
            var customer = db.Customers.AsNoTracking().Include(s => s.Branch).Where(s =>  s.Status == 1).ToList();

            return customer;
        }
        public async Task<Models.Customer> GetCustomerbyId(int cus_id)
        {
            var customer = db.Customers.AsNoTracking().Include(s => s.Branch).Where(s => s.Status == 1 && s.CustomerId == cus_id).FirstOrDefault();

            return customer;
        }
        public async Task<bool> Check_Customer_Backlist(string natId)
        {

            var ck = db.BlackLists.Include(s=>s.Customer).AsNoTracking().Any(s => s.Customer.NatId == natId);

            return ck;
        }
        //อัพเดทเงินสด
        public async Task<bool> Update_Cash(int branch_id,CashLog cashLogs)
        {
            var toedit = db.CashLogs.Where(s => s.BranchId == branch_id && s.DateCreate.Date == DateTime.Now.Date).FirstOrDefault();

            if (toedit == null)
            {

                db.CashLogs.Add(cashLogs);
                await db.SaveChangesAsync();
               
            }
            else 
            {
                toedit.Log1000 = cashLogs.Log1000;
                toedit.Log500 = cashLogs.Log500;
                toedit.Log100 = cashLogs.Log100;
                toedit.Log50 = cashLogs.Log50;
                toedit.Log20 = cashLogs.Log20;
                toedit.Log10 = cashLogs.Log10;
                toedit.Log5 = cashLogs.Log5;
                toedit.Log2 = cashLogs.Log2;
                toedit.Log1 = cashLogs.Log1;
                toedit.DateCreate = DateTime.Now;

                db.CashLogs.Update(toedit);
                await db.SaveChangesAsync();
              
            }
            return true;
        }
        public async Task<CashLog> Get_Cash(int branch_id)
        {
            var cash = db.CashLogs.AsNoTracking().Where(s => s.BranchId == branch_id && s.DateCreate.Date == DateTime.Now.Date).FirstOrDefault();
            return cash;
        }
        public async Task<string> Get_Promise_No(int branch_id, string type)
        {
            //var next_no = db.RunningNos.AsNoTracking().Where(s => s.BranchId == branch_id && s.Type == type).FirstOrDefault().NextNo;
            var branch = db.Branches.AsNoTracking().Include(s => s.ProvinceNavigation).Where(s => s.Id == branch_id).FirstOrDefault();
            var branch_province = branch.Code;
            var next_no = branch.Promiseno+1;
            int nextNo = Convert.ToInt32(next_no);
            string numberPart = nextNo.ToString("D7");
            string prefix = branch_province.Trim() + "#";
            var promise_no = prefix + numberPart;
            return promise_no;
        }
        public async Task<string> Get_Receipt_No(int branch_id, string type)
        {
           // var next_no = db.RunningNos.AsNoTracking().Where(s => s.BranchId == branch_id && s.Type == type).FirstOrDefault().NextNo;
            var branch = db.Branches.AsNoTracking().Include(s => s.ProvinceNavigation).Where(s => s.Id == branch_id).FirstOrDefault();
         //   var branch_province = branch.ProvinceNavigation.ProvinceShortEn;
            var next_no = branch.Receipt +1;
            int nextNo = Convert.ToInt32(next_no);
            string numberPart = nextNo.ToString("D7");
            string prefix = branch.Code.Trim()  + "-";
            var receipt_no = prefix + numberPart;
            return receipt_no;
        }
        //Gen Receipt No Old สร้างใบเสร็จเก่า
        public async Task<string> Get_Receipt_No_NV(string branch_code, string type)
        {
            // var next_no = db.RunningNos.AsNoTracking().Where(s => s.BranchId == branch_id && s.Type == type).FirstOrDefault().NextNo;
            var stationno = db_nv.Branches.AsNoTracking().Where(s => s.Code == branch_code).FirstOrDefault();
            var branch = db_nv.Stations.AsNoTracking().Where(s => s.Branch.Contains(stationno.Name)).FirstOrDefault();
            //   var branch_province = branch.ProvinceNavigation.ProvinceShortEn;
            var next_no = branch.Receiptno + 1;
            int nextNo = Convert.ToInt32(next_no);
            string numberPart = nextNo.ToString("D7");
            string prefix = branch.Stationno.Trim() + "-";
            var receipt_no = prefix + numberPart;
            return receipt_no;
        }
        public async Task<string> Get_Receipt_No_V(string branch_code, string type)
        {
            // var next_no = db.RunningNos.AsNoTracking().Where(s => s.BranchId == branch_id && s.Type == type).FirstOrDefault().NextNo;
            var stationno = db_v.Branches.AsNoTracking().Where(s => s.Code == branch_code).FirstOrDefault();
            var branch = db_v.Stations.AsNoTracking().Where(s => s.Branch.Contains(stationno.Name)).FirstOrDefault();
            //   var branch_province = branch.ProvinceNavigation.ProvinceShortEn;
            var next_no = branch.Receiptno + 1;
            int nextNo = Convert.ToInt32(next_no);
            string numberPart = nextNo.ToString("D7");
            string prefix = branch.Stationno.Trim() + "-";
            var receipt_no = prefix + numberPart;
            return receipt_no;
        }
        public async Task<string> Get_Ref_Code(int branch_id, string type, string branch_code, int product_id,int vat)
        {
            int next_no = 0;
            string result = "";
            //var next_no = db.RunningNos.AsNoTracking().Where(s => s.BranchId == branch_id && s.Type == type).FirstOrDefault().NextNo;
            var product_code = db.Collaterals.AsNoTracking().Where(s => s.Id == product_id).FirstOrDefault().Refcode;
            //var next_no = db.Branches.AsNoTracking().Where(s => s.Id == branch_id).FirstOrDefault().Refcode +1;

            if (vat == 1)
            {
                next_no = (int)db.ProductRefcodes.AsNoTracking().Where(s => s.BranchId == branch_id).FirstOrDefault().RefcodeV + 1;
                string numberPart = next_no.ToString("D4");
                result = numberPart + "/" + branch_code;
            }
            else
            {
                if (product_id == 1 || product_id == 2 || product_id == 4)
                {
                    next_no = (int)db.ProductRefcodes.AsNoTracking().Where(s => s.BranchId == branch_id).FirstOrDefault().RefcodeNvCar + 1;
                    string numberPart = next_no.ToString("D4");
                    result = product_code.Trim() + "-" + numberPart + "/" + branch_code;
                }
                else if (product_id == 3)
                {
                    next_no = (int)db.ProductRefcodes.AsNoTracking().Where(s => s.BranchId == branch_id).FirstOrDefault().RefcodeNvLand + 1;
                    string numberPart = next_no.ToString("D4");
                    result = product_code.Trim() + "-" + numberPart + "/" + branch_code;
                }
                else if (product_id == 5)
                {
                    next_no = (int)db.ProductRefcodes.AsNoTracking().Where(s => s.BranchId == branch_id).FirstOrDefault().RefcodeNvBook + 1;
                    string numberPart = next_no.ToString("D4");
                    result = product_code.Trim() + "-" + numberPart + "/" + branch_code;
                }
            }
           
            return result;
        }
        public async Task<string> Get_Ref_AccCode(int branch_id)
        {
            int next_no = 0;
            string result = "";

            var branch_info = db.Branches.AsNoTracking().Where(s => s.Id == branch_id).FirstOrDefault();

                next_no = (int)branch_info.Accdocno + 1;
                string numberPart =branch_info.Code+"."+next_no.ToString("D7");
                result = numberPart;
            

            return result;
        }
        public async Task<BlackList> GetBlackList(int cus_id)
        {
            var info = db.BlackLists.AsNoTracking().Where(s => s.CustomerId == cus_id).FirstOrDefault();
            return info;
        }
        public async Task<Models.Customer> GetCustomerInfo(int cus_id)
        {
            var info = db.Customers.AsNoTracking().Where(s => s.CustomerId == cus_id).FirstOrDefault();
            return info;
        }
        public async Task<List<Province>> GetProvince()
        {
            var province_info = db.Provinces.AsNoTracking().ToList();
            return province_info;
        }
        public async Task<List<Collateral>> GetCollaterals()
        {
            var collaterals = db.Collaterals.AsNoTracking().ToList();
            return collaterals;
        }
        public async Task<Models.Branch> GetBranches(int b_id)
        {
            var branch_info = db.Branches.AsNoTracking().Where(s => s.Id == b_id).FirstOrDefault();
            return branch_info;
        }
        public string FormatNumber(decimal number)
        {
            // Using standard numeric format specifier with no decimal places
            return number.ToString("N0", CultureInfo.InvariantCulture);
        }

        public async Task<List<Models.Periodtran>> Add_Periodtrans(Models.Promise promise, int ptype)
        {
            List<Models.Periodtran> lst_periodtrans = new List<Models.Periodtran>();
            CultureInfo thaiCulture = new CultureInfo("th-TH");
            thaiCulture.DateTimeFormat.Calendar = new ThaiBuddhistCalendar();


            var capital = promise.Capital;
            var amount = promise.Amount;
            int count_p = 1;
            if (ptype == 1)
            {
                for (int i =0; i < promise.Periods; i++)
                {
                    if (i != 0)
                    { 
                        count_p++;
                    }
                   
                    var cnt_total_capital = lst_periodtrans.Sum(s => s.Capital);
                    Models.Periodtran p = new Models.Periodtran();
                    p.PromiseId = promise.Id;
                    p.BranchId = promise.BranchId;
                    p.Ptype = 1;
                    p.CustomerId = promise.CustomerId;
                    p.Period = i+1;
                    p.Periods = Convert.ToInt32(promise.Daypaid);
                    p.Tdate = promise.FirstDatePay.AddMonths(i).ToString("dd/MM/yyyy", thaiCulture);
                    p.Tdateformat = promise.FirstDatePay.AddMonths(i).ToString("yyyyMMdd");
                    
                  
                  

                    if (promise.Periods == count_p)
                    {
                        p.Capital =   capital - cnt_total_capital;
                        p.Interest = amount - p.Capital;

                    }
                    else 
                    {
                        p.Capital = promise.CapitalCal;
                        p.Interest = promise.Interest_Service;

                    }

                    p.Service = promise.Service;
                    p.Amount = promise.Amount;
                    p.Cappaid = 0;
                    p.Intpaid = 0;
                    p.Paidamount = 0;
                    p.Status = 0;
                    p.Usercode = promise.Usercode;

                    lst_periodtrans.Add(p);

                    
                }
            }
            if (ptype == 2)
            {
                for (int i = 1; i <= promise.Periods; i++)
                {

                    Models.Periodtran p = new Models.Periodtran();
                    p.PromiseId = promise.Id;
                    p.BranchId = promise.BranchId;
                    p.Ptype = 2;
                    p.CustomerId = promise.CustomerId;
                    p.Period = i;
                    p.Periods = Convert.ToInt32(promise.Daypaid);
                    if (i == 1)
                    {
                        p.Tdate = promise.FirstDatePay.ToString("dd/MM/yyyy", thaiCulture);
                        p.Tdateformat = promise.FirstDatePay.ToString("yyyyMMdd");
                    }
                    else
                    {
                        p.Tdate = promise.FirstDatePay.AddMonths(i).ToString("dd/MM/yyyy", thaiCulture);
                        p.Tdateformat = promise.FirstDatePay.AddMonths(i).ToString("yyyyMMdd");
                    }
                    //p.Tdate = promise.FirstDatePay.AddMonths(i).ToString("dd/MM/yyyy", thaiCulture);
                    //p.Tdateformat = promise.FirstDatePay.AddMonths(i).ToString("yyyyMMdd");
                    if (i == promise.Periods)
                    {
                        p.Capital = promise.Capital;
                        p.Amount = promise.Amount + promise.Capital;
                    }
                    else
                    {
                        p.Capital = 0;
                        p.Amount = promise.Amount;
                    }

                    p.Interest = promise.Interest_Service;
                    p.Service = promise.Service;

                    p.Cappaid = 0;
                    p.Intpaid = 0;
                    p.Paidamount = 0;
                    p.Status = 0;
                    p.Usercode = promise.Usercode;

                    lst_periodtrans.Add(p);


                }
            }


            return lst_periodtrans;
        }

     


        // คำนวณดอกเบี้ย
        public decimal CalculateInterest(decimal loanAmount, decimal interestRate, int termMonths)
        {
            // คำนวณดอกเบี้ยรวมตามจำนวนเงินกู้ อัตราดอกเบี้ย และจำนวนเดือนที่กู้
            return loanAmount * interestRate / 100 / 12 * termMonths;
        }

        // คำนวณงวดการชำระเงิน
        public List<Models.Periodtran> CalculateInstallments(decimal loanAmount, decimal interestRate, int termMonths)
        {
            // คำนวณอัตราดอกเบี้ยต่อเดือน
            decimal monthlyInterestRate = interestRate / 12 / 100;

            // คำนวณยอดชำระเงินต่อเดือน
            decimal monthlyPayment = loanAmount * monthlyInterestRate / (1 - (decimal)Math.Pow((double)(1 + monthlyInterestRate), -termMonths));

            // สร้างรายการงวดการชำระเงิน
            List<Models.Periodtran> installments = new List<Models.Periodtran>();
            decimal remainingPrincipal = loanAmount;

            // วนลูปเพื่อสร้างงวดการชำระเงินแต่ละเดือน
            for (int month = 1; month <= termMonths; month++)
            {
                // คำนวณดอกเบี้ยและเงินต้นที่ต้องชำระในแต่ละงวด
                decimal interestPayment = remainingPrincipal * monthlyInterestRate;
                decimal principalPayment = monthlyPayment - interestPayment;
                remainingPrincipal -= principalPayment;

                // เพิ่มข้อมูลงวดการชำระเงินใน List
                //installments.Add(new Periodtran
                //{
                //    InstallmentNumber = month,
                //    DueDate = DateTime.Now.AddMonths(month),
                //    PrincipalAmount = principalPayment,
                //    InterestAmount = interestPayment,
                //    TotalAmount = principalPayment + interestPayment,
                //    RemainingPrincipal = remainingPrincipal
                //});
            }

            // คืนค่า List ของงวดการชำระเงิน
            return installments;
        }

        // การชำระเงิน
        public void MakePayment(decimal paymentAmount, List<Models.Periodtran> installments)
        {
            // เก็บยอดเงินที่เหลือจากการชำระ
            decimal remainingPayment = paymentAmount;

            // วนลูปเพื่อลดยอดเงินในแต่ละงวดการชำระ
            foreach (var installment in installments)
            {
                if (remainingPayment <= 0)
                    break;

                // คำนวณยอดเงินต้นที่ต้องชำระในแต่ละงวด
                decimal principalPayment = Math.Min((decimal)installment.Amount, remainingPayment);
                remainingPayment -= principalPayment;
                installment.Amount -= principalPayment;

                // คำนวณยอดดอกเบี้ยที่ต้องชำระในแต่ละงวด (ถ้ามียอดเหลือจากเงินต้น)
                decimal interestPayment = 0;
                if (remainingPayment > 0)
                {
                    interestPayment = Math.Min((decimal)installment.Interest, remainingPayment);
                    remainingPayment -= interestPayment;
                    installment.Interest -= interestPayment;
                }

                // อัพเดทยอดรวมของงวดการชำระ
                installment.Amount = installment.Capital + installment.Interest;
            }
        }

        // บันทึกการชำระเงินลงฐานข้อมูล
        //public async Task RecordPayment(decimal paymentAmount, DateTime paymentDate, string receiptNo)
        //{
        //    // เริ่ม transaction ใหม่
        //    using var transaction = await db.Database.BeginTransactionAsync();

        //    try
        //    {
        //        // ดึงข้อมูลสินเชื่อและรายละเอียดการชำระเงินตามงวด
        //        var loans = await db.Promises.ToListAsync();
        //        var installments = await db.Periodtrans.ToListAsync();
              
        //        // ทำการชำระเงิน
        //        MakePayment(paymentAmount, installments);

        //        // สร้างรายการการชำระเงินใหม่
        //        var payment = new Models.Receipttran
        //        {
        //            Amount = paymentAmount,
        //            Tdate = paymentDate.AddYears(543).ToString("dd/MM/yyyyy"),
        //            Receiptno = receiptNo
        //        };

        //        // เพิ่มข้อมูลการชำระเงินลงในฐานข้อมูล
        //        db.Receipttrans.Add(payment);
        //        await db.SaveChangesAsync();

        //        // สร้างรายละเอียดการชำระเงินในแต่ละงวด
        //        List<Models.Receiptdesc> paymentDetails = new List<Models.Receiptdesc>();
        //        foreach (var installment in installments)
        //        {
        //            //paymentDetails.Add(new Receiptdesc
        //            //{
        //            //    r = payment.PaymentID,
        //            //    InstallmentID = installment.InstallmentID,
        //            //    PrincipalAmount = installment.PrincipalAmount,
        //            //    InterestAmount = installment.InterestAmount,
        //            //    TotalAmount = installment.PrincipalAmount + installment.InterestAmount,
        //            //    PaymentDate = paymentDate,
        //            //    RemainingBalance = installment.TotalAmount,
        //            //    RemainingPrincipal = installment.PrincipalAmount,
        //            //    RemainingInterest = installment.InterestAmount
        //            //});
        //        }

        //        // เพิ่มรายละเอียดการชำระเงินลงในฐานข้อมูล
        //        db.Receiptdescs.AddRange(paymentDetails);
        //        await db.SaveChangesAsync();

        //        // ยืนยันการทำ transaction
        //        await transaction.CommitAsync();
        //    }
        //    catch
        //    {
        //        // ยกเลิก transaction หากเกิดข้อผิดพลาด
        //        await transaction.RollbackAsync();
        //        throw;
        //    }
        //}
       
    }
    public class Receipt
    {
        public string daypaid { get; set; }
        public string receipt_no { get; set; }
        public string promise_no { get; set; }
        public string fullname { get; set; }
        public string address { get; set; }
        public string product { get; set; }
        public string paid_by { get; set; }

        public string total_fee { get; set; }
        public string total_amount { get; set; }


        public string peroid_remain { get; set; }
        public string amount_text { get; set; }
        public bool ck_total_fee { get; set; }
        public string receive_by { get; set; }

        public string amount { get; set; }

        public string deposit { get; set; }

        public string paidby_deposit { get; set; }

        //ปิดสัญญาก่อนกำหนด

        //งวดคงเหลือ
        public int peroid_s { get; set; }
        public int peroid_e { get; set; }

        //ยอดลูกหนี้คงเหลือ
        public string pending_payment { get; set; }
        //ชำระค่าปรับ
        public string payment_fine {  get; set; }
        //ค่าปิดบัญชี

        public string payment_full { get; set; }
        //ดอกเบี้ยเพิ่ม
        public string payment_interest { get; set; }
        //เงินรับฝากล่วงหน้าตัดบัญชี
        public string total_deposit { get; set; }
        //ส่วนลด
        public string discount { get; set; }
        //ส่วนต่าง
        public string pay_difference {  get; set; }
        //รวม
        public string total_payment { get; set; }
    }
}
