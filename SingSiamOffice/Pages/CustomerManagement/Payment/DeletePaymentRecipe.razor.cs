using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using SingSiamOffice.Manage;
using SingSiamOffice.Models;

namespace SingSiamOffice.Pages.CustomerManagement.Payment
{
    public partial class DeletePaymentRecipe
    {
        [Inject]
        NavigationManager navigationManager { get; set; }
        [Inject]
        IJSRuntime JSRuntime { get; set; }
        [Parameter]
        public int peroidtran_id { get; set; }
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
        Manage.Receipt receipt = new Receipt();
        private bool ck_deposit { get; set; }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await JSRuntime.InvokeVoidAsync("printReceipt");
            }
        }
        protected override async void OnInitialized()
        {
           
        }
    }
}
