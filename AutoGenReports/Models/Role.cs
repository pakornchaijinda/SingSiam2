using System;
using System.Collections.Generic;

namespace AutoGenReports.Models
{
    public partial class Role
    {
        public Role()
        {
            Logins = new HashSet<Login>();
        }

        public int Id { get; set; }
        public string? RoleName { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Login> Logins { get; set; }
    }
}
