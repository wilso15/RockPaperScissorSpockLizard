using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class AI
    {
        Scissor scissors = new Scissor("Scissor");
        Paper paper = new Paper("Paper");
        Rock rock = new Rock("Rock");
        Lizard lizard = new Lizard("Lizard");
        Spock spock = new Spock("Spock");

        public string AIchoice;
        public AI()
        {

        }
        public string getAIchoice() 
        {
            Random random = new Random();
            int randChoice = random.Next(1,6);
            switch (randChoice)
            {
                case 1:
                    AIchoice = scissors.Name;
                    break;
                case 2:
                    AIchoice = rock.Name;
                    break;
                default:
                    break;
                case 3:
                    AIchoice = paper.Name;
                    break;
                case 4:
                    AIchoice = lizard.Name;
                    break;
                case 5:
                    AIchoice = spock.Name;
                    break;
            }
            return AIchoice;
        }
    }
}

//"Enter 0 for Rock, 1 for Paper, 2 for Scissor, 3 for Lizard, 4 for Spock: