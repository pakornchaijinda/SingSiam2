using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models;

public partial class Account
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public int? Acctype { get; set; }

    public string? Sumcode { get; set; }
}
