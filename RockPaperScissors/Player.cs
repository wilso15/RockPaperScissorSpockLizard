using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Player 
    {
        Rock rock;
        
        public enum choices { Rock, Paper, Scissor, Lizard, Spock };

        public Player()
        {

        }
        public choices getUserInput()
        {
            Console.WriteLine("Enter 0 for Rock, 1 for Paper, 2 for Scissor, 3 for Lizard, 4 for Spock:");
            choices userInput = (choices)Enum.Parse(typeof(choices), Console.ReadLine());
            return userInput;
        }
    }
}
