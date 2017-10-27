using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone.Web.Models;
using Capstone.Web.DAL;

namespace Capstone.Web.Controllers
{
    public class SurveyController : Controller
    {
        private IParkDAL dal;

        public SurveyController(IParkDAL dal)
        {
            this.dal = dal;
        }

        [HttpGet]
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
                dal.NewSurvey(model);
                return RedirectToAction("Result");
            }
        }

        public ActionResult Result()
        {
            List<SurveyModel> model = dal.SurveyResults();

            return View("Result",model);
        }
    }
}