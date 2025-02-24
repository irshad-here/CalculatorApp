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


2. **Add the Source Files:**

   Replace the generated Program.cs with the provided Program.cs content.
   Create the following files in the project directory and paste the corresponding code into each file:
   -Calculator.cs
   -Parser.cs
   -CalculatorHistory.cs

2. **Build the Application:**
   ```bash
   dotnet build
   dotnet run

3. **Sample Usage and Output:**
   ```bash
   Select an option:
1. Evaluate Expression
2. View History (requires authentication)
3. Exit
Choice:


