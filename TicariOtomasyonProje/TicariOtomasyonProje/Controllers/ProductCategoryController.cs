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
    public class ProductCategoryController : Controller
    {
        ProductManager pm = new ProductManager(new EFProductDal());
        CustomerManager cm = new CustomerManager(new EFCustomerDal());
        CategoryManager cat = new CategoryManager(new EFCategoryDal());
        PublisherManager pub = new PublisherManager(new EFPublisherDal());
        AuthorManager aut = new AuthorManager(new EFAuthorDal());
       

        SalePageModel spm = new SalePageModel();
        Context c = new Context();
        // GET: ProductCategory
       
        public ActionResult Index(int id)
        {
            spm.Book = c.Books.Where(x => x.CategoryID == id).ToList();
            spm.Category = cat.GetListById(id);
            return View(spm);

            /*
                        foreach (var item in c.Books)
                        {
                            var count = item.BookID;
                            ViewBag.count = c.Books.Where(x => x.BookID == 1).Count();
                        }*/

        }
        public ActionResult PublisherList(int id)
        {
            spm.Book = c.Books.Where(x => x.PublisherID == id).ToList();
           
            spm.Publisher = pub.GetListByID(id);
            return View(spm);

        }
        public ActionResult AuthorList(int id)
        {
            spm.Book = c.Books.Where(x => x.AuthorID == id).ToList();
           
            spm.Author = aut.GetListById(id);
            return View(spm);

        }

    /*public JsonResult SearchBox(string Search)
        {
            if (Search=="Id")
            {
                try
                {
                    var value=c.Books.Where(x=>x.BookID==IDependencyResolver ||)
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }*/
    }
}