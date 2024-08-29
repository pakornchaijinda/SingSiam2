using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models;

public partial class TransectionSlip
{
    public int TransactionSlipId { get; set; }

    public int TransactionHistoryId { get; set; }

    public string Doc { get; set; } = null!;

    public virtual TransactionHistory TransactionHistory { get; set; } = null!;
}
