using System.ComponentModel.DataAnnotations.Schema;

namespace SingSiamOffice.Models.SingSiamOld
{

        public partial class Promise
    {
            [NotMapped]
            public string ProductName { get; set; }

        }
    
}
