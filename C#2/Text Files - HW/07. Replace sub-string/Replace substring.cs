using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _07.Replace_sub_string
{
    class Program
    {
        //Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
        static void Main()
        {
            //file is in 'bin/Debug' directory of the project
            using (StreamReader reader = new StreamReader("text.txt"))
            {
                using (StreamWriter output = new StreamWriter("result.txt"))
                {
                    for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                    {
                        string newLine = line.Replace("start", "finish");
                        output.WriteLine(newLine);
                    }
                }
            }
            Console.WriteLine("Replacing done!");
        }
    }
}
