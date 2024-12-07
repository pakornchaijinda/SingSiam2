using System;
using System.Collections.Generic;

namespace AutoGenReports.Models
{
    public partial class Customer
    {
        public Customer()
        {
            BlackLists = new HashSet<BlackList>();
            Externalars = new HashSet<Externalar>();
            Guarantors = new HashSet<Guarantor>();
            Periodtrans = new HashSet<Periodtran>();
            Promises = new HashSet<Promise>();
            ReceiptdescCancles = new HashSet<ReceiptdescCancle>();
            Receiptdescs = new HashSet<Receiptdesc>();
            ReceipttranCancles = new HashSet<ReceipttranCancle>();
            Receipttrans = new HashSet<Receipttran>();
        }

        public int CustomerId { get; set; }
        public string NatId { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public DateTime Bdate { get; set; }
        public string Religion { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string CardCreate { get; set; } = null!;
        public string CardExprite { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Job { get; set; } = null!;
        public string? JobAddress { get; set; }
        public string? LocationLink { get; set; }
        public string? ManRef { get; set; }
        public string? ManRelation { get; set; }
        public string? ManPhone { get; set; }
        public string? OrtherDebt { get; set; }
        public int BranchId { get; set; }
        public string? CusImg { get; set; }
        public int? Status { get; set; }

        public virtual Branch Branch { get; set; } = null!;
        public virtual ICollection<BlackList> BlackLists { get; set; }
        public virtual ICollection<Externalar> Externalars { get; set; }
        public virtual ICollection<Guarantor> Guarantors { get; set; }
        public virtual ICollection<Periodtran> Periodtrans { get; set; }
        public virtual ICollection<Promise> Promises { get; set; }
        public virtual ICollection<ReceiptdescCancle> ReceiptdescCancles { get; set; }
        public virtual ICollection<Receiptdesc> Receiptdescs { get; set; }
        public virtual ICollection<ReceipttranCancle> ReceipttranCancles { get; set; }
        public virtual ICollection<Receipttran> Receipttrans { get; set; }
    }
}
