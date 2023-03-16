using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntityLayer.Concrate;

namespace TicariOtomasyonProje.Models
{
    public class ProductModel
    {

        public IEnumerable<Book> Book { get; set; }
        public IEnumerable<Customer> Customer { get; set; }
        public IEnumerable<Publisher> Publisher { get; set; }
        public IEnumerable<Author> Author { get; set; }
        public IEnumerable<Category> Category { get; set; }


    }
}