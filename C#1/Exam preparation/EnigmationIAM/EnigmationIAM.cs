using System;

    class Program
    {
        static void Main()
        {
            string input = "(1+9)%6–(7%2)*8=";
            char[] chars = input.ToCharArray();
            char add = '+';
            bool inBrackets = false;

            foreach( char symbol in chars)
            {
                decimal innerSum = 0;
                int innerO = '+';

                if (inBrackets)
                {
                    if(char.IsDigit(symbol))
                    {
                        switch (innerO)
                        {
                            case '+':
                                innerSum += symbol - '0';
                                break;
                            case '-':
                                innerSum -= symbol - '0';
                                break;
                            case '*':
                                innerSum *= symbol - '0';
                                break;
                            case '%':
                                innerSum %= symbol - '0';
                                break;

                        }


                    }

                }

            }


        }
    }

