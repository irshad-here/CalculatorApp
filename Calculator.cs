using System;

namespace CalculatorApp
{
    public class Calculator
    {
        public double Evaluate(string expression)
        {
            // Create a new parser instance with the input expression.
            Parser parser = new Parser(expression);
            double result = parser.ParseExpression();

            // If after parsing there are extra characters, the format is invalid.
            if (parser.CurrentToken != '\0')
            {
                throw new FormatException("Extra characters found in the expression.");
            }
            return result;
        }
    }
}
