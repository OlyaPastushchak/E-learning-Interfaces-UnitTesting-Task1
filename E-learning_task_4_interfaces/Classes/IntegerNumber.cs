using System;
using E_learning_task_4_interfaces.Interfaces;

namespace E_learning_task_4_interfaces
{
    public class IntegerNumber : INumber
    {
        public int Number { get; private set; }

        public IntegerNumber() : this(0) { }

        public IntegerNumber(int number)
        {
            this.Number = number;
        }

        public INumber Add(INumber obj)
        {
            IntegerNumber right = obj as IntegerNumber;
            if (right == null)
            {
                throw new InvalidCastException();
            }

            return new IntegerNumber(this.Number + right.Number);
        }

        public INumber Divide(INumber obj)
        {
            IntegerNumber right = obj as IntegerNumber;
            if (right == null)
            {
                throw new InvalidCastException();
            }
            if (right.Number == 0)
            {
                throw new DivideByZeroException();
            }

            return new IntegerNumber(this.Number / right.Number);
        }

        public INumber Multiply(INumber obj)
        {
            IntegerNumber right = obj as IntegerNumber;
            if (right == null)
            {
                throw new InvalidCastException();
            }

            return new IntegerNumber(this.Number * right.Number);
        }

        public INumber Subtract(INumber obj)
        {
            IntegerNumber right = obj as IntegerNumber;
            if (right == null)
            {
                throw new InvalidCastException();
            }

            return new IntegerNumber(this.Number - right.Number);
        }

        public void FormatInput()
        {
            Console.WriteLine("enter integer number: ");
            string input = Console.ReadLine();
            if (!Int32.TryParse(input, out int number))
            {
                throw new InvalidCastException();
            }
            this.Number = number;
        }

        public void FormatOutput()
        {
            Console.WriteLine("your number : {0} \n __________ ", this.Number);
        }

        public void Divide(int num)
        {
            if (num == 0)
            {
                throw new DivideByZeroException();
            }
            this.Number /= num;
        }

        public int CompareTo(INumber other)
        {
            IntegerNumber comparable = other as IntegerNumber;
            if (comparable == null)
            {
                throw new InvalidCastException();
            }
            if (this.Number > comparable.Number)
            {
                return 1;
            }
            else if (this.Number < comparable.Number)
            {
                return -1;
            }

            return 0;
        }

        public object Clone()
        {
            return new IntegerNumber(this.Number);
        }
    }
}
