using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models;

public partial class Customer
{
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

    public virtual ICollection<BlackList> BlackLists { get; set; } = new List<BlackList>();

    public virtual Branch Branch { get; set; } = null!;

    public virtual ICollection<Externalar> Externalars { get; set; } = new List<Externalar>();

    public virtual ICollection<Guarantor> Guarantors { get; set; } = new List<Guarantor>();

    public virtual ICollection<Periodtran> Periodtrans { get; set; } = new List<Periodtran>();

    public virtual ICollection<Promise> Promises { get; set; } = new List<Promise>();

    public virtual ICollection<ReceiptdescCancle> ReceiptdescCancles { get; set; } = new List<ReceiptdescCancle>();

    public virtual ICollection<Receiptdesc> Receiptdescs { get; set; } = new List<Receiptdesc>();

    public virtual ICollection<ReceipttranCancle> ReceipttranCancles { get; set; } = new List<ReceipttranCancle>();

    public virtual ICollection<Receipttran> Receipttrans { get; set; } = new List<Receipttran>();
}
