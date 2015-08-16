using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_Type_System___HW
{
    //Define a class Student, which contains data about a student – 
    //first, middle and last name, SSN, permanent address, mobile phone e-mail, course, 
    //specialty, university, faculty.
    // Use an enumeration for the specialties, universities and faculties.

    public enum Specialty
    {
        Econmics,
        Maths,
        Law,
        Art,
    }

    public enum Univercity
    {
        SofiaUni,
        TU,
        UASG
    }

    public enum Faculty
    {
        FMI,
        StopFak,
        ArtFak,
        
    }
    public class Student: ICloneable, IComparable<Student>
    {
        private string firstName;
        private string lastName;
        private string middleName;
        private uint ssn;
        private string address;
        private string mobilePhone;
        private string email;
        private uint course;

        public Student(string fname, string mname, string lname, uint ssn, string address,
            string mobile, string email, uint course,
            Univercity univercity, Faculty faculty, Specialty speciality)
        {
            this.FirstName = fname;
            this.MiddleName = mname;
            this.LastName = lname;
            this.SSN = ssn;
            this.Address = address;
            this.MobilePhone = mobile;
            this.Email = email;
            this.Course = course;
            this.University = univercity;
            this.Faculty = faculty;
            this.Speciality = speciality;

        }

        // хубаво е да има валидация, но не ми се занимава:)
        public string FirstName { get; private set; }

        public string MiddleName { get ;private set; }

        public string LastName { get; private set; }
        public uint SSN { get; private set; }

        public string Address { get; private set; }

        public string MobilePhone { get; private set; }

        public string Email { get; private set; }

        public uint Course { get; private set; }

        public Specialty Speciality { get; private set; }

        public Univercity University { get; private set; }

        public Faculty Faculty { get; private set; }

        // Override the standard methods, inherited by System.Object: 
        //Equals(), ToString(), GetHashCode() and operators == and !=.

        public override bool Equals(object obj)
        {
            var anotherStudent = obj as Student;// kazvame my da se durvi kato student

            if (anotherStudent.FirstName == null) //nqma null za6toto nqma proazen konstructpr
                return false;
            if (this.SSN == anotherStudent.SSN)
                return true;
            else
                return false;
        }
        public override string ToString()
        {
            string result = string.Format("{0} {1} {2}", this.FirstName, this.MiddleName, this.LastName);
            return  result;
        }
        public override int GetHashCode()
        {
            var result = this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
            return result;
        }

        public static bool operator == (Student one, Student two)
        {
            if(one.Equals(two))
                return true;
            else
                return false;
        }
        public static bool operator !=(Student one, Student two)
        {
            if (one.Equals(two))
                return false;
            else
                return true;
        }

        //Add implementations of the ICloneable interface. 
        //The Clone() method should deeply copy all object's fields into a new object of type Student.

        public object Clone()
        {
            var newStudent = new Student(this.FirstName, this.MiddleName, this.LastName,
                this.SSN, this.Address, this.MobilePhone, this.Email, this.Course,
                this.University, this.Faculty, this.Speciality);
                
            return newStudent;
        }

        //Implement the IComparable<Student> interface to compare students 
        //by names (as first criteria, in lexicographic order) and by social security number
        //(as second criteria, in increasing order).
        public int CompareTo(Student other)
        {
          bool sameName = (this.FirstName == other.FirstName) && (this.LastName == other.LastName);
          bool sameSSN = (this.SSN == other.SSN);
          if (sameName && sameSSN)
              return 0;
          else 
              return -1;
         
        }
    }
}
