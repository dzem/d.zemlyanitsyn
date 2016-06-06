using System;
using System.Runtime.InteropServices;

namespace Lesson5
{
    public class Client
    {
        private Guid Id { get; }
        public string Phone { get; }
        public string Sum { get; }

        public Client()
        {
            Id = Guid.NewGuid();
            Phone = Console.ReadLine();
            Sum = Console.ReadLine();
        }
        public virtual string PrintNameAndSum()
        {
            return "";
        }
    }
}