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
    public class CustomerLoginController : Controller
    {
        // GET: CustomerLogin
        CustomerManager cm = new CustomerManager(new EFCustomerDal());

        //[HttpGet]
        /* public ActionResult Login()
         {
             return View();
         }

         [HttpPost]
         public ActionResult Login(Customer p)
         {
             Context c = new Context();
             var user = c.Customers.FirstOrDefault(x => x.CustomerName == p.CustomerName && x.CAddressID == p.CAddressID);
             if (user != null)
             {
                 FormsAuthentication.SetAuthCookie(user.CustomerName, false);
                 Session["CustomerName"] = user.CustomerName;
                 return RedirectToAction("Deneme", "SalePage");
             }
             else
             {
                 return RedirectToAction("Login");
             }

         }*/

        public ActionResult Login(string p)
        {
              Context c = new Context();
              p = (string)Session["CustomerName"];
              var user = c.Customers.Where(x => x.CustomerName == p).Select(y => y.CustomerID).FirstOrDefault();
              var values = cm.GetListById(user);
              return View(values);
        }



        [HttpGet]
        public ActionResult DenemeLog()
        {
            
            return View();
        }
        Context c = new Context();

        [HttpPost]
        public ActionResult DenemeLog(Customer p)
        {
            
            var user = c.Customers.FirstOrDefault(x => x.CustomerName == p.CustomerName && x.CustomerPassword == p.CustomerPassword);
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(user.CustomerName, false);
                Session["CustomerName"] = user.CustomerName.ToString();
                return RedirectToAction("Deneme", "SalePage");
            }
           
                return RedirectToAction("Index","AdminLogin");
            
        }




        [HttpGet]
        public ActionResult RegisterV3()
        {
            return View();
        }



        [HttpPost]
        public ActionResult RegisterV3(Customer c)
        {
            if (ModelState.IsValid)
            {
                cm.CustomerAdd(c);
                return RedirectToAction("DenemeLog");
            }

            else
            {
                return View();
            }
        }

    }
}