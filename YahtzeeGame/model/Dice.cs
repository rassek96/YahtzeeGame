using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeGame.model
{
    public class Dice
    {
        private int _value;

        public Dice()
        {
            _value = 0;
        }

        public int Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }

        public int Roll()
        {
            return 1;
        }
    }
}
