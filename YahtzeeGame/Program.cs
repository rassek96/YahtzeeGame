﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Yahtzee";
            controller.PlayGame PlayGame = new controller.PlayGame();
            PlayGame.WelcomeUser();
        }
    }
}
