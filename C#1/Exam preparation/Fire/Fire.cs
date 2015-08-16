using System;

    class Fire
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            int widthX = n;
            int heightY1 = widthX / 2;
            int heightY2 = widthX / 4;
            int heightY3 = widthX / 2;


           for (int i = 1; i <= heightY1; i++)
           {
               int newY = heightY1 - i;
               int newX = widthX - (2 * newY + 2);
               Console.Write(new string('.', newY));
               Console.Write('#');

               Console.Write(new string('.', newX));

               Console.Write('#');
               Console.WriteLine(new string('.', newY));
           }

           for (int i = heightY1 + heightY2; i >= heightY1+1; i--)
            {
                int newY2 = heightY1 + heightY2 - i;
                int newX = widthX - (2 * newY2 + 2);
                Console.Write(new string('.', newY2));
                Console.Write('#');

                Console.Write(new string('.', newX));

                Console.Write('#');
                Console.WriteLine(new string('.', newY2));
            }
           Console.WriteLine(new string('-', widthX));

           for (int i = heightY1 + heightY2+heightY3+1; i >= heightY1+heightY2 + 1+1; i--)
           {
               int newY2 = heightY1 + heightY2 + heightY3+1- i;
               int newX = widthX - (2 * newY2 + 2);
               Console.Write(new string('.', newY2));
               Console.Write(new string('\\',((newX/2)+1)));

               Console.Write(new string('/', ((newX / 2)+1)));
               Console.WriteLine(new string('.', newY2));
           }


        }
    }

