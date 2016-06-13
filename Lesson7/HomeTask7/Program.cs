using System;
using System.Collections.Generic;

namespace HomeTask7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Реализовать неизменяемую структуру - простая дробь(x / y).Числитель и знаменатель -целые числа.
            // Знаменатель - всегда положительный.Ноль - 0 / x.Реализовать операции сложения, вычитания, умножения, деления. 
            // Реализовать интерфейс IComparable.Создать массив из N случайных дробей, отсортировать по возрастанию. Найти сумму всех дробей.
            // *Сделать дробь не сокращаемой.Т.е. 2 / 4-> 1 / 2, 50 / 15-> 10 / 3, 0 / 7-> 0 / 1 и т.д
            try
            {
                SimpleFraction fraction1 = new SimpleFraction(-1, 25);
                SimpleFraction fraction2 = new SimpleFraction(-2, 5);
                SimpleFraction fraction3 = new SimpleFraction(-6, 7);
                SimpleFraction fraction4 = new SimpleFraction(-5, 2);

                Console.WriteLine($"Операция вычитания: {fraction1} - {fraction3} =  {fraction1 - fraction3}");
                Console.WriteLine($"Операция деления: {fraction3} / {fraction4} = {fraction3 / fraction4}");
                Console.WriteLine($"Операция сложения: {fraction2} + {fraction4} = {fraction2 + fraction4}");
                Console.WriteLine($"Операция умножения: {fraction2} * {fraction4} =  {fraction2 * fraction4}");
                Console.WriteLine();
                List<SimpleFraction> fractions = new List<SimpleFraction> { fraction1, fraction2, fraction3, fraction4 };

                fractions.Sort();

                SimpleFraction sumSimpleFraction = new SimpleFraction(0, 1);

                foreach (SimpleFraction fraction in fractions)
                {
                    Console.Write($"{fraction}  ");
                    sumSimpleFraction += fraction;
                }

                Console.WriteLine();
                Console.WriteLine($"Сумма всех дробей = {sumSimpleFraction}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }  

            Console.ReadKey();
        }
    }
}
