using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Personnel
    {
        [Key]
        public int PersonelID { get; set; }

        [StringLength(50)]
        public string PersonelName { get; set; }

        [StringLength(50)]
        public string PersonelSurname { get; set; }

        [StringLength(10)]
        public string PersonelPassword { get; set; }
        [StringLength(1)]
        public string PersonelRole { get; set; }

        public int PersonelTC { get; set; }

        public string AddressDetails { get; set; }
        public string PersonelEducation { get; set; }
        public string PersonelSkils { get; set; }
        public string PersonelNotes { get; set; }
        public string PersonelJob { get; set; }

        /*
                public int PAddressID { get; set; }
                public virtual PersonnelAddress PersonnelAddress { get; set; }*/


        // public ICollection<Personnel> Personnels { get; set; }

    }
}
