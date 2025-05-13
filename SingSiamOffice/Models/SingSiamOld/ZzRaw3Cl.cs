using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models.SingSiamOld;

public partial class ZzRaw3Cl
{
    public int Id { get; set; }

    public string? PromiseNo { get; set; }

    public int? TaxPromise { get; set; }

    public string? Customer { get; set; }

    public string? ClientBranch { get; set; }

    public int? Ptype { get; set; }

    public string? RefCode { get; set; }

    public string? Product { get; set; }

    public string? ReceiptNo { get; set; }

    public string? ReceiptDesc { get; set; }

    public string? Tdate { get; set; }

    public string? TdateFormat { get; set; }

    public string? TdateCal { get; set; }

    public string? TdateCalFormat { get; set; }

    public double? Amount { get; set; }

    public double? Deposit { get; set; }

    public double? Charge1Amt { get; set; }

    public double? Charge2Amt { get; set; }

    public double? Closefee { get; set; }

    public double? Intplus { get; set; }

    public double? Discount { get; set; }

    public double? Netamount { get; set; }

    public double? ResultAmount { get; set; }

    public int? CashPaid { get; set; }

    public int? TransferPaid { get; set; }

    public int? OtherPaid { get; set; }

    public int? CurrentPeriod { get; set; }

    public int? Period { get; set; }

    public double? CapPaid { get; set; }

    public double? IntPaid { get; set; }

    public double? Loanplus { get; set; }

    public double? Loanminus { get; set; }

    public double? Srvpaid { get; set; }

    public double? Inspaid { get; set; }
}
