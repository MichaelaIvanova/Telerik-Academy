using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods_Delegates_Lambda_LINQ_HW
{
    //Implement an extension method Substring(int index, int length) for the class StringBuilder that returns 
    //new StringBuilder and has the same functionality as Substring in the class String
    public static class SubstringBuliderExtension
    {
       public static StringBuilder SubstringB(this StringBuilder input ,int indexStart, int subsringLenght)
       {
           StringBuilder result = new StringBuilder();
           for (int i = 0; i < input.ToString().Length; i++ )
           {
               if (i >= indexStart && i < subsringLenght)
                   result.Append(input[i]);
           }
              return result;
       }
    }
}
