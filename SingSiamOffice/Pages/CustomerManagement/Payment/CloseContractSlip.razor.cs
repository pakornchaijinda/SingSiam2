using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;
using SingSiamOffice.Manage;
using SingSiamOffice.Models;

namespace SingSiamOffice.Pages.CustomerManagement.Payment
{
    public partial class CloseContractSlip
    {
        [Inject]
        NavigationManager navigationManager { get; set; }
        [Inject]
        IJSRuntime JSRuntime { get; set; }
        [Parameter]
        public int promise_id { get; set; }
        [Parameter]
        public string type { get; set; }
        [Inject]
        Manage.Managements Manage { get; set; }
        [Inject]
        Helpers.NumberToText GetNumberToText { get; set; }
        [Inject]
        Manage.GlobalData globalData { get; set; }

        private List<Receiptdesc> lst_receiptdescs = new List<Receiptdesc>();
        private Receipttran receipttran = new Receipttran();
        Login userLogin = new Login();
        Manage.Receipt receipt = new Receipt();
        private bool ck_deposit { get; set; }
        SingSiamOffice.Models.SingsiamdbContext db = new SingSiamOffice.Models.SingsiamdbContext();
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await JSRuntime.InvokeVoidAsync("printReceipt");
            }
        }
        protected override async void OnInitialized()
        {

            lst_receiptdescs = await Manage.GetReceipttran_Close(promise_id, type);
            var receipno_close_id = lst_receiptdescs.Where(s => s.Receipttran.Receiptdesc == "ปิดสัญญาก่อนกำหนด").FirstOrDefault().ReceipttranId;
            receipttran = lst_receiptdescs.Select(s => s.Receipttran).FirstOrDefault();
            receipt.daypaid = receipttran.Tdate;
            receipt.receipt_no = receipttran.Receiptno;
            receipt.promise_no = lst_receiptdescs.FirstOrDefault().Promise.Refcode;
            receipt.fullname = lst_receiptdescs.FirstOrDefault().Customer.FullName;
            receipt.address = lst_receiptdescs.FirstOrDefault().Customer.Address;
            receipt.product = lst_receiptdescs.FirstOrDefault().Promise.Product.Name;
            receipt.paid_by = await GetNumberToText.Paid_By((int)receipttran.PaidBy);
            receipt.total_amount = receipttran.Amount.ToString();
         //   receipt.amount_text = await GetNumberToText.ConvertNumberToThaiWords(Convert.ToInt32(receipttran.Amount));
            var period_remain_qty = lst_receiptdescs.FirstOrDefault().Period;
            var period_s = period_remain_qty;

            var period_e = lst_receiptdescs.LastOrDefault().Period;
            receipt.peroid_remain = (period_e - period_s).ToString();
            receipt.total_fee = (receipttran.Charge1amt + receipttran.Charge2amt).ToString();
            receipt.receive_by = globalData.fullname;
            receipt.deposit = receipttran.Deposit.Value.ToString("N0");

            receipt.peroid_s = Convert.ToInt32(period_s);
            receipt.peroid_e = Convert.ToInt32(period_e);
            //receipt.pending_payment = (receipttran.Capremain + receipttran.Intremain).Value.ToString("N0");
            var pending = lst_receiptdescs.Where(s=>s.ReceipttranId == receipno_close_id).ToList();
            receipt.pending_payment = pending.Sum(s=>s.Amount).Value.ToString("N0");
            receipt.deposit = pending.Sum(s => s.Deposit).Value.ToString("N0");
            receipt.payment_interest = receipttran.Intplus.Value.ToString("N0");
            receipt.payment_full = receipttran.Netamount.Value.ToString("N0");
            receipt.discount = receipttran.Discount.Value.ToString("N0");

            receipt.total_payment = ( receipttran.Netamount).Value.ToString("N0");
            receipt.amount_text = await GetNumberToText.ConvertNumberToThaiWords(Convert.ToInt32(receipttran.Netamount));
            //if (receipttran.Receiptdesc == "รับฝากเงินล่วงหน้า")
            //{
            //    ck_deposit = true;
            //}
            //else
            //{
            //    ck_deposit = false;
            //}
            //if (receipttran.Charge1amt > 0)
            //{
            //    receipt.ck_total_fee = true;
            //}
            try
            {
                var auth = await localStorage.GetItemAsync<string>("authToken");
                if (auth == null)
                {
                    navigationManager.NavigateTo("/");
                }
                else
                {
                    userLogin = db.Logins.Where(s => s.Username == auth).AsNoTracking().FirstOrDefault();
                }
            }
            catch
            {

            }
            StateHasChanged();

        }








    }
}