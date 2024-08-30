﻿using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models;

public partial class TransactionHistory
{
    public int TransactionId { get; set; }

    public int Price { get; set; }

    /// <summary>
    /// เงินสด 1 เงินโอน 2
    /// </summary>
    public int PaymentMethod { get; set; }

    public int BranchId { get; set; }

    public string? Detial { get; set; }

    public int LoginId { get; set; }

    public DateTime CreateAt { get; set; }

    public int SubjectId { get; set; }

    public string TransectionRef { get; set; } = null!;

    public string? SlipUrl { get; set; }

    public int? TransectionIdRef { get; set; }

    public bool? ConfirmTransection { get; set; }

    public int? ReceiopttranId { get; set; }

    public virtual Branch Branch { get; set; } = null!;

    public virtual Login Login { get; set; } = null!;

    public virtual Receipttran? Receiopttran { get; set; }

    public virtual SubjectCost Subject { get; set; } = null!;

    public virtual ICollection<TransectionSlip> TransectionSlips { get; set; } = new List<TransectionSlip>();
}
