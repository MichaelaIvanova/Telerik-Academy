using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.First_before_last
{
    class MainSystemStudent
    {
        static void Main(string[] args)
        {
            Student[] group = new Student[] { 
                new Student ("An", "Blagova", 17),
                new Student ("Ba" , "Catov", 21),
                new Student ("Fa", "Amov", 22)};

            group.Print();
            IList<Student> result = group.FistBeforeLastName();
            result.Print();
            Student fistbetween18and24 = group.FistBetween18and24();
            Console.WriteLine("{0} {1} is the fist between 18 and 24", fistbetween18and24.FirstName, fistbetween18and24.LastName);
            IList<Student> sorted = group.SortNamesFirtsAndThanLastDes();            
            sorted.Print();
            
        }
        
    }
}
