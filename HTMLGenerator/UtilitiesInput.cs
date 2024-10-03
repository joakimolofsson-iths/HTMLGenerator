using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLGenerator
{
    internal static class UtilitiesInput
    {
        internal static string HandleNullAndEmpty(string? userInput)
        {
            while (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Invalid input, try something else!");
                userInput = Console.ReadLine();
            }

            return userInput;
        }
    }
}
