using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models;

public partial class ExternalarDetail
{
    public int Id { get; set; }

    public string? Tdate { get; set; }

    public string? Tdateformat { get; set; }

    public string? Branch { get; set; }

    public string? Docno { get; set; }

    public string? Customer { get; set; }

    public string? Tdesc { get; set; }

    public double? Cutamount { get; set; }

    public string? Usercode { get; set; }
}
