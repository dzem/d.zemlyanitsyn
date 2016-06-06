namespace HomeTask5
{
    // - сберегательный - возможность пополнения и изъятия денег со счета
    class SavingAccount : Account
    {
        public SavingAccount(string owner, decimal balance, bool isActive) : base(owner, balance, isActive)
        {
        }
    }
}
