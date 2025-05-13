using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models.SingSiamOld;

public partial class ZzRaw4Cav
{
    public string? PromiseNo { get; set; }

    public string? RefCode { get; set; }

    public double? Deposit { get; set; }

    public string? Product { get; set; }

    public string? Branch { get; set; }

    public string BranchName { get; set; } = null!;

    public int? Ptype { get; set; }

    public string? Customer { get; set; }

    public string? Name { get; set; }

    public string? Telephone { get; set; }

    public int? Period { get; set; }

    public int? Periods { get; set; }

    public string? Tdate { get; set; }

    public double? Capital { get; set; }

    public double? Interest { get; set; }

    public double? Amount { get; set; }

    public double? CapPaid { get; set; }

    public double? IntPaid { get; set; }

    public double? SrvPaid { get; set; }

    public double? InsPaid { get; set; }

    public double? PaidAmount { get; set; }
}
