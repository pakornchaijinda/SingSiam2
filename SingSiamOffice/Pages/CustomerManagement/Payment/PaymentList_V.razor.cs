
using AutoGenReports.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.JSInterop;
using MudBlazor;
using SingSiamOffice.Manage;
using SingSiamOffice.Models;
using SingSiamOffice.Models.SingSiamOld;
using SingSiamOffice.Models.SingSiamOld2;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace SingSiamOffice.Pages.CustomerManagement.Payment
{
    public partial class PaymentList_V
    {
        [Inject]
        IWebHostEnvironment _env { get; set; }
        [Inject]
        NavigationManager navigationManager { get; set; }
        [Inject]
        Manage.Managements managements { get; set; }
        [Inject]
        IJSRuntime JSRuntime { get; set; }
        [Parameter]
        public string branch_code { get; set; }
        [Parameter]
        public int cus_id { get; set; }

        public string promiseno { get; set; }

        [Inject]
        Manage.GlobalData globalData { get; set; }
        [Inject]
        Manage.Managements Managements { get; set; }
        [Inject]
        Manage.BranchService branchService { get; set; }

        [Inject]
        Manage.PromiseManagement promiseManagement { get; set; }
        private string role { get; set; } = "employee";

        private Models.SingSiamOld2.Promise _promises { get; set; }

        private string filePath { get; set; }
        private string imgbase64 { get; set; }
        private string ReceiptNo { get; set; } = "";

        private int activeIndex = 0;
        private decimal totalFee { get; set; }
        private decimal totalFee_Old { get; set; }
        private decimal? intplus { get; set; } = 0;
        private decimal? discount { get; set; } = 0;
        public int cash_transfer { get; set; } = 1;
        public string type_d = "D";
        public string type_p = "P";

        public bool ck_intplus = false;
        public bool ck_discount = false;
        public int payment_method { get; set; } = 1;
        private int? current_periods { get; set; }

        private payment p = new payment();
        SingsiamdbContext db = new SingsiamdbContext();
        Models.SingSiamOld2._02singsiamContext _02SingsiamContextdb = new Models.SingSiamOld2._02singsiamContext();

        private Models.Customer customer_data = new Models.Customer();
        private Models.SingSiamOld2.Promise _promise = new Models.SingSiamOld2.Promise();
        private List<Models.SingSiamOld2.Periodtran> _Periodtrans = new List<Models.SingSiamOld2.Periodtran>();
        private List<Models.SingSiamOld2.Receiptdesc> _Receiptdescs = new List<Models.SingSiamOld2.Receiptdesc>();

        private Models.SingSiamOld2.Periodtran _promise_pay = new Models.SingSiamOld2.Periodtran();
        private List<Models.SingSiamOld2.Receiptdesc> lst_receiptdescs = new List<Models.SingSiamOld2.Receiptdesc>();
        private Models.SingSiamOld2.Receiptdesc _receiptdesc_toAdd { get; set; }

        protected override async void OnInitialized()
        {
            var uri = navigationManager.ToAbsoluteUri(navigationManager.Uri);
            var query = System.Web.HttpUtility.ParseQueryString(uri.Query);
            promiseno = query["promiseno"];
            promiseno = promiseno.Replace('_', '#').ToString();
            customer_data = await managements.GetCustomerbyId(cus_id);

            _promise = new Models.SingSiamOld2.Promise();
            _Periodtrans = new List<Models.SingSiamOld2.Periodtran>();

            _promise = await managements.GetPromiseDetailVbyPermiseNo(promiseno);
            _Periodtrans = await managements.GetPeriodtransbyPromise_V(promiseno);

            p = new payment();
            var receipt = await managements.Get_Receipt_No_V(branch_code, "receipt");
            p.receipt_no = receipt.ToString();
            p.overpay_qty = _Periodtrans.Where(s => s.OverPayQty > 0).Count();

            p.total_deposit = _Periodtrans.Where(s => s.ck_paid == false).Sum(p => p.Deposit).Value.ToString("N0");
            p.origin_fine = _Periodtrans.Sum(p => p.total_fee).ToString("N0");
            p.custom_fine = _Periodtrans.Sum(p => p.total_fee).ToString("N0");
            totalFee = Convert.ToDecimal(p.origin_fine);
            //p.Minimumfine = _periodtran.Where(s => s.check_overpay == true).Where(s => s.OverPayQty > 0).FirstOrDefault().total_fee;
            try
            {

                p.Minimumpayment = (decimal)_Periodtrans.Where(s => s.ck_paid == false).FirstOrDefault().Amount - (decimal)_Periodtrans.Where(s => s.ck_paid == false).FirstOrDefault().Paidamount + totalFee;

            }
            catch (Exception ex)
            {

            }


            p.total_Charge_follow = _Periodtrans.Where(s => s.ck_paid == false).FirstOrDefault().total_charge_follow.ToString("N0");

            if (p.overpay_qty > 0)
            {
                p.base_temp_deptAmount = _Periodtrans.Where(s => s.check_overpay == true).Sum(p => p.amount_remain);
                var total = ((_Periodtrans.Where(s => s.check_overpay == true).Sum(p => p.amount_remain) + Convert.ToDecimal(p.origin_fine)) - Convert.ToDecimal(p.total_deposit) + Convert.ToDecimal(p.total_Charge_follow));
                p.total_deptAmount = total.ToString("N0");
                p.pending_payAmont = ((_promise_pay.total_deptAmount - _promise_pay.total_deposit) + _promise_pay.total_charge_follow).ToString("N0");
            }
            else
            {
                p.total_deptAmount = "0";
                p.pending_payAmont = "0";
            }
        }

        public CultureInfo GetThaiCulture()
        {
            var culture = new CultureInfo("th-TH");
            DateTimeFormatInfo formatInfo = culture.DateTimeFormat;
            formatInfo.AbbreviatedDayNames = new[] { "อา", "จ", "อ", "พ", "พฤ", "ศ", "ส" };
            formatInfo.DayNames = new[] { "วันอาทิตย์", "วันจันทร์", "วันอังคาร", "วันพุธ", "วันพฤหัสบดี", "วันศุกร์", "วันเสาร์" };
            var monthNames = new[]
            {
        "มกราคม", "กุมภาพันธ์", "มีนาคม", "เมษายน", "พฤษภาคม", "มิถุนายน", "กรกฎาคม", "สิงหาคม", "กันยายน", "ตุลาคม", "พฤศจิกายน", "ธันวาคม",""
    };
            formatInfo.AbbreviatedMonthNames = formatInfo.MonthNames = formatInfo.MonthGenitiveNames = formatInfo.AbbreviatedMonthGenitiveNames = monthNames;
            formatInfo.AMDesignator = "ก่อนเที่ยง";
            formatInfo.PMDesignator = "หลังเที่ยง";
            formatInfo.ShortDatePattern = "dd/MM/yyyy";
            formatInfo.LongDatePattern = "dddd, dd MMMM,yyyy";
            formatInfo.FirstDayOfWeek = DayOfWeek.Sunday;
            return culture;
        }
        private async Task submitpaymentlist()
        {

            if (p.customerPayAmount != null)
            {
                var confirm = await JSRuntime.InvokeAsync<bool>("confirmPayment");
                if (confirm)
                {

                    if (payment_method == 4)
                    {

                        Models.SingSiamOld2.Receipttran _receipttran_toAdd = new Models.SingSiamOld2.Receipttran();

                        _receipttran_toAdd.Promiseno = _promise.Promiseno;
                        _receipttran_toAdd.Taxpromise = 0;
                        _receipttran_toAdd.Specialtaxpromise = 0;
                        _receipttran_toAdd.Branch = _promise.Branch;
                        _receipttran_toAdd.Ptype = _promise.Ptype;
                        _receipttran_toAdd.Customer = _promise.Customer;
                        _receipttran_toAdd.Receiptno = p.receipt_no;
                        _receipttran_toAdd.Receiptdesc = "รับฝากเงินล่วงหน้า";

                        _receipttran_toAdd.Tdate = DateTime.Now.AddYears(543).ToString("dd/MM/yyyy");
                        _receipttran_toAdd.Tdateformat = DateTime.Now.ToString("yyyyMMdd");
                        _receipttran_toAdd.Tdatecal = DateTime.Now.AddYears(543).ToString("dd/MM/yyyy");
                        _receipttran_toAdd.Tdatecalformat = DateTime.Now.ToString("yyyyMMdd");

                        var lastPeriodpay = _Periodtrans.Where(s => s.ck_paid == true).OrderByDescending(s => s.Period).FirstOrDefault().Period;
                        _receipttran_toAdd.Periodchg = lastPeriodpay + 1;
                        _receipttran_toAdd.Periodremain = await managements.Calperiodremain(_promise.Promiseno, Convert.ToDecimal(p.customerPayAmount));
                        _receipttran_toAdd.Usercode = globalData.fullname;
                        if (cash_transfer == 1)
                        {
                            _receipttran_toAdd.Cashpaid = 1;
                        }
                        else
                        {
                            _receipttran_toAdd.Transferpaid = 1;
                        }

                        DateTime today = DateTime.Today;
                        _receipttran_toAdd.Currentperiod = await managements.GetPeriodNumberV(_Periodtrans, today);

                        await promiseManagement.addReceipttran_v(_receipttran_toAdd);

                        //ยอดที่ชำระ
                        globalData.paymentAmount = (decimal)_receipttran_toAdd.Amount;


                        Models.SingSiamOld2.Receiptdesc _receiptdesc_toAdd = new Models.SingSiamOld2.Receiptdesc();
                        _receiptdesc_toAdd.Promiseno = _promise.Promiseno;
                        _receiptdesc_toAdd.Branch = _promise.Branch;
                        _receiptdesc_toAdd.Ptype = _promise.Ptype;
                        _receiptdesc_toAdd.Customer = _promise.Customer;
                        _receiptdesc_toAdd.Receiptno = p.receipt_no;
                        _receiptdesc_toAdd.Tdate = DateTime.Now.AddYears(543).ToString("dd/MM/yyyy");
                        _receiptdesc_toAdd.Tdateformat = DateTime.Now.ToString("yyyyMMdd");
                        _receiptdesc_toAdd.Tdatecal = DateTime.Now.AddYears(543).ToString("dd/MM/yyyy");
                        _receiptdesc_toAdd.Tdatecalformat = DateTime.Now.ToString("yyyyMMdd");

                        _receiptdesc_toAdd.Period = _Periodtrans.Where(s => s.ck_paid == false).Select(s => s.Period).FirstOrDefault();
                        //  _receiptdesc_toAdd.Perioddate = _Periodtrans.Where(s => s.ck_paid == false).Select(s => s.Tdateformat).FirstOrDefault();

                        _receiptdesc_toAdd.Deposit = (double)_receipttran_toAdd.Amount;
                        _receiptdesc_toAdd.Periodchg = _Periodtrans.Where(s => s.ck_paid == false).Select(s => s.Period).FirstOrDefault(); ;

                        _receiptdesc_toAdd.receipt_desc = _receipttran_toAdd.Receiptdesc;



                        _receiptdesc_toAdd.Usercode = globalData.username;
                        //  _receiptdesc_toAdd.Chargeamt = _promise_pay.total_fee;

                        _Receiptdescs.Add(_receiptdesc_toAdd);



                        await promiseManagement.addReceipdesc_v(_Receiptdescs);

                        await JSRuntime.InvokeVoidAsync("paymentsuccess");
                        await Task.Delay(1000);

                        //    navigationManager.NavigateTo($"/paymentlist/{branch_id}/{c_id}/{promise_id}");
                        var p_no = _promise.Promiseno.Replace("#", "_");
                        navigationManager.NavigateTo($"/paymentlistv/{branch_code}/{cus_id}?promiseno=" + p_no, forceLoad: true);
                    }
                    else
                    {
                        if (activeIndex == 0)
                        {

                            if (Convert.ToDecimal(p.customerPayAmount) >= (p.Minimumpayment))
                            {
                                p.temp_total_deptAmount = Convert.ToDecimal(p.customerPayAmount);
                                decimal cal_period_pay = ((Convert.ToDecimal(p.customerPayAmount) - totalFee) - Convert.ToDecimal(p.total_Charge_follow)) / (decimal)_promise.Amount;
                                var period_pay_qty = (int)Math.Ceiling(cal_period_pay);
                                int remainingInstallments = (int)_Periodtrans.Where(s => s.ck_paid == false).Count() - (int)Math.Floor(cal_period_pay);

                                //รายการที่ยังไม่ได้ชำระ
                                var _periodtran_detail = _Periodtrans.Where(s => s.ck_paid == false).Take(period_pay_qty).ToList();

                                //รายการงวดที่เลยค้างชำระ 
                                var amount_per_month_check_overpay = _Periodtrans.Where(s => s.ck_paid == false && s.check_overpay == true).Take(period_pay_qty).ToList();

                                decimal cus_totalpay = Convert.ToDecimal(p.customerPayAmount) + Convert.ToDecimal(p.total_deposit);

                                foreach (var item in _periodtran_detail)
                                {
                                    if (item.Deposit != 0)
                                    {
                                        item.ck_deposit = true;
                                    }
                                    else
                                    {
                                        item.ck_deposit = false;
                                    }



                                    if (item.Paidamount != 0)
                                    {
                                        if (cus_totalpay >= (decimal)item.Paidamount)
                                        {
                                            item.ck_amount = true;
                                            if (item.ck_deposit == true)
                                            {
                                                item.Paidamount = item.Paidamount - item.Deposit;
                                            }
                                            item.amount_remain_pay = Convert.ToDecimal(p.customerPayAmount) - (decimal)item.Paidamount;
                                            cus_totalpay = item.amount_remain_pay;
                                        }
                                        else
                                        {
                                            item.ck_amount = false;
                                            item.amount_remain_pay = cus_totalpay;
                                        }
                                    }
                                    else
                                    {
                                        //จำนวนเงินที่จ่ายไปแล้ว
                                        var already_paid = item.Amount - (item.Cappaid + item.Intpaid);
                                        item.Amount = already_paid;
                                        if (cus_totalpay >= (decimal)item.Amount)
                                        {
                                            item.ck_amount = true;
                                            item.amount_remain_pay = Convert.ToDecimal(p.customerPayAmount) - (decimal)item.Amount;
                                            cus_totalpay = item.amount_remain_pay;
                                        }
                                        else
                                        {
                                            item.ck_amount = false;
                                            item.amount_remain_pay = cus_totalpay;
                                        }
                                    }

                                }


                                Models.SingSiamOld2.Receipttran _receipttran_toAdd = new Models.SingSiamOld2.Receipttran();

                                _receipttran_toAdd.Promiseno = _promise.Promiseno;
                                _receipttran_toAdd.Branch = _promise.Branch;
                                _receipttran_toAdd.Ptype = _promise.Ptype;
                                _receipttran_toAdd.Customer = _promise.Customer;
                                _receipttran_toAdd.Receiptno = p.receipt_no;
                                _receipttran_toAdd.Intplus = (double)intplus;
                                _receipttran_toAdd.Discount = (double)discount;
                                var totalDeposit = Convert.ToDecimal(p.total_deposit);
                                _receipttran_toAdd.Deposit = (double)totalDeposit;
                                if (payment_method == 1 || payment_method == 2 || payment_method == 3)
                                {
                                    _receipttran_toAdd.Amount = Convert.ToDouble(p.customerPayAmount);
                                    _receipttran_toAdd.Receiptdesc = "ชำระค่างวด";
                                }
                                if (payment_method == 4)
                                {
                                    _receipttran_toAdd.Amount = Convert.ToDouble(p.customerPayAmount);
                                    _receipttran_toAdd.Receiptdesc = "รับฝากเงินล่วงหน้า";
                                }

                                _receipttran_toAdd.Tdate = DateTime.Now.AddYears(543).ToString("dd/MM/yyyy");
                                _receipttran_toAdd.Tdateformat = DateTime.Now.ToString("yyyyMMdd");
                                _receipttran_toAdd.Tdatecal = DateTime.Now.AddYears(543).ToString("dd/MM/yyyy");
                                _receipttran_toAdd.Tdatecalformat = DateTime.Now.ToString("yyyyMMdd");


                                //รายการงวดที่จ่าบ
                                _receipttran_toAdd.peroidtrans_info = _Periodtrans.Where(s => s.ck_paid == false).Take(period_pay_qty).ToList();

                                _receipttran_toAdd.Usercode = globalData.fullname;

                                if (payment_method == 1)
                                {
                                    _receipttran_toAdd.Cashpaid = 1;
                                    // _receipttran_toAdd.PaidBy = 1;
                                }
                                if (payment_method == 2)
                                {
                                    _receipttran_toAdd.Transferpaid = 1;
                                    // _receipttran_toAdd.PaidBy = 2;
                                }
                                if (payment_method == 3)
                                {
                                    _receipttran_toAdd.Otherpaid = 1;
                                    //_receipttran_toAdd.PaidBy = 3;
                                }
                                if (payment_method == 4)
                                {
                                    _receipttran_toAdd.Otherpaid = 1;
                                    //_receipttran_toAdd.PaidBy = 4;
                                }

                                //แสดงงวดปัจจุบัน
                                _receipttran_toAdd.Currentperiod = await managements.GetPeriodNumberV(_Periodtrans, DateTime.Now);


                                //สถานะบัญชี
                                if (close_type_status == null)
                                {
                                    _receipttran_toAdd.Closecase = "-";
                                }
                                else
                                {
                                    _receipttran_toAdd.Closecase = close_type_status;
                                }

                                if (payment_method != 4)
                                {


                                    if (amount_per_month_check_overpay.Count() != 0)
                                    {
                                        //var totalFine = _receipttran_toAdd.peroidtrans_info.Sum(s => s.total_fee);
                                        //var totalFollowCharge = _receipttran_toAdd.peroidtrans_info.Sum(s => s.total_charge_follow);
                                        var totalInterest = _receipttran_toAdd.peroidtrans_info.Sum(s => s.Interest);
                                        var totalCapital = _receipttran_toAdd.peroidtrans_info.Sum(s => s.Capital);

                                        //ค่าปรับ
                                        _receipttran_toAdd.Charge1amt = Convert.ToDouble(p.origin_fine);
                                        _receipttran_toAdd.charage_origin = Convert.ToDecimal(p.origin_fine);
                                        //ค่าติดตาม ค่าทวงถาม
                                        _receipttran_toAdd.Charge2amt = Convert.ToDouble(p.total_Charge_follow);

                                        var lastPeriodtrans = _Periodtrans?.Where(s => s.ck_paid == true)
                                      .OrderByDescending(s => s.Period)
                                      .FirstOrDefault();

                                        TimeSpan diffdate;

                                        if (lastPeriodtrans == null || lastPeriodtrans.tdate_pay == null)
                                        {
                                            // If no paid transaction exists or tdate_pay is null, set diffdate to zero
                                            diffdate = TimeSpan.Zero;
                                        }
                                        else
                                        {
                                            // Calculate the difference between now and the last payment date
                                            diffdate = DateTime.Now - lastPeriodtrans.tdate_pay;
                                        }



                                        var cnt_remainpay = diffdate.Days;
                                        p.temp_total_deptAmount = ((decimal)(_Periodtrans.FirstOrDefault().Amount * cnt_remainpay)) + totalFee + Convert.ToDecimal(p.total_Charge_follow);
                                        p.Arbalance = p.temp_total_deptAmount;
                                        p.temp_total_deptAmount = (p.temp_total_deptAmount - Convert.ToDecimal(p.origin_fine)) - Convert.ToDecimal(p.total_Charge_follow);


                                        if (p.temp_total_deptAmount >= (decimal)totalInterest)
                                        {
                                            p.temp_total_deptAmount = p.temp_total_deptAmount - (decimal)totalInterest;
                                            _receipttran_toAdd.Intpaid = totalInterest;
                                        }
                                        else
                                        {
                                            var Intpaid = (decimal)totalInterest - p.temp_total_deptAmount;
                                            _receipttran_toAdd.Intpaid = (double)p.temp_total_deptAmount;
                                            p.temp_total_deptAmount -= p.temp_total_deptAmount;
                                        }

                                        if (p.temp_total_deptAmount >= (decimal)totalCapital)
                                        {
                                            p.temp_total_deptAmount = p.temp_total_deptAmount - (decimal)totalCapital;
                                            if (p.temp_total_deptAmount >= 0)
                                            {
                                                _receipttran_toAdd.Cappaid = totalCapital;
                                            }
                                            else
                                            {
                                                _receipttran_toAdd.Cappaid = amount_per_month_check_overpay.Sum(s => s.Capital);
                                            }

                                        }
                                        else
                                        {
                                            var cappaid = (decimal)totalCapital - p.temp_total_deptAmount;

                                            _receipttran_toAdd.Cappaid = (double)p.temp_total_deptAmount;
                                            p.temp_total_deptAmount -= p.temp_total_deptAmount;
                                        }

                                        //receipttran_toAdd.Cappaid = amount_per_month_check_overpay.Sum(s => s.Capital);
                                        //_receipttran_toAdd.Intpaid = amount_per_month_check_overpay.Sum(s => s.Interest);
                                        // _receipttran_toAdd.Arbalance = p.Arbalance + totalFee + Convert.ToDecimal(p.total_Charge_follow);

                                    }
                                    else
                                    {
                                        // p.Arbalance = (decimal)_periodtran_detail.Where(s => s.ck_amount == true).Sum(s => s.Amount) - (decimal)_periodtran_detail.Where(s => s.ck_amount == true).Sum(s => s.Intpaid);
                                        var lastPeriodtrans = _Periodtrans.Where(s => s.ck_paid == true).OrderByDescending(s => s.Period).FirstOrDefault();
                                        var tdate_pay = lastPeriodtrans.tdate_pay;
                                        TimeSpan diffdate = DateTime.Now - tdate_pay;
                                        var cnt_remainpay = diffdate.Days;
                                        p.temp_total_deptAmount = ((decimal)(_Periodtrans.FirstOrDefault().Amount * cnt_remainpay)) + totalFee + Convert.ToDecimal(p.total_Charge_follow);
                                        p.Arbalance = p.temp_total_deptAmount;
                                        p.temp_total_deptAmount = (p.temp_total_deptAmount - Convert.ToDecimal(p.origin_fine)) - Convert.ToDecimal(p.total_Charge_follow);
                                        _receipttran_toAdd.Cappaid = _periodtran_detail.Where(s => s.ck_amount == true).Sum(s => s.Capital);
                                        _receipttran_toAdd.Intpaid = _periodtran_detail.Where(s => s.ck_amount == true).Sum(s => s.Interest) - _periodtran_detail.Where(s => s.ck_amount == true).Sum(s => s.Intpaid);
                                        _receipttran_toAdd.Arbalance = (double)p.Arbalance;
                                        //ค่าปรับ
                                        _receipttran_toAdd.Charge1amt = (double)totalFee;

                                        //ค่าติดตาม ค่าทวงถาม
                                        _receipttran_toAdd.Charge2amt = Convert.ToDouble(p.total_Charge_follow);
                                    }

                                    var count_periodtran = _Periodtrans.Where(s => s.ck_paid == false).Count();

                                    _receipttran_toAdd.Periodremain = count_periodtran - period_pay_qty;
                                    _receipttran_toAdd.Arremain = _receipttran_toAdd.Arbalance - _receipttran_toAdd.Amount;
                                    //ยอดคงเหลือ
                                    Models.SingSiamOld2.Receipttran? Capremain_before = await managements.GetReceipttranV_bypromiseNo(_promise.Promiseno);
                                    if (Capremain_before == null)
                                    {
                                        _receipttran_toAdd.Capremain = _promise.Capital - _receipttran_toAdd.Cappaid;
                                        var sum_interate = _Periodtrans.Where(s => s.ck_amount == false).Sum(s => s.Interest);
                                        _receipttran_toAdd.Intremain = sum_interate - _receipttran_toAdd.Intpaid;
                                    }
                                    else
                                    {
                                        //var totalcapital = Capremain_before.Capremain;
                                        //  var capremain_amount = totalcapital - Capremain_before.Promise.Periodtrans.Where(s => s.Ispaid == true).Sum(s => s.Cappaid);
                                        if (_promise.Ptype == 1)
                                        {
                                            _receipttran_toAdd.Capremain = Capremain_before.Capremain - _receipttran_toAdd.Cappaid;
                                            _receipttran_toAdd.Intremain = Capremain_before.Intremain - _receipttran_toAdd.Intpaid;
                                        }
                                        else
                                        {
                                            _receipttran_toAdd.Capremain = _promise.Capital;
                                            _receipttran_toAdd.Intremain = Capremain_before.Intremain - _receipttran_toAdd.Intpaid;
                                        }

                                    }
                                }
                                else
                                {
                                    current_periods = await managements.GetPeriodNumberV(_Periodtrans, DateTime.Now);
                                }

                                //บันทึกลง DB Receipttran
                                await promiseManagement.addReceipttran_v(_receipttran_toAdd);


                                //ยอดที่ชำระ
                                globalData.paymentAmount = (((decimal)_receipttran_toAdd.Amount - (decimal)_receipttran_toAdd.Charge1amt) - (decimal)_receipttran_toAdd.Charge2amt);

                                for (int i = 0; i < period_pay_qty; i++)
                                {
                                    Models.SingSiamOld2.Receiptdesc _receiptdesc_toAdd = new Models.SingSiamOld2.Receiptdesc();
                                    _receiptdesc_toAdd.Promiseno = _promise.Promiseno;
                                    _receiptdesc_toAdd.Branch = _promise.Branch;
                                    _receiptdesc_toAdd.Customer = _promise.Customer;
                                    _receiptdesc_toAdd.Receiptno = p.receipt_no;
                                    _receiptdesc_toAdd.Tdate = DateTime.Now.AddYears(543).ToString("dd/MM/yyyy");
                                    _receiptdesc_toAdd.Tdateformat = DateTime.Now.ToString("yyyyMMdd");
                                    _receiptdesc_toAdd.Tdatecal = DateTime.Now.AddYears(543).ToString("dd/MM/yyyy");
                                    _receiptdesc_toAdd.Tdatecalformat = DateTime.Now.ToString("yyyyMMdd");

                                    _receiptdesc_toAdd.Period = _receipttran_toAdd.peroidtrans_info[i].Period;
                                    _receiptdesc_toAdd.Perioddate = _receipttran_toAdd.peroidtrans_info[i].Tdateformat;
                                    _receiptdesc_toAdd.Chargeamt = _receipttran_toAdd.Charge1amt;
                                    _receiptdesc_toAdd.Lateamt = _receipttran_toAdd.Charge2amt;
                                    decimal totalDue = 0;

                                    //ดอกเบี้ยที่จ่ายล่วงหน้า

                                    //var intpaid = _receipttran_toAdd.peroidtrans_info[i].Receiptdescs.Where(s => s.PeriodtranId == _receiptdesc_toAdd.PeriodtranId).Select(s => s.Intpaid).FirstOrDefault();
                                    //var cappaid = _receipttran_toAdd.peroidtrans_info[i].Receiptdescs.Where(s => s.PeriodtranId == _receiptdesc_toAdd.PeriodtranId).Select(s => s.Cappaid).FirstOrDefault();

                                    totalDue = ((decimal)_receipttran_toAdd.peroidtrans_info[i].Capital + (decimal)_receipttran_toAdd.peroidtrans_info[i].Interest) - (decimal)_receipttran_toAdd.peroidtrans_info[i].Deposit;

                                    while (globalData.paymentAmount > 0)
                                    {
                                        if (p.payment_Menthod != 4)
                                        {

                                            if (globalData.paymentAmount >= totalDue)
                                            {

                                                _receiptdesc_toAdd.Cappaid = _receipttran_toAdd.peroidtrans_info[i].Capital * -1;
                                                _receiptdesc_toAdd.Intpaid = (_receipttran_toAdd.peroidtrans_info[i].Interest) * -1;
                                                var total = _receiptdesc_toAdd.Cappaid + _receiptdesc_toAdd.Intpaid;
                                                _receiptdesc_toAdd.Amount = total;
                                                globalData.RemainingPaid = globalData.paymentAmount - ((decimal)_receiptdesc_toAdd.Amount * -1);
                                                globalData.paymentAmount -= totalDue;
                                                break;
                                            }
                                            else
                                            {
                                                if (globalData.paymentAmount < totalDue)
                                                {
                                                    _receiptdesc_toAdd.pending_amount = globalData.paymentAmount;
                                                }
                                                else
                                                {
                                                    _receiptdesc_toAdd.pending_amount = globalData.RemainingPaid;
                                                }

                                                if (_receiptdesc_toAdd.pending_amount >= (decimal)_receipttran_toAdd.peroidtrans_info[i].Interest)
                                                {
                                                    var amount_over_interest = _receiptdesc_toAdd.pending_amount - (decimal)_receipttran_toAdd.peroidtrans_info[i].Interest;
                                                    _receiptdesc_toAdd.Intpaid = _receipttran_toAdd.peroidtrans_info[i].Interest * -1;
                                                    _receiptdesc_toAdd.Cappaid = (double)amount_over_interest * -1;
                                                    var total = _receiptdesc_toAdd.Cappaid + _receiptdesc_toAdd.Intpaid;
                                                    _receiptdesc_toAdd.Amount = (double)_receiptdesc_toAdd.pending_amount * -1;
                                                    globalData.RemainingPaid -= _receiptdesc_toAdd.pending_amount;
                                                    break;
                                                }
                                                else
                                                {
                                                    _receiptdesc_toAdd.Intpaid = (double)_receiptdesc_toAdd.pending_amount * -1;
                                                    _receiptdesc_toAdd.Amount = (double)_receiptdesc_toAdd.pending_amount * -1;
                                                    globalData.paymentAmount -= _receiptdesc_toAdd.pending_amount;
                                                    break;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            _receiptdesc_toAdd.Deposit = (double)_receipttran_toAdd.Amount;
                                            _receiptdesc_toAdd.Periodchg = current_periods;
                                            //_receiptdesc_toAdd.payment_method = 4;
                                            break;
                                        }

                                    }

                                    //  _receiptdesc_toAdd.pending_amount = globalData.RemainingPaid;
                                    //_receiptdesc_toAdd.Chargeamt = _receipttran_toAdd.peroidtrans_info[i].total_fee;
                                    _receiptdesc_toAdd.receipt_desc = _receipttran_toAdd.Receiptdesc;
                                    _receiptdesc_toAdd.Usercode = globalData.fullname;
                                    lst_receiptdescs.Add(_receiptdesc_toAdd);

                                }

                               

                              



                                if (await promiseManagement.addReceipdesc_v(lst_receiptdescs))
                                {
                                    await JSRuntime.InvokeVoidAsync("paymentsuccess");
                                    await Task.Delay(2000);

                                    //    navigationManager.NavigateTo($"/paymentlist/{branch_id}/{c_id}/{promise_id}");
                                    var p_no = _promise.Promiseno.Replace("#", "_");
                                    navigationManager.NavigateTo($"/paymentlistv/{branch_code}/{cus_id}?promiseno=" + p_no, forceLoad: true);
                                }
                                else
                                {
                                   // await promiseManagement.addReceipdesc_v(lst_receiptdescs);
                                    await Task.Delay(2000);
                                    await JSRuntime.InvokeVoidAsync("alert", "ชำระเงินไม่สำเร็จ!");
                                    await Task.Delay(1000);
                                    await Task.Delay(2000);

                                    //    navigationManager.NavigateTo($"/paymentlist/{branch_id}/{c_id}/{promise_id}");
                                    var p_no = _promise.Promiseno.Replace("#", "_");
                                    navigationManager.NavigateTo($"/paymentlistv/{branch_code}/{cus_id}?promiseno=" + p_no, forceLoad: true);
                                }
                            }
                            else
                            {
                                await JSRuntime.InvokeVoidAsync("alert_error_pay_notenough");

                            }
                        }
                        else if (activeIndex == 1)
                        {
                            if (Convert.ToDecimal(p.customerPayAmount) >= Convert.ToDecimal(p.p_total_deptAmount))
                            {


                                Models.SingSiamOld2.Receipttran _receipttran_toAdd = new Models.SingSiamOld2.Receipttran();

                                _receipttran_toAdd.Promiseno = _promise.Promiseno;
                                _receipttran_toAdd.Branch = _promise.Branch;
                                _receipttran_toAdd.Customer = _promise.Customer;
                                _receipttran_toAdd.Receiptno = p.receipt_no;
                                _receipttran_toAdd.Ptype = _promise.Ptype;
                                if (payment_method == 1 || payment_method == 2 || payment_method == 3)
                                {
                                    _receipttran_toAdd.Amount = 0;
                                    _receipttran_toAdd.Receiptdesc = "ปิดสัญญาก่อนกำหนด";
                                }


                                _receipttran_toAdd.Tdate = DateTime.Now.AddYears(543).ToString("dd/MM/yyyy");
                                _receipttran_toAdd.Tdateformat = DateTime.Now.ToString("yyyyMMdd");
                                _receipttran_toAdd.Tdatecal = DateTime.Now.AddYears(543).ToString("dd/MM/yyyy");
                                _receipttran_toAdd.Tdatecalformat = DateTime.Now.ToString("yyyyMMdd");
                                _receipttran_toAdd.peroidtrans_info = _Periodtrans.Where(s => s.ck_paid == false).ToList();

                                if (p.p_close_type_status == null)
                                {
                                    _receipttran_toAdd.Closecase = "-";
                                }
                                else
                                {
                                    _receipttran_toAdd.Closecase = p.p_close_type_status;
                                }
                                if (payment_method != 4)
                                {
                                    var lastPeriodtrans = _Periodtrans.Where(s => s.ck_paid == true).OrderByDescending(s => s.Period).FirstOrDefault();
                                    var tdate_pay = lastPeriodtrans.tdate_pay;
                                    TimeSpan diffdate = DateTime.Now - tdate_pay;
                                    var cnt_remainpay = diffdate.Days;

                                    var Tdate = _Periodtrans.Select(s => s.Tdateformat).ToList();
                                    List<DateTime> dueDates = new List<DateTime>();
                                    foreach (var s in Tdate)
                                    {
                                        DateTime dt = DateTime.ParseExact(s, "yyyyMMdd", CultureInfo.InvariantCulture);
                                        dueDates.Add(dt);
                                    }
                                    int missedPeriods = dueDates
    .Where(d => d > tdate_pay && d < DateTime.Now)
    .Count();
                                    p.temp_total_deptAmount = ((decimal)(_Periodtrans.FirstOrDefault().Amount * cnt_remainpay)) + totalFee + Convert.ToDecimal(p.total_Charge_follow);
                                    p.Arbalance = p.temp_total_deptAmount;
                                    _receipttran_toAdd.Arperiod = missedPeriods;
                                    _receipttran_toAdd.Cappaid = 0;
                                    _receipttran_toAdd.Intpaid = 0;
                                    _receipttran_toAdd.Intplus = (double)intplus;
                                    _receipttran_toAdd.Discount = (double)discount;
                                    Models.SingSiamOld2.Receipttran? Capremain_before = await managements.GetReceipttranV_bypromiseNo(_promise.Promiseno);
                                    if (Capremain_before == null)
                                    {
                                        _receipttran_toAdd.Capremain = _promise.Capital - _receipttran_toAdd.Cappaid;
                                        var sum_interate = _Periodtrans.Where(s => s.ck_paid == false).Sum(s => s.Interest);
                                        _receipttran_toAdd.Intremain = sum_interate - _receipttran_toAdd.Intpaid;
                                    }
                                    else
                                    {
                                        _receipttran_toAdd.Capremain = Capremain_before.Capremain - _receipttran_toAdd.Cappaid;
                                        var sum_interate = Capremain_before.Intremain;
                                        _receipttran_toAdd.Intremain = sum_interate - _receipttran_toAdd.Intpaid;
                                    }


                                    _receipttran_toAdd.Charge1amt = (double)totalFee;
                                    _receipttran_toAdd.Charge2amt = Convert.ToDouble(p.p_total_Charge_follow);

                                    _receipttran_toAdd.Netamount = Convert.ToDouble(p.customerPayAmount);


                                    var count_periodtran = _Periodtrans.Where(s => s.ck_paid == false).Count();
                                    if (count_periodtran == _promise.Periods)
                                    {
                                        _receipttran_toAdd.Periodremain = _promise.Periods - 1;

                                    }
                                    else
                                    {
                                        _receipttran_toAdd.Periodremain = count_periodtran;
                                    }
                                }
                                else
                                {
                                    var count_periodtran = _Periodtrans.Where(s => s.ck_paid == false).Count();
                                    current_periods = await managements.GetPeriodNumberV(_Periodtrans, DateTime.Now);
                                    // _receipttran_toAdd.Periodchg = current_periods;
                                    _receipttran_toAdd.Periodremain = count_periodtran;
                                }




                                _receipttran_toAdd.Usercode = globalData.fullname;

                                if (payment_method == 1)
                                {
                                    _receipttran_toAdd.Cashpaid = 1;

                                }
                                if (payment_method == 2)
                                {
                                    _receipttran_toAdd.Transferpaid = 1;

                                }
                                if (payment_method == 3)
                                {
                                    _receipttran_toAdd.Otherpaid = 1;

                                }
                                if (payment_method == 4)
                                {
                                    _receipttran_toAdd.Otherpaid = 1;

                                }

                                _receipttran_toAdd.Currentperiod = _Periodtrans.Where(s => s.ck_paid == false).Select(s => s.Period).FirstOrDefault();
                                //  _receipttran_toAdd.RemainingPrincipal = ((decimal)customerPayAmount - totalFee) - _promise.Amount;

                                //บันทึกลงใน Table [dbo].[receipttran]
                                await promiseManagement.addReceipttran_v(_receipttran_toAdd);


                                //ยอดที่ปิดชำระสัญญา
                                globalData.paymentAmount = (decimal)_receipttran_toAdd.Netamount;

                                for (int i = 0; i < p.p_overpay_qty; i++)
                                {
                                    Models.SingSiamOld2.Receiptdesc _receiptdesc_toAdd = new Models.SingSiamOld2.Receiptdesc();
                                    _receiptdesc_toAdd.Promiseno = _promise.Promiseno;
                                    _receiptdesc_toAdd.Branch = _promise.Branch;
                                    _receiptdesc_toAdd.Customer = _promise.Customer;
                                    _receiptdesc_toAdd.Receiptno = p.receipt_no;
                                    _receiptdesc_toAdd.Tdate = DateTime.Now.AddYears(543).ToString("dd/MM/yyyy");
                                    _receiptdesc_toAdd.Tdateformat = DateTime.Now.ToString("yyyyMMdd");
                                    _receiptdesc_toAdd.Tdatecal = DateTime.Now.AddYears(543).ToString("dd/MM/yyyy");
                                    _receiptdesc_toAdd.Tdatecalformat = DateTime.Now.ToString("yyyyMMdd");
                                    _receiptdesc_toAdd.Period = _receipttran_toAdd.peroidtrans_info[i].Period;
                                    _receiptdesc_toAdd.Perioddate = _receipttran_toAdd.peroidtrans_info[i].Tdateformat;
                                    _receiptdesc_toAdd.Chargeamt = _receipttran_toAdd.Charge1amt;
                                    _receiptdesc_toAdd.Deposit = _receipttran_toAdd.peroidtrans_info[i].Deposit;

                                    decimal totalDue = ((decimal)_receipttran_toAdd.peroidtrans_info[i].Capital + (decimal)_receipttran_toAdd.peroidtrans_info[i].Interest) - ((decimal)_receipttran_toAdd.peroidtrans_info[i].Paidamount * -1);

                                    var totalPaidremain = ((decimal)_receipttran_toAdd.peroidtrans_info[i].Paidamount * -1);


                                    if (totalPaidremain > 0)
                                    {
                                        _receiptdesc_toAdd.Intpaid = (_receipttran_toAdd.peroidtrans_info[i].Interest - (double)totalPaidremain) * -1;
                                        totalPaidremain = totalPaidremain - (decimal)_receipttran_toAdd.peroidtrans_info[i].Interest;


                                    }
                                    else
                                    {
                                        _receiptdesc_toAdd.Intpaid = (_receipttran_toAdd.peroidtrans_info[i].Interest * -1);
                                    }

                                    if ((double)totalPaidremain >= _receipttran_toAdd.peroidtrans_info[i].Capital)
                                    {
                                        _receiptdesc_toAdd.Cappaid = (_receipttran_toAdd.peroidtrans_info[i].Capital - (double)totalPaidremain) * -1;

                                        totalPaidremain = totalPaidremain + (decimal)_receiptdesc_toAdd.Cappaid;
                                    }
                                    else
                                    {
                                        _receiptdesc_toAdd.Cappaid = _receipttran_toAdd.peroidtrans_info[i].Capital * -1;
                                    }
                                    _receiptdesc_toAdd.Amount = (((double)_receipttran_toAdd.peroidtrans_info[i].Capital + (double)_receipttran_toAdd.peroidtrans_info[i].Interest) - ((double)_receipttran_toAdd.peroidtrans_info[i].Paidamount * -1)) * -1;
                                    _receiptdesc_toAdd.Usercode = globalData.fullname;
                                    _receiptdesc_toAdd.Chargeamt = (double)totalFee;

                                    lst_receiptdescs.Add(_receiptdesc_toAdd);

                                }

                                //บันทึกลงใน Table [dbo].[receiptdesc]
                                //await promiseManagement.addReceipdesc_v(lst_receiptdescs);


                                //Check Close Promise 
                               


                                if (await promiseManagement.addReceipdesc_v(lst_receiptdescs))
                                {
                                    await promiseManagement.updateClosePromiseV(_promise.Promiseno);
                                    await Task.Delay(2000);
                                    await JSRuntime.InvokeVoidAsync("paymentsuccess");
                                    await Task.Delay(1000);

                                    if (activeIndex == 0)
                                    {
                                        var p_no = _promise.Promiseno.Replace("#", "_");
                                        navigationManager.NavigateTo($"/paymentlistv/{branch_code}/{cus_id}?promiseno=" + p_no, forceLoad: true);
                                    }
                                    else
                                    {
                                        navigationManager.NavigateTo($"/customerlist/{globalData.branch_id}/{cus_id}", forceLoad: true);
                                    }
                                  
                                }
                                else
                                {
                                    //await promiseManagement.addReceipdesc_v(lst_receiptdescs);
                                    //await promiseManagement.updateClosePromiseV(_promise.Promiseno);
                                    await Task.Delay(2000);
                                    await JSRuntime.InvokeVoidAsync("alert", "ชำระเงินไม่สำเร็จ!");
                                    await Task.Delay(1000);


                                    var p_no = _promise.Promiseno.Replace("#", "_");
                                    navigationManager.NavigateTo($"/paymentlistv/{branch_code}/{cus_id}?promiseno=" + p_no, forceLoad: true);
                                }
                            }
                            else
                            {
                                await JSRuntime.InvokeVoidAsync("alert_error_pay_notenough");

                            }
                        }
                        else { }

                    }

                }
                else
                {
                    await JSRuntime.InvokeVoidAsync("paymenterror");
                }
            }
            else
            {
                await JSRuntime.InvokeVoidAsync("paymenterror_amount");
            }

        }

        private int? ExpandedPeriodtransId;
        private void ToggleDetails(int periodtranId)
        {
            if (ExpandedPeriodtransId == periodtranId)
            {
                ExpandedPeriodtransId = null;
            }
            else
            {
                ExpandedPeriodtransId = periodtranId;
            }
        }
        private void goback()
        {
            navigationManager.NavigateTo($"/customerlist/{branch_code}/{cus_id}");
        }

        #region UploadIMG
        private List<string> fileNames = new List<string>();
        private const int MaxImageUploadSizeMB = 1;
        private const int MaxImageUploadSize = MaxImageUploadSizeMB * 1000000; //in bytes
        private ImageUploadFormModel _formModel = new ImageUploadFormModel();
        public class ImageUploadFormModel
        {
            public IBrowserFile ImageFile { get; set; }
            public string PreviewUrl { get; set; } = null;

            [Required]
            public byte[] ImageFileData { get; set; }
        }

        public IBrowserFile ImageFile { get; set; }
        public byte[] ImageFileData { get; set; }

        private async Task UploadFiles(IBrowserFile file)
        {

            fileNames.Add(file.Name);


            if (file is null)
                return;

            if (file.Size > MaxImageUploadSize)
            {
                Snackbar.Configuration.PositionClass = Defaults.Classes.Position.TopCenter;
                Snackbar.Add($"please don't exceed {MaxImageUploadSize / 1000000} MB", Severity.Error);
                return;
            }

            _formModel.ImageFile = await file.RequestImageFileAsync("image/jpeg", 400, 400);
            if (_formModel.ImageFile is null)
                return;

            await using var imageStream = _formModel.ImageFile.OpenReadStream();
            _formModel.ImageFileData = new byte[_formModel.ImageFile.Size];
            await imageStream.ReadAsync(_formModel.ImageFileData);

            _formModel.PreviewUrl = $"data:image/jpeg;base64,{Convert.ToBase64String(_formModel.ImageFileData)}";

            // Create a unique folder name based on current date and time
            var folderName = _promise.Promiseno;


            // Create the folder inside the wwwroot/Uploads directory
            var folderPath = Path.Combine("UploadsSlip", folderName);


            var folderDirectory = Path.Combine(_env.WebRootPath, folderPath);
            if (!Directory.Exists(folderDirectory))
            {
                Directory.CreateDirectory(folderDirectory);
            }

            folderName = folderName + '_' + _promise.Customer + ReceiptNo;
            // Generate a unique file name for the uploaded image
            var fileName = $"{folderName}{Path.GetExtension(file.Name)}";

            // Combine the folder path and file name to get the full path of the image
            var file_Path = Path.Combine(folderDirectory, fileName);

            using (var stream = new FileStream(file_Path, FileMode.Create))
            {
                await file.OpenReadStream().CopyToAsync(stream);
            }

            int index = file_Path.IndexOf("wwwroot");

            if (index != -1)
            {
                // Split the string based on the search text
                string[] parts = file_Path.Split(new[] { "wwwroot" }, StringSplitOptions.None);

                filePath = parts[1];
                // PromiseInfo.UploadImg = parts[1];
            }


            // Save the uploaded image to the specified path

            StateHasChanged();
        }

        #endregion

        //แก้ไขค่าปรับชำระ หน้ายอดปิดทั้งหมด
        private void ValueChanged(ChangeEventArgs args)
        {
            var amount = args.Value.ToString();
            if (amount == "")
            {
                amount = "0";
            }
            totalFee = Convert.ToDecimal(amount);

            if (totalFee == 0)
            {
                p.total_deptAmount = p.base_temp_deptAmount.ToString("N0");

                p.p_origin_fine = _Periodtrans.Where(s => s.ck_paid == false).Sum(p => p.total_fee).ToString("N0");
                p.p_total_deptAmount = (Convert.ToInt32(p.p_origin_fine) + p.base_temp_total_deptAmount).ToString("N0");
            }
            else
            {

                var total = Convert.ToInt32(p.base_temp_deptAmount);
                p.total_deptAmount = (total + totalFee).ToString("N0");
                p.p_total_deptAmount = ((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount).ToString("N0");
                var p_totalDeptAmount = Convert.ToDecimal(p.p_total_deptAmount);
                p.p_custom_fine = totalFee.ToString("N0");
                p.p_total_deptAmount = (Convert.ToInt32(p_totalDeptAmount) + totalFee).ToString("N0");
            }


        }

        //แก้ไขค่าปรับการชำระ
        private void CalculateStandardDimensions(ChangeEventArgs args)
        {
            var amount = args.Value.ToString();
            if (amount == "")
            {
                amount = "0";
            }
            totalFee = Convert.ToDecimal(amount);

            if (totalFee == 0)
            {

                p.total_deptAmount = (_Periodtrans.Where(s => s.check_overpay == true).Sum(p => p.amount_remain) + Convert.ToInt32(p.origin_fine)).ToString("N0");
                var pendingAmount = ((Convert.ToDecimal(p.total_deptAmount) - Convert.ToDecimal(p.total_deposit)));
                p.pending_amount = pendingAmount.ToString("N0");
            }
            else
            {
                if (p.overpay_qty > 0)
                {
                    var total = (_Periodtrans.Where(s => s.check_overpay == true).Sum(p => p.amount_remain));

                    p.total_deptAmount = (total + totalFee).ToString("N0");
                    p.custom_fine = totalFee.ToString("N0");
                    var pendingAmount = ((Convert.ToDecimal(p.total_deptAmount) - Convert.ToDecimal(p.total_deposit)));
                    p.pending_amount = pendingAmount.ToString("N0");
                }
                else
                {
                    p.total_deptAmount = "0";
                    p.pending_amount = "0";
                }

            }


        }



        //เพิ่มดอกเบี้ย
        private void AdjustIntPlusChanged(ChangeEventArgs args)
        {

            if (discount == 0)
            {
                ck_discount = true;
                var amount = args.Value.ToString();
                if (amount == "")
                {
                    amount = "0";
                }
                intplus = Convert.ToDecimal(amount);

                if (intplus == 0)
                {
                    ck_intplus = false;
                    ck_discount = false;
                    if (totalFee != 0)
                    {
                        p.p_total_deptAmount = (((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + totalFee) - Convert.ToDecimal(p.p_total_deposit)).ToString("N0");
                    }
                    else
                    {
                        p.p_total_deptAmount = ((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + Convert.ToDecimal(p.p_origin_fine) - Convert.ToDecimal(p.p_total_deposit)).ToString("N0");
                        p.base_temp_total_deptAmount = ((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + Convert.ToDecimal(p.p_origin_fine));
                    }

                }
                else
                {
                    if (totalFee != 0)
                    {
                        p.p_total_deptAmount = (((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + totalFee) - Convert.ToDecimal(p.p_total_deposit)).ToString("N0");
                    }
                    else
                    {
                        p.p_total_deptAmount = ((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + Convert.ToDecimal(p.p_origin_fine) - Convert.ToDecimal(p.p_total_deposit)).ToString("N0");
                        p.base_temp_total_deptAmount = ((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + Convert.ToDecimal(p.p_origin_fine));
                    }
                    var total_deptAmount_intplus = (Convert.ToDecimal(p.p_total_deptAmount) + (decimal)intplus);
                    p.p_total_deptAmount = total_deptAmount_intplus.ToString("N0");
                }

            }
            else
            {
                intplus = 0;
                Snackbar.Configuration.PositionClass = Defaults.Classes.Position.TopCenter;
                Snackbar.Add("กรุณาลบข้อมูลส่วนลด", Severity.Error);
                StateHasChanged();
            }

        }

        private async Task AdjustIntPlus()
        {
            if (intplus == null)
            {
                intplus = 0;
                Snackbar.Configuration.PositionClass = Defaults.Classes.Position.TopCenter;
                Snackbar.Add("กรุณาใส่ตัวเลขที่ต้องการ", Severity.Error);
            }
            else
            {
                if (intplus == 0)
                {

                    if (totalFee != 0)
                    {
                        p.p_total_deptAmount = (((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + totalFee) - Convert.ToDecimal(p.p_total_deposit)).ToString("N0");
                    }
                    else
                    {
                        p.p_total_deptAmount = ((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + Convert.ToDecimal(p.p_origin_fine) - Convert.ToDecimal(p.p_total_deposit)).ToString("N0");
                        p.base_temp_total_deptAmount = ((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + Convert.ToDecimal(p.p_origin_fine));
                    }

                }
                else
                {
                    var total_deptAmount_intplus = (Convert.ToDecimal(p.p_total_deptAmount) + (decimal)intplus);
                    p.p_total_deptAmount = total_deptAmount_intplus.ToString("N0");
                }
            }


        }
        //ลดดอกเบี้ย
        private void AdjustDiscountChanged(ChangeEventArgs args)
        {

            if (intplus == 0)
            {
                ck_intplus = true;
                var amount = args.Value.ToString();
                if (amount == "")
                {
                    amount = "0";
                }
                discount = Convert.ToDecimal(amount);

                if (discount == 0)
                {
                    ck_discount = false;
                    ck_intplus = false;
                    if (totalFee != 0)
                    {
                        p.p_total_deptAmount = (((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + totalFee) - Convert.ToDecimal(p.p_total_deposit)).ToString("N0");
                    }
                    else
                    {
                        p.p_total_deptAmount = ((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + Convert.ToDecimal(p.p_origin_fine) - Convert.ToDecimal(p.p_total_deposit)).ToString("N0");
                        p.base_temp_total_deptAmount = ((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + Convert.ToDecimal(p.p_origin_fine));
                    }

                }
                else
                {
                    if (discount > p.p_paidinterestAmount)
                    {
                        Snackbar.Configuration.PositionClass = Defaults.Classes.Position.TopCenter;
                        Snackbar.Add("ไม่สามารถปรับลดดอกเบี้ย เนื่องจากจำนวนเกินดอกเบี้ยที่ลดได้", Severity.Error);
                    }
                    else
                    {
                        if (totalFee != 0)
                        {
                            p.p_total_deptAmount = (((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + totalFee) - Convert.ToDecimal(p.p_total_deposit)).ToString("N0");
                        }
                        else
                        {
                            p.p_total_deptAmount = ((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + Convert.ToDecimal(p.p_origin_fine) - Convert.ToDecimal(p.p_total_deposit)).ToString("N0");
                            p.base_temp_total_deptAmount = ((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + Convert.ToDecimal(p.p_origin_fine));
                        }
                        var total_deptAmount_discount = (Convert.ToDecimal(p.p_total_deptAmount) - (decimal)discount);
                        p.p_total_deptAmount = total_deptAmount_discount.ToString("N0");
                        //var discount_total = (_promise_pay.pending_amount * -1) - (decimal)discount;
                        //_promise_pay.pending_amount = discount_total * -1;
                    }


                }
            }
            else
            {
                discount = 0;
                Snackbar.Configuration.PositionClass = Defaults.Classes.Position.TopCenter;
                Snackbar.Add("กรุณาลบข้อมูลเพิ่มดอกเบี้ย", Severity.Error);
                StateHasChanged();
            }



        }
        private async Task AdjustDiscount()
        {
            if (discount == null)
            {
                discount = 0;
                Snackbar.Configuration.PositionClass = Defaults.Classes.Position.TopCenter;
                Snackbar.Add("กรุณาใส่ตัวเลขที่ต้องการ", Severity.Error);
            }
            else
            {
                if (discount == 0)
                {

                    if (totalFee != 0)
                    {
                        p.p_total_deptAmount = (((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + totalFee) - Convert.ToDecimal(p.p_total_deposit)).ToString("N0");
                    }
                    else
                    {
                        p.p_total_deptAmount = ((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + Convert.ToDecimal(p.p_origin_fine) - Convert.ToDecimal(p.p_total_deposit)).ToString("N0");
                        p.base_temp_total_deptAmount = ((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + Convert.ToDecimal(p.p_origin_fine));
                    }

                }
                else
                {
                    if (discount > p.p_paidinterestAmount)
                    {
                        Snackbar.Configuration.PositionClass = Defaults.Classes.Position.TopCenter;
                        Snackbar.Add("ไม่สามารถปรับลดดอกเบี้ย เนื่องจากจำนวนเกินดอกเบี้ยที่ลดได้", Severity.Error);
                    }
                    else
                    {

                        var total_deptAmount_discount = (Convert.ToDecimal(p.p_total_deptAmount) - (decimal)discount);
                        p.p_total_deptAmount = total_deptAmount_discount.ToString("N0");
                        //var discount_total = (_promise_pay.pending_amount * -1) - (decimal)discount;
                        //_promise_pay.pending_amount = discount_total * -1;
                    }


                }
            }


        }
        private decimal Amount = 0m;
        private void OnInputChanged(ChangeEventArgs e)
        {
            string inputValue = e.Value.ToString().Replace(",", ""); // Remove existing commas
            if (decimal.TryParse(inputValue, out decimal result))
            {
                Amount = result;
                p.customerPayAmount = Amount.ToString("N0"); // Format with commas
            }
            else
            {
                // If parsing fails, keep the original input
                p.customerPayAmount = inputValue;
            }
        }
        void SetTab(int index)
        {
            activeIndex = index;

            if (activeIndex == 0)
            {
                paidprincipleAmount = 0;
                paidinterestAmount = 0;


                p.overpay_qty = _Periodtrans.Where(s => s.check_overpay == true).Where(s => s.OverPayQty > 0).Count();
                p.total_deposit = _Periodtrans.Where(s => s.ck_paid == false).Sum(p => p.Deposit).Value.ToString("N0");
                p.origin_fine = _Periodtrans.Where(s => s.check_overpay == true).Sum(p => p.total_fee).ToString("N0");
                //  p.total_Charge_follow = _Periodtrans.Sum(p => p.total_charge_follow).ToString("N0");
                p.total_Charge_follow = _Periodtrans.FirstOrDefault().total_charge_follow.ToString("N0");
                if (p.overpay_qty > 0)
                {
                    //p.Minimumfine = _periodtran.Where(s => s.check_overpay == true).Where(s => s.OverPayQty > 0).FirstOrDefault().total_fee;
                    p.Minimumpayment = (decimal)_Periodtrans.Where(s => s.check_overpay == true).Where(s => s.OverPayQty > 0).FirstOrDefault().Amount;
                    p.base_temp_total_deptAmount = (_Periodtrans.Where(s => s.check_overpay == true).Sum(p => p.amount_remain) + Convert.ToDecimal(p.origin_fine) + Convert.ToDecimal(p.total_Charge_follow));
                    p.total_deptAmount = (_Periodtrans.Where(s => s.check_overpay == true).Sum(p => p.amount_remain) + Convert.ToDecimal(p.origin_fine) + Convert.ToDecimal(p.total_Charge_follow)).ToString("N0");
                    p.pending_amount = (((_promise_pay.total_deptAmount - _promise_pay.total_deposit) + _promise_pay.total_fee) + _promise_pay.total_charge_follow).ToString("N0");
                }
                else
                {
                    p.total_deptAmount = "0";
                    p.pending_amount = "0";
                }
            }
            else if (activeIndex == 1)
            {
                payment_method = 1;
                p.p_overpay_qty = _Periodtrans.Where(s => s.ck_paid == false).Count();

                p.p_total_deposit = _Periodtrans.Where(s => s.ck_paid == false).Sum(p => p.Deposit).Value.ToString("N0");

                p.p_custom_fine = _Periodtrans.Where(s => s.ck_paid == false).Sum(p => p.total_fee).ToString("N0");
                p.p_total_Charge_follow = _Periodtrans.Where(s => s.ck_paid == false).FirstOrDefault().total_charge_follow.ToString("N0");
                p.p_origin_fine = _Periodtrans.Where(s => s.ck_paid == false).Sum(p => p.total_fee).ToString("N0");
                p.p_paidfineAmount = (Convert.ToDecimal(p.p_origin_fine) + Convert.ToDecimal(p.p_total_Charge_follow)).ToString("N0");


                p.p_total_deptAmount = _Periodtrans.Where(s => s.ck_paid == false).Sum(p => (decimal)p.Amount).ToString("N0");
                p.base_temp_total_deptAmount = _Periodtrans.Where(s => s.ck_paid == false).Sum(p => (decimal)p.Amount);
                p.p_pending_amount = (_promise_pay.total_deptAmount - _promise_pay.total_deposit + Convert.ToDecimal(p.p_origin_fine) + Convert.ToInt32(p.p_total_Charge_follow)) * -1;

                var p_type = _Periodtrans.Select(s => s.Ptype).FirstOrDefault();
                if (p_type == 1)
                {
                    p.p_paidprincipleAmount = _Periodtrans.Where(s => s.ck_paid == false).Sum(p => (decimal)p.Capital);
                    var remain_amount = _Periodtrans.Where(s => s.ck_paid == false).Sum(p => (decimal)p.Intpaid);
                    //p.p_paidinterestAmount = _Periodtrans.Where(s => s.ck_paid == false).Sum(p => (decimal)p.Interest) - remain_amount;
                    p.p_paidinterestAmount = _Periodtrans.Where(s => s.ck_paid == false).Sum(p => (decimal)p.Interest) - remain_amount;
                    var ckoverpay = _Periodtrans.Where(s => s.ck_paid == false && s.check_overpay == true).Sum(p => (decimal)p.Interest);
                    if (ckoverpay != 0)
                    {
                        p.p_paidinterestAmountDiscount = (p.p_paidinterestAmount - ckoverpay) + Convert.ToDecimal(p.p_total_Charge_follow);
                    }
                    else
                    {
                        p.p_paidinterestAmountDiscount = p.p_paidinterestAmount + +Convert.ToDecimal(p.p_total_Charge_follow);
                    }


                    if (totalFee != 0)
                    {
                        p.p_total_deptAmount = ((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + totalFee + Convert.ToDecimal(p.p_total_Charge_follow) - Convert.ToDecimal(p.p_total_deposit)).ToString("N0");
                    }
                    else
                    {
                        p.p_total_deptAmount = ((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + Convert.ToDecimal(p.p_origin_fine) - Convert.ToDecimal(p.p_total_deposit)).ToString("N0");
                        p.base_temp_total_deptAmount = ((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + Convert.ToDecimal(p.p_origin_fine));
                    }
                }
                else
                {
                    p.p_paidprincipleAmount = (decimal)_Periodtrans.LastOrDefault().Capital;

                    p.p_paidinterestAmount = (decimal)_Periodtrans.Where(s => s.ck_paid == false).Sum(s => s.Interest);
                    var ckoverpay = _Periodtrans.Where(s => s.ck_paid == false && s.check_overpay == true).Sum(p => (decimal)p.Interest);
                    if (ckoverpay != 0)
                    {
                        p.p_paidinterestAmountDiscount = p.p_paidinterestAmount - ckoverpay;
                    }
                    else
                    {
                        p.p_paidinterestAmountDiscount = p.p_paidinterestAmount;
                    }

                    if (totalFee != 0)
                    {
                        p.p_total_deptAmount = (((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + totalFee - Convert.ToDecimal(p.p_total_deposit))).ToString("N0");
                    }
                    else
                    {
                        p.p_total_deptAmount = ((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + Convert.ToDecimal(p.p_origin_fine) - Convert.ToDecimal(p.p_total_deposit)).ToString("N0");
                        p.base_temp_total_deptAmount = ((decimal)_Periodtrans.LastOrDefault().Amount + Convert.ToDecimal(p.p_origin_fine));
                    }
                }


            }
            StateHasChanged();
        }
    }
}
