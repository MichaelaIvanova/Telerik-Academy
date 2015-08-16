using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_classes___part_2___HW
{
    public static class CalcDistance
    {
        //3.Write a static class with a static method to calculate the distance between two points
        public static decimal CalcDistanceBetween(Point first, Point second)
        {
            double distance = Math.Sqrt((double)((first.X - second.X) * (first.X - second.X) 
                + (first.Y - second.Y) * (first.Y - second.Y)
                + (first.Z - second.Z) * (first.Z - second.Z)));
            return (decimal)distance;
        }

    }
}
