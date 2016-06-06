using System;

namespace HomeTask5
{
    // Реализовать классы для управления банковскими счетами. 
    // Каждый счет должен иметь номер, владельца, текущую сумму на счету не меньше нуля. 
    // Реализовать метод закрытия счета. С закрытым счетом нельзя проводить никакие операции.
    // Счет не может быть закрыт, если он имеет положительный баланс.
    public abstract class Account
    {
        public Guid Id { get; private set; }
        public string Owner { get; private set; }
        public decimal Balance { get; set; }
        public bool IsActive { get; private set; }

        public Account(string owner, decimal balance, bool isActive)
        {
            Id = Guid.NewGuid();
            Owner = owner;
            if (balance < 0)
            {
                throw new ArgumentOutOfRangeException("Текущий баланс не может быть меньше нуля.");
            }
            else
            {
                Balance = balance;
            }
            IsActive = isActive;
        }

        public virtual void Withdrawal(decimal value)
        {
            if (!IsActive)
            {
                throw new InvalidOperationException("Операция невозможна. Счет закрыт.");
            }
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Невозможно списать со счёта отрицательную сумму енотов.");
            }
            if (value == 0)
            {
                throw new ArgumentOutOfRangeException("Невозможно списать со счёта ноль енотов.");
            }
            if (value > Balance)
            {
                throw new InvalidOperationException($"Операция невозможна. Сумма изъятия {value} превышает баланс {Balance} енотов на счету.");
            }
            Balance -= value;
            Console.WriteLine($"Со счёта {Owner} : {Id} изъято {value} енотов. Баланс счёта {Balance} енотов.");
        }

        public void Refill(decimal value)
        {
            if (!IsActive)
            {
                throw new InvalidOperationException("Операция невозможна. Счет закрыт.");
            }
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Невозможно пополнить счёт на отрицательную сумму енотов.");
            }
            if (value == 0)
            {
                throw new ArgumentOutOfRangeException("Невозможно пополнить счёт на ноль енотов.");
            }
            Balance += value;
            Console.WriteLine($"Счёт {Owner} : {Id} пополнен на {value} енотов. Баланс счёта {Balance} енотов.");
        }

        public void Close()
        {
            if (!IsActive)
            {
                throw new InvalidOperationException("Операция невозможна. Счет уже закрыт.");
            }
            if (Balance > 0)
            {
                throw new InvalidOperationException($"Закрытие счёта с положительным балансом невозможно. Баланс счёта {Balance} енотов.");
            }
            IsActive = false;
            Console.WriteLine($"Счёт {Owner} : {Id} закрыт.");
        }
    }
}
