using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KumarTMC_EightToTen_Endpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace KumarTMC_EightToTen_Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Magic8BallController : ControllerBase
    {
                private readonly Magic8BallService _magic8BallService;

        public Magic8BallController(Magic8BallService magic8BallService)
        {
            _magic8BallService = magic8BallService;
        }

        
        

        [HttpGet]
        [Route("Magic8Ball/{input}")]
        public string Magic8Ball(string input)

        {
            return _magic8BallService.Magic8Ball(input);
        }

    }
}