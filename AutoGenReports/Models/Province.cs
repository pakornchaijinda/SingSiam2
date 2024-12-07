using System;
using System.Collections.Generic;

namespace AutoGenReports.Models
{
    public partial class Province
    {
        public Province()
        {
            Branches = new HashSet<Branch>();
            Promises = new HashSet<Promise>();
        }

        public int Id { get; set; }
        public string ProvinceName { get; set; } = null!;
        public string ProvinceShortTh { get; set; } = null!;
        public string ProvinceShortEn { get; set; } = null!;
        public bool? IsActive { get; set; }

        public virtual ICollection<Branch> Branches { get; set; }
        public virtual ICollection<Promise> Promises { get; set; }
    }
}
