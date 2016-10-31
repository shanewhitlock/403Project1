using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SWProject1.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        //our about page. populate list
        public void Index()
        {
            List<string> aboutList = new List<string>();
            aboutList.Add("Update Info");
            aboutList.Add("Support Ticket");
            aboutList.Add("Ask Us");
            aboutList.Add("Request a Mission");
            ViewBag.AboutList = new SelectList(aboutList);
           
        }
        //return the mission data.
        public ViewResult QuestionCategory(string AboutList)
        {
            ViewBag.question = AboutList;
            return View("CategoryChosen");
        }

    }
}