using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicariOtomasyonProje.Models
{
    public class CategoryChart
    {

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public int? BP { get; set; }
        public string BN { get; set; }
    }
}