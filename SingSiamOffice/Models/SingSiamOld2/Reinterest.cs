using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models.SingSiamOld2;

public partial class Reinterest
{
    public int Id { get; set; }

    public string? Batchno { get; set; }

    public int? Days { get; set; }

    public string? Tdate { get; set; }

    public string? Tdateformat { get; set; }

    public string? Promiseno { get; set; }

    public string? Refcode { get; set; }

    public string? Customer { get; set; }

    public string? CustomerName { get; set; }

    public double? Oldcapital { get; set; }

    public int? Periods { get; set; }

    public double? Artotal { get; set; }

    public double? Latetotal { get; set; }

    public double? Newcapital { get; set; }

    public double? Newinterest { get; set; }
}
