using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Player 
    {        
        public enum choices { Rock, Paper, Scissor, Lizard, Spock };
        public int score;
        public int highScore;

        public Player()
        {
            score = 0;
            highScore = 0;
        }
        public choices getUserInput()
        {
            Console.WriteLine("Enter 0 for Rock, 1 for Paper, 2 for Scissor, 3 for Lizard, 4 for Spock:");
            choices userInput = (choices)Enum.Parse(typeof(choices), Console.ReadLine());
            return userInput;
        }

        public void getScore()
        {
            score += 1;
            System.IO.StreamWriter file = new System.IO.StreamWriter("score.txt", true);
            file.WriteLine(score);
            file.Close();
        }
        public int logHighScore()
        {
            if (score > highScore)
            {
                highScore = score;
            }
            return highScore;
        }
    }
}
