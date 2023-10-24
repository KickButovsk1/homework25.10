using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string symbols = String.Empty;
            string result = String.Empty;
            foreach (char item in str)
            {
                if (!result.Contains(item))
                {
                    result += item;
                }
            }
            foreach (char item in result) 
            {
                int count = 0;
                foreach(char ss in str)
                {
                    if (item == ss)
                    {
                        count++;
                    }
                }
                if (count >= 1)
                {
                    symbols += item;
                }
            }
            Console.WriteLine(symbols.Length);
            Console.ReadKey();
                  
        }
    }
}
