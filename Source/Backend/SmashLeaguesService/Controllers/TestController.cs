using System;
using System.Web.Http;
using Microsoft.Azure.Mobile.Server.Config;

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

        [HttpGet, Route("api/Test/RandomNumber")]
        public int GetLuckyNumber()
        {
            Random random = new Random();
            return random.Next();
        }
    }
}
