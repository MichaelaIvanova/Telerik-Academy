using System;
    class BeerTime
    {
//A beer time is after 1:00 PM and before 3:00 AM.
//Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.
        static void Main()
        {
            Console.WriteLine("Enter time hh:mm tt");
            DateTime currentTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(currentTime);
            Console.WriteLine("Enter time hh:mm tt Beer starts");
            DateTime beerStarts = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(beerStarts);
            Console.WriteLine("Enter time hh:mm tt Beer ends");
            DateTime beerEnds = DateTime.Parse(Console.ReadLine());
            DateTime beerEnds2 = beerEnds.AddHours(24.00);
            Console.WriteLine(beerEnds2);


            if ( currentTime > beerStarts && currentTime < beerEnds2)
            {
                Console.WriteLine("It is beer time:)");
            
            }
            else
            {
                Console.WriteLine("It is NOT beer time:)");
            }


  

  




        }
    }

