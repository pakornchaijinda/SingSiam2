using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;
using MudBlazor;
using SingSiamOffice.Models;

namespace SingSiamOffice.Pages.CustomerManagement.CustomerDept
{
    public partial class Customerdept
    {
        [Inject]
        NavigationManager navigationManager { get; set; }
        [Inject]
        IJSRuntime JSRuntime { get; set; }


        private string role { get; set; } = "employee";
        public string? depts_details { get; set; }
        public double? depts_amount { get; set; }
        bool tosave { get; set; } = true;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                
                await JSRuntime.InvokeVoidAsync("sideBar");
            }
        }


        private async Task submit()
        {
            if (selectedItems.Count() == 0)
            {
                Snackbar.Add("โปรดเลือกรายการและใส่จำนวน", Severity.Error);
                return;
            }
            var confirm = await JSRuntime.InvokeAsync<bool>("confirmSaveData");
            if (confirm)
            {

             
                try
                {
                    //update accpiad
                    //Branch uppdate_accpiad = db.Branches.Where(s => s.Id == cus_info.BranchId).FirstOrDefault();
                    //uppdate_accpiad.Arpaidno = uppdate_accpiad.Arpaidno.Value + 1;
                    //db.Entry(uppdate_accpiad).State = EntityState.Modified;
                    //db.SaveChangesAsync();
                    foreach (var data in selectedItems)
                    {
                        data.Docno = Bill_code;
                        data.Paidamount = data.Aramount;
                        data.PaidComplete = true;
                        db.Entry(data).State = EntityState.Modified;
                        await db.SaveChangesAsync();
                    }
                    get_data();
                    await JSRuntime.InvokeVoidAsync("confirm");
                    await Task.Delay(100);

                }
                catch(Exception e)
                {
                    await JSRuntime.InvokeVoidAsync("alert_error");
                }

              
               

            }
            else
            {
                //await JSRuntime.InvokeVoidAsync("alert_error");
            }
        }
        private void goBack()
        {
            navigationManager.NavigateTo("/customerlist/"+cus_info.BranchId.ToString());
        }
    }
}
