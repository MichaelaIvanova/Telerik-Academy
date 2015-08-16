using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _19.Dates_from_text_in_Canada
{
    class Program
    {
        //Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
        //Display them in the standard date format for Canada.
        static void Main(string[] args)
        {
            string text = "Dwayne Douglas Johnson was born 02.05.1972. The Rock gained fame in WWE from 03.1996 to 03/2004.";
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> dates = new List<string>();
            // gledame da ima to4no 3 to4ki
            foreach ( string str in words)
            {
                int dotsCount = DotCounter(str);
                if(dotsCount == 3)
                {
                    dates.Add(str);
                }
            }
            Console.WriteLine(string.Join("5", dates));

            List<string> datesCorr = new List<string>();// validirame mestata na to4kite

            foreach( string str in dates)
            {
                int dotFirstIndex = str.IndexOf('.');
                string next = str.Substring(dotFirstIndex + 1);
                int secondIndex = next.IndexOf('.');
                int dotSecondIndec = secondIndex + dotFirstIndex+1;// pribavqme za da vidim v celia string koi index e
                int dotThirdIndex = str.LastIndexOf('.');
                // pri nas indeksite na to4kite trqbva da sa: 2, 5 i 10 i duljinata trqbav da e sus6tat t.e 11
                if ( dotFirstIndex == 2 && dotSecondIndec ==5 && dotThirdIndex == 10 && str.Length == 11)
                {
                    datesCorr.Add(str);
                }
            }
            Console.WriteLine("really it is corect:");
            Console.WriteLine(string.Join("5", datesCorr));

            // In candean
            foreach (string str in datesCorr)
            {
                string candadean = str.Remove(str.Length - 1);// nova promenliva za6toto ina4e e samo read only
                DateTime date = DateTime.ParseExact(candadean, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine(date.ToShortDateString().ToString(new CultureInfo("en-CA")));
            }
        }
        static int DotCounter(string str)
        {
            int counter = 0;
            foreach(char symbol in str)
            {
                if (symbol == '.')
                    counter++;
            }
            return counter;
        }
    }
}
