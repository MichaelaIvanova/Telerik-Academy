using System;


    class Program
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";
            object helloWorld = hello +' '+ world;
            object helloWorldS = (string)helloWorld;
            Console.WriteLine(helloWorldS);

        }
    }

