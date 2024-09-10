using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Globalization;

namespace SingSiamOffice.Pages.Dashboard
{
    public partial class Dashboard
    {
        [Inject]
        IJSRuntime JSRuntime { get; set; }
        [Inject]
        NavigationManager navigationManager { get; set; }


        private string role { get; set; } = "employee";


        DateTime? date { get; set; } = null;


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

        private async void moneyCalculate()
        {
            //navigationManager.NavigateTo($"/moneycalculator");
            try
            {
                string url = $"/moneycalculator/";
                await JSRuntime.InvokeAsync<object>("open", url, "_blank");
            }
            catch
            {

            }
          

        }
     




        //protected override async Task OnAfterRenderAsync(bool firstRender)
        //{
        //    if (firstRender) 
        //    {

        //        await JSRuntime.InvokeVoidAsync("sideBar");
        //    }
        //}

    }
}
