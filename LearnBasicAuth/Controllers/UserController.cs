using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnBasicAuth.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private Dictionary<string, string> userRegistered = new Dictionary<string, string>()
        {
            { "user1", "password1" },
            { "user2", "password2" },
            { "user3", "password3" }
        };
        [HttpGet]
        public ActionResult<Dictionary<string, string>> Index()
        {
            return Ok(userRegistered);
        }
    }
}
