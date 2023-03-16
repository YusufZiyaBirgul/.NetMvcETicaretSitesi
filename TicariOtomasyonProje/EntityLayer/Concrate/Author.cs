using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Author
    {
        [Key]
        public int AuthorID { get; set; }

        [StringLength(30)]
        public string AuthorName { get; set; }

        [StringLength(30)]
        public string AuthorSurname { get; set; }


        public ICollection<Book> Books { get; set; }


    }
}
