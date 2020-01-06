using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Text;
using SimpleCalculator.Classes;

namespace HowToDestoryCalculatorTurorial
{
    class SimpleCalculatorTest
    {
        SimpleCalculator.Classes.CalculatorTypes.SimpleCalculator simpleCalc;
        [SetUp]
        public void Setup()
        {
            simpleCalc = new SimpleCalculator.Classes.CalculatorTypes.SimpleCalculator();
        }

        [Test]
        public void DevideByZeroTestThrowExcetpion()
        {
            simpleCalc.Expression = "5/0";
            Assert.Catch(() => { simpleCalc.ValidateData(); });
            simpleCalc.Expression = "0/0";
            Assert.Catch(() => { simpleCalc.ValidateData(); });
            simpleCalc.Expression = "3-8/0";
            Assert.Catch(() => { simpleCalc.ValidateData(); });
        }
        [Test]
        public void WrongExpressionFormatThrowException()
        {
            simpleCalc.Expression = "-5+4";
            Assert.Catch(() => { simpleCalc.ValidateData(); });
            simpleCalc.Expression = "5++2";
            Assert.Catch(() => { simpleCalc.ValidateData(); });
            simpleCalc.Expression = "5x+3";
            Assert.Catch(() => { simpleCalc.ValidateData(); });
            simpleCalc.Expression = "5/-1";
            Assert.Catch(() => { simpleCalc.ValidateData(); });
            simpleCalc.Expression = "5+(-1+2)";
            Assert.Catch(() => { simpleCalc.ValidateData(); });
        }
        [Test]
        public void EntryUndefindedCharsThrowExcetpion()
        {
            simpleCalc.Expression = " ";
            Assert.Catch(() => { simpleCalc.ValidateData(); });
            simpleCalc.Expression = "2+(3+3)";
            Assert.Catch(() => { simpleCalc.ValidateData(); });
            simpleCalc.Expression = "2+5=7";
            Assert.Catch(() => { simpleCalc.ValidateData(); });
        }
        [Test]
        public void SolveExpression()
        {
            string expression = "5+1-3*5/5-4";
            string expression2 = "22/2+1*4*2+1-10";
            Calculator calculator = new Calculator(simpleCalc);
            Assert.AreEqual(-1, calculator.SolveExpression(expression));
            Assert.AreEqual(10, calculator.SolveExpression(expression2));
        }
    }
}