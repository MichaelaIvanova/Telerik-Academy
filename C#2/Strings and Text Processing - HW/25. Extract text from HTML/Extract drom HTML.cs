using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.Extract_text_from_HTML
{
    class Program
    {
        //Write a program that extracts from given HTML file its title 
        //(if available), and its body text without the HTML tags.
        //<html>
  //<head><title>News</title></head>
  //<body><p><a href="http://academy.telerik.com">Telerik
  //  Academy</a>aims to provide free real-world practical
   // training for young people who want to turn into
   // skilful .NET software engineers.</p></body>
//</html>
        static void Main(string[] args)
        {
            string input = "<html><head><title>News</title></head><body><p><a href=\"http://academy.telerik.com\">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>";
           List<string>  splited = input.Split(new char[] { '<', '>','"' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string remove1 = "html";
            string remove2 = "head";
            string remove3 = "title";
            string remove4 = "/title";
            string remove5 = "/head";
            string remove6 = "/html";
            string remove7 = "p";
            string remove8 = "/p";
            string remove9 = "/a";
            string remove10 = "a";
            string remove11 = "a href=";
            string remove12 = "body";
            string remove13 = "/body";


            List<string> remove = new List<string>();
            remove.Add(remove1);
            remove.Add(remove2);
            remove.Add(remove3);
            remove.Add(remove4);
            remove.Add(remove5);
            remove.Add(remove6);
            remove.Add(remove7);
            remove.Add(remove8);
            remove.Add(remove9);
            remove.Add(remove10);
            remove.Add(remove11);
            remove.Add(remove12);
            remove.Add(remove13);


                for(int i = 0; i<splited.Count; i++)
                {
                    if(splited[i]==remove1)
                    {
                        splited.Remove(remove1);
                    }
                    if (splited[i] == remove2)
                    {
                        splited.Remove(remove2);
                    }
                    if (splited[i] == remove3)
                    {
                        splited.Remove(remove3);
                    }
                    if (splited[i] == remove4)
                    {
                        splited.Remove(remove4);
                    }
                    if (splited[i] == remove5)
                    {
                        splited.Remove(remove5);
                    }
                    if (splited[i] == remove6)
                    {
                        splited.Remove(remove6);
                    }
                    if (splited[i] == remove7)
                    {
                        splited.Remove(remove7);
                    }
                    if (splited[i] == remove8)
                    {
                        splited.Remove(remove8);
                    }
                    if (splited[i] == remove9)
                    {
                        splited.Remove(remove9);
                    }
                    if (splited[i] == remove10)
                    {
                        splited.Remove(remove10);
                    }
                    if (splited[i] == remove11)
                    {
                        splited.Remove(remove11);
                    }
                    if (splited[i] == remove12)
                    {
                        splited.Remove(remove12);
                    }
                    if (splited[i] == remove13)
                    {
                        splited.Remove(remove13);
                    }
                }
                //Console.WriteLine(string.Join(" ", splited));
            for (int i = 0; i<splited.Count; i++)
            {
                if(splited[i] == "p")
                {
                    splited.Remove("p");
                }
                if (splited[i] == "/html")
                {
                    splited.Remove("/html");
                }
            }
            Console.WriteLine(string.Join(" ", splited));
        }
    }
}
