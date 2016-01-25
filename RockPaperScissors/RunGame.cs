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
                            Console.WriteLine("Player chose rock, AI chose scissor.");
                            display.displayWin();
                            player.getScore();
                            player.logHighScore();
                            break;
                        case "paper":
                            Console.WriteLine("Player chose rock, AI chose paper.");
                            display.displayLoss();
                            break;
                        case "rock":
                            Console.WriteLine("Player chose rock, AI chose rock.");
                            display.displayDraw();
                            break;
                        case "spock":
                            Console.WriteLine("Player chose rock, AI chose spock.");
                            display.displayLoss();
                            break;
                        case "lizard":
                            Console.WriteLine("Player chose rock, AI chose lizard.");
                            display.displayWin();
                            player.getScore();
                            player.logHighScore();
                            break;
                    }
                    break;
                case Player.choices.Paper:
                    switch (ai.getAIchoice())
                    {
                        case "scissor":
                            Console.WriteLine("Player chose paper, AI chose scissor.");
                            display.displayLoss();
                            break;
                        case "paper":
                            Console.WriteLine("Player chose paper, AI chose paper.");
                            display.displayDraw();
                            break;
                        case "rock":
                            Console.WriteLine("Player chose paper, AI chose rock.");
                            display.displayWin();
                            player.getScore();
                            player.logHighScore();
                            break;
                        case "spock":
                            Console.WriteLine("Player chose paper, AI chose spock.");
                            display.displayWin();
                            player.getScore();
                            player.logHighScore();
                            break;
                        case "lizard":
                            Console.WriteLine("Player chose paper, AI chose lizard.");
                            display.displayLoss();
                            break;
                    }
                    break;
                case Player.choices.Scissor:
                    switch (ai.getAIchoice())
                    {
                        case "scissor":
                            Console.WriteLine("Player chose scissor, AI chose scissor.");
                            display.displayDraw();
                            break;
                        case "paper":
                            Console.WriteLine("Player chose scissor, AI chose paper.");
                            display.displayWin();
                            player.getScore();
                            player.logHighScore();
                            break;
                        case "rock":
                            Console.WriteLine("Player chose scissor, AI chose rock.");
                            display.displayLoss();
                            break;
                        case "spock":
                            Console.WriteLine("Player chose scissor, AI chose spock.");
                            display.displayLoss();
                            break;
                        case "lizard":
                            Console.WriteLine("Player chose scissor, AI chose lizard.");
                            display.displayWin();
                            player.getScore();
                            player.logHighScore();
                            break;
                    }
                    break;
                case Player.choices.Spock:
                    switch (ai.getAIchoice())
                    {
                        case "scissor":
                            Console.WriteLine("Player chose spock, AI chose scissor.");
                            display.displayWin();
                            player.getScore();
                            player.logHighScore();
                            break;
                        case "paper":
                            Console.WriteLine("Player chose spock, AI chose paper.");
                            display.displayLoss();
                            break;
                        case "rock":
                            Console.WriteLine("Player chose spock, AI chose rock.");
                            display.displayWin();
                            player.getScore();
                            player.logHighScore();
                            break;
                        case "spock":
                            Console.WriteLine("Player chose spock, AI chose spock.");
                            display.displayDraw();
                            break;
                        case "lizard":
                            Console.WriteLine("Player chose spock, AI chose lizard.");
                            display.displayLoss();
                            break;
                    }
                    break;
                case Player.choices.Lizard:
                    switch (ai.getAIchoice())
                    {
                        case "scissor":
                            Console.WriteLine("Player chose lizard, AI chose scissor.");
                            display.displayLoss();
                            break;
                        case "paper":
                            Console.WriteLine("Player chose lizard, AI chose paper.");
                            display.displayWin();
                            player.getScore();
                            player.logHighScore();
                            break;
                        case "rock":
                            Console.WriteLine("Player chose lizard, AI chose rock.");
                            display.displayLoss();
                            break;
                        case "spock":
                            Console.WriteLine("Player chose lizard, AI chose spock.");
                            display.displayWin();
                            player.getScore();
                            player.logHighScore();
                            break;
                        case "lizard":
                            Console.WriteLine("Player chose lizard, AI chose lizard.");
                            display.displayDraw();
                            break;
                    }
                    break;
            }
        }
    }
}
