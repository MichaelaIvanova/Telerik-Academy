using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Palindromes
{
    class Palindromes
    {
        //Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
        //A palindrome is a word, phrase, number, or other sequence of characters which reads the same backward or forward.
        static void Main(string[] args)
        {
            string input = "I listen to ABBA.I am gosho i like lamal, I run exe and study in telerik.I work hamal, lol.";
            string[] word = input.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
            
            List<string> palidromes = new List<string>();

            foreach (string str in word)
            {
                int lenght = str.Length;

                if (lenght %2 == 0 && lenght >1)
                {
                    for (int i = 0; i < lenght;  i++)
                    {
                        if ( str [i] == str[lenght - i-1])
                        {
                            palidromes.Add(str);
                        }
                    }
                }
                else if (lenght%2 !=0 && lenght >1)
                {
                    for (int i = 0; i < lenght; i++)
                    {
                        int middleIndex = lenght / 2;
                        string firstPart = str.Substring(0, middleIndex);
                        string secondPart = str.Substring(middleIndex + 1);
                        string reverse = Reverse(secondPart);

                        if (firstPart == reverse)
                        {
                            palidromes.Add(str);
                        }
                    }
                }              
            }
            List<string> noDupes = palidromes.Distinct().ToList();// mahan dublicatite

            Console.WriteLine(string.Join(",",noDupes));
        }
        static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
