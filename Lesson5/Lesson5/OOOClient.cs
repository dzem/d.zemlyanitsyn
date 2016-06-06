namespace Lesson5
{
    public class OOOClient : Client
    {
        private string Name { get; }
        private string Account { get; }

        public OOOClient(string name, string account) : base()
        {
            Name = name;
            Account = account;
        }

        public override string PrintNameAndSum()
        {
            return $"{Name} : {Sum}" ;
        }
    }
}