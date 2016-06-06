using System;

namespace HomeTask5
{
    // - накопительный - возможность пополнения и изъятия денег со счета, но не меньше первоначального взноса, наличие процентной ставки, капитализация процентов за месяц
    class AccumulationAccount : Account
    {
        public decimal InitialDeposit { get; private set; }
        public decimal Rate { get; private set; }

        public AccumulationAccount(string owner, decimal balance, bool isActive, decimal initialDeposit, decimal rate) : base(owner, balance, isActive)
        {
            InitialDeposit = initialDeposit;
            Rate = rate;
        }

        public override void Withdrawal(decimal value)
        {
            if (value < InitialDeposit)
            {
                throw new InvalidOperationException($"Операция невозможна. Сумма изъятия {value} должна превышать первоначальный взнос в {InitialDeposit} енотов.");
            }
            base.Withdrawal(value);
        }

        public void Capitalization()
        {
            if (!IsActive)
            {
                throw new InvalidOperationException("Операция невозможна. Счет закрыт.");
            }
            Console.WriteLine($"По счету {Owner} : {Id} проводится капитализация процентов.");
            Refill(Balance * ((Rate / 12) / 100));
        }
    }
}
