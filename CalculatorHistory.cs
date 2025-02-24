using System;
using System.Collections.Generic;

namespace CalculatorApp
{
    public class CalculatorHistory
    {
        private readonly List<string> history = new List<string>();

        public void AddEntry(string expression, string result)
        {
            history.Add($"{expression} = {result}");
        }

        // Display the history only if the correct password is provided.
        public void ShowHistory(string password)
        {
            // Simple authentication: password must match "admin"
            if (password != "admin")
            {
                Console.WriteLine("Authentication failed.");
                return;
            }
            Console.WriteLine("\nCalculation History:");
            foreach (var entry in history)
            {
                Console.WriteLine(entry);
            }
        }
    }
}
