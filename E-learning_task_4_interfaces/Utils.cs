using E_learning_task_4_interfaces.Interfaces;
using System;
using System.Globalization;

namespace E_learning_task_4_interfaces
{
    public static class Utils
    {
        public static void MultiParamsFormatOutput(params IInputOuptput[] arr)
        {
            foreach (var item in arr)
            {
                item.FormatOutput();
            }
        }

        public static int Gcd(int a, int b)
        {           
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int tmp = a % b;
                a = b;
                b = tmp;
            }
            return a;
        }

        public static int Lcm(int a, int b)
        {
            return Math.Abs(a * b) / Gcd(a, b);
        }

        public static uint GetArrayLength()
        {
            Console.WriteLine(" eneter array size :");
            if (!UInt32.TryParse(Console.ReadLine(), NumberStyles.AllowLeadingWhite, null, out UInt32 length))
            {
                throw new FormatException("you enterd number in a wrong romat : it is not a integer number ... ");
            }

            return length;
        }

        public static INumber[] CreateArrayOfType<T>(uint length) where T : class, INumber, new()
        {
            T[] array = new T[length];
            for (uint i = 0; i < array.Length; i++)
            {
                array[i] = new T();
                array[i].FormatInput();
            }

            return array;
        }
    }
}
