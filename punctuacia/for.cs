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
            string pattern = ".,;:!?";
            int i = 0;
            for (int k = 0; k<str.Length; k++)
            {
                if (pattern.Contains(str[k]))
                {
                    i++;
                }
            }
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
