using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining___Classes___part_1__HW
{
    class Display
    {
        //Problem 1: Initialize classes Display

        private double? size;
        private ulong? numberOfColors;

        // Problem 5: Encapsulate all data fields
        public double? Size
        {
            get { return size; }
            set
            {
                if(value<0)
                {
                    throw new ArgumentException("Must be positive since it is a size");
                }
                else
                {
                    this.size = value;
                }
            }
        }
        public ulong? Colors
        {
            get { return numberOfColors; }
            set
            {
                if (value == null || value > 0)
                {
                    this.numberOfColors = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The colors of the display must be positive numbers.");
                }
            }
        }
        public Display()  // tova e default constructor
        {
            this.size = null;
            this.numberOfColors = null;
        }
        //Problem 2: Define constructors for the Display
        
        public Display(double? size, ulong? numberOfColors)// imame samo za izvikvane tezi 2 ne6ta
            : this()
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }
    }
}
