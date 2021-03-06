﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Web.Models;

namespace Capstone.Web.DAL
{
   public interface IParkDAL
    {
        List<ParkModel> AllParks();
        ParkModel GetPark(string parkCode);
        List<WeatherModel> GetWeather(string parkCode);
        void NewSurvey(SurveyModel s);
        List<SurveyModel> SurveyResults();
    }
}
