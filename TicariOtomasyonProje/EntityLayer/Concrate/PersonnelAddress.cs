using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
   public class PersonnelAddress
    {
        [Key]
        public int PAddressID { get; set; }

        [StringLength(100)]
        public string AddressDetails { get; set; }

       // public ICollection<Personnel> Personnels { get; set; }
       

    }
}
