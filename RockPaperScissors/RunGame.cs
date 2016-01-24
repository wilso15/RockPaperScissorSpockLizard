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
                            Console.WriteLine("You Win!");
                            break;
                        case "paper":
                            Console.WriteLine("player chose rock, AI chose paper.");
                            Console.WriteLine("You Lose!");
                            break;
                        case "rock":
                            Console.WriteLine("player chose rock, AI chose rock.");
                            Console.WriteLine("It's a Tie!");
                            break;
                        case "spock":
                            Console.WriteLine("player chose rock, AI chose spock.");
                            Console.WriteLine("You Lose!");
                            break;
                        case "lizard":
                            Console.WriteLine("player chose rock, AI chose lizard.");
                            Console.WriteLine("You Win!");
                            break;
                    }
                    break;
                case Player.choices.Paper:
                    switch (ai.getAIchoice())
                    {
                        case "scissor":
                            Console.WriteLine("player chose paper, AI chose scissor.");
                            Console.WriteLine("You Lose!");
                            break;
                        case "paper":
                            Console.WriteLine("player chose paper, AI chose paper.");
                            Console.WriteLine("It's a Tie!");
                            break;
                        case "rock":
                            Console.WriteLine("player chose paper, AI chose rock.");
                            Console.WriteLine("You Win!");
                            break;
                        case "spock":
                            Console.WriteLine("player chose paper, AI chose spock.");
                            Console.WriteLine("You Win!");
                            break;
                        case "lizard":
                            Console.WriteLine("player chose paper, AI chose lizard.");
                            Console.WriteLine("You Lose!");
                            break;
                    }
                    break;
                case Player.choices.Scissor:
                    switch (ai.getAIchoice())
                    {
                        case "scissor":
                            Console.WriteLine("player chose scissor, AI chose scissor.");
                            Console.WriteLine("It's a Tie!");
                            break;
                        case "paper":
                            Console.WriteLine("player chose scissor, AI chose paper.");
                            Console.WriteLine("You Win!");
                            break;
                        case "rock":
                            Console.WriteLine("player chose scissor, AI chose rock.");
                            Console.WriteLine("You Lose!");
                            break;
                        case "spock":
                            Console.WriteLine("player chose scissor, AI chose spock.");
                            Console.WriteLine("You Lose!");
                            break;
                        case "lizard":
                            Console.WriteLine("player chose scissor, AI chose lizard.");
                            Console.WriteLine("You Win!");
                            break;
                    }
                    break;
                case Player.choices.Spock:
                    switch (ai.getAIchoice())
                    {
                        case "scissor":
                            Console.WriteLine("player chose spock, AI chose scissor.");
                            Console.WriteLine("You Win!");
                            break;
                        case "paper":
                            Console.WriteLine("player chose spock, AI chose paper.");
                            Console.WriteLine("You Lose!");
                            break;
                        case "rock":
                            Console.WriteLine("player chose spock, AI chose rock.");
                            Console.WriteLine("You Win!");
                            break;
                        case "spock":
                            Console.WriteLine("player chose spock, AI chose spock.");
                            Console.WriteLine("It's a Tie!");
                            break;
                        case "lizard":
                            Console.WriteLine("player chose spock, AI chose lizard.");
                            Console.WriteLine("You Lose!");
                            break;
                    }
                    break;
                case Player.choices.Lizard:
                    switch (ai.getAIchoice())
                    {
                        case "scissor":
                            Console.WriteLine("player chose lizard, AI chose scissor.");
                            Console.WriteLine("You Lose!");
                            break;
                        case "paper":
                            Console.WriteLine("player chose lizard, AI chose paper.");
                            Console.WriteLine("You Win!");
                            break;
                        case "rock":
                            Console.WriteLine("player chose lizard, AI chose rock.");
                            Console.WriteLine("You Lose!");
                            break;
                        case "spock":
                            Console.WriteLine("player chose lizard, AI chose spock.");
                            Console.WriteLine("You Win!");
                            break;
                        case "lizard":
                            Console.WriteLine("player chose lizard, AI chose lizard.");
                            Console.WriteLine("It's a Tie!");
                            break;
                    }
                    break;
            }
        }
    }
}
