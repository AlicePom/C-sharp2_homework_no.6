using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_2_domaci_ukol_c._6
{
    public class GraphicObject
    {
        public ConsoleColor Color { get; private set; }

        public GraphicObject(ConsoleColor color)
        {
            Color = color;
        }

        // a method that prints the object (without parameters) to the console
        public virtual void DrawWithoutParams()
        {
            Console.WriteLine("X");
        }

        // a method that enables the user to change the console color
        public void SetConsoleColor()
        {
            Console.ForegroundColor = Color;
        }
        
        // a method that enables to change the console color back to white
        public void ResetConsoleColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
