using System;

namespace HomeTask12
{
    public struct SimpleFraction : IComparable
    {
        private long denominator;

        public long Numerator { get; private set; }
        public long Denominator
        {
            get { return denominator; }
            private set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Знаменатель не может быть равен нулю");
                }
                if (value < 0)
                {
                    denominator = Math.Abs(value);
                    Numerator = Numerator * -1;
                }
                else
                {
                    denominator = value;
                }
            }
        }

        public SimpleFraction(long numerator, long denominator) : this()
        {
            Numerator = numerator;
            Denominator = denominator;
            Simplify();
        }

        private void Simplify()
        {
            long gcd = GCD(Numerator, Denominator);
            Numerator = Numerator / gcd;
            Denominator = Denominator / gcd;
        }

        private static long GCD(long a, long b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            for (;;)
            {
                long remainder = a % b;
                if (remainder == 0) return b;
                a = b;
                b = remainder;
            };
        }

        public static SimpleFraction operator +(SimpleFraction a, SimpleFraction b)
        {
            long gcd = GCD(a.Denominator, b.Denominator);

            long num = a.Numerator * (b.Denominator / gcd) + b.Numerator * (a.Denominator / gcd);
            long denom = a.Denominator * (b.Denominator / gcd);
            return new SimpleFraction(num, denom);
        }

        public static SimpleFraction operator -(SimpleFraction a)
        {
            return new SimpleFraction(-a.Numerator, a.Denominator);
        }

        public static SimpleFraction operator -(SimpleFraction a, SimpleFraction b)
        {
            return a + -b;
        }

        public static SimpleFraction operator *(SimpleFraction a, SimpleFraction b)
        {
            return new SimpleFraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
        }

        public static SimpleFraction operator /(SimpleFraction a, SimpleFraction b)
        {
            if (b.Denominator == 0)
            {
                throw new DivideByZeroException("Нельзя делить на 0");
            }
            return a * new SimpleFraction(b.Denominator, b.Numerator);
        }

        public int CompareTo(object obj)
        {
            SimpleFraction value = (SimpleFraction)obj;
            if (value.Numerator * Denominator < value.Denominator * Numerator)
            {
                return 1;
            }
            if (value.Numerator * Denominator > value.Denominator * Numerator)
            {
                return -1;
            }
            return 0;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }

}

