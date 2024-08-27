using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace SingSiamOffice.Pages.Contracts.ContractsReport
{
    public partial class ContractReport
    {
        [Inject]
        IJSRuntime JSRuntime { get; set; }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await JSRuntime.InvokeVoidAsync("printReceipt");
            }
        }

    }

}
