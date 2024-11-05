using Microsoft.AspNetCore.Components;

namespace SingSiamOffice.Pages.Report
{
    public partial class ReportPortal
    {
        [Inject]
        NavigationManager navigation { get; set; }



        private void bankreport()
        {
            navigation.NavigateTo("/bank-report");
        }
        private void branchexpensereport()
        {
            navigation.NavigateTo("/branchexpense-report");
        }
        private void conclusionreport()
        {
            navigation.NavigateTo("/conclusion-report");
        }
        private void expensesreport()
        {
            navigation.NavigateTo("/expenses-report");
        }
        private void moneycountreport()
        {
            navigation.NavigateTo("/moneycount-report");
        }
        private void montlyIncomereport()
        {
            navigation.NavigateTo("/montlyIncome-report");
        }
        private void transferreport()
        {
            navigation.NavigateTo("/transfer-report");
        }
    }
}
