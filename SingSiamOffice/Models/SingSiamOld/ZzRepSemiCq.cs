using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models.SingSiamOld;

public partial class ZzRepSemiCq
{
    public string? PromiseNo { get; set; }

    public string? PromiseDate { get; set; }

    public int? PromisePeriod { get; set; }

    public string? RefCode { get; set; }

    public double? Deposit { get; set; }

    public string? Product { get; set; }

    public string? Pname { get; set; }

    public string? Branch { get; set; }

    public string BranchName { get; set; } = null!;

    public int? Ptype { get; set; }

    public string? Customer { get; set; }

    public string? Name { get; set; }

    public string? Telephone { get; set; }

    public long Period { get; set; }

    public double? AllCap { get; set; }

    public double? AllInt { get; set; }

    public double? AllAmount { get; set; }

    public double? AllCapPaid { get; set; }

    public double? AllIntPaid { get; set; }

    public double? AllSrvPaid { get; set; }

    public double? AllInsPaid { get; set; }

    public double? AllPaid { get; set; }

    public string? Insurance2 { get; set; }

    public string? InsName2 { get; set; }

    public string? InsTel2 { get; set; }
}
