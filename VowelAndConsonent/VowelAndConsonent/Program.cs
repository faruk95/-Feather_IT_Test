using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelAndConsonent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a String :");
            string s=Console.ReadLine();
            foreach (var item in s)
            {if (item >= 'A' && item <= 'z')
                {
                    if (item == 'a' || item == 'A' || item == 'E' || item == 'E' || item == 'o' || item == 'O' || item == 'i' || item == 'I' || item == 'u' || item == 'U')
                    {
                        Console.WriteLine($"{item} is an Vowel");
                    }
                    else
                        Console.WriteLine($"{item} is a Consonent");
                }
            else
                    Console.WriteLine($"\n{item} Neither vowel nor a Consonent\n");
            
            }
            Console.ReadKey();
        }
    }
}
