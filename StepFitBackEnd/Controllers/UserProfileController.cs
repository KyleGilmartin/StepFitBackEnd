using StepFitBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Treblle.Net;

namespace StepFitBackEnd.Controllers
{
    [Treblle]
    [Authorize]
    [Route("API/UserProfile")]
    public class UserProfileController : ApiController
    {
        // GET: api/UserProfile/username
        public string Get(string username)
        {
            using (var context = new UserProfileDBContext())
            {
                var query = context.Users.FirstOrDefault(s => s.UserName == username);
                return query == null ? "" : query.ProfileImage;
            }
        }

        // POST : api/UserProfile
        public IHttpActionResult Post([FromBody] UserProfileModel UserProfile)
        {
            using (var db = new UserProfileDBContext())
            {
                var result = db.Users.SingleOrDefault(b => b.UserName == UserProfile.UserName);
                if(result != null)
                {
                    result.ProfileImage = UserProfile.ProfileImage;
                    db.SaveChanges();
                }
                return Ok();
            }
        }

           
    }
}
