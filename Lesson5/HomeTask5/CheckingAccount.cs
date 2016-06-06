using System;

namespace HomeTask5
{
    // - расчетный - возможность пополнения и изъятия денег со счета, наличие платы за обслуживание, списание суммы за обслуживание со счета
    class CheckingAccount : Account
    {
        public decimal Charge { get; private set; }

        public CheckingAccount(string owner, decimal balance, bool isActive, decimal charge) : base(owner, balance, isActive)
        {
            Charge = charge;
        }

        public void TakeCharge()
        {
            if (!IsActive)
            {
                throw new InvalidOperationException("Операция невозможна. Счет закрыт.");
            }
            Balance -= Charge;
            Console.WriteLine($"Со счёта {Owner} : {Id} списано за обслуживание {Charge} енотов. Баланс счёта {Balance} енотов.");
        }
    }
}
