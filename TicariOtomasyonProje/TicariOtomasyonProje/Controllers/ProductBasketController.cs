using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TicariOtomasyonProje.Controllers
{[AllowAnonymous]
    public class ProductBasketController : Controller
    {
        ProductManager pm = new ProductManager(new EFProductDal());
        // GET: ProductBasket
        public ActionResult AddBasket()
        {
            var result = pm.GetBookList();
            return View(result);
        }
    }
}