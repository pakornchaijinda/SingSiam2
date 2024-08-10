using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models;

public partial class Closeconfig
{
    public short Id { get; set; }

    public double? Rangefrom { get; set; }

    public double? Rangeto { get; set; }

    public double? Amount { get; set; }
}
