using System;
using System.Collections.Generic;
using System.Text;

namespace CountLetters
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string s = countLetters(input);
            Console.WriteLine(s);
        }
        static string countLetters(string input)
        {
            StringBuilder result = new StringBuilder ("");
            int sum = 0;
            var Storage = new Dictionary<char, int>();

            for(int j = 0; j<input.Length; j++)
            {
                sum = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[j] == input[i])
                    {                       
                         sum++;
                        Storage[input[j]] = sum;
                    }                
                }               
            }
            foreach(var p in Storage)
            {
                result.Append(p.Key);
                result.Append("-");
                result.Append (p.Value);
                
            }
            
            return result.ToString();
        }
    }
}
