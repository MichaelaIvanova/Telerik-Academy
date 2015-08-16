using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Adding_polynomials
{
    class AddPoly
    {
        //Write a method that adds two polynomials.
        //Represent them as arrays of their coefficients.
        //x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}
        static void Main(string[] args)
        {
            string polynomOne = "1x^2+0x^1+5x^0";
            string polynomTwo = "2x^2+3x^1+1x^0";

            string[] result = AdTwoPolynoms(polynomOne, polynomTwo);
            Console.WriteLine(string.Join("", result));


        }

        static string[] AdTwoPolynoms(string polynomOne, string polynomTwo)
        {
            List<int> coeficientsOne = new List<int>();
            List<int> coeficientsTwo = new List<int>();

            for (int i = 0; i < polynomOne.Length; i++)
            {
                if (polynomOne[i] == 'x')
                {
                    coeficientsOne.Add(polynomOne[i - 1] - '0');
                }
            }

           // Console.WriteLine(string.Join(",", coeficientsOne));

            for (int i = 0; i < polynomTwo.Length; i++)
            {
                if (polynomOne[i] == 'x')
                {
                    coeficientsTwo.Add(polynomTwo[i - 1] - '0');
                }
            }
            //Console.WriteLine(string.Join(",", coeficientsTwo));

            var result = Enumerable.Zip(coeficientsOne, coeficientsTwo, (a, b) => a + b);
            int[] summed = result.ToArray();

            //List<string> summedPolynom = new List<string>();
            string[] degreeX = {"x^2+" ,"x^1+","x^0"};

            string[] together = new string[summed.Length];

            for(int i = 0; i<together.Length; i++)
            {
                together[i] = summed[i] + degreeX[i];
            }
            return together;
        }

    }
}
