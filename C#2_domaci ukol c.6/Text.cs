using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_2_domaci_ukol_c._6
{
    public class Text : GraphicObject
    {
        public Text(ConsoleColor color) : base(color)
        {
        }

        // A method that enables the user to write a text of a chosen color and prints it on the console
        public override void DrawWithoutParams()
        {
            SetConsoleColor();

            // the user is asked to write a text to be printed back to the console
            Console.WriteLine("Enter the text: ");

            // the text is printed to the console
            Console.Write("You wrote: " + Console.ReadLine());

            ResetConsoleColor();
        }
    }
}
