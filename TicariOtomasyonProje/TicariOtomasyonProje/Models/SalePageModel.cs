using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicariOtomasyonProje.Models
{
    public class SalePageModel
    {
        public IEnumerable<Book> Book { get; set; }
        public IEnumerable<Customer> Customer { get; set; }
        public IEnumerable<Publisher> Publisher { get; set; }
        public IEnumerable<Author> Author { get; set; }
        public IEnumerable<Category> Category { get; set; }
        public IEnumerable<Contact> Contact { get; set; }
        public IEnumerable<Message> Message { get; set; }
       
    }
}