using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class MainSystemShapes
    {
        static void Main()
        {
            Triangle triangle = new Triangle(2, 3);
            Rectangle rectangle = new Rectangle(2, 3);
            Square square = new Square(2);
            Console.WriteLine("Triangle area is {0}", triangle.CalculateSurface());
            Console.WriteLine("Rectangle area is {0}", rectangle.CalculateSurface());
            Console.WriteLine("Square area is {0}", square.CalculateSurface());

            //Write a program that tests the behaviour of the CalculateSurface() method 
            //for different shapes (Square, Rectangle, Triangle) stored in an array

            Shape[] all = new Shape[] 
            {   new Triangle (2,3),
                new Rectangle(2,3),
                new Square (3)
            };

            foreach (Shape shape in all)
            {
                Console.WriteLine("{0} is the area of the object {1}",
                    shape.CalculateSurface(), shape.GetType());
            }

        }
    }
}
