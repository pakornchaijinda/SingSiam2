using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.JSInterop;
using MudBlazor;
using SingSiamOffice.Manage;
using SingSiamOffice.Models;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace SingSiamOffice.Pages.CustomerManagement.Payment
{
    public partial class PaymentList
    {
        [Inject]
        IWebHostEnvironment _env { get; set; }
        [Inject]
        NavigationManager navigationManager { get; set; }
        [Inject]
        IJSRuntime JSRuntime { get; set; }
        [Parameter]
        public int branch_id { get; set; }
        [Parameter]
        public int c_id { get; set; }
        [Parameter]
        public int promise_id { get; set; }
        [Inject]
        Manage.Managements managements { get; set; }

        [Inject]
        Manage.GlobalData globalData { get; set; }
        [Inject]
        Manage.PromiseManagement promiseManagement { get; set; }
        public bool paid_status { get; set; } = true;


      

        //payment method
        //1 เงินสด 2 เงินโอน 3 อื่นๆ 
        // 2,3 มีหลักฐานการชำระ

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
        public string filePath;
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

            folderName = folderName + '_' + _promise.Customer.NatId + ReceiptNo;
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


        public string type_d = "D";
        public string type_p = "P";
        public int payment_method { get; set; } = 1;

        private string role { get; set; } = "employee";
        public bool pay_check { get; set; }

        public decimal deposotamount { get; set; }

        bool _expanded = true;
        private decimal totalFee { get; set; }
        private decimal totalFee_Old { get; set; }
        private void OnExpandCollapseClick()
        {
            _expanded = !_expanded;
        }
        private int? current_periods { get; set; }
        private List<Receiptdesc> lst_receiptdescs = new List<Receiptdesc>();
        private Receiptdesc _receiptdesc_toAdd { get; set; }
        private List<Periodtran> _periodtran = new List<Periodtran>();
        private Promise _promise = new Promise();
        private Periodtran _promise_pay = new Periodtran();

        private payment p = new payment();
        private decimal? intplus { get; set; } = 0;
        private decimal? discount { get; set; } = 0;
        public string pending_totalpayment { get; set; }   
        
        //ยอดที่ต้องชำระ
        public string? total_deptAmount { get; set; }
        //ยอดรับฝากเงิน
        public string? total_deposit { get; set; }




        private string ReceiptNo { get; set; } = "";
        int activeIndex = 0;
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                
                await JSRuntime.InvokeVoidAsync("sideBar");
            }
        }
        protected override async void OnInitialized()
        {
            p = new payment();  
            _periodtran =await managements.GetPeriodtransbyPromiseId(promise_id);
            _promise = await managements.GetPromisebyPromiseId(promise_id);
         
            p.overpay_qty = _periodtran.Where(s=>s.OverPayQty > 0).Count();
          
            p.total_deposit = _periodtran.Sum(p => p.Deposit).Value.ToString("N0");
            p.origin_fine = _periodtran.Sum(p => p.total_fee).ToString("N0");
            p.custom_fine = _periodtran.Sum(p => p.total_fee).ToString("N0");
            totalFee = Convert.ToDecimal(p.origin_fine);
           p.total_Charge_follow = _periodtran.Sum(p => p.total_charge_follow).ToString("N0");

            if (p.overpay_qty > 0)
            {
                p.base_temp_deptAmount = _periodtran.Where(s=>s.check_overpay == true).Sum(p => p.amount_remain);
                var total = (_periodtran.Where(s => s.check_overpay == true).Sum(p => p.amount_remain) + Convert.ToDecimal(p.origin_fine));
                p.total_deptAmount = total.ToString("N0");
                p.pending_payAmont =(( _promise_pay.total_deptAmount - _promise_pay.total_deposit)  + _promise_pay.total_charge_follow).ToString("N0");
            }
            else 
            {
                p.total_deptAmount = "0";
                p.pending_payAmont = "0";
            } 
     
            var receipt = await managements.Get_Receipt_No(branch_id, "receipt");
            p.receipt_no = receipt.ToString();
        }
        private decimal Amount = 0m;

        // แปลงค่ายอดที่ต้องชำระ
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

                p.overpay_qty = _periodtran.Where(s => s.check_overpay == true).Where(s => s.OverPayQty > 0).Count();
                p.total_deposit = _periodtran.Where(s => s.check_overpay == true).Sum(p => p.total_deposit).ToString("N0");
                p.origin_fine = _periodtran.Where(s => s.check_overpay == true).Sum(p => p.total_fee).ToString("N0");
                p.total_Charge_follow = _periodtran.Sum(p => p.total_charge_follow).ToString("N0");

                if (p.overpay_qty > 0)
                {
                    p.base_temp_total_deptAmount = (_periodtran.Where(s => s.check_overpay == true).Sum(p => p.amount_remain) + Convert.ToDecimal(p.origin_fine) + Convert.ToDecimal(p.total_Charge_follow));
                    p.total_deptAmount = (_periodtran.Where(s => s.check_overpay == true).Sum(p => p.amount_remain) + Convert.ToDecimal(p.origin_fine) + Convert.ToDecimal(p.total_Charge_follow)).ToString("N0");
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
                p.p_overpay_qty = _periodtran.Where(s => s.Ispaid == false).Count();

                p.p_total_deposit = _periodtran.Where(s => s.Ispaid == false).Sum(p => p.total_deposit).ToString("N0");
                p.p_origin_fine = _periodtran.Where(s => s.Ispaid == false).Sum(p => p.total_fee).ToString("N0");
                p.p_custom_fine = _periodtran.Where(s => s.Ispaid == false).Sum(p => p.total_fee).ToString("N0");
                p.p_total_Charge_follow = _periodtran.Where(s => s.Ispaid == false).Sum(p => p.total_charge_follow).ToString("N0");
                p.p_paidfineAmount = (Convert.ToDecimal(p.p_origin_fine) + Convert.ToDecimal(p.p_total_Charge_follow)).ToString("N0");


                p.p_total_deptAmount = _periodtran.Where(s => s.Ispaid == false).Sum(p => (decimal)p.Amount).ToString("N0");
                p.base_temp_total_deptAmount = _periodtran.Where(s => s.Ispaid == false).Sum(p => (decimal)p.Amount);
                p.p_pending_amount = (_promise_pay.total_deptAmount - _promise_pay.total_deposit + Convert.ToDecimal(p.p_origin_fine) + Convert.ToInt32(p.p_total_Charge_follow)) * -1;

                p.p_paidprincipleAmount = _periodtran.Where(s => s.Ispaid == false).Sum(p => (decimal)p.Capital);
                var remain_amount = _periodtran.Where(s => s.Ispaid == false).Sum(p => (decimal)p.Paidremain) * -1;
                p.p_paidinterestAmount = _periodtran.Where(s => s.Ispaid == false).Sum(p => (decimal)p.Interest) - remain_amount;

                if (totalFee != 0)
                {
                    p.p_total_deptAmount = ((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + totalFee).ToString("N0");
                }
                else 
                {
                    p.p_total_deptAmount = ((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + Convert.ToDecimal(p.p_origin_fine)).ToString("N0");
                    p.base_temp_total_deptAmount = ((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + Convert.ToDecimal(p.p_origin_fine));
                }
            
            }
            StateHasChanged();
        }

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

                p.p_origin_fine = _periodtran.Where(s => s.Ispaid == false).Sum(p => p.total_fee).ToString("N0");
                p.p_total_deptAmount = (Convert.ToInt32(p.p_origin_fine) + p.base_temp_total_deptAmount).ToString("N0");
            }
            else
            {
             
                var total =Convert.ToInt32(p.base_temp_deptAmount);
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

                p.total_deptAmount = (_periodtran.Where(s => s.check_overpay == true).Sum(p => p.amount_remain) + Convert.ToInt32(p.origin_fine)).ToString("N0");
                var pendingAmount = ((Convert.ToDecimal(p.total_deptAmount) - Convert.ToDecimal(p.total_deposit)));
                p.pending_amount = pendingAmount.ToString("N0");
            }
            else
            {
                if (p.overpay_qty > 0)
                {
                    var total = (_periodtran.Where(s => s.check_overpay == true).Sum(p => p.amount_remain));

                    p.total_deptAmount = (total+ totalFee).ToString("N0");
                    p.custom_fine = totalFee.ToString("N0");
                    var pendingAmount  = ((Convert.ToDecimal(p.total_deptAmount) - Convert.ToDecimal(p.total_deposit)));
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
                   // p.p_total_deptAmount = p.base_temp_total_deptAmount.ToString("N0") ;
                    if (totalFee != 0)
                    {
                        p.p_total_deptAmount = ((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + totalFee).ToString("N0");
                    }
                    else
                    {
                        p.p_total_deptAmount = ((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + Convert.ToDecimal(p.p_origin_fine)).ToString("N0");
                        p.base_temp_total_deptAmount = ((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + Convert.ToDecimal(p.p_origin_fine));
                    }
                    //p.p_total_deptAmount = _periodtran.Where(s => s.Ispaid == false).Sum(p => (decimal)p.Amount).ToString("N0");
                    //p.p_pending_amount = (_promise_pay.total_deptAmount - _promise_pay.total_deposit + _promise_pay.total_fee + _promise_pay.total_charge_follow) * -1;
                    //p.pending_totalpayment = (_promise_pay.pending_amount * -1).ToString();
                }
                else
                {
                    var total_deptAmount_intplus = (Convert.ToDecimal(p.p_total_deptAmount) + (decimal)intplus);
                    p.p_total_deptAmount = total_deptAmount_intplus.ToString("N0");
                }
            }


        }
        //ลดดอกเบี้ย
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
                    //p.p_total_deptAmount = p.base_temp_total_deptAmount.ToString("N0");
                    if (totalFee != 0)
                    {
                        p.p_total_deptAmount = ((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + totalFee).ToString("N0");
                    }
                    else
                    {
                        p.p_total_deptAmount = ((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + Convert.ToDecimal(p.p_origin_fine)).ToString("N0");
                        p.base_temp_total_deptAmount = ((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + Convert.ToDecimal(p.p_origin_fine));
                    }
                    //p.p_pending_amount = (_promise_pay.total_deptAmount - _promise_pay.total_deposit + _promise_pay.total_fee + _promise_pay.total_charge_follow) * -1;
                    //pending_totalpayment = (_promise_pay.pending_amount * -1).ToString();
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

        private async Task delete()
        {
            var confirm = await JSRuntime.InvokeAsync<bool>("confirmdelete");
            if (confirm)
            {
                await JSRuntime.InvokeVoidAsync("deletesuccess");
                await Task.Delay(100);

                navigationManager.NavigateTo("/paymentlist");

            }
            else
            {
                //await JSRuntime.InvokeVoidAsync("delete_error");
            }
        }

        //บันทึกการชำระ
        private async Task submitpaymentlist()
        {

            if (p.customerPayAmount != null)
            {
                var confirm = await JSRuntime.InvokeAsync<bool>("confirmPayment");
                if (confirm)
                {

                    if (payment_method == 4)
                    {
                        decimal cal_period_pay = ((decimal)customerPayAmount - _promise_pay.total_fee) / (decimal)_promise.Amount;
                        var period_pay_qty = (int)Math.Ceiling(cal_period_pay);
                        int remainingInstallments = (int)_periodtran.Where(s => s.Ispaid == false).Count() - (int)Math.Floor(cal_period_pay);

                        Receipttran _receipttran_toAdd = new Receipttran();

                        _receipttran_toAdd.PromiseId = _promise.Id;
                        _receipttran_toAdd.BranchId = _promise.BranchId;
                        _receipttran_toAdd.CustomerId = _promise.CustomerId;
                        _receipttran_toAdd.Receiptno = ReceiptNo;
                        _receipttran_toAdd.Amount = (decimal)customerPayAmount;
                        _receipttran_toAdd.Receiptdesc = "รับฝากเงินล่วงหน้า";

                        _receipttran_toAdd.Tdate = DateTime.Now.AddYears(543).ToString("dd/MM/yyyy");
                        _receipttran_toAdd.Tdateformat = DateTime.Now.ToString("yyyyMMdd");
                        _receipttran_toAdd.Tdatecal = DateTime.Now.AddYears(543).ToString("dd/MM/yyyy");
                        _receipttran_toAdd.Tdatecalformat = DateTime.Now.ToString("yyyyMMdd");
                        _receipttran_toAdd.peroidtrans_info = _periodtran.Where(s => s.Ispaid == false).Take(period_pay_qty).ToList();

                        current_periods = await managements.GetCurrentPeriod(promise_id);
                        _receipttran_toAdd.Periodchg = current_periods;
                        _receipttran_toAdd.Periodremain = _promise.Periods - 1;
                        _receipttran_toAdd.Usercode = globalData.fullname;
                        _receipttran_toAdd.Otherpaid = 1;
                        _receipttran_toAdd.PaidBy = 4;
                        _receipttran_toAdd.Currentperiod = _periodtran.Where(s => s.Ispaid == false).Select(s => s.Period).FirstOrDefault();
                        //  _receipttran_toAdd.RemainingPrincipal = ((decimal)customerPayAmount - totalFee) - _promise.Amount;


                        await promiseManagement.addReceipttran(_receipttran_toAdd);
                        //เพิ้ม expent income
                            
                        //TransactionHistory history = new TransactionHistory();
                        //history.SubjectId = 3;
                        //history.BranchId = branch_id;
                        //history.PaymentMethod = payment_method;
                        //history.Detial = "ได้รับชำระค่างวด งวดที่:" + 


                        //ยอดที่ชำระ
                        globalData.paymentAmount = (decimal)_receipttran_toAdd.Amount;

                        for (int i = 0; i < period_pay_qty; i++)
                        {
                            Receiptdesc _receiptdesc_toAdd = new Receiptdesc();
                            _receiptdesc_toAdd.PromiseId = _promise.Id;
                            _receiptdesc_toAdd.BranchId = _promise.BranchId;
                            _receiptdesc_toAdd.CustomerId = _promise.CustomerId;
                            _receiptdesc_toAdd.Receiptno = ReceiptNo;
                            _receiptdesc_toAdd.ReceipttranId = _receipttran_toAdd.Id;
                            _receiptdesc_toAdd.PeriodtranId = _receipttran_toAdd.peroidtrans_info[i].Id;
                            _receiptdesc_toAdd.Tdate = DateTime.Now.AddYears(543).ToString("dd/MM/yyyy");
                            _receiptdesc_toAdd.Tdateformat = DateTime.Now.ToString("yyyyMMdd");
                            _receiptdesc_toAdd.Tdatecal = DateTime.Now.AddYears(543).ToString("dd/MM/yyyy");
                            _receiptdesc_toAdd.Tdatecalformat = DateTime.Now.ToString("yyyyMMdd");

                            _receiptdesc_toAdd.Period = _receipttran_toAdd.peroidtrans_info[i].Period;
                            _receiptdesc_toAdd.Perioddate = _receipttran_toAdd.peroidtrans_info[i].Tdateformat;
                            _receipttran_toAdd.Charge1amt = _receipttran_toAdd.Charge1amt;
                            _receipttran_toAdd.Charge2amt = _receipttran_toAdd.Charge2amt;

                            decimal totalDue = (decimal)_receipttran_toAdd.peroidtrans_info[i].Capital + (decimal)_receipttran_toAdd.peroidtrans_info[i].Interest;

                            while (globalData.paymentAmount > 0)
                            {
                                if (payment_method != 4)
                                {
                                    if (globalData.paymentAmount >= totalDue)
                                    {
                                        _receiptdesc_toAdd.Cappaid = _receipttran_toAdd.peroidtrans_info[i].Capital * -1;
                                        _receiptdesc_toAdd.Intpaid = _receipttran_toAdd.peroidtrans_info[i].Interest * -1;
                                        var total = _receiptdesc_toAdd.Cappaid + _receiptdesc_toAdd.Intpaid;
                                        _receiptdesc_toAdd.Amount = total;
                                        globalData.RemainingPaid = globalData.paymentAmount - (decimal)_receiptdesc_toAdd.Amount;
                                        globalData.paymentAmount -= totalDue;
                                        break;
                                    }
                                    else
                                    {
                                        _receiptdesc_toAdd.pending_amount = globalData.RemainingPaid;
                                        if (_receiptdesc_toAdd.pending_amount >= _receipttran_toAdd.peroidtrans_info[i].Interest)
                                        {
                                            var amount_over_int = _receiptdesc_toAdd.pending_amount - _receipttran_toAdd.peroidtrans_info[i].Interest;
                                            _receiptdesc_toAdd.Intpaid = _receipttran_toAdd.peroidtrans_info[i].Interest * -1;
                                            _receiptdesc_toAdd.Cappaid = (_receipttran_toAdd.peroidtrans_info[i].Capital - amount_over_int) * -1;
                                            var total = _receiptdesc_toAdd.Cappaid + _receiptdesc_toAdd.Intpaid;
                                            _receiptdesc_toAdd.Amount = total * -1;
                                            globalData.RemainingPaid -= _receiptdesc_toAdd.pending_amount;
                                            break;
                                        }
                                        else
                                        {
                                            _receiptdesc_toAdd.Intpaid = _receiptdesc_toAdd.pending_amount * -1;
                                            _receiptdesc_toAdd.Amount = _receiptdesc_toAdd.pending_amount * -1;
                                            globalData.paymentAmount -= _receiptdesc_toAdd.pending_amount;
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    _receiptdesc_toAdd.Deposit = (decimal)_receipttran_toAdd.Amount;
                                    _receiptdesc_toAdd.Periodchg = current_periods;
                                    _receiptdesc_toAdd.payment_method = 4;
                                    break;
                                }

                            }

                            //  _receiptdesc_toAdd.pending_amount = globalData.RemainingPaid;
                            _receiptdesc_toAdd.Usercode = globalData.username;
                            _receiptdesc_toAdd.Chargeamt = _promise_pay.total_fee;

                            lst_receiptdescs.Add(_receiptdesc_toAdd);

                        }

                        await promiseManagement.addReceipdesc(lst_receiptdescs);

                        await JSRuntime.InvokeVoidAsync("paymentsuccess");
                        await Task.Delay(100);

                        //    navigationManager.NavigateTo($"/paymentlist/{branch_id}/{c_id}/{promise_id}");
                        navigationManager.NavigateTo($"/paymentlist/{branch_id}/{c_id}/{promise_id}", forceLoad: true);
                    }
                    else 
                    {
                        if (activeIndex == 0)
                        {
                            if (Convert.ToDecimal(p.customerPayAmount) >= Convert.ToDecimal(p.total_deptAmount))
                            {

                                decimal cal_period_pay = ((Convert.ToDecimal(p.customerPayAmount) - totalFee) - Convert.ToDecimal(p.total_Charge_follow)) / (decimal)_promise.Amount;
                                var period_pay_qty = (int)Math.Ceiling(cal_period_pay);
                                int remainingInstallments = (int)_periodtran.Where(s => s.Ispaid == false).Count() - (int)Math.Floor(cal_period_pay);



                                Receipttran _receipttran_toAdd = new Receipttran();

                                _receipttran_toAdd.PromiseId = _promise.Id;
                                _receipttran_toAdd.BranchId = _promise.BranchId;
                                _receipttran_toAdd.CustomerId = _promise.CustomerId;
                                _receipttran_toAdd.Receiptno = p.receipt_no;
                                _receipttran_toAdd.Intplus = intplus;
                                _receipttran_toAdd.Discount = discount;
                                if (payment_method == 1 || payment_method == 2 || payment_method == 3)
                                {
                                    _receipttran_toAdd.Amount = Convert.ToDecimal(p.customerPayAmount);
                                    _receipttran_toAdd.Receiptdesc = "ชำระค่างวด";
                                }
                                if (payment_method == 4)
                                {
                                    _receipttran_toAdd.Amount = Convert.ToDecimal(p.customerPayAmount);
                                    _receipttran_toAdd.Receiptdesc = "รับฝากเงินล่วงหน้า";
                                }

                                _receipttran_toAdd.Tdate = DateTime.Now.AddYears(543).ToString("dd/MM/yyyy");
                                _receipttran_toAdd.Tdateformat = DateTime.Now.ToString("yyyyMMdd");
                                _receipttran_toAdd.Tdatecal = DateTime.Now.AddYears(543).ToString("dd/MM/yyyy");
                                _receipttran_toAdd.Tdatecalformat = DateTime.Now.ToString("yyyyMMdd");
                                _receipttran_toAdd.peroidtrans_info = _periodtran.Where(s => s.Ispaid == false).Take(period_pay_qty).ToList();

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
                                    var amount_per_month_check_overpay = _periodtran.Where(s => s.Ispaid == false && s.check_overpay == true).Sum(s => s.Amount);
                                    if (amount_per_month_check_overpay != 0)
                                    {
                                        p.Arbalance = amount_per_month_check_overpay;
                                    }
                                    else 
                                    {
                                        p.Arbalance = _periodtran.Where(s => s.Ispaid == false ).Sum(s => s.Amount);
                                    }
                                    _receipttran_toAdd.Arbalance = p.Arbalance + totalFee + Convert.ToDecimal(p.total_Charge_follow);
                                    _receipttran_toAdd.Cappaid = _periodtran.Where(s => s.Ispaid == false && s.check_overpay == true).Sum(s => s.Capital);

                                  //  var calpay_remain = (((Convert.ToDecimal(p.customerPayAmount) - _receipttran_toAdd.Cappaid) - totalFee) - Convert.ToDecimal(p.total_Charge_follow));

                                    _receipttran_toAdd.Intpaid = _periodtran.Where(s => s.Ispaid == false && s.check_overpay == true).Sum(s => s.Interest);
                                    Receipttran? Capremain_before = await managements.GetReceipttran_bypromiseId(promise_id);
                                    if (Capremain_before == null)
                                    {
                                        _receipttran_toAdd.Capremain = _promise.Capital - _receipttran_toAdd.Cappaid;
                                        var sum_interate = _periodtran.Where(s => s.Ispaid == false).Sum(s => s.Interest);
                                        _receipttran_toAdd.Intremain = sum_interate - _receipttran_toAdd.Intpaid;
                                    }
                                    else
                                    {
                                        _receipttran_toAdd.Capremain = Capremain_before.Capremain - _receipttran_toAdd.Cappaid;
                                        var sum_interate = Capremain_before.Intremain;
                                        _receipttran_toAdd.Intremain = sum_interate - _receipttran_toAdd.Intpaid;
                                    }


                                    _receipttran_toAdd.Charge1amt = totalFee;
                                    _receipttran_toAdd.Charge2amt = Convert.ToDecimal(p.total_Charge_follow);
                                    var count_periodtran = _periodtran.Where(s => s.Ispaid == false).Count();
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
                                    current_periods = await managements.GetCurrentPeriod(promise_id);
                                    _receipttran_toAdd.Periodchg = current_periods;
                                    _receipttran_toAdd.Periodremain = _promise.Periods - 1;
                                }




                                _receipttran_toAdd.Usercode = globalData.fullname;

                                if (payment_method == 1)
                                {
                                    _receipttran_toAdd.Cashpaid = 1;
                                    _receipttran_toAdd.PaidBy = 1;
                                }
                                if (payment_method == 2)
                                {
                                    _receipttran_toAdd.Transferdate = "1";
                                    _receipttran_toAdd.PaidBy = 2;
                                }
                                if (payment_method == 3)
                                {
                                    _receipttran_toAdd.Otherpaid = 1;
                                    _receipttran_toAdd.PaidBy = 3;
                                }
                                if (payment_method == 4)
                                {
                                    _receipttran_toAdd.Otherpaid = 1;
                                    _receipttran_toAdd.PaidBy = 4;
                                }

                                _receipttran_toAdd.Currentperiod = _periodtran.Where(s => s.Ispaid == false).Select(s => s.Period).FirstOrDefault();
                                //  _receipttran_toAdd.RemainingPrincipal = ((decimal)customerPayAmount - totalFee) - _promise.Amount;


                                await promiseManagement.addReceipttran(_receipttran_toAdd);


                                //ยอดที่ชำระ
                                globalData.paymentAmount = (decimal)_receipttran_toAdd.Amount;

                                for (int i = 0; i < period_pay_qty; i++)
                                {
                                    Receiptdesc _receiptdesc_toAdd = new Receiptdesc();
                                    _receiptdesc_toAdd.PromiseId = _promise.Id;
                                    _receiptdesc_toAdd.BranchId = _promise.BranchId;
                                    _receiptdesc_toAdd.CustomerId = _promise.CustomerId;
                                    _receiptdesc_toAdd.Receiptno = ReceiptNo;
                                    _receiptdesc_toAdd.ReceipttranId = _receipttran_toAdd.Id;
                                    _receiptdesc_toAdd.PeriodtranId = _receipttran_toAdd.peroidtrans_info[i].Id;
                                    _receiptdesc_toAdd.Tdate = DateTime.Now.AddYears(543).ToString("dd/MM/yyyy");
                                    _receiptdesc_toAdd.Tdateformat = DateTime.Now.ToString("yyyyMMdd");
                                    _receiptdesc_toAdd.Tdatecal = DateTime.Now.AddYears(543).ToString("dd/MM/yyyy");
                                    _receiptdesc_toAdd.Tdatecalformat = DateTime.Now.ToString("yyyyMMdd");

                                    _receiptdesc_toAdd.Period = _receipttran_toAdd.peroidtrans_info[i].Period;
                                    _receiptdesc_toAdd.Perioddate = _receipttran_toAdd.peroidtrans_info[i].Tdateformat;
                                    _receiptdesc_toAdd.Chargeamt = _receipttran_toAdd.Charge1amt;


                                    decimal totalDue = ((decimal)_receipttran_toAdd.peroidtrans_info[i].Capital + (decimal)_receipttran_toAdd.peroidtrans_info[i].Interest) - ((decimal)_receipttran_toAdd.peroidtrans_info[i].Paidremain * -1);

                                    while (globalData.paymentAmount > 0)
                                    {
                                        if (payment_method != 4)
                                        {
                                            if (globalData.paymentAmount >= totalDue)
                                            {
                                                _receiptdesc_toAdd.Cappaid = _receipttran_toAdd.peroidtrans_info[i].Capital * -1;
                                                _receiptdesc_toAdd.Intpaid = _receipttran_toAdd.peroidtrans_info[i].Interest * -1;
                                                var total = _receiptdesc_toAdd.Cappaid + _receiptdesc_toAdd.Intpaid;
                                                _receiptdesc_toAdd.Amount = total;
                                                globalData.RemainingPaid = globalData.paymentAmount - ((decimal)_receiptdesc_toAdd.Amount * -1);
                                                globalData.paymentAmount -= totalDue;
                                                break;
                                            }
                                            else
                                            {
                                                _receiptdesc_toAdd.pending_amount = globalData.RemainingPaid;
                                                if (_receiptdesc_toAdd.pending_amount >= _receipttran_toAdd.peroidtrans_info[i].Interest)
                                                {
                                                    var amount_over_int = _receiptdesc_toAdd.pending_amount - _receipttran_toAdd.peroidtrans_info[i].Interest;
                                                    _receiptdesc_toAdd.Intpaid = _receipttran_toAdd.peroidtrans_info[i].Interest * -1;
                                                    _receiptdesc_toAdd.Cappaid = (_receipttran_toAdd.peroidtrans_info[i].Capital - amount_over_int) * -1;
                                                    var total = _receiptdesc_toAdd.Cappaid + _receiptdesc_toAdd.Intpaid;
                                                    _receiptdesc_toAdd.Amount = total * -1;
                                                    globalData.RemainingPaid -= _receiptdesc_toAdd.pending_amount;
                                                    break;
                                                }
                                                else
                                                {
                                                    _receiptdesc_toAdd.Intpaid = _receiptdesc_toAdd.pending_amount * -1;
                                                    _receiptdesc_toAdd.Amount = _receiptdesc_toAdd.pending_amount * -1;
                                                    globalData.paymentAmount -= _receiptdesc_toAdd.pending_amount;
                                                    break;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            _receiptdesc_toAdd.Deposit = (decimal)_receipttran_toAdd.Amount;
                                            _receiptdesc_toAdd.Periodchg = current_periods;
                                            _receiptdesc_toAdd.payment_method = 4;
                                            break;
                                        }

                                    }

                                    //  _receiptdesc_toAdd.pending_amount = globalData.RemainingPaid;
                                    _receiptdesc_toAdd.Usercode = globalData.username;
                                    _receiptdesc_toAdd.Chargeamt =  Convert.ToDecimal(p.origin_fine);

                                    lst_receiptdescs.Add(_receiptdesc_toAdd);

                                }

                                await promiseManagement.addReceipdesc(lst_receiptdescs);

                                await JSRuntime.InvokeVoidAsync("paymentsuccess");
                                await Task.Delay(100);

                                //    navigationManager.NavigateTo($"/paymentlist/{branch_id}/{c_id}/{promise_id}");
                                navigationManager.NavigateTo($"/paymentlist/{branch_id}/{c_id}/{promise_id}", forceLoad: true);
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

                                //decimal cal_period_pay = ((Convert.ToDecimal(p.customerPayAmount) - totalFee) - Convert.ToDecimal(p.p_total_Charge_follow)) / (decimal)_promise.Amount;
                                //var period_pay_qty = (int)Math.Ceiling(cal_period_pay);
                                //int remainingInstallments = (int)_periodtran.Where(s => s.Ispaid == false).Count() - (int)Math.Floor(cal_period_pay);




                                Receipttran _receipttran_toAdd = new Receipttran();

                                _receipttran_toAdd.PromiseId = _promise.Id;
                                _receipttran_toAdd.BranchId = _promise.BranchId;
                                _receipttran_toAdd.CustomerId = _promise.CustomerId;
                                _receipttran_toAdd.Receiptno = p.receipt_no;
                              
                                if (payment_method == 1 || payment_method == 2 || payment_method == 3)
                                {
                                    _receipttran_toAdd.Amount = 0;
                                    _receipttran_toAdd.Receiptdesc = "ปิดสัญญาก่อนกำหนด";
                                }
                              

                                _receipttran_toAdd.Tdate = DateTime.Now.AddYears(543).ToString("dd/MM/yyyy");
                                _receipttran_toAdd.Tdateformat = DateTime.Now.ToString("yyyyMMdd");
                                _receipttran_toAdd.Tdatecal = DateTime.Now.AddYears(543).ToString("dd/MM/yyyy");
                                _receipttran_toAdd.Tdatecalformat = DateTime.Now.ToString("yyyyMMdd");
                                _receipttran_toAdd.peroidtrans_info = _periodtran.Where(s => s.Ispaid == false).Take(p.p_overpay_qty).ToList();

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
                                    int overpay_qty = _periodtran.Where(s=>s.Ispaid == false && s.check_overpay == true).Count();
                                    var arbalance_qty = _periodtran.FirstOrDefault().Amount;
                                    _receipttran_toAdd.Arbalance =(((arbalance_qty * overpay_qty) + totalFee )+ Convert.ToDecimal(p.p_total_Charge_follow));
                                    _receipttran_toAdd.Arperiod = overpay_qty; 
                                    _receipttran_toAdd.Cappaid = 0;
                                    _receipttran_toAdd.Intpaid = 0;
                                    _receipttran_toAdd.Intplus = intplus;
                                    _receipttran_toAdd.Discount = discount;
                                    Receipttran? Capremain_before = await managements.GetReceipttran_bypromiseId(promise_id);
                                    if (Capremain_before == null)
                                    {
                                        _receipttran_toAdd.Capremain = _promise.Capital - _receipttran_toAdd.Cappaid;
                                        var sum_interate = _periodtran.Where(s => s.Ispaid == false).Sum(s => s.Interest);
                                        _receipttran_toAdd.Intremain = sum_interate - _receipttran_toAdd.Intpaid;
                                    }
                                    else
                                    {
                                        _receipttran_toAdd.Capremain = Capremain_before.Capremain - _receipttran_toAdd.Cappaid;
                                        var sum_interate = Capremain_before.Intremain;
                                        _receipttran_toAdd.Intremain = sum_interate - _receipttran_toAdd.Intpaid;
                                    }


                                    _receipttran_toAdd.Charge1amt = totalFee;
                                    _receipttran_toAdd.Charge2amt = Convert.ToDecimal(p.p_total_Charge_follow);

                                    _receipttran_toAdd.Netamount =Convert.ToDecimal(p.customerPayAmount);
                                    var count_periodtran = _periodtran.Where(s => s.Ispaid == false).Count();
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
                                    current_periods = await managements.GetCurrentPeriod(promise_id);
                                    _receipttran_toAdd.Periodchg = current_periods;
                                    _receipttran_toAdd.Periodremain = _promise.Periods - 1;
                                }




                                _receipttran_toAdd.Usercode = globalData.fullname;

                                if (payment_method == 1)
                                {
                                    _receipttran_toAdd.Cashpaid = 1;
                                    _receipttran_toAdd.PaidBy = 1;
                                }
                                if (payment_method == 2)
                                {
                                    _receipttran_toAdd.Transferdate = "1";
                                    _receipttran_toAdd.PaidBy = 2;
                                }
                                if (payment_method == 3)
                                {
                                    _receipttran_toAdd.Otherpaid = 1;
                                    _receipttran_toAdd.PaidBy = 3;
                                }
                                if (payment_method == 4)
                                {
                                    _receipttran_toAdd.Otherpaid = 1;
                                    _receipttran_toAdd.PaidBy = 4;
                                }

                                _receipttran_toAdd.Currentperiod = _periodtran.Where(s => s.Ispaid == false).Select(s => s.Period).FirstOrDefault();
                                //  _receipttran_toAdd.RemainingPrincipal = ((decimal)customerPayAmount - totalFee) - _promise.Amount;


                                await promiseManagement.addReceipttran(_receipttran_toAdd);


                                //ยอดที่ปิดชำระสัญญา
                                globalData.paymentAmount = (decimal)_receipttran_toAdd.Netamount;

                                for (int i = 0; i < p.p_overpay_qty; i++)
                                {
                                    Receiptdesc _receiptdesc_toAdd = new Receiptdesc();
                                    _receiptdesc_toAdd.PromiseId = _promise.Id;
                                    _receiptdesc_toAdd.BranchId = _promise.BranchId;
                                    _receiptdesc_toAdd.CustomerId = _promise.CustomerId;
                                    _receiptdesc_toAdd.Receiptno = p.receipt_no;
                                    _receiptdesc_toAdd.ReceipttranId = _receipttran_toAdd.Id;
                                    _receiptdesc_toAdd.PeriodtranId = _receipttran_toAdd.peroidtrans_info[i].Id;
                                    _receiptdesc_toAdd.Tdate = DateTime.Now.AddYears(543).ToString("dd/MM/yyyy");
                                    _receiptdesc_toAdd.Tdateformat = DateTime.Now.ToString("yyyyMMdd");
                                    _receiptdesc_toAdd.Tdatecal = DateTime.Now.AddYears(543).ToString("dd/MM/yyyy");
                                    _receiptdesc_toAdd.Tdatecalformat = DateTime.Now.ToString("yyyyMMdd");

                                    _receiptdesc_toAdd.Period = _receipttran_toAdd.peroidtrans_info[i].Period;
                                    _receiptdesc_toAdd.Perioddate = _receipttran_toAdd.peroidtrans_info[i].Tdateformat;
                                    _receiptdesc_toAdd.Chargeamt = _receipttran_toAdd.Charge1amt;


                                    decimal totalDue = ((decimal)_receipttran_toAdd.peroidtrans_info[i].Capital + (decimal)_receipttran_toAdd.peroidtrans_info[i].Interest) - ((decimal)_receipttran_toAdd.peroidtrans_info[i].Paidremain * -1);

                                    while (globalData.paymentAmount > 0)
                                    {
                                        if (payment_method != 4)
                                        {
                                            if (globalData.paymentAmount >= totalDue)
                                            {
                                                _receiptdesc_toAdd.Cappaid = _receipttran_toAdd.peroidtrans_info[i].Capital * -1;
                                                _receiptdesc_toAdd.Intpaid = _receipttran_toAdd.peroidtrans_info[i].Interest * -1;
                                                var total = _receiptdesc_toAdd.Cappaid + _receiptdesc_toAdd.Intpaid;
                                                _receiptdesc_toAdd.Amount = total;
                                                globalData.RemainingPaid = globalData.paymentAmount - ((decimal)_receiptdesc_toAdd.Amount * -1);
                                                globalData.paymentAmount -= totalDue;
                                                break;
                                            }
                                            else
                                            {
                                                _receiptdesc_toAdd.pending_amount = globalData.RemainingPaid;
                                                if (_receiptdesc_toAdd.pending_amount >= _receipttran_toAdd.peroidtrans_info[i].Interest)
                                                {
                                                    var amount_over_int = _receiptdesc_toAdd.pending_amount - _receipttran_toAdd.peroidtrans_info[i].Interest;
                                                    _receiptdesc_toAdd.Intpaid = _receipttran_toAdd.peroidtrans_info[i].Interest * -1;
                                                    _receiptdesc_toAdd.Cappaid = (_receipttran_toAdd.peroidtrans_info[i].Capital - amount_over_int) * -1;
                                                    var total = _receiptdesc_toAdd.Cappaid + _receiptdesc_toAdd.Intpaid;
                                                    _receiptdesc_toAdd.Amount = total * -1;
                                                    globalData.RemainingPaid -= _receiptdesc_toAdd.pending_amount;
                                                    break;
                                                }
                                                else
                                                {
                                                    _receiptdesc_toAdd.Intpaid = _receiptdesc_toAdd.pending_amount * -1;
                                                    _receiptdesc_toAdd.Amount = _receiptdesc_toAdd.pending_amount * -1;
                                                    globalData.paymentAmount -= _receiptdesc_toAdd.pending_amount;
                                                    break;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            _receiptdesc_toAdd.Deposit = (decimal)_receipttran_toAdd.Amount;
                                            _receiptdesc_toAdd.Periodchg = current_periods;
                                            _receiptdesc_toAdd.payment_method = 4;
                                            break;
                                        }

                                    }

                                    //  _receiptdesc_toAdd.pending_amount = globalData.RemainingPaid;
                                    _receiptdesc_toAdd.Usercode = globalData.username;
                                    _receiptdesc_toAdd.Chargeamt = totalFee;

                                    lst_receiptdescs.Add(_receiptdesc_toAdd);

                                }

                                await promiseManagement.addReceipdesc(lst_receiptdescs);

                                //Check Close Promise 
                                await promiseManagement.updateClosePromise(promise_id);
                                await JSRuntime.InvokeVoidAsync("paymentsuccess");
                                await Task.Delay(100);

                               
                                navigationManager.NavigateTo($"/paymentlist/{branch_id}/{c_id}/{promise_id}", forceLoad: true);
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

        private void goback()
        {
            navigationManager.NavigateTo($"/customerlist/{branch_id}/{c_id}");
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
        private async Task receipt(int? peroidtran_id,string type)
        {
            string url = $"/paymentrecipe/{peroidtran_id}/{type}";
            await JSRuntime.InvokeAsync<object>("open", url, "_blank");
            //navigationManager.NavigateTo("/paymentrecipe");
        }

    }
}
