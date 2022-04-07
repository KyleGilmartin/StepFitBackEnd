using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StepFitBackEnd.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace StepFitBackEnd
{
    public class UserProfileDBContext : IdentityDbContext<UserProfileModel>
    {
        public UserProfileDBContext()
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}