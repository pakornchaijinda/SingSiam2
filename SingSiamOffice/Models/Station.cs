using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models;

public partial class Station
{
    public int Id { get; set; }

    public string? Ipaddress { get; set; }

    public string? Macaddress { get; set; }

    public string? Stationno { get; set; }

    public double? Promiseno { get; set; }

    public double? Receiptno { get; set; }

    public double? Addcapno { get; set; }

    public double? Accdocno { get; set; }

    public double? Arpaidno { get; set; }

    public string? Branch { get; set; }

    public int? Taxreceive { get; set; }

    public int? Batchno { get; set; }

    public int? Specialtaxreceive { get; set; }

    public string? Cloudcamera { get; set; }

    public double? Color1 { get; set; }

    public double? Color2 { get; set; }

    public double? Color3 { get; set; }

    public double? Color4 { get; set; }
}
