using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Extract_e_mails
{
    class Program
    {
        //Write a program for extracting all email addresses from given text.
        //All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
        static void Main()
        {
            string text = "mail examples example@abv.bg or dwayne.johnson@gmail.com are valid.These emails: example@yahoo.  @academy.com how@you.is. are not valid.";
            string [] splited = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> mails = new List<string>();

            foreach(string str in splited)
            {
                if(str.Contains('@') && str.Contains('.'))
                {
                    mails.Add(str);
                }
            }
           // Console.WriteLine(string.Join(",", mails));

            List<string> correct = new List<string>();

            foreach(string s in mails)
            {
                int lastPositionDot = s.Length - 1;
                int lastCharDot = s.LastIndexOf('.');
                int firstPositionMonkey = 0;
                int firstCharMonkey = s.IndexOf('@');//first index by deafault

                if(lastPositionDot!=lastCharDot && firstCharMonkey!=firstPositionMonkey)
                {
                    correct.Add(s);
                }

            }
            Console.WriteLine("the only correct mails are:");
            Console.WriteLine(string.Join(",", correct));

        }

    }
}