using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using SingSiamOffice.Manage;
using SingSiamOffice.Models;
using SingSiamOffice.Models.SingSiamOld;
using System.Globalization;

namespace SingSiamOffice.Pages.CustomerManagement.Payment
{
    public partial class PaymentList_NV
    {
        [Inject]
        IWebHostEnvironment _env { get; set; }
        [Inject]
        NavigationManager navigationManager { get; set; }
        [Inject]
        Manage.Managements managements { get; set; }
        [Inject]
        IJSRuntime JSRuntime { get; set; }
        [Parameter]
        public string branch_code { get; set; }
        [Parameter]
        public int cus_id { get; set; }

        public string promiseno { get; set; }

        [Inject]
        Manage.GlobalData globalData { get; set; }
        [Inject]
        Manage.Managements Managements { get; set; }
        private string role { get; set; } = "employee";



       
        private Models.SingSiamOld.Promise _promises { get; set; }

        private string filePath { get; set; }
        private string imgbase64 { get; set; }
     

        SingsiamdbContext db = new SingsiamdbContext();
        Models.SingSiamOld._01singsiamContext _01SingsiamContextdb = new Models.SingSiamOld._01singsiamContext();

        private Models.Customer customer_data = new Models.Customer();
        private Models.SingSiamOld.Promise _promise = new Models.SingSiamOld.Promise();
        protected override async void OnInitialized()
        {
            var uri = navigationManager.ToAbsoluteUri(navigationManager.Uri);
            var query = System.Web.HttpUtility.ParseQueryString(uri.Query);
            promiseno = query["promiseno"];
            promiseno = promiseno.Replace('_', '#').ToString();
            customer_data = await managements.GetCustomerbyId(cus_id);
            _promise = await managements.GetPromiseDetailNVbyPermiseNo(promiseno);
        }
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
    }
}
