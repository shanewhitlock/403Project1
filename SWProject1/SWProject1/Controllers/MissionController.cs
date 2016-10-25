using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SWProject1.Controllers
{
    public class MissionController : Controller
    {
        // GET: Mission
        public ActionResult Index()
        {
            List<string> missions = new List<string>();
            missions.Add("Jamaica, Kingston");
            missions.Add("Idaho, Boise");
            missions.Add("Utah, Provo South");
            ViewBag.Missions = new SelectList(missions);
            return View();
        }

        public ViewResult CategoryChosen(string Missions)
        {
            ViewBag.mission = Missions;
            return View("CategoryChosen");
        }

        
    }
}