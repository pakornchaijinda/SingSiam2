using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string? Cardid { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Telephone { get; set; }

    public string? Office { get; set; }

    public string? Officeaddress { get; set; }

    public string? Officetel { get; set; }

    public string? Homemap { get; set; }

    public string? Officemap { get; set; }

    public string? Nickname { get; set; }

    public string? Reference { get; set; }

    public string? Jobdesc { get; set; }

    public string? Cardexpire { get; set; }

    public string? Cardexpireformat { get; set; }

    public string? HomeN { get; set; }

    public string? HomeE { get; set; }

    public string? OfficeN { get; set; }

    public string? OfficeE { get; set; }

    public int? Status { get; set; }

    public double? Arbalance { get; set; }
}
