using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models;

public partial class ReceiptdescCancel
{
    public int Id { get; set; }

    public string? Promiseno { get; set; }

    public string? Branch { get; set; }

    public int? Ptype { get; set; }

    public string? Customer { get; set; }

    public string? Receiptno { get; set; }

    public string? Tdate { get; set; }

    public string? Tdateformat { get; set; }

    public string? Tdatecal { get; set; }

    public string? Tdatecalformat { get; set; }

    public int? Period { get; set; }

    public string? Perioddate { get; set; }

    public double? Cappaid { get; set; }

    public double? Intpaid { get; set; }

    public double? Amount { get; set; }

    public string? Usercode { get; set; }

    public string? Clientno { get; set; }

    public string? Clientbranch { get; set; }

    public double? Loanplus { get; set; }

    public double? Loanminus { get; set; }

    public double? Oldint { get; set; }

    public double? Newint { get; set; }

    public int? Periodchg { get; set; }

    public double? Deposit { get; set; }

    public double? Chargeamt { get; set; }

    public double? Lateamt { get; set; }

    public double? Srvpaid { get; set; }

    public double? Inspaid { get; set; }
}
