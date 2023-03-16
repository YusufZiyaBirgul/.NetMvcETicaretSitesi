using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TicariOtomasyonProje.Controllers
{
    public class PersonnelDetailsController : Controller
    {
        PersonnelManager pm = new PersonnelManager(new EFPersonnelDal());
        [Authorize(Roles ="A")]
        public ActionResult Profile(string p)
        {
            Context c = new Context();
           
            p = (string)Session["PersonelName"];
            var personelId=c.Personnels.Where(x=>x.PersonelName==p).Select(y=>y.PersonelID).FirstOrDefault();
            var personelValues = pm.GetListByPeronelId(personelId);
            return View(personelValues);
        }

        public ActionResult UpdateInfo()
        {
            return View();
        }
    }
}