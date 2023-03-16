using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [StringLength(20)]
        public string CategoryName { get; set; }

       public ICollection<Book> Books { get; set; }





    }
}
