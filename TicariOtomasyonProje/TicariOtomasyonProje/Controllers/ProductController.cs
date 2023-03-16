using BusinessLayer.Concrete;
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
    public class ProductController : Controller
    {


        ProductModel model = new ProductModel();
        ProductManager pm = new ProductManager(new EFProductDal());
        public ActionResult GetProductList()
        {
            var productValues = pm.GetBookList();
            
            
            return View(productValues);
        }
        
        [HttpGet]
        public ActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBook(Book p)
        {
            pm.BookAdd(p);
            return RedirectToAction("GetProductList");
        }


        public ActionResult DeleteBook(int id)
        {
            var deleteValue = pm.GetByID(id);
            pm.BookDelete(deleteValue);
            return RedirectToAction("GetProductList");
        }

        [HttpGet]
        public ActionResult UpdateBook(int id)
        {
            var updateValue = pm.GetByID(id);
            return View(updateValue);
        }
        [HttpPost]
        public ActionResult UpdateBook(Book p)
        {
            pm.BookUpdate(p);
            return RedirectToAction("GetProductList");
        }
    }
}