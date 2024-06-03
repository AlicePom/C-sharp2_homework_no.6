using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_2_domaci_ukol_c._6
{
    public class Triangle : GraphicObject
    {
        public int Height { get; private set; }
        public string Symbol { get; private set; }

        public Triangle(int height, string symbol, ConsoleColor color) : base(color)
        {
            Height = height;
            Symbol = symbol;
        }

        // A method that creates the triangle based on the user input and prints it on the console
        public override void DrawWithoutParams()
        {
            SetConsoleColor();

            int lineOrder; // the order number of the line within the triangle
            int symbolCount; // total number of symbols per line
            int spaceCount; // total number of spaces per line
            int symbolOrder; // the order number of the symbol within the line
            int totalSymbolsSpaces = 2 * Height - 1; // total number of symbols and spaces per each line

            // a cycle that creates individual lines of the triangle of b given height (number of lines)
            for (lineOrder = 1; lineOrder <= Height; lineOrder++)
            {
                symbolCount = lineOrder * 2 - 1;

                // a cycle that puts spaces on the line before the symbol(s)
                for (spaceCount = 0; spaceCount < (totalSymbolsSpaces - symbolCount) / 2; spaceCount++)
                {
                    Console.Write(" ");
                }

                // a cycle that puts symbols on the line
                for (symbolOrder = 0; symbolOrder < symbolCount; symbolOrder++)
                {
                    Console.Write(Symbol);
                }

                //// a cycle that puts spaces on the line after the symbol(s) - not necessary here
                //for (spaceCount = 0; spaceCount < (totalSymbolsSpaces - symbolCount) / 2; spaceCount++)
                //{
                //    Console.Write(" ");
                //}

                Console.WriteLine();
            }

            ResetConsoleColor();
        }
    }
}
