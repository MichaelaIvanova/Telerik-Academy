using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Parse_URL
{
    class Program
    {
//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
        static void Main(string[] args)
        {
            string input = "http://telerikacademy.com/Courses/Courses/Details/212";
            //string [] split = input.Split(new char[]{':','.'});
           // string protocol = split[0];

            List<string> urlElements = new List<string>();

            for ( int i = 0; i <input.Length; i++)
            {
                if(input[i] == ':')
                {
                    string protocol = input.Substring(0, i);
                    Console.WriteLine("protocol = [{0}]",protocol);
                }
                if(input[i]=='/' && input[i+1]=='/')
                {
                    string body = input.Substring(i + 2);
                    int indexNextIdent = body.IndexOf('/');
                    string server = body.Substring(0, indexNextIdent);
                    string resource = body.Substring(indexNextIdent + 1);
                    Console.WriteLine("server = [{0}]", server);
                    Console.WriteLine("source = [{0}]", resource);
                }

                
            }
            
        }
    }
}
