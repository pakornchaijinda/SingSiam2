﻿using Microsoft.AspNetCore.Components;
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
using System.Linq;

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

       public bool ck_intplus = false;
        public bool ck_discount = false;
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


        public int cash_transfer { get; set; } = 1;



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
            _periodtran = await managements.GetPeriodtransbyPromiseId(promise_id);
            _promise = await managements.GetPromisebyPromiseId(promise_id);

            p.overpay_qty = _periodtran.Where(s => s.OverPayQty > 0).Count();

            p.total_deposit = _periodtran.Where(s => s.Ispaid == false).Sum(p => p.Deposit).Value.ToString("N0");
            p.origin_fine = _periodtran.Sum(p => p.total_fee).ToString("N0");
            p.custom_fine = _periodtran.Sum(p => p.total_fee).ToString("N0");
            totalFee = Convert.ToDecimal(p.origin_fine);
            //p.Minimumfine = _periodtran.Where(s => s.check_overpay == true).Where(s => s.OverPayQty > 0).FirstOrDefault().total_fee;
            try
            {
             
                    p.Minimumpayment = _periodtran.FirstOrDefault().Amount - _periodtran.FirstOrDefault().Paidamount;
                
            }
            catch (Exception ex) 
            {
               
            }
        
          
            p.total_Charge_follow = _periodtran.Sum(p => p.total_charge_follow).ToString("N0");

            if (p.overpay_qty > 0)
            {
                p.base_temp_deptAmount = _periodtran.Where(s=>s.check_overpay == true).Sum(p => p.amount_remain);
                var total = ((_periodtran.Where(s => s.check_overpay == true).Sum(p => p.amount_remain) + Convert.ToDecimal(p.origin_fine))- Convert.ToDecimal(p.total_deposit));
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
                p.total_deposit = _periodtran.Where(s => s.Ispaid == false).Sum(p => p.Deposit).Value.ToString("N0");
                p.origin_fine = _periodtran.Where(s => s.check_overpay == true).Sum(p => p.total_fee).ToString("N0");
                p.total_Charge_follow = _periodtran.Sum(p => p.total_charge_follow).ToString("N0");

                if (p.overpay_qty > 0)
                {
                    //p.Minimumfine = _periodtran.Where(s => s.check_overpay == true).Where(s => s.OverPayQty > 0).FirstOrDefault().total_fee;
                    p.Minimumpayment = _periodtran.Where(s => s.check_overpay == true).Where(s => s.OverPayQty > 0).FirstOrDefault().Amount;
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
                payment_method = 1;
                p.p_overpay_qty = _periodtran.Where(s => s.Ispaid == false).Count();

                p.p_total_deposit = _periodtran.Where(s => s.Ispaid == false).Sum(p => p.Deposit).Value.ToString("N0");
                p.p_origin_fine = _periodtran.Where(s => s.Ispaid == false).Sum(p => p.total_fee).ToString("N0");
                p.p_custom_fine = _periodtran.Where(s => s.Ispaid == false).Sum(p => p.total_fee).ToString("N0");
                p.p_total_Charge_follow = _periodtran.Where(s => s.Ispaid == false).Sum(p => p.total_charge_follow).ToString("N0");
                p.p_paidfineAmount = (Convert.ToDecimal(p.p_origin_fine) + Convert.ToDecimal(p.p_total_Charge_follow)).ToString("N0");


                p.p_total_deptAmount = _periodtran.Where(s => s.Ispaid == false).Sum(p => (decimal)p.Amount).ToString("N0");
                p.base_temp_total_deptAmount = _periodtran.Where(s => s.Ispaid == false).Sum(p => (decimal)p.Amount);
                p.p_pending_amount = (_promise_pay.total_deptAmount - _promise_pay.total_deposit + Convert.ToDecimal(p.p_origin_fine) + Convert.ToInt32(p.p_total_Charge_follow)) * -1;

                var p_type = _periodtran.Select(s=>s.Ptype).FirstOrDefault();
                if (p_type == 1)
                {
                    p.p_paidprincipleAmount = _periodtran.Where(s => s.Ispaid == false).Sum(p => (decimal)p.Capital);
                    var remain_amount = _periodtran.Where(s => s.Ispaid == false).Sum(p => (decimal)p.Paidremain) * -1;
                    p.p_paidinterestAmount = _periodtran.Where(s => s.Ispaid == false).Sum(p => (decimal)p.Interest) - remain_amount;
                    var ckoverpay = _periodtran.Where(s => s.Ispaid == false && s.check_overpay == true).Sum(p => (decimal)p.Interest);
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
                        p.p_total_deptAmount = ((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + totalFee - Convert.ToDecimal(p.p_total_deposit)).ToString("N0");
                    }
                    else
                    {
                        p.p_total_deptAmount = ((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + Convert.ToDecimal(p.p_origin_fine) - Convert.ToDecimal(p.p_total_deposit)).ToString("N0");
                        p.base_temp_total_deptAmount = ((decimal)p.p_paidprincipleAmount + (decimal)p.p_paidinterestAmount + Convert.ToDecimal(p.p_origin_fine));
                    }
                }
                else 
                {
                    p.p_paidprincipleAmount = _periodtran.LastOrDefault().Capital;

                    p.p_paidinterestAmount = _periodtran.Where(s=>s.Ispaid == false).Sum(s=>s.Interest);
                    var ckoverpay = _periodtran.Where(s => s.Ispaid == false && s.check_overpay == true).Sum(p => (decimal)p.Interest);
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
                        p.base_temp_total_deptAmount = ((decimal)_periodtran.LastOrDefault().Amount +Convert.ToDecimal(p.p_origin_fine));
                    }
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

        //ลบสัญญา
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
                      
                        Receipttran _receipttran_toAdd = new Receipttran();

                        _receipttran_toAdd.PromiseId = _promise.Id;
                        _receipttran_toAdd.BranchId = _promise.BranchId;
                        _receipttran_toAdd.CustomerId = _promise.CustomerId;
                        _receipttran_toAdd.Receiptno = p.receipt_no;
                        _receipttran_toAdd.Amount = Convert.ToDecimal(p.customerPayAmount);
                        _receipttran_toAdd.Receiptdesc = "รับฝากเงินล่วงหน้า";

                        _receipttran_toAdd.Tdate = DateTime.Now.AddYears(543).ToString("dd/MM/yyyy");
                        _receipttran_toAdd.Tdateformat = DateTime.Now.ToString("yyyyMMdd");
                        _receipttran_toAdd.Tdatecal = DateTime.Now.AddYears(543).ToString("dd/MM/yyyy");
                        _receipttran_toAdd.Tdatecalformat = DateTime.Now.ToString("yyyyMMdd");
                   
                        current_periods = await managements.GetCurrentPeriod(promise_id);
                        _receipttran_toAdd.Periodchg = current_periods;
                        _receipttran_toAdd.Periodremain = _promise.Periods - 1;
                        _receipttran_toAdd.Usercode = globalData.fullname;
                        if (cash_transfer == 1)
                        {
                            _receipttran_toAdd.Cashpaid = 1;
                        }
                        else 
                        {
                            _receipttran_toAdd.Transferpaid = 1;
                        }
                        _receipttran_toAdd.Otherpaid = 1;
                        _receipttran_toAdd.PaidBy = 4;
                        _receipttran_toAdd.Currentperiod = _periodtran.Where(s => s.Ispaid == false).Select(s => s.Period).FirstOrDefault();
                     
                        await promiseManagement.addReceipttran(_receipttran_toAdd);
               
                        //ยอดที่ชำระ
                        globalData.paymentAmount = (decimal)_receipttran_toAdd.Amount;

                       
                            Receiptdesc _receiptdesc_toAdd = new Receiptdesc();
                            _receiptdesc_toAdd.PromiseId = _promise.Id;
                            _receiptdesc_toAdd.BranchId = _promise.BranchId;
                            _receiptdesc_toAdd.CustomerId = _promise.CustomerId;
                            _receiptdesc_toAdd.Receiptno = p.receipt_no;
                            _receiptdesc_toAdd.ReceipttranId = _receipttran_toAdd.Id;
                            _receiptdesc_toAdd.PeriodtranId = _periodtran.Where(s => s.Ispaid == false).Select(s => s.Id).FirstOrDefault();
                            _receiptdesc_toAdd.Tdate = DateTime.Now.AddYears(543).ToString("dd/MM/yyyy");
                            _receiptdesc_toAdd.Tdateformat = DateTime.Now.ToString("yyyyMMdd");
                            _receiptdesc_toAdd.Tdatecal = DateTime.Now.AddYears(543).ToString("dd/MM/yyyy");
                            _receiptdesc_toAdd.Tdatecalformat = DateTime.Now.ToString("yyyyMMdd");

                            _receiptdesc_toAdd.Period = _periodtran.Where(s => s.Ispaid == false).Select(s => s.Period).FirstOrDefault();
                            _receiptdesc_toAdd.Perioddate = _periodtran.Where(s => s.Ispaid == false).Select(s => s.Tdateformat).FirstOrDefault();

                            _receiptdesc_toAdd.Deposit = (decimal)_receipttran_toAdd.Amount;
                            _receiptdesc_toAdd.Periodchg = current_periods;
                            _receiptdesc_toAdd.payment_method = 4;
                                 
                                

                            

                            _receiptdesc_toAdd.Usercode = globalData.username;
                            _receiptdesc_toAdd.Chargeamt = _promise_pay.total_fee;

                            lst_receiptdescs.Add(_receiptdesc_toAdd);

                        

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
                           
                            if (Convert.ToDecimal(p.customerPayAmount) >= (p.Minimumpayment))
                            {
                                p.temp_total_deptAmount = Convert.ToDecimal(p.customerPayAmount);
                                decimal cal_period_pay = ((Convert.ToDecimal(p.customerPayAmount) - totalFee) - Convert.ToDecimal(p.total_Charge_follow)) / (decimal)_promise.Amount;
                                var period_pay_qty = (int)Math.Ceiling(cal_period_pay);
                                int remainingInstallments = (int)_periodtran.Where(s => s.Ispaid == false).Count() - (int)Math.Floor(cal_period_pay);

                                //รายการที่ยังไม่ได้ชำระ
                                var _periodtran_detail =  _periodtran.Where(s => s.Ispaid == false).Take(period_pay_qty).ToList();

                                //รายการงวดที่เลยค้างชำระ 
                                var amount_per_month_check_overpay = _periodtran.Where(s => s.Ispaid == false && s.check_overpay == true).Take(period_pay_qty).ToList();

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



                                    if (item.Paidremain != 0)
                                    {
                                        if (cus_totalpay >= item.Paidremain)
                                        {
                                            item.ck_amount = true;
                                            if (item.ck_deposit == true)
                                            {
                                                item.Paidremain =  item.Paidremain - item.Deposit;
                                            }
                                            item.amount_remain_pay = Convert.ToDecimal(p.customerPayAmount) - (decimal)item.Paidremain;
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
                                        if (cus_totalpay >= item.Amount)
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


                                Receipttran _receipttran_toAdd = new Receipttran();

                                _receipttran_toAdd.PromiseId = _promise.Id;
                                _receipttran_toAdd.BranchId = _promise.BranchId;
                                _receipttran_toAdd.CustomerId = _promise.CustomerId;
                                _receipttran_toAdd.Receiptno = p.receipt_no;
                                _receipttran_toAdd.Intplus = intplus;
                                _receipttran_toAdd.Discount = discount;
                                var totalDeposit = Convert.ToDecimal(p.total_deposit);
                                _receipttran_toAdd.Deposit = (decimal)totalDeposit;
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
                                //รายการงวดที่จ่าบ
                                _receipttran_toAdd.peroidtrans_info = _periodtran.Where(s => s.Ispaid == false).Take(period_pay_qty).ToList();

                                _receipttran_toAdd.Usercode = globalData.fullname;

                                if (payment_method == 1)
                                {
                                    _receipttran_toAdd.Cashpaid = 1;
                                    _receipttran_toAdd.PaidBy = 1;
                                }
                                if (payment_method == 2)
                                {
                                    _receipttran_toAdd.Transferpaid = 1;    
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

                                //แสดงงวดปัจจุบัน
                                _receipttran_toAdd.Currentperiod = _periodtran.Where(s => s.Ispaid == false).Select(s => s.Period).FirstOrDefault();


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

                                        p.Arbalance = p.temp_total_deptAmount;
                                        p.temp_total_deptAmount = (p.temp_total_deptAmount - Convert.ToDecimal(p.origin_fine)) - Convert.ToDecimal(p.total_Charge_follow); 
                                        //ค่าปรับ
                                        _receipttran_toAdd.Charge1amt = Convert.ToDecimal(p.origin_fine);
                                        _receipttran_toAdd.charage_origin = Convert.ToDecimal(p.origin_fine);
                                        //ค่าติดตาม ค่าทวงถาม
                                        _receipttran_toAdd.Charge2amt = Convert.ToDecimal(p.total_Charge_follow);

                                        //p.Arbalance = amount_per_month_check_overpay.Sum(s=>s.Amount) + amount_per_month_check_overpay.Sum(s=>s.Deposit);
                                       
                                        if (p.temp_total_deptAmount >= totalInterest)
                                        {
                                            p.temp_total_deptAmount = p.temp_total_deptAmount - (decimal)totalInterest;
                                            _receipttran_toAdd.Intpaid = totalInterest;
                                        }
                                        else
                                        {
                                            var Intpaid = (decimal)totalInterest - p.temp_total_deptAmount;
                                            _receipttran_toAdd.Intpaid = p.temp_total_deptAmount;
                                            p.temp_total_deptAmount -= p.temp_total_deptAmount;
                                        }

                                        if (p.temp_total_deptAmount >= totalCapital)
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
                                          var cappaid= (decimal)totalCapital - p.temp_total_deptAmount;
                                          
                                            _receipttran_toAdd.Cappaid = p.temp_total_deptAmount;
                                            p.temp_total_deptAmount -= p.temp_total_deptAmount;
                                        }

                                        //receipttran_toAdd.Cappaid = amount_per_month_check_overpay.Sum(s => s.Capital);
                                        //_receipttran_toAdd.Intpaid = amount_per_month_check_overpay.Sum(s => s.Interest);
                                        // _receipttran_toAdd.Arbalance = p.Arbalance + totalFee + Convert.ToDecimal(p.total_Charge_follow);
                                      
                                    }
                                    else 
                                    {
                                        p.Arbalance = _periodtran_detail.Where(s=>s.ck_amount == true).Sum(s => s.Amount) - _periodtran_detail.Where(s => s.ck_amount == true).Sum(s => s.Intpaid);
                                       
                                        _receipttran_toAdd.Cappaid = _periodtran_detail.Where(s=>s.ck_amount == true).Sum(s => s.Capital);
                                        _receipttran_toAdd.Intpaid = _periodtran_detail.Where(s => s.ck_amount == true).Sum(s => s.Interest) - _periodtran_detail.Where(s => s.ck_amount == true).Sum(s => s.Intpaid);
                                        _receipttran_toAdd.Arbalance = p.Arbalance + totalFee + Convert.ToDecimal(p.total_Charge_follow);
                                        //ค่าปรับ
                                        _receipttran_toAdd.Charge1amt = totalFee;

                                        //ค่าติดตาม ค่าทวงถาม
                                        _receipttran_toAdd.Charge2amt = Convert.ToDecimal(p.total_Charge_follow);
                                    }
                                   
                                    //ยอดคงเหลือ
                                    Receipttran? Capremain_before = await managements.GetReceipttran_bypromiseId(promise_id);
                                    if (Capremain_before == null)
                                    {
                                        _receipttran_toAdd.Capremain = _promise.Capital - _receipttran_toAdd.Cappaid;
                                        var sum_interate = _periodtran.Where(s => s.Ispaid == false).Sum(s => s.Interest);
                                        _receipttran_toAdd.Intremain = sum_interate - _receipttran_toAdd.Intpaid;
                                    }
                                    else
                                    {
                                        var totalcapital = Capremain_before.Promise.Periodtrans.Sum(s => s.Capital);
                                        var capremain_amount =totalcapital - Capremain_before.Promise.Periodtrans.Where(s => s.Ispaid == true).Sum(s => s.Cappaid);
                                        _receipttran_toAdd.Capremain = capremain_amount - _receipttran_toAdd.Cappaid;
                                        var totalinterate = Capremain_before.Promise.Periodtrans.Sum(s => s.Interest);
                                        var Interemain_amount =totalinterate - Capremain_before.Promise.Periodtrans.Where(s => s.Ispaid == true).Sum(s => s.Intpaid);
                                        var sum_interate = Interemain_amount;
                                        _receipttran_toAdd.Intremain = sum_interate - _receipttran_toAdd.Intpaid;

                                    }

                                   

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

                                //  _receipttran_toAdd.RemainingPrincipal = ((decimal)customerPayAmount - totalFee) - _promise.Amount;


                                //บันทึกลง DB Receipttran
                                await promiseManagement.addReceipttran(_receipttran_toAdd);


                                //ยอดที่ชำระ
                                globalData.paymentAmount = (((decimal)_receipttran_toAdd.Amount - (decimal)_receipttran_toAdd.Charge1amt) - (decimal)_receipttran_toAdd.Charge2amt);

                                for (int i = 0; i < period_pay_qty; i++)
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
                                    _receiptdesc_toAdd.Lateamt = _receipttran_toAdd.Charge2amt;
                                    decimal totalDue = 0;

                                    //ดอกเบี้ยที่จ่ายล่วงหน้า
                                    
                                    var intpaid = _receipttran_toAdd.peroidtrans_info[i].Receiptdescs.Where(s=>s.PeriodtranId == _receiptdesc_toAdd.PeriodtranId).Select(s => s.Intpaid).FirstOrDefault();
                                    var cappaid = _receipttran_toAdd.peroidtrans_info[i].Receiptdescs.Where(s => s.PeriodtranId == _receiptdesc_toAdd.PeriodtranId).Select(s => s.Cappaid).FirstOrDefault();

                                    if (intpaid == null)
                                    {
                                        totalDue = ((((decimal)_receipttran_toAdd.peroidtrans_info[i].Capital + (decimal)_receipttran_toAdd.peroidtrans_info[i].Interest)) - (decimal)_receipttran_toAdd.peroidtrans_info[i].Paidremain);
                                    }
                                    else 
                                    {
                                        if (intpaid != 0)
                                        {
                                            totalDue = ((decimal)_receipttran_toAdd.peroidtrans_info[i].Capital + (decimal)_receipttran_toAdd.peroidtrans_info[i].Interest) - ((decimal)intpaid * -1) - ((decimal)cappaid * -1);
                                            _receipttran_toAdd.peroidtrans_info[i].Interest = _receipttran_toAdd.peroidtrans_info[i].Interest + intpaid;
                                            _receipttran_toAdd.peroidtrans_info[i].Capital = _receipttran_toAdd.peroidtrans_info[i].Capital + cappaid;
                                        }
                                        else
                                        {
                                            totalDue = (((decimal)_receipttran_toAdd.peroidtrans_info[i].Capital + (decimal)_receipttran_toAdd.peroidtrans_info[i].Interest) - (decimal)_receipttran_toAdd.peroidtrans_info[i].Paidremain ) - (decimal)_receipttran_toAdd.Deposit;
                                        }
                                    }
                                 
                                   

                                    while (globalData.paymentAmount > 0)
                                    {
                                        if (p.payment_Menthod != 4)
                                        {
                                            totalDue = totalDue - (decimal)_receipttran_toAdd.peroidtrans_info[i].Deposit;
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
                                              
                                                if (_receiptdesc_toAdd.pending_amount >= _receipttran_toAdd.peroidtrans_info[i].Interest)
                                                {
                                                    var amount_over_int = _receiptdesc_toAdd.pending_amount - _receipttran_toAdd.peroidtrans_info[i].Interest;
                                                    _receiptdesc_toAdd.Intpaid = _receipttran_toAdd.peroidtrans_info[i].Interest * -1;
                                                    _receiptdesc_toAdd.Cappaid =  amount_over_int * -1;
                                                    var total = _receiptdesc_toAdd.Cappaid + _receiptdesc_toAdd.Intpaid;
                                                    _receiptdesc_toAdd.Amount = _receiptdesc_toAdd.pending_amount * -1;
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
                                    //_receiptdesc_toAdd.Chargeamt = _receipttran_toAdd.peroidtrans_info[i].total_fee;

                                    _receiptdesc_toAdd.Usercode = globalData.fullname;
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
                                _receipttran_toAdd.peroidtrans_info = _periodtran.Where(s => s.Ispaid == false).ToList();

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
                                    var arbalance_qty = _periodtran.FirstOrDefault().Amount;
                                    int overpay_qty = _periodtran.Where(s=>s.Ispaid == false && s.check_overpay == true).Count();
                                    if (overpay_qty != 0)
                                    {
                                        _receipttran_toAdd.Arbalance = (((arbalance_qty * overpay_qty) + totalFee) + Convert.ToDecimal(p.p_total_Charge_follow));
                                    }
                                    else 
                                    {
                                        _receipttran_toAdd.Arbalance = (((arbalance_qty) + totalFee) + Convert.ToDecimal(p.p_total_Charge_follow));
                                    }
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
                                    _receipttran_toAdd.Transferpaid = 1;
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

                                //บันทึกลงใน Table [dbo].[receipttran]
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
                                    _receiptdesc_toAdd.Deposit = _receipttran_toAdd.peroidtrans_info[i].Deposit;

                                    decimal totalDue = ((decimal)_receipttran_toAdd.peroidtrans_info[i].Capital + (decimal)_receipttran_toAdd.peroidtrans_info[i].Interest) - ((decimal)_receipttran_toAdd.peroidtrans_info[i].Paidremain * -1);

                                    var totalPaidremain = ((decimal)_receipttran_toAdd.peroidtrans_info[i].Paidremain *-1);


                                    if (totalPaidremain > 0)
                                    {
                                        _receiptdesc_toAdd.Intpaid = (_receipttran_toAdd.peroidtrans_info[i].Interest - totalPaidremain) * -1;
                                        totalPaidremain = totalPaidremain - (decimal)_receipttran_toAdd.peroidtrans_info[i].Interest;
                                      
                                       
                                    }
                                    else 
                                    {
                                        _receiptdesc_toAdd.Intpaid = (_receipttran_toAdd.peroidtrans_info[i].Interest * -1);
                                    }

                                    if (totalPaidremain >= _receipttran_toAdd.peroidtrans_info[i].Capital)
                                    {
                                        _receiptdesc_toAdd.Cappaid = (_receipttran_toAdd.peroidtrans_info[i].Capital - totalPaidremain) * -1;
                                        
                                        totalPaidremain = totalPaidremain + (decimal)_receiptdesc_toAdd.Cappaid;
                                    }
                                    else
                                    {
                                        _receiptdesc_toAdd.Cappaid = _receipttran_toAdd.peroidtrans_info[i].Capital * -1;
                                    }
                                    _receiptdesc_toAdd.Amount =( ((decimal)_receipttran_toAdd.peroidtrans_info[i].Capital + (decimal)_receipttran_toAdd.peroidtrans_info[i].Interest) - ((decimal)_receipttran_toAdd.peroidtrans_info[i].Paidremain * -1)) *-1;
                                    _receiptdesc_toAdd.Usercode = globalData.fullname;
                                    _receiptdesc_toAdd.Chargeamt = totalFee;

                                    lst_receiptdescs.Add(_receiptdesc_toAdd);

                                }

                                //บันทึกลงใน Table [dbo].[receiptdesc]
                                await promiseManagement.addReceipdesc(lst_receiptdescs);

                               
                                //Check Close Promise 
                                await promiseManagement.updateClosePromise(promise_id);
                                await Task.Delay(1000);
                                await JSRuntime.InvokeVoidAsync("paymentsuccess");
                                await Task.Delay(100);

                                if (activeIndex == 0)
                                {
                                    navigationManager.NavigateTo($"/paymentlist/{branch_id}/{c_id}/{promise_id}", forceLoad: true);
                                }
                                else 
                                {
                                    navigationManager.NavigateTo($"/customerlist/{branch_id}/{c_id}", forceLoad: true);
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
