using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractNumberFromStringAndAdditionTheNUmber
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int i = 0;

            int[] result = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            Console.Write("\nPlease Enter Your Desier String :");

            string s = Console.ReadLine();
            Console.WriteLine("\nAfter Extracting Single Digits :  ");
            foreach (var k in s)
            {

                switch (k)
                {
                    case '0':
                        result[i] = result[i] + 0;
                        result[i] = result[i] * 10 + 0; Console.Write(" {0} ", k);
                        break;
                    case '1':
                        result[i] = result[i] + 0;
                        result[i] = result[i] * 10 + 1; Console.Write(" {0} ", k);
                        break;

                    case '2':
                        {
                            result[i] = result[i] + 0;
                            result[i] = result[i] * 10 + 2; Console.Write(" {0} ", k);
                        }
                        break;

                    case '3':
                        {
                            result[i] = result[i] + 0;
                            result[i] = result[i] * 10 + 3; Console.Write(" {0} ", k);
                        }
                        break;

                    case '4':
                        {
                            result[i] = result[i] + 0;
                            result[i] = result[i] * 10 + 4; Console.Write(" {0} ", k);
                        }
                        break;

                    case '5':
                        {
                            result[i] = result[i] + 0;
                            result[i] = result[i] * 10 + 5; Console.Write(" {0} ", k);
                        }
                        break;

                    case '6':
                        {
                            result[i] = result[i] + 0;
                            result[i] = result[i] * 10 + 6; Console.Write(" {0}  ", k);
                        }
                        break;

                    case '7':
                        {
                            result[i] = result[i] + 0;
                            result[i] = result[i] * 10 + 7; Console.Write(" {0}  ", k);
                        }
                        break;
                    case '8':
                        {
                            result[i] = result[i] + 0;
                            result[i] = result[i] * 10 + 8; Console.Write(" {0}  ", k);
                        }
                        break;
                    case '9':
                        {
                            result[i] = result[i] + 0;
                            result[i] = result[i] * 10 + 9; Console.Write(" {0}  ", k);
                        }
                        break;
                    default:
                        i++;
                        break;
                }
            }
            Console.WriteLine(" ");
            i = 0;
            Console.Write("\nExtracting As a Number : ");
            for (int m = 0; m < result.Length; m++)
            {
                i += result[m];
                if (result[m] != 0)
                    Console.Write(" {0} ", result[m]);
            }
            Console.WriteLine("\n\nSummation : {0} ", i);
            Console.ReadKey();
        }
    }
}
