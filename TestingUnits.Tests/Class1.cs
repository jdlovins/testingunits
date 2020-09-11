using NUnit.Framework;
using System;

namespace TestingUnits.Tests
{
    [TestFixture]
    public class CalcTest
    {
        private Calculator _calc;
        public CalcTest()
        {
            _calc = new Calculator();
        }

        [Test]
        public void CanMath_ReturnTrue()
        {
            var result = _calc.Sum(5, 5);

            Assert.AreEqual(result, 10);
        }
    }
}
