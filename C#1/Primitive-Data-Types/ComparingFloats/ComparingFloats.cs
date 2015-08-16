using System;

    class ComparingFloats
    {
        static void Main()
        {
            Console.WriteLine("Enter the fist float number");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second float number");
            double secondNumber = double.Parse(Console.ReadLine());
            double difference = firstNumber - secondNumber;
            Console.WriteLine("Difference between number: {0}", difference);

            double absoluteValue = Math.Abs(difference);
            Console.WriteLine("Absolute Value:{0}", absoluteValue);
            double eps = 0.000001;

            bool check = absoluteValue < eps;
            if (absoluteValue < eps)
                 {
                Console.WriteLine(check);
                 }
            if (absoluteValue >= eps)
                { 
            Console.WriteLine("Error");
                }


        }
    }

