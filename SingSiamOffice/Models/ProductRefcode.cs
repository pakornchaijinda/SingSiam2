using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models;

public partial class ProductRefcode
{
    public int BranchId { get; set; }

    public int? RefcodeV { get; set; }

    public int? RefcodeNvCar { get; set; }

    public int? RefcodeNvLand { get; set; }

    public int? RefcodeNvBook { get; set; }

    public virtual Branch Branch { get; set; } = null!;
}
