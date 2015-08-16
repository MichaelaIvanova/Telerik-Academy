using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _09.Delete_odd_lines
{
    class Program
    {
        static void Main()
        {
            //file is in 'bin/Debug' directory of the project
            List<string> evenLines = new List<string>();
            using (StreamReader reader = new StreamReader("text.txt"))
            {
                int lineNum = 1;
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (lineNum % 2 == 0)
                    {
                        evenLines.Add(line);
                    }
                    lineNum++;
                    line = reader.ReadLine();
                }
            }
            using (StreamWriter output = new StreamWriter("text.txt"))
            {
                for (int i = 0; i < evenLines.Count; i++)
                {
                    output.WriteLine(evenLines[i]);
                }
            }
            Console.WriteLine("Odd lines removed!");
        }
    }
}
