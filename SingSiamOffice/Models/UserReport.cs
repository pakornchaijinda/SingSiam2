using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models;

public partial class UserReport
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Menucode { get; set; }

    public int? Allow { get; set; }
}
