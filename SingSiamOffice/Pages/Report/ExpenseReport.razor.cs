using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Globalization;
using SingSiamOffice.Models;
using Microsoft.EntityFrameworkCore;
using System.Transactions;
using SingSiamOffice.Shared;
using SingSiamOffice.Helpers;
using Microsoft.Extensions.Primitives;

namespace SingSiamOffice.Pages.Report
{
    public partial class ExpenseReport
    {
        [Inject]
        IJSRuntime JSRuntime { get; set; }

        private Branch? selectedBranch;
        private int selectedYear;
        private string role { get; set; } = "admin";

        NumberToText helper = new NumberToText();

        string date = DateTime.Now.ToString("dd/MM/yyyy", new CultureInfo("th-TH"));
        DateTime? filter_date { get; set; }

        string graphTitle = "รายรับ - รายจ่าย";
        string graphTitleYear = "";

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
                var transactionsHistories = await db.TransactionHistories.GroupBy(transaction => transaction.CreateAt.Year).Select(g => new
                {
                    Year = g.Key,
                    TotalRevenue = g.Where(transaction => transaction.Subject.SubjectType == 1).Sum(transaction => transaction.Price),
                    TotalExpense = g.Where(transaction => transaction.Subject.SubjectType == 2).Sum(transaction => transaction.Price)
                }).ToListAsync();

                var totalRevenue = transactionsHistories.Select(transaction => transaction.TotalRevenue);
                var totalExpense = transactionsHistories.Select(transaction => transaction.TotalExpense);
                var years = transactionsHistories.Select(transaction => transaction.Year.ToString());

                await JSRuntime.InvokeVoidAsync("sideBar");
                await RenderGraph(years, totalRevenue, totalExpense);
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

        private async Task Search()
        {
            SingsiamdbContext db = new SingsiamdbContext();
            IQueryable<TransactionHistory> transactionsQuery = db.TransactionHistories;
            List<int> totalRevenue;
            List<int> totalExpense;
            List<string> xLabels;

            if (selectedBranch != null)
            {
                transactionsQuery = db.TransactionHistories.Where(transaction => transaction.BranchId == selectedBranch.Id);
                graphTitle = $"รายรับ - รายจ่าย สาขา {selectedBranch.BranchName}";
            }

            if (selectedYear != 0)
            {
                var transactions = await transactionsQuery
                    .Where(transaction => transaction.CreateAt.Year == selectedYear)
                    .GroupBy(transaction => transaction.CreateAt.Month).Select(g => new
                    {
                        Month = g.Key,
                        TotalRevenue = g.Where(transaction => transaction.Subject.SubjectType == 1).Sum(transaction => transaction.Price),
                        TotalExpense = g.Where(transaction => transaction.Subject.SubjectType == 2).Sum(transaction => transaction.Price)
                    }).ToListAsync();

                // Fill empty months with TotalRevenue = 0 and TotalExpense = 0
                for (int month = 1; month <= 12; month++)
                {
                    if (!transactions.Any(p => p.Month == month))
                    {
                        transactions.Add(new
                        {
                            Month = month,
                            TotalRevenue = 0,
                            TotalExpense = 0
                        });
                    }
                }

                transactions = transactions.OrderBy(transaction => transaction.Month).ToList();

                totalRevenue = transactions.Select(transaction => transaction.TotalRevenue).ToList();
                totalExpense = transactions.Select(transaction => transaction.TotalExpense).ToList();
                xLabels = transactions.Select(transaction => helper.MonthNumberToText(transaction.Month)).ToList();

                graphTitleYear = $"ปี {selectedYear + 543}";
            }
            else
            {
                var transactions = await transactionsQuery.GroupBy(transaction => transaction.CreateAt.Year).Select(g => new
                {
                    Year = g.Key,
                    TotalRevenue = g.Where(transaction => transaction.Subject.SubjectType == 1).Sum(transaction => transaction.Price),
                    TotalExpense = g.Where(transaction => transaction.Subject.SubjectType == 2).Sum(transaction => transaction.Price)
                }).ToListAsync();

                totalRevenue = transactions.Select(transaction => transaction.TotalRevenue).ToList();
                totalExpense = transactions.Select(transaction => transaction.TotalExpense).ToList();
                xLabels = transactions.Select(transaction => transaction.Year.ToString()).ToList();
            }

            await RenderGraph(xLabels, totalRevenue, totalExpense);
        }

        private async Task ResetSearch()
        {
            graphTitle = "รายรับ - รายจ่าย";
            graphTitleYear = "";
            selectedBranch = null;
            selectedYear = 0;
            await Search();
        }

        private async Task RenderGraph(IEnumerable<string> labels, IEnumerable<int> totalRevenue, IEnumerable<int> totalExpense)
        {
            await JSRuntime.InvokeVoidAsync("barchart", labels, "รายรับ", totalRevenue, "รายจ่าย", totalExpense);
        }

        private string YearToString(int value)
        {
            if (value == 0) return "ไม่ระบุปี";
            return value.ToString();
        }
    }
}
