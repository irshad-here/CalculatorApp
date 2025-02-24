using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            CalculatorHistory history = new CalculatorHistory();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Evaluate Expression");
                Console.WriteLine("2. View History (requires authentication)");
                Console.WriteLine("3. Exit");
                Console.Write("Choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter expression: ");
                        string expr = Console.ReadLine();
                        try
                        {
                            double result = calculator.Evaluate(expr);
                            Console.WriteLine("Result: " + result);
                            history.AddEntry(expr, result.ToString());
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("Error");
                            history.AddEntry(expr, "Error");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Format Error");
                            history.AddEntry(expr, "Format Error");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                            history.AddEntry(expr, "Error");
                        }
                        break;

                    case "2":
                        Console.Write("Enter password to view history: ");
                        string password = Console.ReadLine();
                        history.ShowHistory(password);
                        break;

                    case "3":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please select 1, 2, or 3.");
                        break;
                }
            }
        }
    }
}
