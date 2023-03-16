using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace TicariOtomasyonProje.Controllers
{
    [AllowAnonymous]
    public class AdminLoginController : Controller
    {

        // GET: AdminLogin
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Personnel p)
        {

            Context c = new Context();
            var user = c.Personnels.FirstOrDefault(x => x.PersonelName == p.PersonelName && x.PersonelPassword == p.PersonelPassword);
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(user.PersonelName, false);
                Session["PersonelName"] = user.PersonelName;
                return RedirectToAction("GetCustomerAll", "AdminCustomer");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }




        [HttpGet]
        public ActionResult CusLog()
        {
            return View();
        }


        [HttpPost]
        public ActionResult CusLog(Customer p)
        {

            Context c = new Context();
            var user = c.Customers.FirstOrDefault(x => x.CustomerName == p.CustomerName && x.CustomerPassword == p.CustomerPassword);
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(user.CustomerName, false);
                Session["CustomerName"] = user.CustomerName;
                return RedirectToAction("SonDeneme", "SalePage");
            }
            else
            {
                return RedirectToAction("CusLog");
            }
        }






    }
}