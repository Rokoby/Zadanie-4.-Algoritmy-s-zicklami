﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Часть__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            int n2 = 0;
            for (int i = 1; i <= n; i++)
            {
                n2 += 2 * i - 1;
                Console.WriteLine(n2);
            }
            Console.ReadKey();
        }
    }
}
