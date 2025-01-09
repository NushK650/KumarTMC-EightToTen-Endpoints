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
        [Route("hard/{guessnum}")]
        public string hard (string guessnum)
        {
            return _guessItService.hard(guessnum);
        }

        [HttpGet]
        [Route("medium/{guessnum}")]
        public string  medium (string guessnum)
        {
            return _guessItService.medium(guessnum);
        }

        [HttpGet]
        [Route("easy/{guessnum}")]
        public string easy(string guessnum)
        {
            return _guessItService.easy(guessnum);
        }
        
    }
}