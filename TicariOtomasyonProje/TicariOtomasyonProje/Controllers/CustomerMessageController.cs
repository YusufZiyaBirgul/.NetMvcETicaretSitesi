using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TicariOtomasyonProje.Controllers
{
    public class CustomerMessageController : Controller
    {
        MessageManager mm = new MessageManager(new EFMessageDal());

        public ActionResult ReciverInbox(string p)
        {
            var messageValue = mm.GetMessageListInbox(p);
            return View(messageValue);

        }
    }
}