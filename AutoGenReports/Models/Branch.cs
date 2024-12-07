using System;
using System.Collections.Generic;

namespace AutoGenReports.Models
{
    public partial class Branch
    {
        public Branch()
        {
            CashLogs = new HashSet<CashLog>();
            Customers = new HashSet<Customer>();
            Logins = new HashSet<Login>();
            Periodtrans = new HashSet<Periodtran>();
            Promises = new HashSet<Promise>();
            ReceiptdescCancles = new HashSet<ReceiptdescCancle>();
            Receiptdescs = new HashSet<Receiptdesc>();
            ReceipttranCancles = new HashSet<ReceipttranCancle>();
            Receipttrans = new HashSet<Receipttran>();
            TransactionHistories = new HashSet<TransactionHistory>();
        }

        public int Id { get; set; }
        public string BranchName { get; set; } = null!;
        public string? BranchCode { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public bool IsActive { get; set; }
        public string? NoBlank { get; set; }
        public string? Province { get; set; }
        public string? BranchMap { get; set; }
        public string? BlankType { get; set; }
        public DateTime? CreateAt { get; set; }
        public int? ProvinceId { get; set; }
        public int? Promiseno { get; set; }
        public int? Refcode { get; set; }
        public int? Receipt { get; set; }
        public int? Accdocno { get; set; }
        public int? Arpaidno { get; set; }
        public string? Code { get; set; }

        public virtual Province? ProvinceNavigation { get; set; }
        public virtual ICollection<CashLog> CashLogs { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Login> Logins { get; set; }
        public virtual ICollection<Periodtran> Periodtrans { get; set; }
        public virtual ICollection<Promise> Promises { get; set; }
        public virtual ICollection<ReceiptdescCancle> ReceiptdescCancles { get; set; }
        public virtual ICollection<Receiptdesc> Receiptdescs { get; set; }
        public virtual ICollection<ReceipttranCancle> ReceipttranCancles { get; set; }
        public virtual ICollection<Receipttran> Receipttrans { get; set; }
        public virtual ICollection<TransactionHistory> TransactionHistories { get; set; }
    }
}
