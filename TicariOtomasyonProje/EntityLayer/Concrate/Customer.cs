using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [StringLength(30)]
        public string CustomerName { get; set; }

        [StringLength(30)]
        public string CustomerSurname { get; set; }

        [StringLength(10)]
        public string CustomerPassword { get; set; }


        /*public int CAddressID { get; set; }
        public virtual CustomerAddress CustomerAddress { get; set; }*/

        public ICollection<Order> Orders { get; set; }

    }
}
