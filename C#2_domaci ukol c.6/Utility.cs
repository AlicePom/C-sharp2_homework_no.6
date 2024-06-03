using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_2_domaci_ukol_c._6
{
    public static class Utility // contains static methods to enter parameters/color/symbol to create a graphic object
    {
        // A utility method that enables to specify a parameter of a particular graphic object
        public static int EnterNumber(string objectType, string paramType)
        {
            bool parsedInput;
            int number;

            do
            {
                Console.Write($"Enter the {objectType} {paramType} (whole number greater than 1): ");
                parsedInput = int.TryParse(Console.ReadLine(), out number);

            } while (!parsedInput || number <= 1);

            return number;
        }

        // A utility method that enables to specify a symbol that would form a particular graphic object
        public static string EnterSymbol(string objectType)
        {
            string symbol;

            do
            {
                Console.Write($"Enter the symbol that should form the {objectType}: ");
                symbol = Console.ReadLine();
            } while (string.IsNullOrEmpty(symbol));

            return symbol;
        }

        // A utility method that enables to set color of a particular graphic object
        public static ConsoleColor SetObjectColor(string objectType)
        {
            Console.Write($"Choose the color of the {objectType}. ");

            bool parsedInput;
            int number;

            Dictionary<int, ConsoleColor> colorDictinary = new Dictionary<int, ConsoleColor>()
            {
                {1, ConsoleColor.Red },
                {2, ConsoleColor.Blue },
                {3, ConsoleColor.Green },
                {4, ConsoleColor.Yellow },
                {5, ConsoleColor.White },
                {6, ConsoleColor.Cyan },
                {7, ConsoleColor.Magenta }
            };

            do
            {
                Console.Write("Enter the number of the color: 1 - Red, 2 - Blue, 3 - Green, 4 - Yellow, 5 - White, 6 - Cyan, 7 - Magenta: ");
                parsedInput = int.TryParse(Console.ReadLine(), out number);

            } while (!parsedInput || number < 1 || number > 7);

            return colorDictinary[number];
        }
    }
}
