using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeGame.model
{
    class Die
    {
        private int _value;
        private bool _save;

        public Die()
        {
            _value = 0;
            _save = false;
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
        public bool Save
        {
            get
            {
                return _save;
            }
            set
            {
                _save = value;
            }
        }
    }
}
