using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models.SingSiamOld2;

public partial class ZzRaw4Cpv
{
    public string? Tdate { get; set; }

    public string? TdateFormat { get; set; }

    public string? PromiseNo { get; set; }

    public string? Branch { get; set; }

    public string BranchName { get; set; } = null!;

    public string? RefCode { get; set; }

    public string? Product { get; set; }

    public string? Pname { get; set; }

    public int? Ptype { get; set; }

    public string? Customer { get; set; }

    public int? Period { get; set; }

    public int? Periods { get; set; }

    public double? Capital { get; set; }

    public double? Interest { get; set; }

    public double? Service { get; set; }

    public double? Insurance { get; set; }

    public double? Amount { get; set; }

    public double? CapPaid { get; set; }

    public double? IntPaid { get; set; }

    public double? Srvpaid { get; set; }

    public double? Inspaid { get; set; }

    public double? PaidAmount { get; set; }
}
