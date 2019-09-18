using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Haazri.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {        
        [HttpPost("/signup")]
        public ActionResult<string> Signup(string id, string password)
        {
            return "inside singup method";
        }

        [HttpGet("/login")]
        public ActionResult<string> Login(string id, string password)
        {
            return "inside login method";
        }
    }
}
