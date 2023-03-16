using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicariOtomasyonProje.Models;

namespace TicariOtomasyonProje.Controllers
{
    [AllowAnonymous]
    public class BuyPageController : Controller
    {
        ProductManager pm = new ProductManager(new EFProductDal());
        // GET: BuyPage
        SalePageModel spm = new SalePageModel();

        public ActionResult Buy()
        {
            return View();
        }


        public ActionResult Deneme(int id)
        {
            /*
            Context c = new Context();
            p = (string)Session["BookName"];
            var user = c.Books.Where(x => x.BookName == p).Select(y => y.BookID).FirstOrDefault();
            var values = pm.GetByID(user);
            return View(values);*/

            //int id;
            //var result = pm.GetListByID(id);
            //return View(result);
           

            spm.Book = pm.GetListByID(id);
            return View(spm);
        }

        public ActionResult SameCategory(int cId)
        {

            Context c = new Context();
            var category = c.Books.Where(x=>x.CategoryID==cId);

            return View();
        }

    }
}