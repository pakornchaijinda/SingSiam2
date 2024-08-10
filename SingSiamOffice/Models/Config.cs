using System;
using System.Collections.Generic;

namespace SingSiamOffice.Models;

public partial class Config
{
    public int Id { get; set; }

    public string? Orgname { get; set; }

    public string? Orgaddress { get; set; }

    public string? Orgtelfax { get; set; }

    public string? Signname { get; set; }

    public double? Servicecharge { get; set; }

    public int? Asktime { get; set; }

    public double? Askamt { get; set; }

    public double? Askpc { get; set; }

    public int? Followtime { get; set; }

    public double? Followamt { get; set; }

    public double? Followpc { get; set; }

    public int? Hurrytime { get; set; }

    public double? Hurryamt { get; set; }

    public double? Hurrypc { get; set; }

    public int? Daylate { get; set; }

    public int? Paymethod { get; set; }

    public int? Loanservins { get; set; }

    public int? Editfee { get; set; }

    public int? Loancreate { get; set; }

    public int? Maxins { get; set; }

    public int? Externalar { get; set; }

    public int? Arbranch { get; set; }

    public int? Closeedit { get; set; }

    public double? Taxrate { get; set; }

    public string? Taxid { get; set; }

    public string? Ftphost { get; set; }

    public string? Ftppath { get; set; }

    public string? Ftpuser { get; set; }

    public string? Ftppass { get; set; }

    public string? Wwwpath { get; set; }

    public double? Specialtaxrate { get; set; }

    public double? Localtaxrate { get; set; }

    public int? Disablemanual { get; set; }

    public int? Loancontrol { get; set; }

    public int? AddonMemo { get; set; }

    public int? DataMore { get; set; }

    public int? Latecap { get; set; }

    public int? Cutflat { get; set; }
}
