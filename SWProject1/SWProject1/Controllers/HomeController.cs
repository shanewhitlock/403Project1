using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// hello this is abstract comment

namespace SWProject1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public void List()
        {
            List<string> aboutList = new List<string>();
            aboutList.Add("Update Info");
            aboutList.Add("Support Ticket");
            aboutList.Add("Ask Us");
            aboutList.Add("Request a Mission");
            ViewBag.AboutList = new SelectList(aboutList);
        }
    }
}