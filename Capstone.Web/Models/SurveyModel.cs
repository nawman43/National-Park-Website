using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Capstone.Web.Models
{
    public class SurveyModel
    {
        [Required(ErrorMessage = "Enter your email")]
        public string Email { get; set; }

        public string StateOfResidence { get; set; }
        public string Activity { get; set; }
        public string FavPark { get; set; }
    }
}