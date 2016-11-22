using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace YahtzeeGame.Test
{
    [TestFixture]
    class DiceTest
    {
        [Test]
        public void ShouldReturnDiceValue()
        {
            model.Dice sut = new model.Dice();
            int expected = sut.Roll();
            Assert.That(expected, Is.InRange(1, 6));
        }
    }
}
