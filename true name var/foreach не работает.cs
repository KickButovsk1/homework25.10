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
            string result = String.Empty;
            str = str.ToLower();
            foreach (char item in str)
            {
                if (!pattern.Contains(item))
                {
                    result += item;
                }
            }
            foreach (char symbol in str) 
            {
                if (char.IsDigit(str.First()))
                {
                    result += symbol;
                }
            }
            foreach (char final in str)
            { 
                if (str.Contains(pattern))
                {
                    Console.WriteLine(str);
                }
            }
            Console.ReadKey();        
        }
    }
}
