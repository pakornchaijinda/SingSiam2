using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models;

public partial class Branch
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;
}
