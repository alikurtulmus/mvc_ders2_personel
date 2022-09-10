using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_ders2_personel.Models;


namespace mvc_ders2_personel.Controllers
{
    public class ExperienceController : Controller
    {
        // GET: Experience

        PersonalDbEntities personalDbEntities = new PersonalDbEntities();

        public ActionResult Index()
        {
            var values = personalDbEntities.TblExperiences.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddExperience()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddExperience(TblExperience p)
        {
            personalDbEntities.TblExperiences.Add(p);
            personalDbEntities.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteExperience(int id)
        {
            var values = personalDbEntities.TblExperiences.Where(y => y.ExperienceID == id).FirstOrDefault();
            personalDbEntities.TblExperiences.Remove(values);
            personalDbEntities.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditExperience(int id)
        {
            var values = personalDbEntities.TblExperiences.Where(y => y.ExperienceID == id).FirstOrDefault();
            return View();

        }




    }
}