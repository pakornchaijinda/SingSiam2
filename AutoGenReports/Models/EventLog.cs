using System;
using System.Collections.Generic;

namespace AutoGenReports.Models
{
    public partial class EventLog
    {
        public Guid Uuid { get; set; }
        public string TableName { get; set; } = null!;
        public string Opertation { get; set; } = null!;
        public int UpdateBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
