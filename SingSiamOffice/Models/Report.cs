using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models;

public partial class Report
{
    public long ReportId { get; set; }

    public int BranchId { get; set; }

    public int ReportType { get; set; }

    public string JsonData { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public string? TransactionDate { get; set; }
}
