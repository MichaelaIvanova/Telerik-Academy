using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04.Compare_text_files
{
    class Program
    {
        //compare line by line , they are equal
        static void Main(string[] args)
        {
            using(StreamReader reader1 = new StreamReader(@"text1.txt"))
            {
                using (StreamReader reader2 = new StreamReader(@"text2.txt"))
                {
                    string lineReader1 = reader1.ReadLine();
                    string lineReader2 = reader2.ReadLine();
                    int count = File.ReadLines(@"text2.txt").Count();// vzimame ob6tiq broj redeove
                    //Console.WriteLine(count);
                    int counterSame = 0;

                    List<string> same = new List<string>();
                    List<string> diff = new List<string>();
                    int currIndex = 1;//indexer of lines

                    while(lineReader1 != null)
                    {
                        if (lineReader1 == lineReader2)
                        {  
                            same.Add(currIndex.ToString());
                            currIndex++;
                            counterSame++;
                        }
                        else
                        {
                            diff.Add(currIndex.ToString());
                            currIndex++;
                        }
                        lineReader1 = reader1.ReadLine();
                        lineReader2 = reader2.ReadLine();
                    }

                    Console.WriteLine("{0} lines are same, {1} lines are diff", counterSame, count-counterSame);
                    Console.WriteLine("the same lines are at indexes:");
                    Console.WriteLine(string.Join(" & ", same));
                    Console.WriteLine("the diff lines are at indexes:");
                    Console.WriteLine(string.Join(" & ", diff));

                }


            }

        }
    }
}
