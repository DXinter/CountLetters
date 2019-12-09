using System;
using System.Collections.Generic;

namespace CountLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string s = countLetters(input);
            Console.WriteLine(s);
        }
        static string countLetters(string input)
        {
            string result = "";
            int sum = 0;
            var s = new Dictionary<char, int>();

            foreach (char symbol in input)
            {
                sum = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (symbol == input[i])
                    {                       
                         sum++;
                        s[symbol] = sum;
                    }                
                }               
            }
            foreach(var p in s)
            {
                result += p.Key;
                result += "-";
                result += p.Value;
                
            }

            return result;
        }
    }
}
