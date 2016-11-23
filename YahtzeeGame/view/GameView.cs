using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace YahtzeeGame.view
{
    class GameView
    {
        public void DisplayWelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Yahtzee, please select what you want to do.");
            Console.WriteLine("1. Play Yahtzee");
            Console.WriteLine("2. Quit");

        }
        public ConsoleKeyInfo GetInput()
        {
            ConsoleKeyInfo userInput = Console.ReadKey(true);
            while (!Char.IsNumber(userInput.KeyChar))
            {
                userInput = Console.ReadKey(true);
            }
            return userInput;
        }

        public void DisplayDiceValues(model.Dice dice)
        {
            Console.WriteLine("Dice values");
            foreach(model.Die die in dice.GetDice())
            {
                System.Threading.Thread.Sleep(400);
                Console.Write(die.Value + ", ");
            }
            Console.WriteLine("\n");
        }

        public void DislayPlayerOptions(List<model.Scores> options)
        {
            Console.WriteLine("Select what you want to do.");
            Console.WriteLine("1. Roll again");
            Console.WriteLine("2. Select dice to keep");
            int i = 3;
            foreach(model.Scores option in options)
            {
                Console.WriteLine(i + ". " + string.Concat(option.ToString().Select(x => Char.IsUpper(x) ? " " + x : x.ToString())).TrimStart(' '));
                i++;
            }
            Console.WriteLine();
        }

        public void ClearConsole()
        {
            Console.Clear();
        }

        public void SelectDice(model.Dice dice)
        {
            Console.WriteLine("Select dice to keep");
            int i = 1;
            foreach (model.Die die in dice.GetDice())
            {
                Console.Write(i + ". " + die.Value);
                if (die.Save)
                {
                    Console.Write("(Saved)");
                }
                Console.WriteLine();
                i++;
            }
            Console.WriteLine(i + ". Done");
        }

        public void DisplayPlayerScore(model.PlayerScores scores)
        {
            int score = 0;
            score += scores.Ones + scores.Twos + scores.Threes + scores.Fours + scores.Fives + scores.Sixes + scores.ThreeOfAKind + scores.FourOfAKind + scores.FullHouse + scores.SmallStraight + scores.LargeStraight + scores.Yahtzee + scores.Chance;
            Console.WriteLine("Player Score: " + score);
        }
    }
}
