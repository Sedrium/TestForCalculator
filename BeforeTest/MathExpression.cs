using SimpleCalculator.Classes;
using SimpleCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HowToDestoryCalculatorTurorial.BeforeTest
{
    public class MathExpression
    {
        public IList<IMathSymbol> CreateExpression()
        {
            List<IMathSymbol> mathExpression = new List<IMathSymbol>();
            mathExpression.Add(new DigitSymbol(0));
            mathExpression.Add(new SubtractionSymbol());
            mathExpression.Add(new DigitSymbol(0));
            mathExpression.Add(new MultiplicationSymbol());
            mathExpression.Add(new DigitSymbol(0));
            mathExpression.Add(new MultiplicationSymbol());
            mathExpression.Add(new DigitSymbol(0));
            return mathExpression;
        }
        public IList<IMathSymbol> CreateExpressionDobuleSubtractionOperators()
        {
            List<IMathSymbol> mathExpression = new List<IMathSymbol>();
            mathExpression.Add(new SubtractionSymbol());
            mathExpression.Add(new DigitSymbol(0));
            mathExpression.Add(new SubtractionSymbol());
            mathExpression.Add(new DigitSymbol(0));
            mathExpression.Add(new MultiplicationSymbol());
            mathExpression.Add(new SubtractionSymbol());
            mathExpression.Add(new DigitSymbol(0));
            mathExpression.Add(new MultiplicationSymbol());
            mathExpression.Add(new DigitSymbol(0));
            return mathExpression;
        }
    }
}
