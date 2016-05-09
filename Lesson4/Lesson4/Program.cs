using System;

namespace Lesson4._1
{
    class Program
    {
        //Создать класс “Телефон”, который содержит следующие данные: код города, номер телефона, которые не могут быть изменены. 
        //Добавить метод, который возвращает строку вида “(999) 999999” или “999999”, если код города отсутствует.

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
            Phone phone = new Phone(SetCode(),SetPhone());
            Console.WriteLine(phone.GetPhone());
            Console.ReadKey();
        }
    }
}
