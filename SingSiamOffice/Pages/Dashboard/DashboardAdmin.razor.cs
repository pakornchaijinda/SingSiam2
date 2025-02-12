using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Globalization;
using SingSiamOffice.Models;
using Microsoft.EntityFrameworkCore;
using SingSiamOffice.Helpers;
using System.Diagnostics.Contracts;
using SingSiamOffice.Manage;

namespace SingSiamOffice.Pages.Dashboard
{
    public partial class DashboardAdmin
    {
        [Inject]
        IJSRuntime JSRuntime { get; set; }

        private string role { get; set; } = "admin";

        private List<int> years = new List<int>();
        private int selectedYear;

        string date = DateTime.Now.AddYears(543).ToString("dd/MM/yyyy");
        DateTime? filter_date { get; set; }

        NumberToText helper = new NumberToText();

        decimal totalRevenueSummary;
        TotalNumberOfContractsSummary totalNumberOfContractsSummary = new TotalNumberOfContractsSummary();
        TotalLoanDisbursementSummary totalLoanDisbursementSummary = new TotalLoanDisbursementSummary();

        private async void HandleSelectedYearChanged()
        {
            SingsiamdbContext db = new SingsiamdbContext();

            var promises = await db.Promises
                .Where(promise => promise.Tdatetime!.Value.Year == selectedYear)
                .GroupBy(promise => promise.Tdatetime!.Value.Month).Select(g => new
                {
                    Month = g.Key,
                    TotalSales = g.Sum(promise => promise.Amount) ?? 0m,
                    TotalPromises = g.Count()
                }).ToListAsync();

            // Fill empty months with TotalSales = 0 and TotalPromises = 0
            for (int month = 1; month <= 12; month++)
            {
                if (!promises.Any(p => p.Month == month))
                {
                    promises.Add(new
                    {
                        Month = month,
                        TotalSales = 0m,
                        TotalPromises = 0
                    });
                }
            }

            promises = promises.OrderBy(promise => promise.Month).ToList();

            var TotalSales = promises.Select(promise => promise.TotalSales);
            var TotalPromises = promises.Select(promise => promise.TotalPromises);
            var monthNames = promises.Select(promise => helper.MonthNumberToText(promise.Month));

            await JSRuntime.InvokeVoidAsync("linechart", monthNames, TotalPromises, TotalSales);
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

        protected override async Task OnInitializedAsync()
        {
            totalRevenueSummary = await CalculateTotalRevenueSummary();
            totalNumberOfContractsSummary = await CalculateTotalNumberOfContractsSummary();
            totalLoanDisbursementSummary = await CalculateTotalLoanDisbursementSummary();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                SingsiamdbContext db = new SingsiamdbContext();

                var promises = await db.Promises.GroupBy(promise => promise.Tdatetime!.Value.Year).Select(g => new
                {
                    Year = g.Key,
                    TotalSales = g.Sum(promise => promise.Amount),
                    TotalPromises = g.Count()
                }).ToListAsync();

                int startYear = 2024;
                int currentYear = DateTime.Now.Year;

                for (int year = startYear; year <= currentYear; year++)
                {
                    years.Add(year);
                }

                var TotalSales = promises.Select(promise => promise.TotalSales);
                var TotalPromises = promises.Select(promise => promise.TotalPromises);
                var Years = promises.Select(promise => promise.Year);

                await JSRuntime.InvokeVoidAsync("sideBar");
                await JSRuntime.InvokeVoidAsync("linechart", Years, TotalPromises, TotalSales);
            }
        }

        async Task<decimal> CalculateTotalRevenueSummary()
        {
            SingsiamdbContext db = new SingsiamdbContext();
            return await db.Promises.SumAsync(promise => promise.Amount) ?? 0;
        }

        async Task<TotalNumberOfContractsSummary> CalculateTotalNumberOfContractsSummary()
        {
            SingsiamdbContext db = new SingsiamdbContext();
            int finance = await db.Promises.CountAsync(promise => promise.Ptype == 1);
            int loan = await db.Promises.CountAsync(promise => promise.Ptype == 2);
            return new TotalNumberOfContractsSummary { Finance = finance, Loan = loan };
        }

        async Task<TotalLoanDisbursementSummary> CalculateTotalLoanDisbursementSummary()
        {
            SingsiamdbContext db = new SingsiamdbContext();
            decimal finance = await db.Promises.Where(promise => promise.Ptype == 1).SumAsync(promise => promise.Capital) ?? 0;
            decimal loan = await db.Promises.Where(promise => promise.Ptype == 2).SumAsync(promise => promise.Capital) ?? 0;
            return new TotalLoanDisbursementSummary { Finance = finance, Loan = loan };
        }

        private void Reset()
        {
            selectedYear = 0;
            branchs = "";
        }

        private string branchs;
        private string[] branchlists =
        {
        "1001 | สาขาเชียงใหม่", "1002 | สาขาลำพูน", "1003 | สาขาดอนเมือง", "1004 | สาขาตลาดไทย",


    };

        private async Task<IEnumerable<string>> SearchBranch(string value)
        {
            // In real life use an asynchronous function for fetching data from an api.
            await Task.Delay(5);

            // if text is null or empty, show complete list
            if (string.IsNullOrEmpty(value))
                return branchlists;
            return branchlists.Where(x => x.Contains(value, StringComparison.InvariantCultureIgnoreCase));
        }

        class TotalNumberOfContractsSummary
        {
            public int Finance { get; set; }
            public int Loan { get; set; }

            public TotalNumberOfContractsSummary() { }

            public TotalNumberOfContractsSummary(int finance, int loan)
            {
                Finance = finance;
                Loan = loan;
            }
        }

        class TotalLoanDisbursementSummary
        {
            public decimal Finance { get; set; }
            public decimal Loan { get; set; }
            public TotalLoanDisbursementSummary() { }
            public TotalLoanDisbursementSummary(decimal finance, decimal loan)
            {
                Finance = finance;
                Loan = loan;
            }
        }
    }
}

