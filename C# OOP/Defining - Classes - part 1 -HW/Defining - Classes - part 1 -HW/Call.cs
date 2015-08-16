using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining___Classes___part_1__HW
{
    //Create a class Call to hold a call performed through a GSM.
    //It should contain date, time, dialled phone number and duration (in seconds).
    class Call
    {
        private DateTime? date;
        private string dailledPhone;
        private uint? duration;

        // set property
        public DateTime? Date
        {
            get { return date; }
            set
            {
                try
                {
                    this.date = value;
                }
                catch (FormatException)
                {
                    throw new FormatException("Date format is invalid.");
                }
            }
        }
        public string DailledPhone
        {
            get { return dailledPhone; }
            set { this.dailledPhone = value; }
        }
        public uint? Duration
        {
            get { return duration; }
            set { this.duration = value; }
        }
        // kakvo da ima vseki call

        public Call()
        {
            this.date = null;
            this.dailledPhone = null;
            this.duration = null;
        }
        public Call(DateTime date, string dailledPhone, uint duration): this()
        {
            this.date = date;
            this.dailledPhone = dailledPhone;
            this.duration = duration;
        }



    }
}
