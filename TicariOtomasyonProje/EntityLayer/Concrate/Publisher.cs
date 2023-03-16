using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Publisher
    {
        [Key]
        public int PublisherID { get; set; }

        [StringLength(40)]
        public string PublisherName { get; set; }

        [StringLength(40)]
        public string AuthorizedPerson { get; set; }

        [StringLength(11)]
        public string ContactNumber { get; set; }

        public ICollection<Book> Books { get; set; }


    }
}
