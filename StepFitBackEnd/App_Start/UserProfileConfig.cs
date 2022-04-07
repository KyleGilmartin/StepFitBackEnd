using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using StepFitBackEnd.Models;

namespace StepFitBackEnd.App_Start
{
    public class UserProfileConfig : EntityTypeConfiguration<UserProfileModel>
    {
        public UserProfileConfig(): base()
        {
            HasKey(p => p.UserName);
            ToTable("UserProfile");
        }
    }
}