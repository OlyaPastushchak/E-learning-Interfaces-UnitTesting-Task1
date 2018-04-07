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
                INumber[] integerArray = Utils.CreateIntegerArray();
                var cloned = Task.CloneArray(integerArray);
                var integerSum = Task.Sum(integerArray);
                var integerMultiplying = Task.Multiplying(integerArray);
                var integerAvgNumber = Task.AvgNumber(integerArray);

                INumber[] rationalArray = Utils.CreateRationalArray();
                var rationalSum = Task.Sum(rationalArray);
                var rationalMultiplying = Task.Multiplying(rationalArray);
                var rationalAvgNumber = Task.AvgNumber(rationalArray);
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
        }
    }
}
