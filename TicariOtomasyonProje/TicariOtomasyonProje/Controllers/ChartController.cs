using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicariOtomasyonProje.Models;

namespace TicariOtomasyonProje.Controllers
{[AllowAnonymous]
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Category()
        {
            return View();
        }
        Context c = new Context();
        
        public ActionResult ChartCategory()
        {
            return Json(kategori() , JsonRequestBehavior.AllowGet);
        }
        public List<CategoryChart> kategori()
        {
            List<CategoryChart> cs = new List<CategoryChart>();
           
            cs = c.Books.Select(x => new CategoryChart
            {

                BN = x.BookName,
                BP = x.Inverntory

            }).ToList();
           
            
            return cs;
        }
    }
}