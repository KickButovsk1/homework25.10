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
            foreach (char item in str)
            {
                if (pattern.Contains(item))
                {
                    i++;
                }
            }
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
