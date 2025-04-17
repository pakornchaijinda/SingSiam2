using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models.SingSiamOld;

public partial class ZzRaw6Cm
{
    public int Id { get; set; }

    public string? PromiseNo { get; set; }

    public int? TaxPromise { get; set; }

    public string? Customer { get; set; }

    public string? ClientBranch { get; set; }

    public string BranchName { get; set; } = null!;

    public int? Ptype { get; set; }

    public string? RefCode { get; set; }

    public string? Product { get; set; }

    public string? Pname { get; set; }

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

    public int? MinPeriod { get; set; }

    public int? MaxPeriod { get; set; }

    public double? AllCapPaid { get; set; }

    public double? AllIntPaid { get; set; }

    public double? AllLoanPlus { get; set; }

    public double? AllLoanMinus { get; set; }

    public double? AllSrvPaid { get; set; }

    public double? AllInsPaid { get; set; }
}
