﻿using System;
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
           for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    if (!result.Contains(str[i]))
                    {
                        result += str[i];
                    }
                }
            }
            if (result == String.Empty)
            {
                result = "NO";
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
