using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Web.Http;
using Microsoft.Azure.Mobile.Server.Config;
using SmashLeaguesService.DataObjects;
using SmashLeaguesService.Models;

namespace SmashLeaguesService.Controllers
{
    [MobileAppController]
    public class TestController : ApiController
    {
        // GET api/Test
        //[HttpGet, Route("api/Test/Message")]
        //public string Get()
        //{
        //    return "Hello from custom controller!";
        //}

        //[HttpGet, Route("api/Test/RandomNumber")]
        //public int GetLuckyNumber()
        //{
        //    Random random = new Random();
        //    return random.Next();
        //}

        [HttpGet, Route("api/Test/GetUser")]
        public User GetUser(string id)
        {
            SmashLeaguesContext ctx = new SmashLeaguesContext();
            var users = ctx.Users.Where(u => u.UserId == id);
            var user = users.FirstOrDefault();
            return user;
        }

        [HttpPost, Route("api/Test/SetUser")]
        public User SetUser(string id, string username)
        {
            SmashLeaguesContext context = new SmashLeaguesContext();
            User user = new User
            {
                Id = Guid.NewGuid().ToString(),
                CreatedAt = DateTimeOffset.UtcNow,
                UserId = id,
                Username = username
            };
            context.Users.Add(user);

            try
            {
                context.SaveChanges();
            }
            catch(DbEntityValidationException e)
            {
                


                foreach(var eve in e.EntityValidationErrors)
                {
                    Trace.TraceError("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach(var ve in eve.ValidationErrors)
                    {
                        Trace.TraceError("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                            ve.PropertyName,
                            eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                            ve.ErrorMessage);
                    }
                }
                throw;
            }
            catch(Exception e)
            {
                Trace.TraceError("User:\n\tId:{0}\n\tCreatedAt:{1}\n\tUserId:{2}\n\tUsername:{3}", user.Id,
                    user.CreatedAt, user.UserId, user.Username);

                throw;
            }
            return user;
        }
    }
}