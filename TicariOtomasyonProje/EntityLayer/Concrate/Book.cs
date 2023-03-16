using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
   public class Book
    {
        [Key]
        public int BookID { get; set; }

        [StringLength(30)]
        public string BookName { get; set; }

        public int Inverntory { get; set; } //Stok
        public int PurchasePrice { get; set; } //Alış
        public int SalePrice { get; set; } //Satış
       
        // [StringLength(30)]
       // public string PublisherName { get; set; } //Yayınevi
       
        
        //[StringLength(30)]
        //public string Category { get; set; }

        [StringLength(150)]
        public string BookImage { get; set; }


        public int PublisherID { get; set; }
        public virtual Publisher Publisher { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public int AuthorID { get; set; }
        public virtual Author Author { get; set; }

        public ICollection<Order> Orders { get; set; }




        /* public int PurchaseID { get; set; }
         public virtual Purchase Purchase { get; set; }

         public int SaleID { get; set; }
         public virtual Sale Sale { get; set; }
         */


    }
}
