using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models.SingSiamOld;

public partial class Userreport
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Menucode { get; set; }

    public int? Allow { get; set; }
}
