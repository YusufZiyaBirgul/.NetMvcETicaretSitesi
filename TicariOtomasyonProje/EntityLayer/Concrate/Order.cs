using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        
        public int OrderNo { get; set; }

        [StringLength(20)]
        public string OrderStatus { get; set; }



        
        public int BookID { get; set; }
        public virtual Book book { get; set; }




        

        public int CustomerID { get; set; }
        public virtual Customer customer { get; set; }


    }
}
