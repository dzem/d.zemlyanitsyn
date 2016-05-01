using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввести с консоли 2 числа. Вывести их сумму на консоль
            int a;
            int b;
            int c;

            try
            {
                Console.WriteLine("Введите число");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите ещё одно число");
                b = Convert.ToInt32(Console.ReadLine());
                c = a + b;
                Console.WriteLine("Сумма: " + (c).ToString());
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректные данные");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Число вне диапазона int");            
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
