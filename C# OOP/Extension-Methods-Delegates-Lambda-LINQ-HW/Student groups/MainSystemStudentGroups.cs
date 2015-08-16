using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_groups
{
    class MainSystemStudentGroups
    {
        static void Main(string[] args)
        {
            //9.Create a List<Student> with sample students. 
            //9.Select only the students that are from group number 2.

            List<Student> studentGroup = new List<Student> {
                new Student("Asia", "Petrova", "k90906", "02 08889 1 2 3","a.p@abv.bg", new List<int>{2,2,3,6,6}, 1),
                new Student("BAsia", "BPetrova", "k90906009", "02 08889 1 2 99","a.p.hghg@abv.bg", new List<int>{3,2,3,6,6}, 3),
                new Student("CAsia", "CPetrova", "k909000001", "08889 1  3 4 5 ","c.cpetrova@gmail.com", new List<int>{2,2,2,26,2}, 2),
                new Student("DAsia", "DPetrova", "k909066666", "08889 1  3 4 7 ","c.cpetrova@gbg.bg", new List<int>{6,6,6,2,6}, 2),
            };
            //Select only the students that are from group number 2. and order by first name
             var sorted =                              
               from st in studentGroup
               where st.GroupNumber == 2
               orderby st.FirstName
               select st;

            //Student groups extensions
            //Implement the previous using the same query expressed with extension methods.

            var result = studentGroup.SelectGroup2();
            Print(result);
            var resultmail = studentGroup.SelectGroupAbv();
            Print(resultmail);
            var resultSofia = studentGroup.SelectGroupPhoneSofia();
            Print(resultSofia);
            studentGroup.SelectExcelentMark();
            studentGroup.SelectPoorMark();
            studentGroup.SelectAllMarks2006();

            //Problem 18. Grouped by GroupNumber
            var grouped = studentGroup.OrderBy(x => x.GroupNumber).ToList();
            Print(grouped);
            // problem 19
            studentGroup.Grouped();
        }

        public static void Print(List<Student> result)
        {
            foreach (Student st in result)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName + " " + st.GroupNumber);
            }
        }

    }
}
