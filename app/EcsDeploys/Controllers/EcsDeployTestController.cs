using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EcsDeploys.Controllers
{
    [Route("test")]
    [ApiController]
    public class EcsDeployTestController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        [Route("{status}")]
        public IActionResult Get(int status)
        {
            return StatusCode(status);
        }
    }
}
