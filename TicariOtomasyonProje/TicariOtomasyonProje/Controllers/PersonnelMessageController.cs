using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TicariOtomasyonProje.Controllers
{
    public class PersonnelMessageController : Controller
    {
        MessageManager mm = new MessageManager(new EFMessageDal());
        // GET: PersonnelMessage
        public ActionResult Inbox()
        {
            string p = (string)Session["PersonelName"];
            var messageValue = mm.GetMessageListInbox(p);

            return View(messageValue);
        }

        public ActionResult SendBox()
        {
            string p = (string)Session["PersonelName"];
            var messageValue = mm.GetMessageListSendbox(p);
            return View(messageValue);
        }
        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewMessage(Message p)
        {
            mm.messageAdd(p);
            return RedirectToAction("Sendbox");
        }
        public PartialViewResult MessageMenu()
        {
            return PartialView();
        }

        public ActionResult MessageDetails(int id)
        {
            var messageVlaues = mm.GetByID(id);
            return View(messageVlaues);
        }
    }
}