using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models;

public partial class Externalar
{
    public int Id { get; set; }

    public DateTime Tdate { get; set; }

    public string? Docno { get; set; }

    public int CustomerId { get; set; }

    public string? Tdesc { get; set; }

    public double? Aramount { get; set; }

    public double? Paidamount { get; set; }

    public int LoginId { get; set; }

    public string? Clientno { get; set; }

    public int Flg { get; set; }

    public bool? PaidComplete { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Login Login { get; set; } = null!;
}
