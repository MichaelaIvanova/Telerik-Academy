using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.Line_numbers
{
    class Program
    {
        //Write a program that reads a text file and inserts line numbers in front of each of its lines.
        //The result should be written to another text file.
        static void Main()
        {
            StreamReader reader = new StreamReader(@"1.txt");

            using (reader)
            {
                string line = reader.ReadLine();
                StreamWriter writer = new StreamWriter(@"new.txt");
                int lineNum = 0;
                using (writer)
                {
                    while (line != null)
                    {
                        lineNum++;
                        writer.WriteLine("Line {0}: {1}", lineNum, line);
                        line = reader.ReadLine();
                    }
                }
            }
            Console.WriteLine("Lines are with numbers now!");
        }
    }
}