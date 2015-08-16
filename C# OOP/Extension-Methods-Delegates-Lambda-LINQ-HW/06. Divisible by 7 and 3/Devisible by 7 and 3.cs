using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Divisible_by_7_and_3
{
    class Devisible
    {
        //Write a program that prints from given array of integers all 
        //numbers that are divisible by 7 and 3. 
        //Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 3, 6, 21, 3, 7, 20000 };


            //Rewrite the same with LINQ.
            var resutl = from n in nums
                         where n % 3 == 0 && n % 7 == 0
                         select n;
            foreach ( int n in resutl)
            {
                Console.WriteLine(n);
            }
            // with lamda

            IList<int> finded = FindDevby7and3(nums);
            foreach (int n in finded)
                Console.WriteLine(n);
                     
        }
        static IList<int> FindDevby7and3(IList<int> nums)
        {
            var result = nums.Where(n => n % 3 == 0 && n % 7 == 0).Select(n => n).ToList();
            return result;
        }
    }
}
