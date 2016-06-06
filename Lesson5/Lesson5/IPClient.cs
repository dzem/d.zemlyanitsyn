namespace Lesson5
{
    public class IPClient : Client
    {
        private string Fio { get; }
        private string Birthdate { get; }

        public IPClient(string fio, string birthdate) : base()
        {
            Fio = fio;
            Birthdate = birthdate;
        }

        public override string PrintNameAndSum()
        {
            return $"{Fio} : {Sum}";
        }
    }
}