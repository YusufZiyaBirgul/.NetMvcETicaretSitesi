using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TicariOtomasyonProje.Controllers
{ [AllowAnonymous]
    public class AdminCustomerController : Controller
    {
        CustomerManager cm = new CustomerManager(new EFCustomerDal());
        
        // GET: AdminCustomer
        public ActionResult GetCustomerAll()
        {
            
            var customerValue = cm.GetCustomerList();
            return View(customerValue);
        }
    }
}