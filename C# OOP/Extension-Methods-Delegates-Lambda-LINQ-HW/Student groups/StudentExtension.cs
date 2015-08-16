using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_groups
{
    //10. Student groups extensions
    //Implement the previous using the same query expressed with extension methods.
    public static class StudentExtension
    {
        public static List<Student> SelectGroup2(this List<Student> students)
        {
            var result =
                from st in students
                where st.GroupNumber == 2
                orderby st.FirstName
                select st;

            return result.ToList();
        }
        //Problem 11. Extract students by email

        public static List<Student> SelectGroupAbv(this List<Student> students)
        {
            var result =
                from st in students
                where st.Email.Contains("abv.bg")
                orderby st.FirstName
                select st;

            return result.ToList();
        }
        //Problem 12. Extract students by phone
        //Extract all students with phones in Sofia.
        public static List<Student> SelectGroupPhoneSofia(this List<Student> students)
        {
            var result =
                from st in students
                where st.PhoneNumber.Substring(0,2) == "02"
                orderby st.FirstName
                select st;

            return result.ToList();
        }
        //Problem 13. Extract students by marks
        //Select all students that have at least one mark Excellent (6) 
        //into a new anonymous class that has properties – FullName and Marks.

        public static void SelectExcelentMark(this List<Student> students)
        {
            var result =
                from st in students
                where st.Marks.Contains(6)
                orderby st.FirstName
                select new {FullName = st.FirstName.ToString(), Mark = st.Marks};

            Console.WriteLine("Students sorted by atleast one 6 mark");

            foreach (var student in result)
            {
                Console.WriteLine(student.FullName + "[" + string.Join(", ", student.Mark) + "]");
            }
            Console.WriteLine();
        }
        //Problem 14. Extract students with two marks
        public static void SelectPoorMark(this List<Student> students)
        {
            var result =
                from st in students
                where st.Marks.Contains(2)
                orderby st.FirstName
                select new { FullName = st.FirstName.ToString(), Mark = st.Marks };

            Console.WriteLine("Students sorted by atleast one 2 mark");

            foreach (var student in result)
            {
                Console.WriteLine(student.FullName + "[" + string.Join(", ", student.Mark) + "]");
            }
            Console.WriteLine();
        }
        //Problem 15. Extract marks
        //Extract all Marks of the students that enrolled in 2006. 
        //(The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

        public static void SelectAllMarks2006(this List<Student> students)
        {
            var result =
                from st in students
                where st.FN.Substring(4,2) == "06"
                orderby st.FirstName
                select st;

            Console.WriteLine("Students sorted all mark 2006 enrolled");

            foreach (Student student in result)
            {
                Console.WriteLine(student.FirstName + "[" + string.Join(", ", student.Marks) + "]");
            }
            Console.WriteLine();          
            
        }
        //Problem 19. Grouped by GroupName extensions
        public static void Grouped(this List<Student> students)
        {
            var grouped = students.OrderBy(x => x.GroupNumber).ToList();
            foreach(Student st in grouped)
            {
                Console.WriteLine(st.FirstName + " "+st.LastName + " "+st.GroupNumber);
            }
        }
    }
}
