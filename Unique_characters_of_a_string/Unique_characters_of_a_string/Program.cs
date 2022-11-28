using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Unique_characters_of_a_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number =new int[256];
            Console.WriteLine("Please Enter a String : ");
            string s=Console.ReadLine();
                        
            for (int i = 0; i < s.Length; i++)
            {
               
                for (int j = 0; j < 256; j++)
                {
                    if (s[i] == (char)j) { number[j]++; }                
                }
            }
            Console.WriteLine("\nUnique Character list  : ");
            for (int j = 0; j < 256; j++)
            {   
                if((number[j])!=0)
                Console.Write($"{(char)(j)} "); 
            }
            Console.ReadKey();
        }
    }
}
