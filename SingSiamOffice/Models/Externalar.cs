using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models;

public partial class Externalar
{
    public int Id { get; set; }

    public string? Tdate { get; set; }

    public string? Tdateformat { get; set; }

    public string? Branch { get; set; }

    public string? Docno { get; set; }

    public string? Customer { get; set; }

    public string? Tdesc { get; set; }

    public double? Aramount { get; set; }

    public double? Paidamount { get; set; }

    public string? Usercode { get; set; }

    public string? Clientno { get; set; }

    public int? Flg { get; set; }
}
