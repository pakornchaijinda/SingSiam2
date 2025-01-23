using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models.SingSiamOld2;

public partial class ZzRepRawPcv
{
    public string? Tdate { get; set; }

    public string? TdateFormat { get; set; }

    public string? PromiseNo { get; set; }

    public string? Branch { get; set; }

    public string BranchName { get; set; } = null!;

    public string? PromiseDate { get; set; }

    public int? PromisePeriod { get; set; }

    public string? RefCode { get; set; }

    public string? Product { get; set; }

    public string? Pname { get; set; }

    public int? Ptype { get; set; }

    public string? Customer { get; set; }

    public string? CusName { get; set; }

    public string? Telephone { get; set; }

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

    public string? Insurance1 { get; set; }

    public string? InsName1 { get; set; }

    public string? InsTel1 { get; set; }
}
