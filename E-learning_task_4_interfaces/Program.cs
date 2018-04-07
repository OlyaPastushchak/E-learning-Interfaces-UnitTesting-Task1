using E_learning_task_4_interfaces.Interfaces;
using System;

namespace E_learning_task_4_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                INumber[] integerArray = Utils.CreateArrayOfType<IntegerNumber>(Utils.GetArrayLength());
                var integerArrayCopy = Task.CloneArray(integerArray);
                Task.SortAscending(integerArrayCopy);
                IntegerNumber integerSum = Task.Sum(integerArrayCopy) as IntegerNumber;
                IntegerNumber integerMultiplying = Task.Multiplying(integerArrayCopy) as IntegerNumber;
                IntegerNumber integerAvgNumber = Task.AvgNumber(integerArrayCopy) as IntegerNumber;
                Utils.MultiFormatOutput(integerSum, integerMultiplying, integerAvgNumber);

                INumber[] rationalArray = Utils.CreateArrayOfType<RationalNumber>(Utils.GetArrayLength());
                var rationalArrayCopy = Task.CloneArray(rationalArray);
                Task.SortDescending(rationalArrayCopy);
                RationalNumber rationalSum = Task.Sum(rationalArrayCopy) as RationalNumber;
                RationalNumber rationalMultiplying = Task.Multiplying(rationalArrayCopy) as RationalNumber;
                RationalNumber rationalAvgNumber = Task.AvgNumber(rationalArrayCopy) as RationalNumber;
                Utils.MultiFormatOutput(rationalSum, rationalMultiplying, rationalAvgNumber);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);

            }
            catch (Exception e)
            {
                Console.WriteLine("Something bad happend : " + e.Message);
            }

            Console.ReadKey();
        }
    }
}
