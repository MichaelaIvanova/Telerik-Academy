using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.First_before_last
{
    public static class StudentExtensions
    {
        //problem 3 method that from a given array of students finds all students whose first name is before its last name alphabetically.
        public static IList<Student> FistBeforeLastName(this IList<Student> studentsGroup)
        {                    
            var sorted = studentsGroup.Where(st => st.FirstName.CompareTo(st.LastName) <0 ).Select(st=>st).ToList();      // Using Lambda expression
            return sorted;
        }
        // print list
        public static void Print (this IList<Student> studentsGroup)
        {
            foreach (Student st in studentsGroup)
            {
                Console.WriteLine(st.FirstName +" " + st.LastName);
            }
        }
       // Problem 4. Age range
        //Write a LINQ query that finds the first name and last name 
        //of all students with age between 18 and 24.

        public static Student FistBetween18and24(this IList<Student> studentGroups)
        {
            Student fistStudent = studentGroups.Where(st=>st.Age>=18 && st.Age<=24).First();
            return fistStudent;
        }
        //Problem 5. Order students
        //Using the extension methods OrderBy() and ThenBy() with 
        //lambda expressions sort the students by first name and last name in descending order.

        public static IList<Student> SortNamesFirtsAndThanLastDes(this IList<Student> studentGroups)
        {
            var sorted = studentGroups.OrderByDescending(st => st.FirstName)
                                       .ThenByDescending(st => st.LastName).ToList();
            Console.WriteLine("Descending order of students' names:");
            return sorted;
        }

    }
}
