using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace SingSiamOffice.Pages.BlackList
{
    public partial class AddBlackList
    {
        [Inject]
        IJSRuntime JSRuntime { get; set; }
        [Inject]
        NavigationManager navigationManager { get; set; }


        private string role { get; set; } = "employee";


        public string idcard { get; set; }
        public string name;
        public string tel;
        public string description { get; set; }


        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                
                await JSRuntime.InvokeVoidAsync("sideBar");
            }
        }

        async Task<bool> save()
        {
            try
            {
                db.Blacklists.Add(add_black);
                await db.SaveChangesAsync();
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }

        private async Task submit()
        {
            var confirm = await JSRuntime.InvokeAsync<bool>("confirmSaveData");
            if (confirm)
            {
                add_black.Cardid = selectCus.Cardid;
                add_black.Name = selectCus.Name;
                add_black.Tdesc = description;
          
                if (await save())
                {
                    await JSRuntime.InvokeVoidAsync("confirm");
                    await Task.Delay(100);

                    navigationManager.NavigateTo("/blacklist_list");
                }
                else
                {
                    await JSRuntime.InvokeVoidAsync("alert_error");
                }
               

            }
            else
            {
                //
            }
        }

        private void goback()
        {
            navigationManager.NavigateTo("/blacklist_list");
        }
    }
}
