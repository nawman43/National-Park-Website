using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Web.Models
{
    public class ParkModel
    {
        public string ParkCode { get; set; }
        public string ParkName { get; set; }
        public string State { get; set; }
        public int Acreage { get; set; }
        public int EleveationInFeet { get; set; }
        public int MilesOfTrail { get; set; }
        public int NumbereOfCampsites { get; set; }
        public string Climate { get; set; }
        public int YearFounded { get; set; }
        public int AnnualVisitorCount { get; set; }
        public string InspirationalQuote { get; set; }
        public string QuoteSource { get; set; }
        public string ParkDescription { get; set; }
        public int EntryrFee { get; set; }
        public int NumberOfAnimalSpecies { get; set; }
        
        public int FiveDayForcastValue { get; set; }
        public double Low { get; set;}
        public double High { get; set;}
        public string Forecast { get; set;}
        public List<WeatherModel> Weather { get; set; } = new List<WeatherModel>();
        
    }
}