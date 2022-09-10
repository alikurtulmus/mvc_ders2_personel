using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_ders2_personel.Models;


namespace mvc_ders2_personel.Controllers
{
    public class SkillController : Controller
    {
        // GET: Skill

        PersonalDbEntities personalDbEntities=new PersonalDbEntities();

        public ActionResult Index()
        {
            var values = personalDbEntities.TblSkills.ToList();

            return View(values);
        }


        [HttpGet]

        public ActionResult AddSkill()
        {
            return View();
        }


        [HttpPost]

        public ActionResult AddSkill(TblSkill p)
        {
            personalDbEntities.TblSkills.Add(p);
            personalDbEntities.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSkill(int id)
        {
            var value=personalDbEntities.TblSkills.Where(x => x.SkillID == id).FirstOrDefault();
            personalDbEntities.TblSkills.Remove(value);
            personalDbEntities.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]

        public ActionResult EditSkill(int id)
        {
            var value=personalDbEntities.TblSkills.Where(x=>x.SkillID==id).FirstOrDefault();
            return View(value);
        }


    }
}