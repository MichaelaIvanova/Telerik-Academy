using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Text_Files___HW
{
    class Program
    {
  //Write a program that reads a text file and prints on the console its odd lines.
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader(@"test.txt"))
            {
                int lineNum = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (lineNum % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }
                    lineNum++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}
