using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _11.Prefix__test
{
    class Program
    {
        //Write a program that deletes from a text file all words that start with the prefix test.
        //Words contain only the symbols 0…9, a…z, A…Z, _.
        static void Main()
        {
            //files are in 'bin/Debug' directory of the project
            using (StreamReader reader = new StreamReader("test.txt"))
            {
                using (StreamWriter output = new StreamWriter("fixed.txt"))
                {
                    string line = reader.ReadLine();
                    List<string> removed = new List<string>();

                    while (line != null)
                    {
                        List<string> words = line.Split(' ').ToList();
                        foreach (string word in words)
                        {
                            if (word[0] == 't' && word[1] == 'e' && word[2] == 's'
                                   && word[3] == 't' && word.Length > 3)
                            {
                               // removed.Add(word.Replace("test", ""));
                            }
                            else
                                removed.Add(word);
                        }
                        line = reader.ReadLine();
                    }
                    Console.WriteLine(string.Join(" ", removed));

                    output.WriteLine(string.Join(" ", removed));
                }
            }
            Console.WriteLine("All words starting with \"test\" removed.");
        }
    }
}
