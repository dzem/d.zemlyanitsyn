using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {

    static void Main(string[] args)
        {
            Console.WriteLine("Введите телефон и сумму заказа");
            IPClient ipClient = new IPClient("Евлампий Сгибатель", "10.03.1927");
            Console.WriteLine(ipClient.PrintNameAndSum());

            Console.WriteLine("Введите телефон и сумму заказа");
            OOOClient oooClient = new OOOClient("Раковины и панцири", "314159265359");
            Console.WriteLine(oooClient.PrintNameAndSum());

            Console.ReadKey();
        }
    }
}
