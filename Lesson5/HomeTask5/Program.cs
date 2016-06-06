using System;

namespace HomeTask5
{
    class Program
    {
        // Реализовать классы для управления банковскими счетами. 
        // Каждый счет должен иметь номер, владельца, текущую сумму на счету не меньше нуля. 
        // Типы счетов: 
        // - сберегательный - возможность пополнения и изъятия денег со счета
        // - накопительный - возможность пополнения и изъятия денег со счета, но не меньше первоначального взноса, наличие процентной ставки, капитализация процентов за месяц
        // - расчетный - возможность пополнения и изъятия денег со счета, наличие платы за обслуживание, списание суммы за обслуживание со счета
        // - обезличенный металлический счет - тип металла, количество грамм, стоимость за грамм (текущий курс), возможность пополнять и обналичивать счет по текущему курсу
        // Реализовать метод закрытия счета. С закрытым счетом нельзя проводить никакие операции.
        // Счет не может быть закрыт, если он имеет положительный баланс.



        static void Main(string[] args)
        {
            try
            {
                SavingAccount sa = new SavingAccount("Twilight", 1984m, true);
                sa.Refill(16m);
                sa.Withdrawal(2000m);
                sa.Close();
                AccumulationAccount aa = new AccumulationAccount("Applejack", 1500m, true, 2000m, 24m);
                aa.Refill(500m);
                aa.Capitalization();
                aa.Withdrawal(2040m);
                aa.Close();
                CheckingAccount ca = new CheckingAccount("Rarity", 1380m, true, 1480m);
                ca.Refill(111m);
                ca.Withdrawal(11m);
                ca.TakeCharge();
                ca.Close();
                MetalAccount ma = new MetalAccount("Fluttershy", 0m, true, "uranium", 200m, 0.8m);
                ma.Refill(8m);
                ma.BuyMetal(10m);
                ma.SellMetal(210m);
                ma.Withdrawal(168m);
                ma.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
