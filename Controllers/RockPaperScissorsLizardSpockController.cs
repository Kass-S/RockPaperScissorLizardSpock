using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RockPaperScissorLizardSpock.Services;

namespace RockPaperScissorLizardSpock.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RockPaperScissorsLizardSpockController : ControllerBase
    {
        private readonly RockPaperScissorsLizardSpockServices _rockPaperScissorsLizardSpockServices;
        public RockPaperScissorsLizardSpockController(RockPaperScissorsLizardSpockServices rockPaperScissorsLizardSpockServices){
            _rockPaperScissorsLizardSpockServices = rockPaperScissorsLizardSpockServices;
        }

        [HttpGet]
        [Route("PlayRPSLS")]
        public string PlayGame()
        {
            return _rockPaperScissorsLizardSpockServices.PlayGame();
        }
    }
}