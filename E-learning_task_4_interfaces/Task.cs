using System;
using E_learning_task_4_interfaces.Interfaces;

namespace E_learning_task_4_interfaces
{
    public static class Task
    {
        
        public static INumber[] CloneArray(INumber[] arr)
        {
            INumber[] cloned = new INumber[arr.Length];
            int index = 0;
            Array.ForEach(arr, delegate (INumber item)
            {
                cloned[index] = item.Clone() as INumber;
                index++;
            });

            return cloned;
        }

        public static INumber Sum(INumber[] arr)
        {
            INumber sum = null;

            if (Array.TrueForAll(arr, item => item is RationalNumber))
            {
                sum = new RationalNumber();
            }
            else if (Array.TrueForAll(arr, item => item is IntegerNumber))
            {
                sum = new IntegerNumber();
            }
            else
            {
                throw new ArgumentException("cannot calculate sum of array which elements are of different types");
            }

            foreach (var item in arr)
            {
                sum = sum.Add(item);
            }

            return sum;
        }

        public static INumber Multiplying(INumber[] arr)
        {
            INumber mul = null;

            if (Array.TrueForAll(arr, item => item is RationalNumber))
            {
                mul = new RationalNumber(1,1);
            }
            else if (Array.TrueForAll(arr, item => item is IntegerNumber))
            {
                mul = new IntegerNumber(1);
            }
            else
            {
                throw new ArgumentException("cannot calculate sum of array which elements are of different types");
            }

            foreach (var item in arr)
            {
                mul = mul.Multiply(item);
            }

            return mul;
        }

        public static INumber AvgNumber(INumber[] arr)
        {
            var result = Sum(arr);
            result.Divide(arr.Length);

            return result;
        }

        //asc
        public static void SortingAsc(INumber[] arr)
        {
            Array.Sort(arr, delegate (INumber left, INumber right) { return left.CompareTo(right); });
        }

        //desc
        public static void SortingDesc(INumber[] arr)
        {
            Array.Sort(arr, delegate (INumber left, INumber right) { return right.CompareTo(left); });
        }
    }
}
