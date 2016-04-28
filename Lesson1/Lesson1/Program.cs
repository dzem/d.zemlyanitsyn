using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            String a = Console.ReadLine();
            Console.WriteLine("Введите ещё одно число");
            String b = Console.ReadLine();
            try
            {
                int c = Convert.ToInt32(a) + Convert.ToInt32(b);
                Console.WriteLine("Сумма: " + (c).ToString());
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректные данные");
            }
        }
    }
}
