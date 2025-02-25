using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Globalization;
using SingSiamOffice.Models;
using Microsoft.EntityFrameworkCore;
using SingSiamOffice.Helpers;

namespace SingSiamOffice.Pages.Report
{
    public partial class ContractReport
    {
        [Inject]
        IJSRuntime JSRuntime { get; set; }

        private Branch? selectedBranch;
        private int selectedYear = DateTime.Now.Year;
        NumberToText helper = new NumberToText();

        private string role { get; set; } = "admin";

        string date = DateTime.Now.ToString("dd/MM/yyyy", new CultureInfo("th-TH"));
        DateTime? filter_date { get; set; }

        string graphTitle = "จำนวนสัญญาแต่ละสาขา";
        string graphTitleYear = $"ปี";

        List<PromiseGroup> promiseGroups = new List<PromiseGroup>();

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

        protected override async Task OnInitializedAsync()
        {
            graphTitle = "จำนวนสัญญาแต่ละสาขา";
            graphTitleYear = $"ปี {selectedYear}";
            await base.OnInitializedAsync();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await Search();
            }
        }

        private async Task<IEnumerable<Branch>> SearchBranch(string value)
        {
            SingsiamdbContext db = new SingsiamdbContext();
            return await db.Branches.ToListAsync();
        }

        private async Task<IEnumerable<int>> SearchYear(string value)
        {
            SingsiamdbContext db = new SingsiamdbContext();
            return await db.Promises.Select(promise => promise.Tdatetime!.Value.Year).Distinct().ToListAsync();
        }

        private string YearToString(int value)
        {
            if (value == 0) return "ไม่ระบุปี";
            return value.ToString();
        }

        private async Task Search()
        {
            SingsiamdbContext db = new SingsiamdbContext();
            IQueryable<Promise> promisesQuery = db.Promises;
            List<int> totalFinancePromises = new List<int>();
            List<int> totalLoanPromises = new List<int>();
            List<string> xLabels = new List<string>();

            var yearFilterPromises = promisesQuery
                    .Where(promise => promise.Tdatetime!.Value.Year == selectedYear);

            graphTitleYear = $"ปี {selectedYear}";

            if (selectedBranch != null)
            {
                graphTitle = $"จำนวนสัญญา สาขา {selectedBranch.BranchName}";

                var promises = await yearFilterPromises
                    .Where(promise => promise.Branch == selectedBranch)
                    .GroupBy(promise => promise.Tdatetime!.Value.Month).Select(g => new PromiseGroup
                    {
                        Month = g.Key,
                        TotalFinancePromises = g.Count(promise => promise.Ptype == 1),
                        TotalLoanPromises = g.Count(promises => promises.Ptype == 2),
                        TotalFinanceSales = g.Where(promise => promise.Ptype == 1).Sum(promise => promise.Amount) ?? 0,
                        TotalLoanSales = g.Where(promise => promise.Ptype == 2).Sum(promise => promise.Amount) ?? 0
                    }).ToListAsync();

                // Fill empty months with TotalFinancePromises = 0 and TotalLoanPromises = 0
                for (int month = 1; month <= 12; month++)
                {
                    if (!promises.Any(p => p.Month == month))
                    {
                        promises.Add(new PromiseGroup
                        {
                            Month = month,
                            TotalFinancePromises = 0,
                            TotalLoanPromises = 0,
                            TotalFinanceSales = 0,
                            TotalLoanSales = 0
                        });
                    }
                }

                promises = promises.OrderBy(promise => promise.Month).ToList();

                totalFinancePromises = promises.Select(promise => promise.TotalFinancePromises).ToList();
                totalLoanPromises = promises.Select(promise => promise.TotalLoanPromises).ToList();
                xLabels = promises.Select(promise => helper.MonthNumberToText(promise.Month ?? 1)).ToList();

                promiseGroups = promises;
            }
            else
            {
                var promises = await yearFilterPromises.GroupBy(promise => promise.Branch).Select(g => new PromiseGroup
                {
                    Branch = g.Key,
                    TotalFinancePromises = g.Count(promise => promise.Ptype == 1),
                    TotalLoanPromises = g.Count(promise => promise.Ptype == 2),
                    TotalFinanceSales = g.Where(promise => promise.Ptype == 1).Sum(promise => promise.Amount) ?? 0,
                    TotalLoanSales = g.Where(promise => promise.Ptype == 2).Sum(promise => promise.Amount) ?? 0
                }).ToListAsync();

                totalFinancePromises = promises.Select(promise => promise.TotalFinancePromises).ToList();
                totalLoanPromises = promises.Select(promise => promise.TotalLoanPromises).ToList();
                xLabels = promises.Select(promise => promise.Branch!.BranchName ).ToList();

                promiseGroups = promises;
            }

            await JSRuntime.InvokeVoidAsync("sideBar");
            await RenderGraph(xLabels, totalFinancePromises, totalLoanPromises);
            StateHasChanged();
        }

        private async Task ResetSearch()
        {
            selectedBranch = null;
            selectedYear = DateTime.Now.Year;
            graphTitle = "จำนวนสัญญาแต่ละสาขา";
            graphTitleYear = $"ปี {selectedYear}";
            await Search();
        }

        private async Task RenderGraph(IEnumerable<string> labels, IEnumerable<int> totalFinancePromises, IEnumerable<int> totalLoanPromises)
        {
            await JSRuntime.InvokeVoidAsync("barchart", labels, "จำนวนสัญญาไฟแนนซ์", totalFinancePromises, "จำนวนสัญญาเงินกู้", totalLoanPromises);
        }

        class PromiseGroup
        {
            public PromiseGroup() { }

            public PromiseGroup(int totalFinancePromises, int totalLoanPromises, decimal totalFinanceSales, decimal totalLoanSales, Branch branch)
            {
                Branch = branch;
                TotalFinancePromises = totalFinancePromises;
                TotalLoanPromises = totalLoanPromises;
                TotalFinanceSales = totalFinanceSales;
                TotalLoanSales = totalLoanSales;
            }

            public PromiseGroup(int totalFinancePromises, int totalLoanPromises, decimal totalFinanceSales, decimal totalLoanSales, int month)
            {
                Month = month;
                TotalFinancePromises = totalFinancePromises;
                TotalLoanPromises = totalLoanPromises;
                TotalFinanceSales = totalFinanceSales;
                TotalLoanSales = totalLoanSales;
            }

            public Branch? Branch { get; set; }
            public int? Month { get; set; }
            public int TotalFinancePromises { get; set; }
            public int TotalLoanPromises { get; set; }
            public decimal TotalFinanceSales { get; set; }
            public decimal TotalLoanSales { get; set; }
        }

    }
}
