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
            string result = String.Empty;
            string pattern = "1234567890";
            str = str.ToLower();
            foreach (char item in str)
            {
                if (Char.IsDigit(item))
                {
                    if (!result.Contains(item))
                    {
                        result += item;
                    }
                }
            }
            foreach (char item in result)
            {
                pattern = pattern.Replace(item.ToString(), String.Empty);
            }
            if (pattern == String.Empty)
            {
                pattern = "NO";
            }
            Console.WriteLine(pattern);
            Console.ReadKey();
        }
    }
}
