using System;
using System.Collections.Generic;
using System.Text;
using HowToDestoryCalculatorTurorial.BeforeTest;
using NUnit.Framework;
using SimpleCalculator.Classes;
using SimpleCalculator.Interfaces;

namespace HowToDestoryCalculatorTurorial
{
    class ConditionsTest
    {
        IList<IMathSymbol> mathExpression = new List<IMathSymbol>();
        MathExpression MathExpression;
        string emptyString = "";
        string nullString;
        string stringContainChars = "dadaw2das";

        [SetUp]
        public void Setup()
        {
            MathExpression = new MathExpression();
        }

        [Test]
        public void FirstSymbolEqualToSolveSymbolTest()
        {
            mathExpression = MathExpression.CreateExpression();
            var subSymbol = Condition.TakeFirstSymbolEqualToSolveSymbol(mathExpression, SimpleCalculator.Enums.Operations.SubAndAdd);
            var multSymol = Condition.TakeFirstSymbolEqualToSolveSymbol(mathExpression, SimpleCalculator.Enums.Operations.MulAndDiv);
            Assert.AreEqual(subSymbol, mathExpression[1]);
            Assert.AreEqual(multSymol, mathExpression[3]);
        }
        [Test]
        public void ListContainsAnySymbolEqualToSolveSymbolTest()
        {
            var subSymbol = Condition.ListContainsAnySymbolEqualToSolveSymbol(mathExpression, SimpleCalculator.Enums.Operations.SubAndAdd);
            var multSymol = Condition.ListContainsAnySymbolEqualToSolveSymbol(mathExpression, SimpleCalculator.Enums.Operations.MulAndDiv);
            Assert.IsTrue(subSymbol);
            Assert.IsTrue(multSymol);
        }
        [Test]
        public void StringIsNotNullTest()
        {
            var emptyString = Condition.StringIsNotNull(this.emptyString);
            var nullString = Condition.StringIsNotNull(this.nullString);
            var stringContainChars = Condition.StringIsNotNull(this.stringContainChars);
            Assert.IsFalse(emptyString);
            Assert.IsFalse(nullString);
            Assert.IsTrue(stringContainChars);
        }
        [Test]
        public void IsThereSubtractionSymbolAfterOtherSymbolsTest()
        {
            mathExpression = MathExpression.CreateExpressionDobuleSubtractionOperators();
            bool falseExpected = Condition.IsThereSubtractionSymbolAfterOtherSymbols(mathExpression, 1);
            bool trueExpected = Condition.IsThereSubtractionSymbolAfterOtherSymbols(mathExpression, 4);
            Assert.IsFalse(falseExpected);
            Assert.IsTrue(trueExpected);
        }
        [Test]
        public void IsFirstDigitNegativeTest()
        {
            mathExpression = MathExpression.CreateExpressionDobuleSubtractionOperators();
            bool trueExpected = Condition.IsFirstDigitNegative(mathExpression,0);
            bool falseExpected = Condition.IsFirstDigitNegative(mathExpression, 1);
            Assert.IsFalse(falseExpected);
            Assert.IsTrue(trueExpected);
        }
    }
}