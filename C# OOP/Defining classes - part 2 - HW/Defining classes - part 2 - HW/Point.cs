using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_classes___part_2___HW
{
    //1.Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
//1.Implement the ToString() to enable printing a 3D point.
    public struct Point
    {
        //2.Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.

        private decimal x;
        private decimal y;
        private decimal z;
        private static readonly Point zero = new Point(0, 0, 0);

        public decimal X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public decimal Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public decimal Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        //static property to return the point
        public static Point ZeroPoint// vru6ta 0,0,0
        {
            get { return zero;}
            private set { ;}
        }

        public Point(decimal x, decimal y, decimal z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }



         

        public override string ToString()
         {
            Console.WriteLine("X cooredinate is {0}", this.x);
            Console.WriteLine("Y cooredinate is {0}", this.y);
            Console.WriteLine("Z cooredinate is {0}", this.z);
            return base.ToString();
         }
        
    }
}
