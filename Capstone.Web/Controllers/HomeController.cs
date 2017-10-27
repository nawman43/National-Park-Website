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
            List<ParkModel> parks = dal.AllParks();
            return View("Home", parks);
        }

        public ActionResult Detail(string id)
        {
            {
                ParkModel park = dal.GetPark(id);
                park.Weather = dal.GetWeather(id);
                return View("Detail", park);
            }

        }

        //public ActionResult ConvertCelcius()
        //{

        //}
    }
}

//Convert Fahrenheit to Celcius by subtracting 32 & MULTIPLY BY .5556