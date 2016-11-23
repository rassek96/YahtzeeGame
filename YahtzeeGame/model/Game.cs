using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeGame.model
{
    class Game
    {
        private Dice _dice;
        private Player _player;

        public Game(Player player)
        {
            _dice = new Dice();
            _player = player;
        }

        public void Roll()
        {
            _player.Roll(_dice);
        }

        public List<Scores> GetPlayerOptions()
        {
            return _player.CalcOptions(_dice);
        }

        public Dice GetDice()
        {
            return _dice;
        }

    }
}
