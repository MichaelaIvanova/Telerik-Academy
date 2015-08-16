using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triangle_surface
{
    class TriangleSurface
    {
        //Write methods that calculate the surface of a triangle by given:
        //Side and an altitude to it;
        //Three sides;
         //Two sides and an angle between them;
        static void Main(string[] args)
        {
            Console.WriteLine("enter trinagle side a:");
                int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter trinagle height from a:");
                int h = int.Parse(Console.ReadLine());
            Console.WriteLine("enter trinagle side b:");
                int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter trinagle side c:");
                int c = int.Parse(Console.ReadLine());
            Console.WriteLine("enter trinagle angle between b and c:");
                double angle = double.Parse(Console.ReadLine());

                Console.WriteLine("Area calculated with a and h is {0}", AreaWithAandH(a, h));
                Console.WriteLine("Area calculated with 3 sides a,b,c is {0}", AreaWithABC(a,b,c));
                Console.WriteLine("Area calculated with 2 sides b,c and angle is {0}", AreaWithCandBandAngle(b, c, angle));
        }
        static double AreaWithAandH (int a, int h)
        {
            double area = (a * h) / 2;
                return area;
        }
        static double AreaWithABC (int a, int b, int c)
        {
            int p = (a + b + c) / 2;// half the perimeter 
            int root = p * (p - a) * (p - b) * (p - c);
            double area = Math.Sqrt(root);
            return area;
            
        }
        static double AreaWithCandBandAngle (int b, int c, double angle)
        {
            double angleDegrees = Math.PI * angle/ 180.0;// turn to degrees
            double sin = Math.Sin(angleDegrees);
            double area = (b * c * sin) / 2;
            return area;
        }
    }
}
