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
    public partial class PaymentList_NV
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
        private string role { get; set; } = "employee";

        private Models.SingSiamOld.Promise _promises { get; set; }

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

        private payment p = new payment();
        SingsiamdbContext db = new SingsiamdbContext();
        Models.SingSiamOld._01singsiamContext _01SingsiamContextdb = new Models.SingSiamOld._01singsiamContext();

        private Models.Customer customer_data = new Models.Customer();
        private Models.SingSiamOld.Promise _promise = new Models.SingSiamOld.Promise();
        private List<Models.SingSiamOld.Periodtran> _Periodtrans = new List<Models.SingSiamOld.Periodtran>();

        private Models.SingSiamOld.Periodtran _promise_pay = new Models.SingSiamOld.Periodtran();

        protected override async void OnInitialized()
        {
            var uri = navigationManager.ToAbsoluteUri(navigationManager.Uri);
            var query = System.Web.HttpUtility.ParseQueryString(uri.Query);
            promiseno = query["promiseno"];
            promiseno = promiseno.Replace('_', '#').ToString();
            customer_data = await managements.GetCustomerbyId(cus_id);
            _promise = await managements.GetPromiseDetailNVbyPermiseNo(promiseno);
            _Periodtrans = await managements.GetPeriodtransbyPromise_NV(promiseno);

            p = new payment();
            var receipt = await managements.Get_Receipt_No_NV(branch_code, "receipt");
            p.receipt_no = receipt.ToString();
            p.overpay_qty = _Periodtrans.Where(s => s.OverPayQty > 0).Count();

            p.total_deposit = _Periodtrans.Where(s => s.ck_paid == false).Sum(p => p.Deposit).Value.ToString("N0");
            p.origin_fine = _Periodtrans.Sum(p => p.total_fee).ToString("N0");
            p.custom_fine = _Periodtrans.Sum(p => p.total_fee).ToString("N0");
            totalFee = Convert.ToDecimal(p.origin_fine);
            //p.Minimumfine = _periodtran.Where(s => s.check_overpay == true).Where(s => s.OverPayQty > 0).FirstOrDefault().total_fee;
            try
            {

                p.Minimumpayment = (decimal)_Periodtrans.FirstOrDefault().Amount - (decimal)_Periodtrans.FirstOrDefault().Paidamount;

            }
            catch (Exception ex)
            {

            }


            p.total_Charge_follow = _Periodtrans.Where(s=>s.ck_paid == false).FirstOrDefault().total_charge_follow.ToString("N0");

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
                        p.p_paidinterestAmountDiscount = (p.p_paidinterestAmount - ckoverpay ) + Convert.ToDecimal(p.p_total_Charge_follow);
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
