using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

struct Dwarf
{
    public int x;
    public int y;
    public string c;
    public ConsoleColor color;

}


class SmDwarf
{
    static void PrintOnPosition(int x, int y, string c, ConsoleColor color = ConsoleColor.White)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }
    static void PrintStatOnPosition(int x, int y, string c, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }


    static void Main(string[] args)
    {
        int playFieldWidth = 20;
        int livesCount = 5;
        int score = 0;

        Console.BufferHeight = Console.WindowHeight = 20;
        Console.BufferWidth = Console.WindowWidth = 40;
        Dwarf userDwarf = new Dwarf();
        userDwarf.x = 10;
        userDwarf.y = Console.WindowHeight - 1;
        userDwarf.c = "(0)";
        userDwarf.color = ConsoleColor.Green;

        Random randomGen = new Random();
        List<Dwarf> objList = new List<Dwarf>();

        while (true)
        {
            bool hit = false;
            int variations = randomGen.Next(0, 100);
            if (variations <= 10)
            {
                Dwarf objectOne = new Dwarf();
                objectOne.color = ConsoleColor.Cyan;
                objectOne.x = randomGen.Next(0, playFieldWidth);
                objectOne.y = 0;
                objectOne.c = "^";
                objList.Add(objectOne);
            }
            else if (variations > 10 && variations <= 20)
            {
                Dwarf objectOne = new Dwarf();
                objectOne.color = ConsoleColor.Magenta;
                objectOne.x = randomGen.Next(0, playFieldWidth);
                objectOne.y = 0;
                objectOne.c = "@";
                objList.Add(objectOne);
            }
            else if (variations > 20 && variations <= 30)
            {
                Dwarf objectOne = new Dwarf();
                objectOne.color = ConsoleColor.Yellow;
                objectOne.x = randomGen.Next(0, playFieldWidth);
                objectOne.y = 0;
                objectOne.c = "*";
                objList.Add(objectOne);
            }
            else if (variations > 30 && variations <= 40)
            {
                Dwarf objectOne = new Dwarf();
                objectOne.color = ConsoleColor.DarkYellow;
                objectOne.x = randomGen.Next(0, playFieldWidth);
                objectOne.y = 0;
                objectOne.c = "&";
                objList.Add(objectOne);
            }
            else if (variations > 40 && variations <= 50)
            {
                Dwarf objectOne = new Dwarf();
                objectOne.color = ConsoleColor.Gray;
                objectOne.x = randomGen.Next(0, playFieldWidth);
                objectOne.y = 0;
                objectOne.c = "+";
                objList.Add(objectOne);

            }
            else if (variations > 50 && variations <= 60)
            {
                Dwarf objectOne = new Dwarf();
                objectOne.color = ConsoleColor.Magenta;
                objectOne.x = randomGen.Next(0, playFieldWidth);
                objectOne.y = 0;
                objectOne.c = "%";
                objList.Add(objectOne);

            }
            else if (variations > 60 && variations <= 70)
            {
                Dwarf objectOne = new Dwarf();
                objectOne.color = ConsoleColor.Yellow;
                objectOne.x = randomGen.Next(0, playFieldWidth);
                objectOne.y = 0;
                objectOne.c = "$";
                objList.Add(objectOne);
            }
            else if (variations > 70 && variations <= 80)
            {
                Dwarf objectOne = new Dwarf();
                objectOne.color = ConsoleColor.White;
                objectOne.x = randomGen.Next(0, playFieldWidth);
                objectOne.y = 0;
                objectOne.c = "#";
                objList.Add(objectOne);

            }
            else if (variations > 80 && variations <= 85)
            {
                Dwarf objectOne = new Dwarf();
                objectOne.color = ConsoleColor.Blue;
                objectOne.x = randomGen.Next(0, playFieldWidth);
                objectOne.y = 0;
                objectOne.c = "!";
                objList.Add(objectOne);

            }
            else if (variations > 85 && variations <= 90)
            {
                Dwarf objectOne = new Dwarf();
                objectOne.color = ConsoleColor.DarkMagenta;
                objectOne.x = randomGen.Next(0, playFieldWidth);
                objectOne.y = 0;
                objectOne.c = ".";
                objList.Add(objectOne);

            }
            else
            {
                Dwarf objectOne = new Dwarf();
                objectOne.color = ConsoleColor.DarkRed;
                objectOne.x = randomGen.Next(0, playFieldWidth);
                objectOne.y = 0;
                objectOne.c = ",";
                objList.Add(objectOne);
            }


            if (Console.KeyAvailable)
            {
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if ((userDwarf.x - 1) >= 0)
                    {
                        userDwarf.x = userDwarf.x - 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if ((userDwarf.x + 1) < playFieldWidth)
                    {
                        userDwarf.x = userDwarf.x + 1;
                    }
                }

            }
            List<Dwarf> newList = new List<Dwarf>();


            for (int i = 0; i < objList.Count; i++)
            {
                Dwarf oldDwarf = objList[i];
                Dwarf objectOne = new Dwarf();
                objectOne.x = oldDwarf.x;
                objectOne.y = oldDwarf.y + 1;
                objectOne.c = oldDwarf.c;
                objectOne.color = oldDwarf.color;

                if (objectOne.y == userDwarf.y && (objectOne.x == userDwarf.x || objectOne.x == (userDwarf.x + 1) || objectOne.x == (userDwarf.x + 2)))
                {
                    livesCount--;
                    score -= 100;
                    hit = true;
                    if (livesCount <= 0)
                    {
                        PrintStatOnPosition(2, 10, "GAME OVER!", ConsoleColor.Red);
                        PrintStatOnPosition(2, 11, "Press ENTER to exit", ConsoleColor.Red);
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
                if (objectOne.y < Console.WindowHeight)
                {
                    newList.Add(objectOne);
                    score++;
                }

            }

            objList = newList;


            Console.Clear();
            PrintOnPosition(userDwarf.x, userDwarf.y, userDwarf.c, userDwarf.color);
            foreach (var dwarf in objList)
            {
                if (hit)
                {
                    Console.Clear();
                    PrintOnPosition(userDwarf.x, userDwarf.y, "#", ConsoleColor.Red);
                }
                else
                {
                    PrintOnPosition(dwarf.x, dwarf.y, dwarf.c, dwarf.color);
                }
            }

            PrintStatOnPosition(25, 10, "Lives:" + livesCount, ConsoleColor.White);
            PrintStatOnPosition(25, 9, "Score:" + score, ConsoleColor.Yellow);

            Thread.Sleep(150);
        }
    }
}
 
