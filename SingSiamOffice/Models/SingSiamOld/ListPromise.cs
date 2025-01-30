using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models.SingSiamOld;

public partial class ListPromise
{
    public DateTime? Tdatetime { get; set; }

    public string? Customer { get; set; }

    public string? Type { get; set; }

    public string? Refcode { get; set; }

    public string? Name { get; set; }

    public string? Promiseno { get; set; }

    public double? Capital { get; set; }

    public double? Amount { get; set; }

    public string? Code { get; set; }

    public string? BranchName { get; set; }

    public int? Status { get; set; }
}
