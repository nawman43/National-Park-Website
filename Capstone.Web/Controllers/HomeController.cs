using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone.Web.Models;
using Capstone.Web.DAL;

namespace Capstone.Web.Controllers
{
    public class HomeController : Controller
    {
        private IParkDAL dal;

        public HomeController(IParkDAL dal)
        {
            this.dal = dal;
        }
        
        public ActionResult Home()
        {
            ParkDAL dal = new ParkDAL();
            List<ParkModel> parks = dal.AllParks();
            return View("Home" , parks);
        }

        public ActionResult Detail(string id)
        {
            ParkModel park = dal.GetPark(id);
            park.Weather = dal.GetWeather(id);            
            return View("Detail", park);

        }

        public ActionResult Survey()
        {
            return View("Survey");
        }

        [HttpPost]
        public ActionResult Survey(SurveyModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Survey", model);
            }
            else
            {
               return RedirectToAction("Result");
            }            
        }

        public ActionResult Result()
        {
            return View("Result");
        }
    }
}