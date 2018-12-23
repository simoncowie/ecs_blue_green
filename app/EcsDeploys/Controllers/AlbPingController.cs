using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EcsDeploys.Controllers
{
    [Route("ping")]
    [ApiController]
    public class AlbPingController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public IActionResult Ping()
        {
            return Ok("This is fine");
        }

        [Route("500")]
        public IActionResult Ping500()
        {
            return new ContentResult() { 
                StatusCode = 500,
                Content = "This is not okay :-("
            };            
        }
    }
}
