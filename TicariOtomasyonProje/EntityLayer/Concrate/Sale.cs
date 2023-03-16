using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Sale
    {
        [Key]
        public int SaleID { get; set; }
        //public Date PurchaseDate { get; set; }
        public int SaleQuantity { get; set; } //Satın alma miktarı
        public int SalePrice { get; set; } //adet fiyatı
        public int SaleAmount { get; set; } //toplam miktar


       // public ICollection<Book> Books { get; set; }
      


        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }


        public int? PersonelID { get; set; }
        public virtual Personnel Personnel { get; set; }



    }
}
