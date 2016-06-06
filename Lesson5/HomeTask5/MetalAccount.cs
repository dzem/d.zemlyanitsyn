using System;

namespace HomeTask5
{
    // - обезличенный металлический счет - тип металла, количество грамм, стоимость за грамм (текущий курс), возможность пополнять и обналичивать счет по текущему курсу
    class MetalAccount : Account
    {
        public string Metal { get; private set; }
        public decimal Amount { get; private set; }
        public decimal Price { get; private set; }

        public MetalAccount(string owner, decimal balance, bool isActive, string metal, decimal amount, decimal price) : base(owner, balance, isActive)
        {
            Metal = metal;
            Amount = amount;
            Price = price;
        }

        public void SellMetal(decimal amountValue)
        {
            if (!IsActive)
            {
                throw new InvalidOperationException("Операция невозможна. Счет закрыт.");
            }
            if (amountValue < 0)
            {
                throw new ArgumentOutOfRangeException("Невозможно обналичить отрицательное количество металла.");
            }
            if (amountValue == 0)
            {
                throw new ArgumentOutOfRangeException("Невозможно обналичить нулевое количество металла.");
            }
            if (amountValue > Amount)
            {
                throw new InvalidOperationException($"Операция невозможна. Количество продаваемого метала {amountValue} г. превышает количество {Amount} г. метала на счету.");
            }
            Balance += amountValue * Price;
            Amount -= amountValue;
            Console.WriteLine($"Со счёта {Owner} : {Id} продано {amountValue} г. металла {Metal} по цене {Price}. Баланс счёта {Balance} енотов, {Amount} г. металла.");
        }

        public void BuyMetal(decimal amountValue)
        {
            if (!IsActive)
            {
                throw new InvalidOperationException("Операция невозможна. Счет закрыт.");
            }
            if (amountValue < 0)
            {
                throw new ArgumentOutOfRangeException("Невозможно купить отрицательное количество металла.");
            }
            if (amountValue == 0)
            {
                throw new ArgumentOutOfRangeException("Невозможно купить нулевое количество металла.");
            }
            if (amountValue * Price > Balance)
            {
                throw new InvalidOperationException($"Операция невозможна. Не хватает средств для покупки {amountValue} г. металла по цене {Price}. Баланс счета {Balance} енотов.");
            }
            Balance -= amountValue * Price;
            Amount += amountValue;
            Console.WriteLine($"Счёт {Owner} : {Id} пополнен на {amountValue} г. металла {Metal} по цене {Price}. Баланс счёта {Balance} енотов, {Amount} г. металла.");
        }
    }
}
