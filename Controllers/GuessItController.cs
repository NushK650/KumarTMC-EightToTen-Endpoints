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
    public class GuessItController : ControllerBase
    {
        private readonly GuessItService _guessItService;

        public GuessItController (GuessItService guessItService)
        {
            _guessItService = guessItService;
        }

        
        

        [HttpGet]
        [Route("GuessIt/{difficulty}/{guessnum}")]
                public string GuessIt(string difficulty, int guessnum)

        {
            return _guessItService.GuessIt(difficulty, guessnum);
        }
    }
}