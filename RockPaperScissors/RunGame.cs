using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RunGame
    {
        Scissor scissor;
        Paper paper;
        Rock rock;
        Spock spock;
        Lizard lizard;
        Player player;
        AI ai;
        Display display;

        public RunGame()
        {
            scissor = new Scissor("Scissor");
            paper = new Paper("Paper");
            rock = new Rock("Rock");
            spock = new Spock("Spock");
            lizard = new Lizard("Lizard");
            player = new Player();
            ai = new AI();
            display = new Display();
        }

        public void RunThroughGame()
        {
            switch (player.getUserInput())
            {
                case Player.choices.Rock:
                    switch (ai.getAIchoice())
                    {
                        case "scissor":
                            Console.WriteLine("player chose rock, AI chose scissor.");
                            display.displayWin();
                            break;
                        case "paper":
                            Console.WriteLine("player chose rock, AI chose paper.");
                            display.displayLoss();
                            break;
                        case "rock":
                            Console.WriteLine("player chose rock, AI chose rock.");
                            display.displayDraw();
                            break;
                        case "spock":
                            Console.WriteLine("player chose rock, AI chose spock.");
                            display.displayLoss();
                            break;
                        case "lizard":
                            Console.WriteLine("player chose rock, AI chose lizard.");
                            display.displayWin();
                            break;
                    }
                    break;
                case Player.choices.Paper:
                    switch (ai.getAIchoice())
                    {
                        case "scissor":
                            Console.WriteLine("player chose paper, AI chose scissor.");
                            display.displayLoss();
                            break;
                        case "paper":
                            Console.WriteLine("player chose paper, AI chose paper.");
                            display.displayDraw();
                            break;
                        case "rock":
                            Console.WriteLine("player chose paper, AI chose rock.");
                            display.displayWin();
                            break;
                        case "spock":
                            Console.WriteLine("player chose paper, AI chose spock.");
                            display.displayWin();
                            break;
                        case "lizard":
                            Console.WriteLine("player chose paper, AI chose lizard.");
                            display.displayLoss();
                            break;
                    }
                    break;
                case Player.choices.Scissor:
                    switch (ai.getAIchoice())
                    {
                        case "scissor":
                            Console.WriteLine("player chose scissor, AI chose scissor.");
                            display.displayDraw();
                            break;
                        case "paper":
                            Console.WriteLine("player chose scissor, AI chose paper.");
                            display.displayWin();
                            break;
                        case "rock":
                            Console.WriteLine("player chose scissor, AI chose rock.");
                            display.displayLoss();
                            break;
                        case "spock":
                            Console.WriteLine("player chose scissor, AI chose spock.");
                            display.displayLoss();
                            break;
                        case "lizard":
                            Console.WriteLine("player chose scissor, AI chose lizard.");
                            display.displayWin();
                            break;
                    }
                    break;
                case Player.choices.Spock:
                    switch (ai.getAIchoice())
                    {
                        case "scissor":
                            Console.WriteLine("player chose spock, AI chose scissor.");
                            display.displayWin();
                            break;
                        case "paper":
                            Console.WriteLine("player chose spock, AI chose paper.");
                            display.displayLoss();
                            break;
                        case "rock":
                            Console.WriteLine("player chose spock, AI chose rock.");
                            display.displayWin();
                            break;
                        case "spock":
                            Console.WriteLine("player chose spock, AI chose spock.");
                            display.displayDraw();
                            break;
                        case "lizard":
                            Console.WriteLine("player chose spock, AI chose lizard.");
                            display.displayLoss();
                            break;
                    }
                    break;
                case Player.choices.Lizard:
                    switch (ai.getAIchoice())
                    {
                        case "scissor":
                            Console.WriteLine("player chose lizard, AI chose scissor.");
                            display.displayLoss();
                            break;
                        case "paper":
                            Console.WriteLine("player chose lizard, AI chose paper.");
                            display.displayWin();
                            break;
                        case "rock":
                            Console.WriteLine("player chose lizard, AI chose rock.");
                            display.displayLoss();
                            break;
                        case "spock":
                            Console.WriteLine("player chose lizard, AI chose spock.");
                            display.displayWin();
                            break;
                        case "lizard":
                            Console.WriteLine("player chose lizard, AI chose lizard.");
                            display.displayDraw();
                            break;
                    }
                    break;
            }
        }
    }
}
