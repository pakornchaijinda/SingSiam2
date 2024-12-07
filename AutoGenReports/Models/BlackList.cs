using System;
using System.Collections.Generic;

namespace AutoGenReports.Models
{
    public partial class BlackList
    {
        public int BlackId { get; set; }
        public int CustomerId { get; set; }
        public string Detial { get; set; } = null!;
        public DateTime CreateTime { get; set; }

        public virtual Customer Customer { get; set; } = null!;
    }
}
