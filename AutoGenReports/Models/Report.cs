using System;
using System.Collections.Generic;

namespace AutoGenReports.Models
{
    public partial class Report
    {
        public long ReportId { get; set; }
        public int BranchId { get; set; }
        public int ReportType { get; set; }
        public string JsonData { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
    }
}
