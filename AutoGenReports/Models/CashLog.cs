using System;
using System.Collections.Generic;

namespace AutoGenReports.Models
{
    public partial class CashLog
    {
        public int LogId { get; set; }
        public int BranchId { get; set; }
        public DateTime DateCreate { get; set; }
        public int? Log1000 { get; set; }
        public int? Log500 { get; set; }
        public int? Log100 { get; set; }
        public int? Log50 { get; set; }
        public int? Log20 { get; set; }
        public int? Log10 { get; set; }
        public int? Log5 { get; set; }
        public int? Log2 { get; set; }
        public int? Log1 { get; set; }

        public virtual Branch Branch { get; set; } = null!;
    }
}
