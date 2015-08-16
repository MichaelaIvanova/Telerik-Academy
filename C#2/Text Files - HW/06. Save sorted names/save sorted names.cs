using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _06.Save_sorted_names
{
    class Program
    {
//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"text.txt");
            
            using (reader)
            {
                string line = reader.ReadLine();
                StreamWriter writer = new StreamWriter(@"sorted.txt");
                using (writer)
                {
                    List<string> names = new List<string>();
                    while (line != null)
                    {
                        names.Add(line);
                        line = reader.ReadLine();
                    }
                    names.Sort();
                    Console.WriteLine(string.Join("\n", names));

                    foreach (string name in names)
                    {
                        writer.WriteLine(name);
                    }
                }
            }
            Console.WriteLine("Lines are with numbers now!");
        }
    }
}
