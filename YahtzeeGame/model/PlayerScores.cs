using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeGame.model
{
    class PlayerScores
    {
        public int Ones { get; set; } = 0;
        public int Twos { get; set; } = 0;
        public int Threes { get; set; } = 0;
        public int Fours { get; set; } = 0;
        public int Fives { get; set; } = 0;
        public int Sixes { get; set; } = 0;
        public int ThreeOfAKind { get; set; } = 0;
        public int FourOfAKind { get; set; } = 0;
        public int FullHouse { get; set; } = 0;
        public int SmallStraight { get; set; } = 0;
        public int LargeStraight { get; set; } = 0;
        public int Yahtzee { get; set; } = 0;
        public int Chance { get; set; } = 0;
    }
}
