using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Display
    {
        public void displayLoss()
        {
            Console.WriteLine("You lose.");
        }
        public void displayWin()
        {
            Console.WriteLine("You win.");
        }
        public void displayDraw()
        {
            Console.WriteLine("It's a draw.");
        }
    }
}
