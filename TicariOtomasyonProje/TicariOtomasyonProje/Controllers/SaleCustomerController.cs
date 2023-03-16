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
{[AllowAnonymous]
    public class SaleCustomerController : Controller
    {
        ProductManager pm = new ProductManager(new EFProductDal());
        CustomerManager cm = new CustomerManager(new EFCustomerDal());
        // GET: SaleCustomer
        public ActionResult Index()
        {
            Context c = new Context();

            SalePageModel spm = new SalePageModel();
            spm.Book = pm.GetBookList();
            spm.Author = c.Authors.ToList();

            return View(spm);
        }
    }
}