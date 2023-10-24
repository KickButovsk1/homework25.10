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
            string pattern = "abcdefghijklmnopqrstuwxyz1234567890_";
            str = str.ToLower();
            if (Char.IsDigit(str.First()))
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine(str);
            }
            Console.ReadKey();        
        }
    }
}
