using System;
using System.Collections.Generic;

namespace StringEvenOddSeparation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to string Separation Challenge !!!");
            Console.WriteLine("Please enter no of string as input");
            int.TryParse(Console.ReadLine(),out int count);
            List<string> inputStrings = new List<string>();
            for(int i = 1; i <= count; i++)
            {
                inputStrings.Add(Console.ReadLine());
            }
            Console.WriteLine("Output");
            foreach(var item in inputStrings)
            {
                string evenletters = null,oddletters = null;
                for(int j =0; j <item.Length;j++)
                {
                    if(j%2 == 0)
                    {
                        evenletters = string.Concat(evenletters,item[j]);
                    }
                    else
                    {
                        oddletters = string.Concat(oddletters,item[j]);
                    }
                }
                Console.WriteLine($"{evenletters} {oddletters}");
            }
            
        }
    }
}
