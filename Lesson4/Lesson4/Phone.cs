using System.Text.RegularExpressions;

namespace Lesson4._1
{
    public class Phone
    {
        private readonly string _code;
        private readonly string _phone;

        public Phone(string code, string phone)
        {
            _code = code;
            _phone = phone;
        }

        public string GetPhone()
        {
            Regex r = new Regex(@"^\d+(?!\s).");
            Match m = r.Match(_code);
            Match l = r.Match(_phone);

            if (m.Success && !string.IsNullOrEmpty(_code))
            {
                return $"({_code}) {_phone}";
            }
            return l.Success ? _phone : "Невалидные код и телефон";
        }
    }
}