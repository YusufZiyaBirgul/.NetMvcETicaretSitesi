using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TicariOtomasyonProje.Controllers
{[AllowAnonymous]
    public class CustomerContactController : Controller
    {
        ContactManager con = new ContactManager(new EFContactDal());

        //Context c = new Context();
        // GET: CustomerContact
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Contact p)
        {
            con.ContactAdd(p);
            return View();
        }
      
    }
}