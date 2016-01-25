using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Display
    {
        public void displayLoss()
        {
            Console.WriteLine("Player 1, you lose!");
        }
        public void displayWin()
        {
            Console.WriteLine("Player 1, you win!");
        }
        public void displayDraw()
        {
            Console.WriteLine("It's a draw.");
        }
    }
}
