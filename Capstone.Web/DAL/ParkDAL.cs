using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Capstone.Web.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace Capstone.Web.DAL
{
    public class ParkDAL : IParkDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ParkWebsiteDB"].ConnectionString;
        private const string SQL_AllParks = "Select * From park";
        private const string SQL_SinglePark = "Select park.*,weather.* From park Join weather on weather.parkCode = park.parkCode where weather.parkCode = @parkCode";
        private const string SQL_Weather = "Select * From weather Where weather.parkCode = @weather";

        public List<ParkModel> AllParks()
        {
            List<ParkModel> parks = new List<ParkModel>();

            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SQL_AllParks, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ParkModel singlePark = new ParkModel();
                        singlePark.ParkCode = Convert.ToString(reader["parkCode"]);
                        singlePark.ParkName = Convert.ToString(reader["parkName"]);
                        singlePark.State = Convert.ToString(reader["state"]);
                        singlePark.Acreage = Convert.ToInt32(reader["acreage"]);
                        singlePark.EleveationInFeet = Convert.ToInt32(reader["elevationInFeet"]);
                        singlePark.MilesOfTrail = Convert.ToInt32(reader["milesOfTrail"]);
                        singlePark.NumbereOfCampsites = Convert.ToInt32(reader["numberOfCampsites"]);
                        singlePark.Climate = Convert.ToString(reader["climate"]);
                        singlePark.YearFounded = Convert.ToInt32(reader["yearFounded"]);
                        singlePark.AnnualVisitorCount = Convert.ToInt32(reader["annualVisitorCount"]);
                        singlePark.InspirationalQuote = Convert.ToString(reader["inspirationalQuote"]);
                        singlePark.QuoteSource = Convert.ToString(reader["inspirationalQuoteSource"]);
                        singlePark.ParkDescription = Convert.ToString(reader["parkDescription"]);
                        singlePark.EntryrFee = Convert.ToInt32(reader["entryFee"]);
                        singlePark.NumberOfAnimalSpecies = Convert.ToInt32(reader["numberOfAnimalSpecies"]);
                        parks.Add(singlePark);
                        
                    }
                }
            }
            catch
            {
                throw;
            }
            return parks;
        }

        public ParkModel GetPark(string id)
        {
            ParkModel singlePark = new ParkModel();
            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SQL_SinglePark, conn);
                    cmd.Parameters.AddWithValue("@parkCode", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        
                        singlePark.ParkCode = Convert.ToString(reader["parkCode"]);
                        singlePark.ParkName = Convert.ToString(reader["parkName"]);
                        singlePark.State = Convert.ToString(reader["state"]);
                        singlePark.Acreage = Convert.ToInt32(reader["acreage"]);
                        singlePark.EleveationInFeet = Convert.ToInt32(reader["elevationInFeet"]);
                        singlePark.MilesOfTrail = Convert.ToInt32(reader["milesOfTrail"]);
                        singlePark.NumbereOfCampsites = Convert.ToInt32(reader["numberOfCampsites"]);
                        singlePark.Climate = Convert.ToString(reader["climate"]);
                        singlePark.YearFounded = Convert.ToInt32(reader["yearFounded"]);
                        singlePark.AnnualVisitorCount = Convert.ToInt32(reader["annualVisitorCount"]);
                        singlePark.InspirationalQuote = Convert.ToString(reader["inspirationalQuote"]);
                        singlePark.QuoteSource = Convert.ToString(reader["inspirationalQuoteSource"]);
                        singlePark.ParkDescription = Convert.ToString(reader["parkDescription"]);
                        singlePark.EntryrFee = Convert.ToInt32(reader["entryFee"]);
                        singlePark.NumberOfAnimalSpecies = Convert.ToInt32(reader["numberOfAnimalSpecies"]);
                        singlePark.FiveDayForcastValue = Convert.ToInt32(reader["fiveDayForecastValue"]);
                        singlePark.Low = Convert.ToInt32(reader["low"]);
                        singlePark.High = Convert.ToInt32(reader["high"]);
                        singlePark.Forecast = Convert.ToString(reader["forecast"]);
                       
                    }

                    
                }
            }
            catch
            {
                throw;
            }
            return singlePark;
        }

        public List<WeatherModel> GetWeather(string id)
        {
            List<WeatherModel> allWeather = new List<WeatherModel>();
            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SQL_Weather, conn);
                    cmd.Parameters.AddWithValue("@weather", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        WeatherModel weather = new WeatherModel();
                        weather.ParkCode = Convert.ToString(reader["parkCode"]);
                        weather.FiveDayForcastValue = Convert.ToInt32(reader["fiveDayForecastValue"]);
                        weather.Low = Convert.ToInt32(reader["low"]);
                        weather.High = Convert.ToInt32(reader["high"]);
                        weather.Forecast = Convert.ToString(reader["forecast"]);
                        allWeather.Add(weather);
                    }    
                }
            }
            catch
            {
                throw;
            }
            return allWeather;
        }
    }
}