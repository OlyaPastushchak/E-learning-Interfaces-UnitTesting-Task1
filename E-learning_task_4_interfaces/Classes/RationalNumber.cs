using System;
using E_learning_task_4_interfaces.Interfaces;

namespace E_learning_task_4_interfaces
{
    public class RationalNumber : INumber, IInputOuptput
    {
        public int Numerator { get; private set; }
        private int denominator;

        public int Denominator
        {
            get
            {
                return this.denominator;
            }
            private set
            {
                if (value == 0)
                {
                    throw new ArithmeticException("denominator couldn't be 0 ");
                }
                this.denominator = value;
            }
        }

        public RationalNumber()
        {
            this.Numerator = 0;
            this.Denominator = 1;
        }

        public RationalNumber(int numerator, int denominator) : this()
        {
            if (!IsProperFraction(numerator, denominator))
            {
                throw new ArgumentException("fracntion is improper : numerator >= denominator or denominator == 0 ");
            }
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public static bool IsProperFraction(int numerator, int denominator)
        {
            return Math.Abs(numerator) <= Math.Abs(denominator) && denominator != 0;
        }

        public void Reducing()
        {
            int gcd = Utils.Gcd(this.Numerator, this.Denominator);
            if (gcd != 1)
            {
                this.Numerator /= gcd;
                this.Denominator /= gcd;
            }
        }

        public static RationalNumber operator /(RationalNumber left, int right)
        {
            if (right == 0)
            {
                throw new ArgumentException("cannot divide by zero");
            }

            return new RationalNumber(left.Numerator, left.Denominator * right);
        }

        public double ToDouble()
        {
            return this.Numerator * 1.0 / this.Denominator;
        }

        public INumber Add(INumber obj)
        {
            RationalNumber right = obj as RationalNumber;
            if (right == null)
            {
                throw new InvalidCastException();
            }
            int commonDenominator = this.Denominator * right.Denominator;
            int newNumerator = this.Numerator * right.Denominator + right.Numerator * this.Denominator;

            return new RationalNumber(newNumerator, commonDenominator);
        }

        public INumber Subtract(INumber obj)
        {
            RationalNumber right = obj as RationalNumber;
            if (right == null)
            {
                throw new InvalidCastException();
            }
            int commonDenominator = this.Denominator * right.Denominator;
            int newNumerator = this.Numerator * right.Denominator - right.Numerator * this.Denominator;

            return new RationalNumber(newNumerator, commonDenominator);
        }

        public INumber Divide(INumber obj)
        {
            RationalNumber right = obj as RationalNumber;
            if (right == null)
            {
                throw new InvalidCastException();
            }

            return new RationalNumber(this.Numerator * right.Denominator, this.Denominator * right.Numerator);
        }

        public INumber Multiply(INumber obj)
        {
            RationalNumber right = obj as RationalNumber;
            if (right == null)
            {
                throw new InvalidCastException();
            }

            return new RationalNumber(this.Numerator * right.Numerator, this.Denominator * right.Denominator);
        }

        public void FormatInput()
        {
            Console.WriteLine("enter numerator: ");
            int numerator = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter denominator: ");
            int denominator = Int32.Parse(Console.ReadLine());

            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public void FormatOutput()
        {
            Console.WriteLine("rational number :  {0}/{1}", this.Numerator, this.Denominator);
        }

        public void Divide(int num)
        {
            this.Denominator *= num;
        }

        public int CompareTo(INumber other)
        {
            RationalNumber comparable = other as RationalNumber;
            if (comparable == null)
            {
                throw new InvalidCastException();
            }
            int left = this.Numerator * comparable.Denominator;
            int right = comparable.Numerator * this.Denominator;
            if (left > right)
            {
                return 1;
            }
            else if (left < right)
            {
                return -1;
            }

            return 0;
        }

        public object Clone()
        {
            return new RationalNumber(this.Numerator, this.Denominator);
        }
    }
}
