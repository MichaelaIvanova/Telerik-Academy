using System;

    class GravitationMoon
    {
        static void Main()
        {
            Console.WriteLine("Enter you weight in kg:");
            double weightEarth = double.Parse(Console.ReadLine());
            double weightMoon = (weightEarth * 0.17);
            Console.WriteLine("{0} is your weight on the Moon", weightMoon);


        }
    }

