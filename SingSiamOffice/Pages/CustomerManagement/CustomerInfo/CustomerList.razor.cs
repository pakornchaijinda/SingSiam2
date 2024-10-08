﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;
using SingSiamOffice.Authentication;
using SingSiamOffice.Manage;
using SingSiamOffice.Models;
using System;
using static SingSiamOffice.Pages.CustomerManagement.CustomerInfo.AddCustomer;

namespace SingSiamOffice.Pages.CustomerManagement.CustomerInfo
{
    public partial class CustomerList
    {
        [Inject]
        IJSRuntime JSRuntime { get; set; }
        [Inject]
        NavigationManager navigationManager { get; set; }
        [Inject]
        Manage.Managements managements { get; set; }
        [Inject]
        Manage.PromiseManagement promiseManagement { get; set; }
        [Inject] AuthenticationStateProvider authStateProvider { get; set; }    
        [Inject] AuthenticationStateProvider AuthenticationStateProvider { get; set; }

      
        //[CascadingParameter]
        //private Task<AuthenticationState> authenticationStateTasks { get; set; }
        //AuthenticationState auth;
        private string role { get; set; } = "employee";

        bool isOpen;

        bool _expanded = false;

        private void OnExpandCollapseClick()
        {
            _expanded = !_expanded;
        }

        private bool ck_customer_branch { get; set; } = false;
        private string value1;
        private string[] states =
        {
        "Alabama", "Alaska", "American Samoa", "Arizona",
        "Arkansas", "California", "Colorado", "Connecticut",

    };


        private List<Promise> lst_Promises = new List<Promise>();

        async private void remove(int cus_id)
        {
            var confirm = await JSRuntime.InvokeAsync<bool>("confirmdelete");
            if (confirm)
            {
                try
                {
                    var to_remove = db.Customers.Where(s => s.CustomerId == cus_id).FirstOrDefault();
                    to_remove.Status = 0;
                    db.Entry(to_remove).State = EntityState.Modified;
                    await db.SaveChangesAsync();
                    await JSRuntime.InvokeVoidAsync("deletesuccess");
                    await Task.Delay(100);

                    //reset
                    reset();
                }
                catch
                {

                }
            }
            else
            {
                //await JSRuntime.InvokeVoidAsync("alert_error");
            }
            // Check if there is at least one record with the given customer ID
           
        }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                var authenticationState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
                var user = authenticationState.User;


                if (user.Identity.IsAuthenticated)
                {
                    //list_customer = await managements.GetCustomerbyBranch(b_id);
                    //list_customer = await managements.GetCustomerAll();
                }
                await JSRuntime.InvokeVoidAsync("sideBar");
            }
        }
        Login userLogin = new Login();
        


        private string[] search_category = {
            "เลขบัตรประจำตัวประชาชน",
            "ชื่อ - นามสกุล",
            "เบอร์โทร",

};


        private async Task deleteContract(int promiseId)
        {
            var confirm = await JSRuntime.InvokeAsync<bool>("deleteContract");
            if (confirm)
            {
                if (await promiseManagement.Delete_Promise(promiseId))
                {
                    await JSRuntime.InvokeVoidAsync("deleteContractSuccess");
                    await Task.Delay(100);

                    //reset
                    reset();
                   

                    navigationManager.NavigateTo($"/customerlist/{b_id}");
                }
               

            }
            else
            {
                //await JSRuntime.InvokeVoidAsync("alert_error");
            }
        }


        private void addCustomer(int brach_id)
        {
            navigationManager.NavigateTo("/add-customer/" + brach_id.ToString()) ;
        }
        private void editCustomer(int cid)
        {
            navigationManager.NavigateTo("/edit-customer/"+b_id.ToString()+"/"+ cid.ToString());
        }

        private void addContract(int cus_id,int branch_id)
        {
            navigationManager.NavigateTo($"/add-contract/{cus_id}/{branch_id}");
        }
        private void viewContract(int cus_id,int promise_id,int branch_id)
        {
            navigationManager.NavigateTo($"/view-contract/{branch_id}/{cus_id}/{promise_id}");
        }
        private void canclePayment(int promise_id)
        {
            navigationManager.NavigateTo($"/deletepayment/{promise_id}");
        }

        private async Task printContract(int id)
        {
            //navigationManager.NavigateTo("/contractreport/" + id.ToString());

            string url = $"/contractreport/{id.ToString()}";
            await JSRuntime.InvokeAsync<object>("open", url, "_blank");
        }
        private async Task printPaymentDetail(int id)
        {
            //navigationManager.NavigateTo($"/customerpaymentreport/{id}");
            string url = $"/customerpaymentreport/{id.ToString()}";
            await JSRuntime.InvokeAsync<object>("open", url, "_blank");
        }

        private void goBlacklist(int brach_id)
        {
            navigationManager.NavigateTo("/blacklist_list");
        }
        private void goDeptConlection(int brach_id)
        {
            navigationManager.NavigateTo("/deptcollection-list");
        }
        private void goCustomerDept(int cus_id,int promise_id)
        {
            navigationManager.NavigateTo("/customerdept/"+cus_id.ToString() + "/"+promise_id.ToString());
        }
        private void goPayment(int cus_id, int promise_id, int branch_id)
        {
            navigationManager.NavigateTo($"/paymentlist/{branch_id}/{cus_id}/{promise_id}");
        }
    }
}
