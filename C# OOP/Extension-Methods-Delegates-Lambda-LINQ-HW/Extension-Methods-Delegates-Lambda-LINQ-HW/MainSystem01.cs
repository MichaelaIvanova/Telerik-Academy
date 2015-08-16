using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods_Delegates_Lambda_LINQ_HW
{
    class MainSystem01
    {
        //Implement an extension method Substring(int index, int length) for the class StringBuilder that returns 
        //new StringBuilder and has the same functionality as Substring in the class String
        static void Main(string[] args)
        {
            string input = "abcdefg";
            StringBuilder finalinput = new StringBuilder(input);
           Console.WriteLine( finalinput.SubstringB(0, 3));
           Console.WriteLine(finalinput.ToString().Substring(0, 3));//for reference
        }
    }
}
