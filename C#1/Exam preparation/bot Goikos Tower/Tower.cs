using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        int widthX = (2 * n);
        int heightY = n;

        int dashRow = 2;
        int counter = 1;// 
        for (int i = 1; i <= heightY; i++)
        {
            int newY = heightY - i;
            int newX = widthX - (2 * newY + 2);
            Console.Write(new string('.', newY));
            Console.Write('/');
            if (dashRow == i)
            {
                Console.Write((new string('-', newX)));
                dashRow++;// добавям 1
                dashRow += counter;// добавям колкото се е завъртял цикъла и така винаги е с 1 повече от миналия път, т.е през 2 през 3 праз 4 и тн.
                counter++;
            }
            else
            {
                Console.Write(new string('.', newX));
            }
            Console.Write('\\');
            Console.WriteLine(new string('.', newY));

        }

    }
}




