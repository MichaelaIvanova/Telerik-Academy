using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_Type_System___HW
{
    public class MainSysStudent
    {
        static void Main()
        {
            Student studentPesho = new Student("Pesho", "Petrov", "Ivanov", 1234,"Sofia", "098977777","pp@abv.bg", 2,
                Univercity.SofiaUni, Faculty.ArtFak, Specialty.Maths);

            Student studentGosho = new Student("Gosho", "Petrov", "Ivanov", 1234, "Sofia", "098977777", "pp@abv.bg", 2,
                Univercity.SofiaUni, Faculty.ArtFak, Specialty.Maths);

            Console.WriteLine(studentPesho.ToString());
            // compare by ssn
            Console.WriteLine(studentPesho.Equals(studentGosho));
            Console.WriteLine(studentGosho == studentPesho);
            Console.WriteLine(studentGosho != studentPesho);
            Console.WriteLine(studentPesho.GetHashCode());
            // clone

            var newStudent = (Student)studentGosho.Clone();// trqbva da se kastne!
            Console.WriteLine(newStudent.FirstName);
            // compare
            Console.WriteLine("compare");
            Console.WriteLine(studentGosho.CompareTo(newStudent));
            Console.WriteLine(studentGosho.CompareTo(studentPesho));

        }
    }
}
