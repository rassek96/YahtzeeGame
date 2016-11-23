using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeGame.controller
{
    class PlayGame
    {
        private view.GameView gameView;
        private model.Player player;
        private model.Game game;

        public PlayGame()
        {
            gameView = new view.GameView();
            player = new model.Player();
            game = new model.Game(player);
        }

        public void WelcomeUser()
        {
            gameView.DisplayWelcomeMessage();
            ConsoleKeyInfo userInput = gameView.GetInput();
            if (userInput.Key == ConsoleKey.D1)
            {
                StartRound();
            }
            else if (userInput.Key == ConsoleKey.D2)
            {
                Environment.Exit(0);
            }
            else
            {
                WelcomeUser();
            }
        }

        public void StartRound()
        {
            gameView.ClearConsole();
            gameView.DisplayPlayerScore(player.GetScores());
            game.Roll();
            model.Dice dice = game.GetDice();
            gameView.DisplayDiceValues(dice);
            List<model.Scores> options = game.GetPlayerOptions();
            gameView.DislayPlayerOptions(options);
            ConsoleKeyInfo userInput = gameView.GetInput();
            if (userInput.Key == ConsoleKey.D1)
            {
                StartRound();
            }
            else if (userInput.Key == ConsoleKey.D2)
            {
                SelectDice(dice);
            }
            else if(userInput.Key == ConsoleKey.D3)
            {
                if(options.Count > 0)
                {
                    player.AddScore(options[0], dice);
                }
            }
            else if (userInput.Key == ConsoleKey.D4)
            {
                if (options.Count > 1)
                {
                    player.AddScore(options[1], dice);
                }
            }
            else if (userInput.Key == ConsoleKey.D5)
            {
                if (options.Count > 2)
                {
                    player.AddScore(options[2], dice);
                }
            }
            else if (userInput.Key == ConsoleKey.D6)
            {
                if (options.Count > 3)
                {
                    player.AddScore(options[3], dice);
                }
            }
            else if (userInput.Key == ConsoleKey.D7)
            {
                if (options.Count > 4)
                {
                    player.AddScore(options[4], dice);
                }
            }
            StartRound();
        }
        public void SelectDice(model.Dice dice)
        {
            gameView.ClearConsole();
            gameView.SelectDice(dice);
            ConsoleKeyInfo userInput = gameView.GetInput();
            if (userInput.Key == ConsoleKey.D1)
            {
                ToggleSelectDice(dice, 0);
                SelectDice(dice);
            }
            else if (userInput.Key == ConsoleKey.D2)
            {
                ToggleSelectDice(dice, 1);
                SelectDice(dice);
            }
            else if (userInput.Key == ConsoleKey.D3)
            {
                ToggleSelectDice(dice, 2);
                SelectDice(dice);
            }
            else if (userInput.Key == ConsoleKey.D4)
            {
                ToggleSelectDice(dice, 3);
                SelectDice(dice);
            }
            else if (userInput.Key == ConsoleKey.D5)
            {
                ToggleSelectDice(dice, 4);
                SelectDice(dice);
            }
            else if (userInput.Key == ConsoleKey.D6)
            {
                StartRound();
            }
        }
        public void ToggleSelectDice(model.Dice dice, int i)
        {
            if (dice.GetDice()[i].Save)
            {
                dice.GetDice()[i].Save = false;
            }
            else
            {
                dice.GetDice()[i].Save = true;
            }
        }
    }
}
