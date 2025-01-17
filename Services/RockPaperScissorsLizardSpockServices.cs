using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock.Services
{
    public class RockPaperScissorsLizardSpockServices
    {
        public string PlayGame()
        {
            Random rng = new Random();
            int CPUChoice = rng.Next(5);
            string[] CPUArr = ["rock", "paper", "scissors", "lizard", "spock"];
            return CPUArr[CPUChoice];
        }
    }
}