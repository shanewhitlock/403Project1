/******************************
 * Nathan Barton
 * Henrique Bronovski
 * Brian Marchant
 * Shane Whitlock
 * 
 * THIS IS THE AWESOME PROJECT!!!!!
 * Choose a mission and get data about the mission
 * ************************/
using SWProject1.DAL;
using SWProject1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SWProject1.Controllers
{
    public class MissionController : Controller
    {
        private MissionContext db = new MissionContext();
        // GET: Mission
        // this will populate the dropdown list
        public ActionResult Index()
        {
            List<string> missions = new List<string>();
            missions.Add("Jamaica, Kingston");
            missions.Add("Idaho, Boise");
            missions.Add("Canada, Toronto");
            ViewBag.Missions = new SelectList(missions);
            return View();
        }

        

        // This get's the selected mission an will give the SQL query to give 
        //us the correct data
        public ViewResult CategoryChosen(string Missions)
        {
            string inputID = "0";
            if (Missions == "Idaho, Boise")
            {
                inputID = "3";
            }
            else if (Missions == "Canada, Toronto")
            {
                inputID = "2";
            }
            else if (Missions == "Jamaica, Kingston")
            {
                inputID = "1";
            }

            //This is the list of mission data that we will return in the views
            IEnumerable<NewMission> mission =
     db.Database.SqlQuery<NewMission>(
    "Select Mission.MissionID, Mission.Climate, Mission.DominantReligion, Mission.PresID, Mission.MissionName, Mission.MissionHomeAddress, President.PresFirstName, Mission.CountryID, President.PresLastName, President.WifeFirstName, President.WifeLastName, Country.Language " +
    "FROM Mission INNER JOIN President ON President.PresID = Mission.PresID INNER JOIN Country ON Country.CountryID = Mission.CountryID " +
    "WHERE Mission.MissionID = "+ inputID + ";");
            //mission name
            ViewBag.mission = Missions;
            //the image for the mission
            ViewBag.image = "/Content/Images/" + inputID + ".jpg";
            //return data
            return View(mission);
        }

        //gives a full list of all missions
        public ActionResult GetData()
        {
            IEnumerable<NewMission> mission =
     db.Database.SqlQuery<NewMission>(
    "Select Mission.MissionID, Mission.Climate, Mission.DominantReligion, Mission.PresID, Mission.MissionName, Mission.MissionHomeAddress, President.PresFirstName, Mission.CountryID, President.PresLastName, President.WifeFirstName, President.WifeLastName, Country.Language " +
    "FROM Mission INNER JOIN President ON President.PresID = Mission.PresID INNER JOIN Country ON Country.CountryID = Mission.CountryID " +
    ";");
            return View(mission);
        }

        
    }
}