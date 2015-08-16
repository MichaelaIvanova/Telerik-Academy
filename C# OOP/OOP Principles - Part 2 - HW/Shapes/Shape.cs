using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        //fine abstract class Shape with only one abstract 
        //method CalculateSurface() and fields width and height.
        private double width;
        private double height;

        public Shape (double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width 
        {
            get { return this.width; }
            
            private set
            { if (value <= 0)
            { throw new ArgumentOutOfRangeException("Width cannot be zero!"); }
                this.width=value; }
        }


        public double Height
        {   get { return this.height; }
            
            private set
            { if (value <= 0)
            { throw new ArgumentOutOfRangeException("Height cannot be zero!"); }
                this.height=value; }
        }

        public abstract double CalculateSurface();
    }

}
