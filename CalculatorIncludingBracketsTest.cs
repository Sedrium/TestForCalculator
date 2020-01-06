using NUnit.Framework;
using SimpleCalculator.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace HowToDestoryCalculatorTurorial
{
    class CalculatorIncludingBracketsTest
    {
        SimpleCalculator.Classes.CalculatorTypes.CalculatorInculdingBrackets advencedCalc;
        [SetUp]
        public void Setup()
        {
            advencedCalc = new SimpleCalculator.Classes.CalculatorTypes.CalculatorInculdingBrackets();
        }

        [Test]
        public void DevideByZeroTestThrowExcetpion()
        {
            advencedCalc.Expression = "5/0";
            Assert.Catch(() => { advencedCalc.ValidateData(); });
            advencedCalc.Expression = "2+(-5/0)";
            Assert.Catch(() => { advencedCalc.ValidateData(); });
            advencedCalc.Expression = "2+(5-5)/0";
            Assert.Catch(() => { advencedCalc.ValidateData(); });
        }
        [Test]
        public void EntryUndefindedCharsThrowExcetpion()
        {
            advencedCalc.Expression = " ";
            Assert.Catch(() => { advencedCalc.ValidateData(); });
            advencedCalc.Expression = "2+(3+3x)";
            Assert.Catch(() => { advencedCalc.ValidateData(); });
            advencedCalc.Expression = "2+5=7";
            Assert.Catch(() => { advencedCalc.ValidateData(); });
        }
        [Test]
        public void SolveExpression()
        {
            string expression = "(22/((6+(-1*4-2))+(21-2-(-1))))*(-1)";
            Calculator calculator = new Calculator(advencedCalc);
            Assert.AreEqual(-1.1, calculator.SolveExpression(expression));
        }
    }
}
