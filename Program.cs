using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resizeable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Circle Test
            Circle[] circles = new Circle[3];

            circles[0] = new Circle();
            circles[1] = new Circle(3.5);
            circles[2] = new Circle(7, "indigo", false);

            Console.WriteLine("====================================================================================================");
            Console.WriteLine("Circle Test");
            Console.WriteLine("====================================================================================================");
           
            Console.WriteLine("Before resize:");
            foreach (Circle circle in circles)
            {
                Console.WriteLine(circle);
            }

            Console.WriteLine("After resize:");
            foreach (Circle circle in circles)
            {
                circle.Resize();
                Console.WriteLine(circle);
            }

            // Rectangle Test
            Rectangle[] rectangles = new Rectangle[3];

            rectangles[0] = new Rectangle();
            rectangles[1] = new Rectangle(3.5, 7);
            rectangles[2] = new Rectangle(7, 10.5, "red", false);

            Console.WriteLine("====================================================================================================");
            Console.WriteLine("Rectangle Test");
            Console.WriteLine("====================================================================================================");

            Console.WriteLine("Before resize:");
            foreach (Rectangle rectangle in rectangles)
            {
                Console.WriteLine(rectangle);
            }

            Console.WriteLine("After resize:");
            foreach (Rectangle rectangle in rectangles)
            {
                rectangle.Resize();
                Console.WriteLine(rectangle);
            }

            // Square Test
            Square[] squares = new Square[3];

            squares[0] = new Square();
            squares[1] = new Square(2.3);
            squares[2] = new Square(5.8, "yellow", true);

            Console.WriteLine("====================================================================================================");
            Console.WriteLine("Square Test");
            Console.WriteLine("====================================================================================================");

            Console.WriteLine("Before resize:");
            foreach (Square square in squares)
            {
                Console.WriteLine(square);
            }

            Console.WriteLine("After resize:");
            foreach (Square square in squares)
            {
                square.Resize();
                Console.WriteLine(square);
            }
        }        
    }
}
