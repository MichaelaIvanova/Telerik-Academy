using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Parse_tags
{
    class Program
    {
//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
        static void Main(string[] args)
        {
            //Console.WriteLine("enter text");
            //string text = Console.ReadLine();
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
           string start = "<upcase>";
            string end = "</upcase>";

            StringBuilder uppercaseText = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '<')
                {
                    i += start.Length;
                    while (text[i] != '<')
                    {
                        uppercaseText.Append(text[i].ToString().ToUpper());
                        i++;
                    }
                    i += end.Length-1;// za6tot e s / po dulug.
                }
                else
                {
                    uppercaseText.Append(text[i]);
                }
            }
            Console.WriteLine(uppercaseText.ToString());
         

                
            

        }
       // static string ExtractString(string s, string start, string end)
       // {
            // You should check for errors in real-world code, omitted for brevity

 
                //int startIndex = s.IndexOf(start) + start.Length;
                //int endIndex = s.IndexOf(end, startIndex);
                //string current = s.Substring(startIndex, endIndex - startIndex).ToUpper();
                
            

           // return current;
       // }
    }
}
