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

        public RunGame()
        {
            scissor = new Scissor("Scissor");
            paper = new Paper("Paper");
            rock = new Rock("Rock");
            spock = new Spock("Spock");
            lizard = new Lizard("Lizard");
            player = new Player();
            ai = new AI();
        }

        public void RunThroughGame()
        {
            if (player.getUserInput() == Player.choices.Rock && ai.getAIchoice() == scissor.Name)
            {
                //display loss or win or whatever, so make a those classes say "paper covers rock" or w/e and then under all of this...
                //like down here have console.WL "you win/
            }
            if (player.getUserInput() == Player.choices.Rock && ai.getAIchoice() == paper.Name)
            {

            }
            if (player.getUserInput() == Player.choices.Rock && ai.getAIchoice() == rock.Name)
            {

            }
            if (player.getUserInput() == Player.choices.Rock && ai.getAIchoice() == spock.Name)
            {

            }
            if (player.getUserInput() == Player.choices.Rock && ai.getAIchoice() == lizard.Name)
            {

            }

        }
    }
}

//"Enter 0 for Rock, 1 for Paper, 2 for Scissor, 3 for Lizard, 4 for Spock:
