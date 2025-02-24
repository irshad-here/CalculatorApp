using System;

namespace CalculatorApp
{
    // The Parser class implements a recursive descent parser.
    // Grammar:
    // Expression -> Term { ('+'|'-') Term }
    // Term       -> Factor { ('*'|'/') Factor }
    // Factor     -> Number | '(' Expression ')'
    public class Parser
    {
        private readonly string text;
        private int pos;
        private char currentToken;

        public Parser(string text)
        {
            this.text = text;
            pos = 0;
            Advance();
        }

        // Advance to the next non-whitespace character.
        private void Advance()
        {
            while (pos < text.Length && char.IsWhiteSpace(text[pos]))
                pos++;
            currentToken = pos < text.Length ? text[pos] : '\0';
        }

        // Consume the expected token or throw a FormatException.
        private void Eat(char token)
        {
            if (currentToken == token)
            {
                pos++;
                Advance();
            }
            else
            {
                throw new FormatException($"Expected '{token}' but found '{currentToken}'.");
            }
        }

        // Parse an Expression: Term { ('+'|'-') Term }
        public double ParseExpression()
        {
            double result = ParseTerm();
            while (currentToken == '+' || currentToken == '-')
            {
                if (currentToken == '+')
                {
                    Eat('+');
                    result += ParseTerm();
                }
                else
                {
                    Eat('-');
                    result -= ParseTerm();
                }
            }
            return result;
        }

        // Parse a Term: Factor { ('*'|'/') Factor }
        public double ParseTerm()
        {
            double result = ParseFactor();
            while (currentToken == '*' || currentToken == '/')
            {
                if (currentToken == '*')
                {
                    Eat('*');
                    result *= ParseFactor();
                }
                else
                {
                    Eat('/');
                    double denominator = ParseFactor();
                    if (denominator == 0)
                    {
                        throw new DivideByZeroException("Division by zero encountered.");
                    }
                    result /= denominator;
                }
            }
            return result;
        }

        // Parse a Factor: a number or a parenthesized expression.
        public double ParseFactor()
        {
            if (currentToken == '(')
            {
                Eat('(');
                double result = ParseExpression();
                if (currentToken != ')')
                    throw new FormatException("Missing closing parenthesis.");
                Eat(')');
                return result;
            }
            else
            {
                return ParseNumber();
            }
        }

        // Parse a number (supports integer and floating-point).
        public double ParseNumber()
        {
            int start = pos;
            while (currentToken != '\0' && (char.IsDigit(currentToken) || currentToken == '.'))
            {
                pos++;
                Advance();
            }
            string numberStr = text.Substring(start, pos - start);
            if (double.TryParse(numberStr, out double number))
            {
                return number;
            }
            else
            {
                throw new FormatException($"Invalid number format: {numberStr}");
            }
        }

        // Property to expose the current token.
        public char CurrentToken => currentToken;
    }
}
