using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Globalization;
using SingSiamOffice.Models;
using Microsoft.EntityFrameworkCore;

namespace SingSiamOffice.Pages.Report
{
    public partial class ContractReport
    {
        [Inject]
        IJSRuntime JSRuntime { get; set; }

        private Branch? selectedBranch;
        private int selectedYear;

        private string role { get; set; } = "admin";



        string date = DateTime.Now.AddYears(543).ToString("dd/MM/yyyy");
        DateTime? filter_date { get; set; }


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

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                SingsiamdbContext db = new SingsiamdbContext();

                var promises = await db.Promises.GroupBy(promise => promise.Branch).Select(g => new
                {
                    Branch = g.Key,
                    TotalSales = g.Sum(promise => promise.Amount),
                    TotalPromises = g.Count(),
                    TotalFinancePromises = g.Count(promise => promise.Ptype == 1),
                    TotalLoanPromises = g.Count(promise => promise.Ptype == 2)
                }).ToListAsync();

                var totalFinancePromises = promises.Select(promise => promise.TotalFinancePromises);
                var totalLoanPromises = promises.Select(promise => promise.TotalLoanPromises);
                var branchs = promises.Select(promise => promise.Branch.BranchName);

                await JSRuntime.InvokeVoidAsync("sideBar");
                await RenderGraph(branchs, totalFinancePromises, totalLoanPromises);
            }
        }

        private async Task RenderGraph(IEnumerable<string> labels, IEnumerable<int> totalFinancePromises, IEnumerable<int> totalLoanPromises)
        {
            await JSRuntime.InvokeVoidAsync("barchart", labels, "จำนวนสัญญาไฟแนนซ์", totalFinancePromises, "จำนวนสัญญาเงินกู้", totalLoanPromises);
        }
    }
}
