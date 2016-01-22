using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            RunGame rungame = new RunGame();
            rungame.RunThroughGame();
            Console.ReadLine();
        }
    }
}
