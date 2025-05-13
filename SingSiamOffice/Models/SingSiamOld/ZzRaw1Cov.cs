using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models.SingSiamOld;

public partial class ZzRaw1Cov
{
    public int Id { get; set; }

    public string? Branch { get; set; }

    public string? Tdate { get; set; }

    public string? TdateFormat { get; set; }

    public string? DocNo { get; set; }

    public string? AccNo { get; set; }

    public string? Tdesc { get; set; }

    public double? Income { get; set; }

    public double? Expense { get; set; }

    public string? PromiseNo { get; set; }
}
