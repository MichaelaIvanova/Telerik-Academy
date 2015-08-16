using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_classes___part_2___HW
{
    class MainSystem
    {
        static void Main()
        {
           //1.enable printing a 3D point.
            Point pointOne = new Point(1,2,-4);
            Console.WriteLine("the following is a test:");
            pointOne.ToString();
            // 2.checking the private static readonly point
            Console.WriteLine("the initinal readonly point is (0,0,0) and you cannot change it:");
            Point zero = Point.ZeroPoint;
            zero.ToString();
            decimal distance = CalcDistance.CalcDistanceBetween(pointOne, zero);
            Console.WriteLine("The distance is {0}", distance);

            // cheking Paths

            Path ops = new Path();
            ops.Add(zero);
            ops.Add(pointOne);
            ops.Add(new Point(2, 2, 2));
            ops.PointList.Add(new Point(12, 12, 13));// ops.PointList my dava vsi4ki opcii na lista
            int number = ops.Count;
           // Console.WriteLine(ops.PointList.ElementAt(1).ToString());

            PathStorage.Save(ops, @"text.txt");
            Path result = new Path();// tyk gi pulnim
            PathStorage.Load(@"text.txt", result);

            //Check it
            Console.WriteLine("the final result is:");
            foreach (Point point in result.PointList )
            {
                Console.WriteLine("{0} {1} {2}", point.X, point.Y, point.Z);
            }


        }
    }
}
