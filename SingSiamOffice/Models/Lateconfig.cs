using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models;

public partial class Lateconfig
{
    public short Id { get; set; }

    public double? Rangefrom { get; set; }

    public double? Rangeto { get; set; }

    public double? Amount { get; set; }

    public double? FIntpc { get; set; }

    public double? LIntpc { get; set; }
}
