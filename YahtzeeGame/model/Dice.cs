using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeGame.model
{
    class Dice
    {
        private List<Die> _dice = new List<Die>();

        public Dice()
        {
            for(int i = 0; i < 5; i++)
            {
                _dice.Add(new Die());
            }
        }

        public List<Die> GetDice()
        {
            return _dice;
        }

        public void Roll()
        {
            Random rnd = new Random();

            foreach(Die die in _dice)
            {
                if(!die.Save)
                {
                    int value = rnd.Next(1, 7);
                    die.Value = value;
                }
            }
        }
    }
}
