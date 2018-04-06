using E_learning_task_4_interfaces.Interfaces;
using System;
using System.Globalization;

namespace E_learning_task_4_interfaces
{
    public static class Utils
    {
        public static int Gcd(int a, int b)
        {
            if (b == 0)
            {
                return Math.Abs(a);
            }
            return Gcd(b, a % b);
        }

        public static int Lcm(int a, int b)
        {
            return Math.Abs(a * b) / Gcd(a, b);
        }

        public static int InputArrayLength()
        {
            Console.WriteLine(" eneter array size :");
            if (!Int32.TryParse(Console.ReadLine(), NumberStyles.AllowLeadingWhite, null, out int length))
            {
                throw new FormatException("you enterd number in a wrong romat : it is not a integer number ... ");
            }

            return length;
        }

        public static INumber[] CreateIntegerArray()
        {
            int length = InputArrayLength();
            IntegerNumber[] integerArray = new IntegerNumber[length];
            for (int i = 0; i < integerArray.Length; i++)
            {
                integerArray[i] = new IntegerNumber();
                integerArray[i].FormatInput();
            }

            return integerArray;
        }

        public static INumber[] CreateRationalArray()
        {
            int length = InputArrayLength();
            RationalNumber[] rationalArray = new RationalNumber[length];
            for (int i = 0; i < rationalArray.Length; i++)
            {
                rationalArray[i] = new RationalNumber();
                rationalArray[i].FormatInput();
            }

            return rationalArray;
        }
    }
}
