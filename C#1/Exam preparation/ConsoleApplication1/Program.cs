using System;

class DrunkenNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int resultM = 0;
        int resultV = 0;
        int accumresultM = resultM;
        int accumresusltV = resultV;

        for (int i = 0; i <n; i++)
        {
            
            int round1 = int.Parse(Console.ReadLine());
            string roundN1 = round1.ToString();
            int lenght = roundN1.Length;
            int half = lenght / 2;

           

            if (lenght % 2 != 0)
            {
                string Mitko = roundN1.Substring(0, half);
                string Vladko = roundN1.Substring(half - 1, half + 1);
                string middleDigit = roundN1.Substring(half, 1);

                Console.WriteLine(Mitko);
                Console.WriteLine(Vladko);
                Console.WriteLine(middleDigit);

                int middleDiGitReal = int.Parse(middleDigit);
                int accumMiddleDigit = middleDiGitReal;

                foreach (char symbol in Mitko)
                {
                    if (char.IsDigit(symbol))
                    {
                        resultM += symbol - '0';
                        accumresultM++;
                        accumMiddleDigit++;
                    }
                }
                Console.WriteLine("Mitkos beers {0}", (accumresultM + accumMiddleDigit));

                foreach (char symbol in Vladko)
                {
                    if (char.IsDigit(symbol))
                    {
                        resultV += symbol - '0';
                        accumresusltV++;
                        accumMiddleDigit++;
                    }
                }
                Console.WriteLine("Vladkos beers {0}", (accumresusltV + accumMiddleDigit));

                if (accumresultM + accumMiddleDigit > accumresusltV + accumMiddleDigit)
                {
                    Console.WriteLine("M {0}", (accumresultM + accumMiddleDigit));
                }
                else
                {
                    Console.WriteLine("V {0}", (accumresusltV + accumMiddleDigit));

                }

            }

            else
            {
                string Mitko1 = roundN1.Substring(0, half);
                string Vladko1 = roundN1.Substring(half, half);
                Console.WriteLine(Mitko1);
                Console.WriteLine(Vladko1);

                foreach (char symbol in Mitko1)
                {
                    if (char.IsDigit(symbol))
                    {
                        resultM += symbol - '0';
                        accumresultM++;
                    }
                }
                Console.WriteLine("Mitkos beers {0}", resultM);

                foreach (char symbol in Vladko1)
                {
                    if (char.IsDigit(symbol))
                    {
                        resultV += symbol - '0';
                        accumresultM++;
                    }
                }
                Console.WriteLine("Vladkos beers {0}", resultV);
                if (resultM > resultV)
                {
                    Console.WriteLine("M {0}", resultM);
                }
                else
                {
                    Console.WriteLine("V {0}", resultV);

                }

            }
        }
    }
}

