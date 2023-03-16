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
    public class PersonnelController : Controller
    {
        PersonnelManager pm = new PersonnelManager(new EFPersonnelDal());

        // GET: Personnel
        //[Authorize(Roles="A")]
        public ActionResult Index()
        {
            return View();
        }

        //[Authorize(Roles = "A")]
        public ActionResult PersonelGetList()
        {
            var personelValues = pm.GetList();
            return View(personelValues);
        }

        [Authorize(Roles = "A")]
        [HttpGet]
        public ActionResult AddPersonnel()
        {
            #region DropDownListFor
            /*List<SelectListItem> valuePersonnel = (from x in pm.GetAll()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.PersonnelAddress.AddressDetails,
                                                      Value = x.PersonnelAddress.PAddressID.ToString()
                                                  }).ToList();
         

            ViewBag.vlc = valuePersonnel;*/
            #endregion


            return View();
        }

        [HttpPost]
        public ActionResult AddPersonnel(Personnel p)
        {
            pm.PersonelInsert(p);
            return RedirectToAction("PersonelGetList");
            //return View();
        }

        [Authorize(Roles = "A")]
        public ActionResult DeletePersonnel(int id)
        {
            var personnelValue = pm.GetByID(id);
            pm.PersonelDelete(personnelValue);
            return RedirectToAction("PersonelGetList");
        }
        [Authorize(Roles = "A")]
        [HttpGet]
        public ActionResult UpdatePersonnel(int id)
        {
            var personnelValue = pm.GetByID(id);
            return View(personnelValue);
        }
        [HttpPost]
        public ActionResult UdpatePersonnel(Personnel p)
        {
            pm.PersonelUpdate(p);
            return RedirectToAction("PersonelGetList");
        }
    
    public ActionResult SweetAlert()
        {
            return View();
        }
    
    
    }
}