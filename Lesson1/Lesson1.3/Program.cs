using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести с консоли число. Обнулить последний бит этого числа.Вывести на консоль
            int n;

            try
            {
                Console.WriteLine("Введите число");
                n = Convert.ToInt32(Console.ReadLine());
                n >>= 1;
                n <<= 1;
                Console.WriteLine(n);
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректные данные");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Число вне диапазона int");
            }
            Console.ReadKey();
        }
    }
}
