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
            string numberStr = String.Empty;
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
                foreach (char symbol in str)
                {
                    if(item == symbol)
                    {
                        count++;
                    }
                }
                if (count > 1 && Char.IsDigit(item))
                {
                    numberStr += item;
                }
            }
            Console.WriteLine(numberStr);
            Console.ReadKey();
        }
    }
}
