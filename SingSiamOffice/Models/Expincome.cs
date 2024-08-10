using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models;

public partial class Expincome
{
    public int Id { get; set; }

    public string? Branch { get; set; }

    public string? Tdate { get; set; }

    public string? Tdateformat { get; set; }

    public string? Docno { get; set; }

    public string? Accno { get; set; }

    public string? Tdesc { get; set; }

    public double? Income { get; set; }

    public double? Expense { get; set; }

    public string? Promiseno { get; set; }

    public string? Usercode { get; set; }

    public string? Clientno { get; set; }
}
