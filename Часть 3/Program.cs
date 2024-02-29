using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Часть_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите A, B, C");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int A = a;
            int k = 0;
            while (b>=c)

            {
                while (a>=c)
                {
                    a -= c;
                    k++;
                }
                a = A;
                b -= c;
            }
            Console.WriteLine("Число квадратов - {0}", k);
            Console.ReadKey();
        }
    }
}
