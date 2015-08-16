using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.First_before_last
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private byte age;

        public Student(string firstName, string lastName, byte age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be null or empty");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name cannot be null or empty");
                }

                this.lastName = value;
            }
        }

        public byte Age
        {
            get { return age; }
            private set
            {
                if (value < 0 || value >= 125)
                {
                    throw new ArgumentOutOfRangeException("Index is not valid age");
                }
                this.age = value;
            }
        }
    }
}
