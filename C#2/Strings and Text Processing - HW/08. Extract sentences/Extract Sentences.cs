using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Extract_sentences
{
    class Program
    {
        //Write a program that extracts from a given text all sentences containing given word.
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string word = " in ";//ad spaces to destinc it and not to exclude it form beeing part of word
            string[] textBysentences = text.Split('.').ToArray();
            //Console.WriteLine(string.Join("&", textBysentences));

            StringBuilder textWithWordSEntences = new StringBuilder();

            foreach (string str in textBysentences)
            {
                if(str.Contains(word))
                {
                    textWithWordSEntences.Append(str);
                    textWithWordSEntences.Append('.');
                }
            }

            Console.WriteLine(textWithWordSEntences);

        }
    }
}
