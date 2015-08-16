using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Replace_tags
{
    class Program
    {
//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
//<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
        // out put = <p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string replaced = input.Replace("<a href=", "[URL=");
            //Console.WriteLine(replaced);

            List<char> final = new List<char>();

            for (int i = 0; i<replaced.Length; i++)
            {
                final.Add(replaced[i]);

                if (replaced[i] == '>'&& replaced[i-1] !='a'&&replaced[i-1] !='p'&&replaced[i-2]!='/')
                {
                    final.Remove(replaced[i]);
                    final.Add(']');
                }
            }
                Console.WriteLine(string.Join("", final));



            //bool normalState = true;
            //bool tagState = false;
            //List<char> = new List<char>();

            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (input[i])

            //}


        }
    }
}
