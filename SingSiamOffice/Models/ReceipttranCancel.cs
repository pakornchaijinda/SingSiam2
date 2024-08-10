using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models;

public partial class ReceipttranCancel
{
    public int Id { get; set; }

    public string? Promiseno { get; set; }

    public int? Taxpromise { get; set; }

    public int? Specialtaxpromise { get; set; }

    public string? Branch { get; set; }

    public int? Ptype { get; set; }

    public string? Customer { get; set; }

    public string? Receiptno { get; set; }

    public string? Receiptdesc { get; set; }

    public string? Tdate { get; set; }

    public string? Tdateformat { get; set; }

    public string? Tdatecal { get; set; }

    public string? Tdatecalformat { get; set; }

    public double? Amount { get; set; }

    public double? Deposit { get; set; }

    public double? Charge1amt { get; set; }

    public double? Charge2amt { get; set; }

    public double? Arbalance { get; set; }

    public int? Arperiod { get; set; }

    public double? Cappaid { get; set; }

    public double? Intpaid { get; set; }

    public double? Arremain { get; set; }

    public double? Capremain { get; set; }

    public double? Intremain { get; set; }

    public double? Closefee { get; set; }

    public double? Intdiscamt { get; set; }

    public int? Periodremain { get; set; }

    public double? Intplus { get; set; }

    public double? Discount { get; set; }

    public double? Netamount { get; set; }

    public double? Resultamount { get; set; }

    public string? Usercode { get; set; }

    public string? Clientno { get; set; }

    public int? Cashpaid { get; set; }

    public int? Transferpaid { get; set; }

    public string? Transferdate { get; set; }

    public int? Otherpaid { get; set; }

    public string? Clientbranch { get; set; }

    public double? Loanplus { get; set; }

    public double? Loanminus { get; set; }

    public double? Oldint { get; set; }

    public double? Newint { get; set; }

    public int? Periodchg { get; set; }

    public double? Srvpaid { get; set; }

    public double? Inspaid { get; set; }

    public int? Currentperiod { get; set; }

    public string? Closecase { get; set; }
}
