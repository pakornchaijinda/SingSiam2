using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models.SingSiamOld2;

public partial class ZzRaw3Cov
{
    public int Id { get; set; }

    public string? PromiseNo { get; set; }

    public string? RefCode { get; set; }

    public string? Branch { get; set; }

    public string BranchName { get; set; } = null!;

    public string? Tdate { get; set; }

    public string? Customer { get; set; }

    public string? Name { get; set; }

    public string? Telephone { get; set; }

    public string? Product { get; set; }

    public string? PrdDesc { get; set; }

    public int? Ptype { get; set; }

    public double? Capital { get; set; }

    public double? IntRate { get; set; }

    public int? Periods { get; set; }

    public double? Amount { get; set; }

    public string? DayPaid { get; set; }

    public string? FirstDate { get; set; }

    public double? ChargeAmt { get; set; }

    public double? Nampa { get; set; }

    public string? DateClose { get; set; }

    public string? CloseDocNo { get; set; }

    public string? CloseCase { get; set; }

    public double? CloseResult { get; set; }

    public double? SumCharge1 { get; set; }

    public double? SumCharge2 { get; set; }
}
