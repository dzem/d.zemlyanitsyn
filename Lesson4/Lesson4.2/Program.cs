using System;

namespace Lesson4._2
{
    class Program
    {
        //Преобразовать класс “Телефон” на работу со свойствами

        private static string SetCode()
        {
            Console.WriteLine("Введите код города:");
            return Console.ReadLine();
        }

        private static string SetPhone()
        {
            Console.WriteLine("Введите код телефона:");
            return Console.ReadLine();
        }

        static void Main()
        {
            Phone phone = new Phone(SetCode(), SetPhone());
            Console.WriteLine(phone.GetPhoneNumber);
            Console.ReadKey();
        }
    }
}
