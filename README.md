# CalculatorApp

This is a basic calculator application implemented in C#. It supports arithmetic expressions including addition, subtraction, multiplication, division, and parentheses. The application validates inputs, handles errors (such as division by zero and format errors), maintains a history of calculations, and requires authentication (password "admin") to view the calculation history.

## Features
- **Arithmetic Operations:** Addition (`+`), subtraction (`-`), multiplication (`*`), division (`/`), and support for parentheses.
- **Input Validation:** Handles format errors (e.g., mismatched parentheses) and division by zero.
- **Calculation History:** Keeps a record of all calculations performed.
- **Authentication:** Requires a password (`admin`) to view the history.

## File Structure
- **Calculator.cs:** Contains the `Calculator` class that evaluates expressions using the `Parser`.
- **Parser.cs:** Implements a recursive descent parser to parse and evaluate arithmetic expressions.
- **CalculatorHistory.cs:** Manages the history of calculations.
- **Program.cs:** The main program that provides a console menu for user interaction.

## How to Build and Run Using .NET CLI

1. **Create a New Console Application:**
   Open a terminal or command prompt and run:
   ```bash
   dotnet new console -o CalculatorApp
   cd CalculatorApp
