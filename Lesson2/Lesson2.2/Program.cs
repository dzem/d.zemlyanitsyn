using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заполнить с консоли массив из N элементов.Отсортировать.Вывести результат. N - задается с консоли

            uint n = 0;

            Console.WriteLine("Введите N:");
            UInt32.TryParse(Console.ReadLine(), out n);
            int[] a = new int[n];

            Console.WriteLine("Введите N чисел:");
            for (int i = 0 ; i < n ; i++)
            {
                if (!Int32.TryParse(Console.ReadLine(), out a[i]))
                {
                    i--;
                }
            }
            Array.Sort(a);

            Console.WriteLine("Отсортированный массив:");
            foreach (int j in a)
            {
                Console.Write(j+ " ");
            }
            Console.ReadKey();
        }
    }
}
