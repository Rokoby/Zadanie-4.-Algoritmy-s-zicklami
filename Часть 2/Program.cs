using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Часть_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int negatives = 0;
            int positives = 0;
            int a = 0;
            do
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a < 0)
                    negatives++;
                if (a > 0)
                    positives++;
            } while (a != 0);
            if (negatives > positives)
                Console.WriteLine("Отрицательных чисел больше положительных");
            if (negatives < positives)
                Console.WriteLine("Положительных чисел больше отрицательных");
            if (negatives == positives)
                Console.WriteLine("Положительных чисел столько сколько отрицательных");
            Console.ReadLine();
        }
    }
}
