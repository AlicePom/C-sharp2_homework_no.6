using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_2_domaci_ukol_c._6
{
    public class Rectangle : GraphicObject
    {
        public int Length { get; private set; }
        public int Width { get; private set; }
        public string Symbol { get; private set; }

        public Rectangle(int length, int width, string symbol, ConsoleColor color) : base(color)
        {
            Length = length;
            Width = width;
            Symbol = symbol;
        }

        // A method that creates the rectangle based on the user input and prints it on the console
        public override void DrawWithoutParams()
        {
            SetConsoleColor();

            for (int a = 0; a < Width; a++)
            {
                Console.Write(Symbol);

                for (int b = 0; b < Length - 2; b++)
                {
                    if (a > 0 && a < Width - 1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(Symbol);
                    }
                }
                Console.Write(Symbol);
                Console.WriteLine();
            }

            ResetConsoleColor();
        }
    }
}
