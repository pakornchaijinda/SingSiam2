using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models.SingSiamOld2;

public partial class Insurance
{
    public sbyte Id { get; set; }

    public double? Rangefrom { get; set; }

    public double? Rangeto { get; set; }

    public double? Amount { get; set; }
}
