using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Students_and_workers
{
    //Define abstract class Human with a first name and a last name.
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        //constructor
        public Human (string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        //properties
        public string FirstName
        {
            get { return this.firstName; }//uses fields
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
            get { return this.lastName; }// usese fileds
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be null or empty");
                }

                this.lastName = value;
            }
        }


    }
}
