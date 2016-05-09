using System;
using System.Runtime.InteropServices;

namespace Lesson5
{
    public class Client
    {
        private Guid Id { get; }
        private string Phone { get; }
        private string Sum { get; }

        public Client()
        {
            Id = Guid.NewGuid();
            Phone = Console.ReadLine();
            Sum = Console.ReadLine();
        }
    }
}