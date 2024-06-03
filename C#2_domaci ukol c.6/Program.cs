using System.Drawing;

namespace C_2_domaci_ukol_c._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. creating an instance of the GraphicObject class
            GraphicObject generalObject = new GraphicObject(ConsoleColor.White);

            // 2. creating an instance of the Rectangle class
            Console.WriteLine("Let's create a rectangle!");

            int length = Utility.EnterNumber("rectangle", "length");
            int width = Utility.EnterNumber("rectangle", "width");
            string rectangleSymbol = Utility.EnterSymbol("rectangle");
            ConsoleColor rectangleColor = Utility.SetObjectColor("rectangle");

            Rectangle rectangle = new Rectangle(length, width, rectangleSymbol, rectangleColor);
            Console.WriteLine();

            // 3. creating an instance of the Triangle class
            Console.WriteLine("Let's create a triangle!");

            int height = Utility.EnterNumber("triangle", "height");
            string triangleSymbol = Utility.EnterSymbol("triangle");
            ConsoleColor triangleColor = Utility.SetObjectColor("triangle");

            Triangle triangle = new Triangle(height, triangleSymbol, triangleColor);
            Console.WriteLine();

            // 4. creating an instance of the Text class
            Console.WriteLine("Let's write some text!");

            Text text = new Text(Utility.SetObjectColor("text"));
            Console.WriteLine();

            // 5. creating list of GraphicObject class instances and printing them on console
            List<GraphicObject> graphicObjects = new List<GraphicObject>() { generalObject, rectangle, triangle, text };
            
            foreach (var item in graphicObjects)
            {
                item.DrawWithoutParams();
                Console.WriteLine();
            }
        }
    }   
}