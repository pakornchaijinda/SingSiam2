using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace SingSiamOffice.Pages.CustomerManagement.Payment.PaymentReport
{
    public partial class CustomerPaymentReport
    {
        [Inject]
        IJSRuntime JSRuntime { get; set; }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                //await JSRuntime.InvokeVoidAsync("printReceipt");
                
                    await JSRuntime.InvokeVoidAsync("addPageBreaks",24);
            }
        }
    }
}
