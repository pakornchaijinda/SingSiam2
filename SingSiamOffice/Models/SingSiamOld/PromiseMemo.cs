using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models.SingSiamOld;

public partial class PromiseMemo
{
    public int Id { get; set; }

    public string? Promiseno { get; set; }

    public string? Branch { get; set; }

    public string? Refcode { get; set; }

    public string? Tdate { get; set; }

    public string? Tdateformat { get; set; }

    public string? Descrip { get; set; }

    public string? Remark { get; set; }

    public double? Amount { get; set; }

    public string? Usercode { get; set; }
}
