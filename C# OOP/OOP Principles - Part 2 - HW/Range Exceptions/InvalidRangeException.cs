using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range_Exceptions
{
    public class InvalidRangeException<T>: ApplicationException
    {
  //Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range.
    //It should hold error message and a range definition [start … end].
        private T startRange;
        private T endRange;

        public InvalidRangeException(string message, T start, T end, Exception innerException):base(message, innerException)
        {
            this.StartRange = start;
            this.EndRange = end;
        }

        public InvalidRangeException(string message, T start, T end):this(message, start, end, null)
        {

        }

        public T StartRange { get; private set; }

        public T EndRange { get; private set; }
    }
}
