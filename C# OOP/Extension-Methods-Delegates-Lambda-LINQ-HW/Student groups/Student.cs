using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_groups
{
    public class Student
    {
        //Create a class Student with properties FirstName, LastName, FN, 
        //Tel, Email, Marks (a List), GroupNumber.

        private string fistName;
        private string lastName;
        private string fn;
        private string tel;
        private string mail;
        private List<int> marks;
        private uint groupNumber;

        // constructor 
        public Student(string firstName, string lastName, string fN,
            string phoneNumber, string email, List<int> marks, int groupNumber)           
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fN;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        // properties

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FN { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }
        public List<int> Marks { get; private set; }
        public int GroupNumber { get; private set; }

        // method
        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
