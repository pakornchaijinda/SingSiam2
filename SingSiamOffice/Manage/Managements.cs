using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SingSiamOffice.Models;
using System.ComponentModel;
using System.Globalization;

namespace SingSiamOffice.Manage
{
    public class Managements
    {
        SingsiamdbContext db = new SingsiamdbContext();

        public async Task<List<Promise>> GetPromisebyCustomerId(int customer_id)
        {
            var data = db.Promises.AsNoTracking().Include(s => s.Customer).Include(s => s.Branch).Include(s => s.Product).Include(s => s.Periodtrans).Include(s => s.Province)
                .Where(s => s.CustomerId == customer_id && s.Status != 2 && s.IsDelete == false).ToList();
            foreach (var promise in data) 
            {
                promise.FormatCapital = promise.Capital.Value.ToString("N0");
                promise.FormatAmount = promise.Amount.Value.ToString("N0");
                promise.FormatInterest = promise.Intrate.Value.ToString("N0");
                promise.FormatChargeamt = promise.Chargeamt.Value.ToString("N0");
            }
            return data;
        }
        public async Task<Promise> GetPromisebyPromiseId(int promise_id)
        {
            var data = db.Promises.AsNoTracking().Include(s => s.Customer).Include(s => s.Branch).Include(s => s.Product).Include(s => s.Periodtrans).Include(s => s.Province)
                .Where(s => s.Id == promise_id && s.Status != 2 && s.IsDelete == false).FirstOrDefault();

            data.FormatCapital = data.Capital.Value.ToString("N0");
            data.FormatAmount = data.Amount.Value.ToString("N0");
            data.FormatInterest = data.Periodtrans.FirstOrDefault().Interest.Value.ToString("N0");
            data.FormatChargeamt = data.Chargeamt.Value.ToString("N0");
            
            return data;
        }
        public async Task<int?> GetCurrentPeriod(int promise_id) 
        {
            var data = db.Promises.AsNoTracking().Include(s => s.Customer).Include(s => s.Branch).Include(s => s.Product).Include(s => s.Periodtrans).Include(s => s.Province)
                .Where(s => s.Id == promise_id && s.Status != 2 && s.IsDelete == false ).FirstOrDefault();
           var current_period = data.Periodtrans.Where(s=>s.Ispaid == false).FirstOrDefault();
            
            return current_period.Period;
        }
        public async Task<List<Receipttran>> GetReceipttran(int promise_id)
        {
            var data = db.Receipttrans.Include(s=>s.Promise).ThenInclude(s=>s.Customer).Include(s=>s.Branch).Where(s => s.PromiseId == promise_id).AsNoTracking().OrderByDescending(s=>s.Id).ToList();
                
            

            return data;
        }
        public async Task<List<Receipttran>> GetReceipttran_ById(int Receipttran_Id)
        {
            var data = db.Receipttrans.Include(s => s.Promise).ThenInclude(s => s.Customer).Include(s => s.Branch).Where(s => s.Id == Receipttran_Id).AsNoTracking().OrderByDescending(s => s.Id).ToList();
            return data;
        }
        public async Task<Receipttran?> GetReceipttran_bypromiseId(int promiseId)
        {

            var data = db.Receipttrans.Include(s => s.Promise).ThenInclude(s => s.Customer).Include(s => s.Branch).Where(s => s.PromiseId == promiseId).AsNoTracking().OrderByDescending(s => s.Id).FirstOrDefault();
            
            return data;
        }
        public async Task<List<Periodtran>> GetPeriodtransbyPromiseId(int promise_id)
        {
            var config = db.Configs.AsNoTracking().Where(s => s.Id == 1).FirstOrDefault();
            var data = db.Periodtrans.AsNoTracking().Include(s => s.Customer).Include(s => s.Branch).Include(s=>s.Receiptdescs).Where(s => s.PromiseId == promise_id && s.Status != 2 && s.Promise.IsDelete == false).ToList();
            var receipt = db.Receiptdescs.AsNoTracking().Where(s=>s.PromiseId == promise_id).ToList();
            int cnt_overpayment = 0;
            foreach (var periodtran in data)
            {
                //  periodtran.amount_remain = (decimal)periodtran.Amount - (decimal)periodtran.Paidamount;
                periodtran.tdate_pay = DateTime.ParseExact(periodtran.Tdateformat, "yyyyMMdd", null);
                periodtran.currentdate = DateTime.ParseExact(DateTime.Now.ToString("yyyyMMdd"), "yyyyMMdd", null);
                periodtran.ck_receipt = receipt.Any(s => s.PeriodtranId == periodtran.Id);
                try
                {
                    if (receipt.Any(s => s.PeriodtranId == periodtran.Id))
                    {
                        periodtran.Paidremain = receipt.Where(s => s.PeriodtranId == periodtran.Id).FirstOrDefault().Amount;
                    }
                  
                }
                catch (Exception ex) { periodtran.Paidremain = 0; }
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

                    }
                    else
                    {
                        periodtran.latedate = 0;
                        periodtran.style_color = "color: black;";
                        periodtran.check_overpay = false;
                      
                    }
                }
                if (periodtran.Paidremain != 0)
                {
                    periodtran.amount_remain = (decimal)periodtran.Amount +     ((decimal)periodtran.Paidremain *-1);
                    periodtran.total_deptAmount = (decimal)periodtran.amount_remain;
                }
            }

            return data;
        }
        public async Task<List<Receiptdesc>> GetReceipttran(int peroidtran_id,string type) 
        {
            int receiptran_id = 0;
            List<Receiptdesc> lst_receiptdesc = new List<Receiptdesc>();
            if (type != "D")
            {
                receiptran_id = db.Receiptdescs.AsNoTracking().Where(s => s.PeriodtranId == peroidtran_id).FirstOrDefault().ReceipttranId;
                lst_receiptdesc = db.Receiptdescs.AsNoTracking().Include(s => s.Promise).ThenInclude(s => s.Product).Include(s => s.Customer).Include(s => s.Branch).Include(s => s.Receipttran).Include(s => s.Periodtran).Where(s => s.ReceipttranId == receiptran_id).ToList();
            }
            else 
            {
                lst_receiptdesc = db.Receiptdescs.AsNoTracking().Include(s => s.Promise).ThenInclude(s => s.Product).Include(s => s.Customer).Include(s => s.Branch).Include(s => s.Receipttran).Include(s => s.Periodtran).Where(s => s.ReceipttranId == peroidtran_id).ToList();
            }
            
            foreach(var items in lst_receiptdesc) 
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
        public async Task<List<Customer>> GetCustomerbyBranch(int branch_id)
        {
            var customer = db.Customers.AsNoTracking().Include(s => s.Branch).Where(s => s.BranchId == branch_id && s.Status == 1).ToList();

            return customer;
        }
        public async Task<List<Customer>> GetCustomerAll()
        {
            var customer = db.Customers.AsNoTracking().Include(s => s.Branch).Where(s =>  s.Status == 1).ToList();

            return customer;
        }
        public async Task<bool> Check_Customer_Backlist(string natId)
        {

            var ck = db.BlackLists.Include(s=>s.Customer).AsNoTracking().Any(s => s.Customer.NatId == natId);

            return ck;
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
        public async Task<Customer> GetCustomerInfo(int cus_id)
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
        public async Task<Branch> GetBranches(int b_id)
        {
            var branch_info = db.Branches.AsNoTracking().Where(s => s.Id == b_id).FirstOrDefault();
            return branch_info;
        }
        public string FormatNumber(decimal number)
        {
            // Using standard numeric format specifier with no decimal places
            return number.ToString("N0", CultureInfo.InvariantCulture);
        }

        public async Task<List<Periodtran>> Add_Periodtrans(Promise promise, int ptype)
        {
            List<Periodtran> lst_periodtrans = new List<Periodtran>();
            CultureInfo thaiCulture = new CultureInfo("th-TH");
            thaiCulture.DateTimeFormat.Calendar = new ThaiBuddhistCalendar();


            if (ptype == 1)
            {
                for (int i = 1; i <= promise.Periods; i++)
                {

                    Periodtran p = new Periodtran();
                    p.PromiseId = promise.Id;
                    p.BranchId = promise.BranchId;
                    p.Ptype = 1;
                    p.CustomerId = promise.CustomerId;
                    p.Period = i;
                    p.Periods = Convert.ToInt32(promise.Daypaid);
                    p.Tdate = promise.FirstDatePay.AddMonths(i).ToString("dd/MM/yyyy", thaiCulture);
                    p.Tdateformat = promise.FirstDatePay.AddMonths(i).ToString("yyyyMMdd");
                    p.Capital = promise.CapitalCal;
                    p.Interest = promise.Interest_Service;
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

                    Periodtran p = new Periodtran();
                    p.PromiseId = promise.Id;
                    p.BranchId = promise.BranchId;
                    p.Ptype = 2;
                    p.CustomerId = promise.CustomerId;
                    p.Period = i;
                    p.Periods = Convert.ToInt32(promise.Daypaid);
                    p.Tdate = promise.FirstDatePay.AddMonths(i).ToString("dd/MM/yyyy", thaiCulture);
                    p.Tdateformat = promise.FirstDatePay.AddMonths(i).ToString("yyyyMMdd");
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
        public List<Periodtran> CalculateInstallments(decimal loanAmount, decimal interestRate, int termMonths)
        {
            // คำนวณอัตราดอกเบี้ยต่อเดือน
            decimal monthlyInterestRate = interestRate / 12 / 100;

            // คำนวณยอดชำระเงินต่อเดือน
            decimal monthlyPayment = loanAmount * monthlyInterestRate / (1 - (decimal)Math.Pow((double)(1 + monthlyInterestRate), -termMonths));

            // สร้างรายการงวดการชำระเงิน
            List<Periodtran> installments = new List<Periodtran>();
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
        public void MakePayment(decimal paymentAmount, List<Periodtran> installments)
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
        public async Task RecordPayment(decimal paymentAmount, DateTime paymentDate, string receiptNo)
        {
            // เริ่ม transaction ใหม่
            using var transaction = await db.Database.BeginTransactionAsync();

            try
            {
                // ดึงข้อมูลสินเชื่อและรายละเอียดการชำระเงินตามงวด
                var loans = await db.Promises.ToListAsync();
                var installments = await db.Periodtrans.ToListAsync();

                // ทำการชำระเงิน
                MakePayment(paymentAmount, installments);

                // สร้างรายการการชำระเงินใหม่
                var payment = new Receipttran
                {
                    Amount = paymentAmount,
                    Tdate = paymentDate.AddYears(543).ToString("dd/MM/yyyyy"),
                    Receiptno = receiptNo
                };

                // เพิ่มข้อมูลการชำระเงินลงในฐานข้อมูล
                db.Receipttrans.Add(payment);
                await db.SaveChangesAsync();

                // สร้างรายละเอียดการชำระเงินในแต่ละงวด
                List<Receiptdesc> paymentDetails = new List<Receiptdesc>();
                foreach (var installment in installments)
                {
                    //paymentDetails.Add(new Receiptdesc
                    //{
                    //    r = payment.PaymentID,
                    //    InstallmentID = installment.InstallmentID,
                    //    PrincipalAmount = installment.PrincipalAmount,
                    //    InterestAmount = installment.InterestAmount,
                    //    TotalAmount = installment.PrincipalAmount + installment.InterestAmount,
                    //    PaymentDate = paymentDate,
                    //    RemainingBalance = installment.TotalAmount,
                    //    RemainingPrincipal = installment.PrincipalAmount,
                    //    RemainingInterest = installment.InterestAmount
                    //});
                }

                // เพิ่มรายละเอียดการชำระเงินลงในฐานข้อมูล
                db.Receiptdescs.AddRange(paymentDetails);
                await db.SaveChangesAsync();

                // ยืนยันการทำ transaction
                await transaction.CommitAsync();
            }
            catch
            {
                // ยกเลิก transaction หากเกิดข้อผิดพลาด
                await transaction.RollbackAsync();
                throw;
            }
        }
       
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
    }
}
