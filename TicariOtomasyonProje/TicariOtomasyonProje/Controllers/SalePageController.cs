using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicariOtomasyonProje.Models;

namespace TicariOtomasyonProje.Controllers
{
    [AllowAnonymous]
    public class SalePageController : Controller
    {
        ProductManager pm = new ProductManager(new EFProductDal());
        CustomerManager cm = new CustomerManager(new EFCustomerDal());
        CategoryManager cat = new CategoryManager(new EFCategoryDal());
        PublisherManager pub = new PublisherManager(new EFPublisherDal());
        AuthorManager aut = new AuthorManager(new EFAuthorDal());
        ContactManager con = new ContactManager(new EFContactDal());
        MessageManager mm = new MessageManager(new EFMessageDal());
        SalePageModel spm = new SalePageModel();



        Context c = new Context();
        // GET: SalePage
        public ActionResult Product()
        {
            var productValue = pm.GetBookList();
            return View(productValue);
        }

        public ActionResult Deneme(string p)
        {

            spm.Book = pm.GetBookList();
            spm.Category = cat.GetCategoryList();
            //var productValue = pm.GetBookList();
            return View(spm);
        }



        public ActionResult SonDeneme(Contact p)
        {
            /* foreach (var item in c.Books)
             {
                 var count = item.BookID;
                 ViewBag.count = c.Books.Where(x => x.BookID == count).Count();
             }*/


            spm.Book = pm.GetBookList();
            spm.Category = cat.GetCategoryList();

            spm.Publisher = pub.GetPublisherList();
            spm.Author = aut.GetAuthorList();


            // var productValue = pm.GetBookList();

            return View(spm);

        }

        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Contact p)
        {
            con.ContactAdd(p);
            return RedirectToAction("sondeneme", "salepage");
        }

        public ActionResult AddBasket()
        {
            return View();
        }

    }
}