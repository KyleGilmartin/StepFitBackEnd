using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StepFitBackEnd.Models
{
    public class UserProfileModel : ApplicationUser
    {
        public string ProfileImage { get; set; }
    }
}