using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models;

public partial class ProductRefcode
{
    public int CollateralId { get; set; }

    public int BranchId { get; set; }

    public int? RefcodeV { get; set; }

    public int? RefcodeNv { get; set; }

    public virtual Branch Branch { get; set; } = null!;

    public virtual Collateral Collateral { get; set; } = null!;
}
