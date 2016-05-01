using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести с консоли 2 числа: n и i. Вывести значение i-ого бита числа n
            int n;
            int i;
            int c;

            try
            { 
                Console.WriteLine("Введите n");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите i");
                i = Convert.ToInt32(Console.ReadLine());            
                c = (n >> (i - 1)) & 1;
                Console.WriteLine(c);
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
