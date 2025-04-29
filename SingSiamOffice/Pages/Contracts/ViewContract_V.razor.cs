using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using SingSiamOffice.Manage;
using SingSiamOffice.Models;
using System.Diagnostics.Contracts;
using System.Globalization;

namespace SingSiamOffice.Pages.Contracts
{
    public partial class ViewContract_V
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
        public int c_id { get; set; }

        public string promiseno { get; set; }

        [Inject]
        Manage.GlobalData globalData { get; set; }
        [Inject]
        Manage.Managements Managements { get; set; }
        private string role { get; set; } = "employee";



        DateTime? date = DateTime.Now;
        private Customer _customer { get; set; }
        private Models.SingSiamOld.Promise _promises { get; set; }

        private string filePath { get; set; }
        private string imgbase64 { get; set; }
        private List<Guarantor> _guarantor { get; set; }
        Collateral1 collateral1 = new Collateral1();
        Collateral2 collateral2 = new Collateral2();
        Collateral3 collateral3 = new Collateral3();

        SingsiamdbContext db = new SingsiamdbContext();
        Models.SingSiamOld._01singsiamContext _01SingsiamContextdb = new Models.SingSiamOld._01singsiamContext();
        private Models.Customer customer_data = new Models.Customer();
        private Models.SingSiamOld.Promise detailPromise = new Models.SingSiamOld.Promise();
        protected override async void OnInitialized()
        {
            var uri = navigationManager.ToAbsoluteUri(navigationManager.Uri);
            var query = System.Web.HttpUtility.ParseQueryString(uri.Query);
            promiseno = query["promiseno"];
            promiseno = promiseno.Replace('_', '#').ToString();
            customer_data = await managements.GetCustomerbyId(c_id);
            detailPromise = await managements.GetPromiseDetailNVbyPermiseNo(promiseno);
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
        public static string ConvertImageToBase64(string imagePath)
        {
            if (!File.Exists(imagePath))
            {
                throw new FileNotFoundException("Image file not found", imagePath);
            }
            // Read image file into a byte array
            byte[] imageBytes = File.ReadAllBytes(imagePath);

            // Convert byte array to Base64 string
            string base64String = Convert.ToBase64String(imageBytes);

            return base64String;
        }
        private void goBack(int branch_id)
        {
            navigationManager.NavigateTo($"/customerlist/{_customer.BranchId}/{_customer.CustomerId}");
        }
    }
}
