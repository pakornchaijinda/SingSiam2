using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models.SingSiamOld;

public partial class Logfile202503
{
    public int Id { get; set; }

    public string? Branch { get; set; }

    public string? Usercode { get; set; }

    public DateTime? Tdatetime { get; set; }

    public string? Tdate { get; set; }

    public string? Tdateformat { get; set; }

    public string? Section { get; set; }

    public string? Action { get; set; }

    public string? Tdesc { get; set; }
}
