using System;
using System.Collections.Generic;

namespace AutoGenReports.Models
{
    public partial class RunningNo
    {
        public string CurrentNo { get; set; } = null!;
        public string? NextNo { get; set; }
        public string? Type { get; set; }
        public int? BranchId { get; set; }
    }
}
