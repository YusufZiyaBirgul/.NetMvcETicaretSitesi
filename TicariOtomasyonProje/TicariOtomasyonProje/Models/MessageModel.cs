using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicariOtomasyonProje.Models
{
    public class MessageModel
    {
        public IEnumerable<Message> message { get; set; }
        public IEnumerable<Contact> contact { get; set; }

    }
}