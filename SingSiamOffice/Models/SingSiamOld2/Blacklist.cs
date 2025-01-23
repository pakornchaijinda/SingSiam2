using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models.SingSiamOld2;

public partial class Blacklist
{
    public int Id { get; set; }

    public string? Cardid { get; set; }

    public string? Name { get; set; }

    public string? Tdesc { get; set; }
}
