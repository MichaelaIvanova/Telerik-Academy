using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Students_and_workers
{
    //Define a new class Student which is derived from Human and has a new field – grade.
    public class Student:Human
    {
        private int grade;

        public Student (string firstName, string lastName, int grade): base (firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get { return this.grade; }
            private set 
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Grade in non negative !");
                else
                    this.grade = value;
            }
        }

    }
}
