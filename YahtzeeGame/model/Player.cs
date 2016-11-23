using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeGame.model
{
    class Player
    {
        private PlayerScores _scores;
        private int _rolls;

        private string ones = "numOfOnes";
        private string twos = "numOfTwos";
        private string threes = "numOfThrees";
        private string fours = "numOfFours";
        private string fives = "numOfFives";
        private string sixes = "numOfSixes";

        public Player()
        {
            _scores = new PlayerScores();
            _rolls = 0;
        }

        public PlayerScores GetScores()
        {
            return _scores;
        }
        
        public void Roll(Dice dice)
        {
            if(_rolls < 3)
            {
                dice.Roll();
                _rolls++;
            }
        }

        public void AddScore(Scores score, Dice dice)
        {
            Dictionary<string, int> numbers = CountNums(dice);
            switch (score)
            {
                case Scores.Ones:
                    _scores.Ones = numbers[ones] * 1;
                    return;
                case Scores.Twos:
                    _scores.Twos = numbers[twos] * 2;
                    return;
                case Scores.Threes:
                    _scores.Threes = numbers[threes] * 3;
                    return;
                case Scores.Fours:
                    _scores.Fours = numbers[fours] * 4;
                    return;
                case Scores.Fives:
                    _scores.Fives = numbers[fives] * 5;
                    return;
                case Scores.Sixes:
                    _scores.Sixes = numbers[sixes] * 6;
                    return;
            }
        }

        public List<Scores> CalcOptions(Dice dice)
        {
            List<Scores> options = new List<Scores>();

            Dictionary<string, int> numbers = CountNums(dice);

            if (_scores.Ones == 0 && numbers[ones] > 0) { options.Add(Scores.Ones); } 
            if (_scores.Twos == 0 && numbers[twos] > 0) { options.Add(Scores.Twos); }
            if (_scores.Threes == 0 && numbers[threes] > 0) { options.Add(Scores.Threes); }
            if (_scores.Fours == 0 && numbers[fours] > 0) { options.Add(Scores.Fours); }
            if (_scores.Fives == 0 && numbers[fives] > 0) { options.Add(Scores.Fives); }
            if (_scores.Sixes == 0 && numbers[sixes] > 0) { options.Add(Scores.Sixes); }

            if (_scores.ThreeOfAKind == 0 && (numbers[ones] == 3 || numbers[twos] == 3 || numbers[threes] == 3 || numbers[fours] == 3 || numbers[fives] == 3 || numbers[sixes] == 3))
            {
                options.Add(Scores.ThreeOfAKind);

                if(_scores.FullHouse == 0 && (numbers[ones] == 2 || numbers[twos] == 2 || numbers[threes] == 2 || numbers[fours] == 2 || numbers[fives] == 2 || numbers[sixes] == 2))
                {
                    options.Add(Scores.FullHouse);
                }
            }

            if (_scores.FourOfAKind == 0 && (numbers[ones] == 4 || numbers[twos] == 4 || numbers[threes] == 4 || numbers[fours] == 4 || numbers[fives] == 4 || numbers[sixes] == 4))
            {
                options.Add(Scores.FourOfAKind);
            }

            if (_scores.SmallStraight == 0 && (numbers[ones] == 1 && numbers[twos] == 1 && numbers[threes] == 1 && numbers[fours] == 1 && numbers[fives] == 1))
            {
                options.Add(Scores.SmallStraight);
            }

            if (_scores.LargeStraight == 0 && (numbers[twos] == 1 && numbers[threes] == 1 && numbers[fours] == 1 && numbers[fives] == 1 && numbers[sixes] == 1))
            {
                options.Add(Scores.LargeStraight);
            }

            if (_scores.Yahtzee == 0 && (numbers[ones] == 5 || numbers[twos] == 5 || numbers[threes] == 5 || numbers[fours] == 5 || numbers[fives] == 5 || numbers[sixes] == 5))
            {
                options.Add(Scores.Yahtzee);
            }

            if(_scores.Chance == 0)
            {
                options.Add(Scores.Chance);
            }
            

            return options;
        }

        private Dictionary<string, int> CountNums(Dice dice)
        {
            Dictionary<string, int> numbers = new Dictionary<string, int>();
            int numOfOnes = 0;
            int numOfTwos = 0;
            int numOfThrees = 0;
            int numOfFours = 0;
            int numOfFives = 0;
            int numOfSixes = 0;

            foreach (Die die in dice.GetDice())
            {
                if (die.Value == 1) { numOfOnes++; }
                else if (die.Value == 2) { numOfTwos++; }
                else if (die.Value == 3) { numOfThrees++; }
                else if (die.Value == 4) { numOfFours++; }
                else if (die.Value == 5) { numOfFives++; }
                else if (die.Value == 6) { numOfSixes++; }
            }
            numbers.Add(ones, numOfOnes);
            numbers.Add(twos, numOfTwos);
            numbers.Add(threes, numOfThrees);
            numbers.Add(fours, numOfFours);
            numbers.Add(fives, numOfFives);
            numbers.Add(sixes, numOfSixes);
            return numbers;
        }
    }
}
