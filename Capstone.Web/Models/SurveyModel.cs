using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capstone.Web.Models
{
    public class SurveyModel
    {        
        [Required(ErrorMessage = "Enter your email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress (ErrorMessage ="Enter a valid email")]
        public string Email { get; set; }       
        public string ParkName { get; set; }
        public string StateOfResidence { get; set; }
        public string Activity { get; set; }
        public string FavPark { get; set; }
        public List<SurveyModel> SurveyResults { get; set; } = new List<SurveyModel>();
        public int total { get; set; }

        public static List<SelectListItem> States = new List<SelectListItem>()
    {
        new SelectListItem() {Text="Alabama", Value="AL"},
        new SelectListItem() { Text="Alaska", Value="AK"},
        new SelectListItem() { Text="Arizona", Value="AZ"},
        new SelectListItem() { Text="Arkansas", Value="AR"},
        new SelectListItem() { Text="California", Value="CA"},
        new SelectListItem() { Text="Colorado", Value="CO"},
        new SelectListItem() { Text="Connecticut", Value="CT"},
        new SelectListItem() { Text="District of Columbia", Value="DC"},
        new SelectListItem() { Text="Delaware", Value="DE"},
        new SelectListItem() { Text="Florida", Value="FL"},
        new SelectListItem() { Text="Georgia", Value="GA"},
        new SelectListItem() { Text="Hawaii", Value="HI"},
        new SelectListItem() { Text="Idaho", Value="ID"},
        new SelectListItem() { Text="Illinois", Value="IL"},
        new SelectListItem() { Text="Indiana", Value="IN"},
        new SelectListItem() { Text="Iowa", Value="IA"},
        new SelectListItem() { Text="Kansas", Value="KS"},
        new SelectListItem() { Text="Kentucky", Value="KY"},
        new SelectListItem() { Text="Louisiana", Value="LA"},
        new SelectListItem() { Text="Maine", Value="ME"},
        new SelectListItem() { Text="Maryland", Value="MD"},
        new SelectListItem() { Text="Massachusetts", Value="MA"},
        new SelectListItem() { Text="Michigan", Value="MI"},
        new SelectListItem() { Text="Minnesota", Value="MN"},
        new SelectListItem() { Text="Mississippi", Value="MS"},
        new SelectListItem() { Text="Missouri", Value="MO"},
        new SelectListItem() { Text="Montana", Value="MT"},
        new SelectListItem() { Text="Nebraska", Value="NE"},
        new SelectListItem() { Text="Nevada", Value="NV"},
        new SelectListItem() { Text="New Hampshire", Value="NH"},
        new SelectListItem() { Text="New Jersey", Value="NJ"},
        new SelectListItem() { Text="New Mexico", Value="NM"},
        new SelectListItem() { Text="New York", Value="NY"},
        new SelectListItem() { Text="North Carolina", Value="NC"},
        new SelectListItem() { Text="North Dakota", Value="ND"},
        new SelectListItem() { Text="Ohio", Value="OH"},
        new SelectListItem() { Text="Oklahoma", Value="OK"},
        new SelectListItem() { Text="Oregon", Value="OR"},
        new SelectListItem() { Text="Pennsylvania", Value="PA"},
        new SelectListItem() { Text="Rhode Island", Value="RI"},
        new SelectListItem() { Text="South Carolina", Value="SC"},
        new SelectListItem() { Text="South Dakota", Value="SD"},
        new SelectListItem() { Text="Tennessee", Value="TN"},
        new SelectListItem() { Text="Texas", Value="TX"},
        new SelectListItem() { Text="Utah", Value="UT"},
        new SelectListItem() { Text="Vermont", Value="VT"},
        new SelectListItem() { Text="Virginia", Value="VA"},
        new SelectListItem() { Text="Washington", Value="WA"},
        new SelectListItem() { Text="West Virginia", Value="WV"},
        new SelectListItem() { Text="Wisconsin", Value="WI"},
        new SelectListItem() { Text="Wyoming", Value="WY"}
    };

        public static List<SelectListItem> Parks = new List<SelectListItem>()
        {
             new SelectListItem() {Text="Cuyahoga Valley", Value ="CVNP" },
             new SelectListItem() {Text="Everglades",Value="ENP" },
             new SelectListItem() {Text="Grand Canyon",Value="GCNP" },
             new SelectListItem() {Text="Glacier",Value ="GNP" },
             new SelectListItem() {Text="Great Smokey Mountains",Value="GSMNP"},
             new SelectListItem() {Text="Grand Teton",Value="GTNP" },
             new SelectListItem() {Text="Mount Rainer",Value="MRNP"},
             new SelectListItem() {Text="Rocky Mountain",Value="RMNP"},
             new SelectListItem() {Text="Yellowstone",Value="YNP"},
             new SelectListItem() {Text="Yosemite",Value="YNP2"}
        };

        public static List<SelectListItem> TypesOfActivity = new List<SelectListItem>()
        {
            new SelectListItem() {Text="Extremely Active",Value="Extremely Active"},
            new SelectListItem() {Text="Active",Value="Active"},
            new SelectListItem() {Text="Sedentary",Value="Sedentary"},
            new SelectListItem() {Text="Inactive",Value="Inactive"},
        };
    }

}
