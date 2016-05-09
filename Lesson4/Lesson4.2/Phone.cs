using System.Text.RegularExpressions;

namespace Lesson4._2
{
    public class Phone
    {
        public string Code { get; }
        public string PhoneNumber { get; }


        public Phone(string code, string phone)
        {
            Code = code;
            PhoneNumber = phone;
        }

        public string GetPhoneNumber
        {
            get
            {
                Regex r = new Regex(@"^\d+(?!\s).");
                Match m = r.Match(Code);
                Match l = r.Match(PhoneNumber);

                if (m.Success && !string.IsNullOrEmpty(Code))
                {
                    return $"({Code}) {PhoneNumber}";
                }
                return l.Success ? PhoneNumber : "Невалидные код и телефон";
            }
        }
    }
}