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
            if (b == 0)
            {
                return Math.Abs(a);
            }
            return a == 0 ? 1 : Gcd(b, a % b);
        }

        public static int Lcm(int a, int b)
        {
            return Math.Abs(a * b) / Gcd(a, b);
        }

        public static int GetArrayLength()
        {
            Console.WriteLine(" eneter array size :");
            if (!Int32.TryParse(Console.ReadLine(), NumberStyles.AllowLeadingWhite, null, out int length))
            {
                throw new FormatException("you enterd number in a wrong romat : it is not a integer number ... ");
            }

            return length;
        }

        public static INumber[] CreateArrayOfType<T>(int length) where T : class, INumber , new()
        {
            T[] array = new T[length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new T();
                array[i].FormatInput();
            }

            return array;
        }       
    }
}
