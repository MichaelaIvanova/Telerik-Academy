using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanks.Basic;
using Tanks.Basic.UI;

namespace Tanks
{
    class Tanks
    {
        static string[] eagleAscii = new string[] { "\\====-.  ,~\\ .-====/",
                                          "  \\====\\_||_/====/",
                                          "      \\==##==/",
                                          "        \\##/",
                                          "        /||\\" };

        const int CONSOLE_WIDTH = 80;
        const int CONSOLE_HEIGHT = 40;
        const int myTankWidth = 5;
        const int myTankHeight = 5;

        const int enemyTankType1Width = 3;//Type 1 dimensions
        const int enemyTankType1Height = 3;//Type 1 dimensions

        const int enemyTankType2Width = 5;//Type 2 dimensions
        const int enemyTankType2Height = 5;//Type 2 dimensions

        const int enemyTankType3Width = 7;//Type 3 dimensions
        const int enemyTankType3Height = 7;//Type 3 dimensions

        static char[,] field = new char[CONSOLE_HEIGHT, CONSOLE_WIDTH];
        static char[,] prevField = new char[CONSOLE_HEIGHT, CONSOLE_WIDTH];
        static int currentLevel = 0;
        enum ObjectType { 
            BrickWall, StoneWall,
            MyTankUp, MyTankLeft, MyTankDown, MyTankRight,
            enemyTankType1Up,enemyTankType1Down,enemyTankType1Left,enemyTankType1Right,//Type 1 tank
            enemyTankType2Up,enemyTankType2Down,enemyTankType2Left,enemyTankType2Right,//Type 2 tank
            enemyTankType3Up,enemyTankType3Down,enemyTankType3Left,enemyTankType3Right,//Type 3 tank
            Eagle, Bullet 
                        };
        static Dictionary<char[,], Position> movableObjectsOnField = new Dictionary<char[,], Position>();
        static char[,] myTank = null;
        static char[,] myTankUp = null;
        static char[,] myTankLeft = null;
        static char[,] myTankDown = null;
        static char[,] myTankRight = null;
        static Position myTankInitialPos = new Position(10, 30);
        static Position myTankPosition = myTankInitialPos;
        
        static char[,] enemyTankType1 = null;   
        static char[,] enemyTankType1Up = null;
        static char[,] enemyTankType1Left = null;
        static char[,] enemyTankType1Down = null;
        static char[,] enemyTankType1Right = null;
        static Position enemyTankType1InitialPos = new Position(0, 10);
        static Position enemyTankType1Pos = enemyTankType1InitialPos;
       
        static char[,] enemyTankType2 = null;
        static char[,] enemyTankType2Up = null;
        static char[,] enemyTankType2Left = null;
        static char[,] enemyTankType2Down = null;
        static char[,] enemyTankType2Right = null;
       
       
        static char[,] enemyTankType3 = null;
        static char[,] enemyTankType3Up = null;
        static char[,] enemyTankType3Left = null;
        static char[,] enemyTankType3Down = null;
        static char[,] enemyTankType3Right = null;
        

        static void Main(string[] args)
        {
            currentLevel = 1;
            Initialize();

            StartGame();
        }

        private static void Initialize () 
        {
            Basic.UI.ConsoleHelper.ClearAndResetConsole();
            Basic.UI.ConsoleHelper.ResizeConsole(CONSOLE_WIDTH, CONSOLE_HEIGHT);
            PlaceObjectsOnField();
        }

        private static void PlaceObjectsOnField ()
        {
            if (currentLevel == 1)
            {
                char[,] brickWall = GenerateObject(ObjectType.BrickWall, 18, 6);
                PlaceObjectOnField(brickWall, new Position(0, 18));

                brickWall = GenerateObject(ObjectType.BrickWall, 8, 10);
                PlaceObjectOnField(brickWall, new Position(6, 4));

                myTankUp = GenerateObject(ObjectType.MyTankUp, myTankHeight, myTankWidth);
                myTankLeft = GenerateObject(ObjectType.MyTankLeft, myTankHeight, myTankWidth);
                myTankDown = GenerateObject(ObjectType.MyTankDown, myTankHeight, myTankWidth);
                myTankRight = GenerateObject(ObjectType.MyTankRight, myTankHeight, myTankWidth);

                enemyTankType1Up = GenerateEnemyTanks(ObjectType.enemyTankType1Up, enemyTankType1Height, enemyTankType1Width);
                enemyTankType1Down = GenerateEnemyTanks(ObjectType.enemyTankType1Down, enemyTankType1Height, enemyTankType1Width);
                enemyTankType1Right = GenerateEnemyTanks(ObjectType.enemyTankType1Right, enemyTankType1Height, enemyTankType1Width);
                enemyTankType1Left = GenerateEnemyTanks(ObjectType.enemyTankType1Left, enemyTankType1Height, enemyTankType1Width);

                myTank = myTankUp;
                PlaceObjectOnField(myTank, myTankPosition);

                DrawEagle(); //If you can put this in PlaceObjectOnField
            }
            else if (currentLevel == 2)
            {

            }
            else if (currentLevel == 3)
            {

            }
            else if (currentLevel == 4)
            {

            }
            else if (currentLevel == 5)
            {

            }
            else throw new Exception("Invalid level " + currentLevel);
        }

        private static void PlaceObjectOnField(char[,] obj, Position position)
        {
            if (!isInField(position)) throw new Exception("Trying to place object outside field: " + position.X + " " + position.Y);
            //if (!IsFreeSpace(position)) throw new Exception("Trying to place object on occupied space: " + position.X + " " + position.Y); // This may not be needed cause there is CollisionDetection

            int rows = obj.GetLength(0);
            int cols = obj.GetLength(1);
            int currentX = position.X;
            int currentY = position.Y;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    field[currentX, currentY] = obj[i, j];                    
                    currentY++;
                }
                currentY = position.Y;
                currentX++;
            }

            //Basic.UI.ConsoleHelper.WriteOnPosition(obj, position.X, position.Y);
            if (!movableObjectsOnField.ContainsKey(obj)) movableObjectsOnField.Add(obj, new Position(position.X, position.Y));
            else movableObjectsOnField[obj] = new Position(position.X, position.Y);
        }        

        private static void DrawEagle()
        {
            int height = eagleAscii.GetLength(0);

            int left = (CONSOLE_WIDTH / 2) - (eagleAscii[0].Length / 2);
            int top = CONSOLE_HEIGHT - height;

            for(int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(left, top);
                for(int j = 0; j < eagleAscii[i].Length; j++)
                {
                    Console.Write(eagleAscii[i][j]);
                }
                top += 1;
            }
        }

        private static bool isInField (Position position)
        {
            return (position.X >= 0 && position.Y >= 0 && position.X <= CONSOLE_HEIGHT && position.Y <= CONSOLE_WIDTH);            
        }

        private static bool IsFreeSpace (Position position)
        {
            bool free = true;


            return free;
        }

        private static char[,]GenerateEnemyTanks(ObjectType type ,int height,int width)
        {
            char[,] obj = new char[height, width];

            if (type == ObjectType.enemyTankType1Up)
            {
                obj[0, 0] = ' ';
                obj[0, 1] = ' ';
                obj[0, 2] = '^';
                obj[0, 3] = ' ';
                obj[0, 4] = ' ';

                int middleIndex = height / 2;
                char middle = '^';

                for (int i = 1; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (j == 0 || j == 4) obj[i, j] = '#';
                        else if (j == 1 || j == 3) obj[i, j] = '+';
                        else
                        {
                            if (i > middleIndex) middle = '+';
                            else middle = '^';
                            obj[i, j] = middle;
                        }
                    }
                }
            }
            else if (type == ObjectType.enemyTankType1Left)
            {

                obj[2, 0] = '^';
                obj[2, 1] = ' ';
                obj[2, 2] = ' ';
                obj[2, 3] = ' ';
                obj[2, 4] = ' ';

                int middleIndex = height / 2;
                char middle = '^';

                for (int i = 0; i < height; i++)
                {
                    for (int j = 1; j < width; j++)
                    {
                        if (i == 0 || i == 4) obj[i, j] = '#';
                        else if (i == 1 || i == 3) obj[i, j] = '+';
                        else
                        {
                            if (j > middleIndex) middle = '+';
                            else middle = '^';
                            obj[i, j] = middle;
                        }
                    }
                }
            }
            else if (type == ObjectType.enemyTankType1Down)
            {

                obj[4, 0] = ' ';
                obj[4, 1] = ' ';
                obj[4, 2] = '^';
                obj[4, 3] = ' ';
                obj[4, 4] = ' ';

                int middleIndex = height / 2;
                char middle = '^';

                for (int i = 0; i < height - 1; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (j == 0 || j == 4) obj[i, j] = '#';
                        else if (j == 1 || j == 3) obj[i, j] = '+';
                        else
                        {
                            if (i < middleIndex) middle = '+';
                            else middle = '^';
                            obj[i, j] = middle;
                        }
                    }
                }
            }
            else if (type == ObjectType.enemyTankType1Right)
            {

                obj[2, 0] = ' ';
                obj[2, 1] = ' ';
                obj[2, 2] = ' ';
                obj[2, 3] = ' ';
                obj[2, 4] = '^';

                int middleIndex = height / 2;
                char middle = '^';

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width - 1; j++)
                    {
                        if (i == 0 || i == 4) obj[i, j] = '#';
                        else if (i == 1 || i == 3) obj[i, j] = '+';
                        else
                        {
                            if (j < middleIndex) middle = '+';
                            else middle = '^';
                            obj[i, j] = middle;
                        }
                    }
                }
            }





            else throw new Exception("Invalid object type " + type);
            return obj;
        }

        private static char[,] GenerateObject(ObjectType type, int height, int width) 
        {
            char[,] obj = new char[height, width];


            if (type == ObjectType.BrickWall)
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        obj[i, j] = '_';
                    }
                }
            }
            else if (type == ObjectType.StoneWall)
            {

            }
            else if (type == ObjectType.MyTankUp)
            {
                obj[0, 0] = ' ';
                obj[0, 1] = ' ';
                obj[0, 2] = '^';
                obj[0, 3] = ' ';
                obj[0, 4] = ' ';

                int middleIndex = height / 2;
                char middle = '^';

                for (int i = 1; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (j == 0 || j == 4) obj[i, j] = '#';
                        else if (j == 1 || j == 3) obj[i, j] = '+';
                        else
                        {
                            if (i > middleIndex) middle = '+';
                            else middle = '^';
                            obj[i, j] = middle;
                        }
                    }
                }                
            }
            else if (type == ObjectType.MyTankLeft)
            {

                obj[2, 0] = '^';
                obj[2, 1] = ' ';
                obj[2, 2] = ' ';
                obj[2, 3] = ' ';
                obj[2, 4] = ' ';

                int middleIndex = height / 2;
                char middle = '^';

                for (int i = 0; i < height; i++)
                {
                    for (int j = 1; j < width; j++)
                    {
                        if (i == 0 || i == 4) obj[i, j] = '#';
                        else if (i == 1 || i == 3) obj[i, j] = '+';
                        else
                        {
                            if (j > middleIndex) middle = '+';
                            else middle = '^';
                            obj[i, j] = middle;
                        }
                    }
                }
            }
            else if (type == ObjectType.MyTankDown)
            {

                obj[4, 0] = ' ';
                obj[4, 1] = ' ';
                obj[4, 2] = '^';
                obj[4, 3] = ' ';
                obj[4, 4] = ' ';

                int middleIndex = height / 2;
                char middle = '^';

                for (int i = 0; i < height-1; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (j == 0 || j == 4) obj[i, j] = '#';
                        else if (j == 1 || j == 3) obj[i, j] = '+';
                        else
                        {
                            if (i < middleIndex) middle = '+';
                            else middle = '^';
                            obj[i, j] = middle;
                        }
                    }
                } 
            }
            else if (type == ObjectType.MyTankRight)
            {

                obj[2, 0] = ' ';
                obj[2, 1] = ' ';
                obj[2, 2] = ' ';
                obj[2, 3] = ' ';
                obj[2, 4] = '^';

                int middleIndex = height / 2;
                char middle = '^';

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width - 1; j++)
                    {
                        if (i == 0 || i == 4) obj[i, j] = '#';
                        else if (i == 1 || i == 3) obj[i, j] = '+';
                        else
                        {
                            if (j < middleIndex) middle = '+';
                            else middle = '^';
                            obj[i, j] = middle;
                        }
                    }
                }
            }
            




            else throw new Exception("Invalid object type " + type);
            return obj;
        }

        private static void StartGame () 
        {
            bool over = false;
            while (!over)
            {
                Basic.UI.ConsoleHelper.WriteOnPosition(field,prevField, 0, 0);
                CheckPlayerMovement();
                //Basic.UI.ConsoleHelper.WriteOnPosition(field, 0, 0);
            }
        }

        private static void CheckPlayerMovement()
        {
            var key = Console.ReadKey();
            

            if (key.Key == ConsoleKey.UpArrow)
            {
                if (myTankPosition.X > 0)
                {
                    RemoveObject(myTankPosition, myTank.GetLength(0), myTank.GetLength(1));

                    myTank = myTankUp;
                    myTankPosition.X--;

                    MoveObject(myTank, myTankPosition, new Position(myTankPosition.X, myTankPosition.Y));
                }
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                if (myTankPosition.X + myTankHeight < CONSOLE_HEIGHT)
                {
                    RemoveObject(myTankPosition, myTank.GetLength(0), myTank.GetLength(1));

                    myTank = myTankDown;
                    myTankPosition.X++;

                    MoveObject(myTank, myTankPosition, new Position(myTankPosition.X, myTankPosition.Y));
                }
            }
            else if (key.Key == ConsoleKey.LeftArrow)
            {
                if (myTankPosition.Y > 0)
                {
                    RemoveObject(myTankPosition, myTank.GetLength(0), myTank.GetLength(1));

                    myTank = myTankLeft;
                    myTankPosition.Y--;

                    MoveObject(myTank, myTankPosition, new Position(myTankPosition.X, myTankPosition.Y));
                }
            }
            else if (key.Key == ConsoleKey.RightArrow)
            {
                if (myTankPosition.Y + myTankHeight < CONSOLE_WIDTH)
                {
                    RemoveObject(myTankPosition, myTank.GetLength(0), myTank.GetLength(1));

                    myTank = myTankRight;
                    myTankPosition.Y++;

                    MoveObject(myTank, myTankPosition, new Position(myTankPosition.X, myTankPosition.Y));
                }
            }
            else if (key.Key == ConsoleKey.Spacebar)
            {

            }
        }

        private static void MoveObject(char[,] obj, Position position, Position newPos)
        {
            PlaceObjectOnField(obj, newPos);
        }

        private static void RemoveObject(Position position, int height, int width)
        {
            int currentX = position.X;
            int currentY = position.Y;
            for (int i = currentX; i < currentX + height; i++)
            {
                for (int j = currentY; j < currentY + width; j++)
                {
                    field[i, j] = '\0';
                }
            }
        }

        private bool CheckCollision()
        {
            bool isCollision = false;
            //if collisionEagle== true
            //{ Game over}
            return isCollision;