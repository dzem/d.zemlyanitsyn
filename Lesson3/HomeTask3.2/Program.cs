using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeTask3._2
{
    class Program
    {
        //Считывать с консоли числа, пока не будет введено число “-1”, среди введенных чисел вывести все дублирующиеся.

        private static List<int> GetList()
        {
            int number = 0;
            List<int> list = new List<int>();
            Console.WriteLine("Введите поочерёдно целые числа (Ввод '-1' или не целого числа - вывести дублирующиеся числа) :");
            while (number != -1)
            {
                number = GetInt();
                list.Add(number);
            }
            return list;
        }

        private static int GetInt()
        {
            Console.WriteLine("Введите целое число:");
            int value;
            return int.TryParse(Console.ReadLine(), out value) ? value : -1;
        }

        private static void PrintDuplicate(List<int> list)
        {
            var duplicate = list.GroupBy(v => v).Where(g => g.Count() > 1).Select(g => g.Key);

            Console.WriteLine("Дублируются следующие числа:");
            foreach (int c in duplicate)
            {
                Console.Write($"{c} ");
            }
        }

        private static void Main()
        {
            List<int> list = GetList();
            PrintDuplicate(list);
            Console.ReadKey();
        }
    }
}
