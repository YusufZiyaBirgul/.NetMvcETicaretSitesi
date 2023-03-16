using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Purchase
    {
        [Key]
        public int PurchaseID { get; set; }
        
        //public Date PurchaseDate { get; set; }
        public int PurchaseQuantity { get; set; } //Satın alma miktarı
        public int PurchasePrice { get; set; } //adet fiyatı
        public int PurchaseAmount { get; set; } //toplam miktar


        //public ICollection<Book> Books { get; set; }


        public int PersonelID { get; set; }
        public virtual Personnel Personnel { get; set; }




    }
}
