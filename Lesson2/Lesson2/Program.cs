using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввести с консоли N чисел. Вывести сумму, максимальное, минимальное значения, количество четных чисел, произведение нечетных чисел.

            string a;
            int b;
            int n = 0;
            int sum = 0;
            int max = 0;
            int min = 0;
            int evenCounter = 0;
            int oddMultiplication = 0;

            Console.WriteLine("Введите N чисел. Для выполнения рассчетов введите 'calc' ");

            do
            {
                a = Console.ReadLine();
                if (Int32.TryParse(a, out b))
                {
                    n++;
                    sum += b;

                    if (max < b)
                    {
                        max = b;
                    }

                    if (min > b || n == 1)
                    {
                        min = b;
                    }
                    
                    if (b % 2 == 0)
                    {
                        evenCounter++;
                    }

                    if (b % 2 == 1 || b % 2 == -1)
                    {
                        if (oddMultiplication == 0)
                        {
                            oddMultiplication = b;
                        }
                        else
                        {
                            oddMultiplication *= b;
                        }
                    }
                }
                else continue;
            }
            while (a != "calc");

            Console.WriteLine("Сумма чисел: " + sum);
            Console.WriteLine("Максимальное значение: " + max);
            Console.WriteLine("Минимальное значение: " + min);
            Console.WriteLine("Количество четных чисел: " + evenCounter);
            Console.WriteLine("Произведение нечетных чисел: " + oddMultiplication);
            Console.ReadKey();
        }
    }
}
