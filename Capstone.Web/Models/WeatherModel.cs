using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Capstone.Web.Models;

namespace Capstone.Web.Models
{
    public class WeatherModel
    {
        public string ParkCode { get; set; }
        public int FiveDayForcastValue { get; set; }
        public int Low { get; set; }
        public int High { get; set; }
        public string Forecast { get; set; }
        //public bool Fahrenheit { get; set; }
        //public bool Celcius { get; set; }

        public static double ConvertCelcius(double temp)
        {
            double c = 5.0 / 9.0 * (temp - 32);

            return c;
        }

    }
}