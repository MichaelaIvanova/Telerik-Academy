using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining___Classes___part_1__HW
{
    class Battery
    {
        //Problem 3: Set enum BatteryType
        public enum BatteryType
        { LiIon=1, NiMH=2, NiCd=3, }

        //Problem 1: Initialize classes Battery

        private string bateryModel;
        private double? hoursIdle;
        private double? hoursTalk;

        //// Problem 5: Encapsulate all data fields
        public string Model
        {
            get { return bateryModel; }
            set
            {
                if(value.Length<0)
                { throw new ArgumentException("You must enter battery model."); }
                else
                { this.bateryModel = value; } // tova e kato string.lenght i dava stojnostta
            }
        }

        public double? HoursIdle
        {
            get { return hoursIdle; }
            set
            {
                if(value<0)
                { throw new ArgumentException("Hours must be positive or null"); }
                else
                { this.hoursIdle = value; }
            }
        }
        public double? HoursTalk
        {
            get { return hoursTalk; }
            set
            {
                if (value < 0)
                { throw new ArgumentException("Hours must be positive or null"); }
                else
                { this.hoursTalk = value; }
            }
        }

        //Define Constructors for Battery
        public Battery()// tova e default constructor
        {
            this.bateryModel = null;
            this.hoursIdle = null;
            this.hoursTalk = null;
        }
        public Battery(string bateryModel, double hoursIdle, double hoursTalk):this()//tova e pulniq konstruktor
        {
            this.bateryModel = bateryModel;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }
    }
}
