using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models.SingSiamOld2;

public partial class Periodtran
{
    public int Id { get; set; }

    public string? Promiseno { get; set; }

    public int? Taxpromise { get; set; }

    public int? Specialtaxpromise { get; set; }

    public string? Branch { get; set; }

    public string? Refcode { get; set; }

    public int? Ptype { get; set; }

    public string? Customer { get; set; }

    public int? Period { get; set; }

    public int? Periods { get; set; }

    public string? Tdate { get; set; }

    public string? Tdateformat { get; set; }

    public double? Capital { get; set; }

    public double? Interest { get; set; }

    public double? Service { get; set; }

    public double? Insurance { get; set; }

    public double? Amount { get; set; }

    public double? Cappaid { get; set; }

    public double? Intpaid { get; set; }

    public double? Paidamount { get; set; }

    public int? Status { get; set; }

    public string? Usercode { get; set; }

    public string? Clientno { get; set; }

    public double? Deposit { get; set; }

    public double? Loanplus { get; set; }

    public double? Loanminus { get; set; }

    public double? Srvpaid { get; set; }

    public double? Inspaid { get; set; }
}
