using Microsoft.VisualStudio.TestTools.UnitTesting;
using E_learning_task_4_interfaces.Interfaces;

namespace E_learning_task_4_interfaces.Tests
{
    [TestClass()]
    public class TaskTests
    {
        [TestMethod()]
        public void SumIntegerTest()
        {
            INumber[] arr = new IntegerNumber[]
            {
                new IntegerNumber(1),
                new IntegerNumber(0),
                new IntegerNumber(23),
                new IntegerNumber(-22)
            };

            IntegerNumber sum = Task.Sum(arr) as IntegerNumber;

            Assert.AreEqual(2, sum.Number);
        }

        [TestMethod()]
        public void SumRationalTest()
        {
            INumber[] arr = new RationalNumber[]
           {
                new RationalNumber(1,2),
                new RationalNumber(0,1),
                new RationalNumber(2,6),
                new RationalNumber(1,5)
           };

            RationalNumber mul = Task.Sum(arr) as RationalNumber;

            Assert.AreEqual(62, mul.Numerator);
            Assert.AreEqual(60, mul.Denominator);
        }

        [TestMethod()]
        public void MultiplyingIntegerTest()
        {
            INumber[] arr = new IntegerNumber[]
            {
                new IntegerNumber(1),
                new IntegerNumber(1),
                new IntegerNumber(23),
                new IntegerNumber(-2)
            };

            IntegerNumber mul = Task.Multiplying(arr) as IntegerNumber;

            Assert.AreEqual(-46, mul.Number);
        }

        [TestMethod()]
        public void MultiplyingRationalTest()
        {
            INumber[] arr = new RationalNumber[]
           {
                new RationalNumber(1,2),
                new RationalNumber(0,1),
                new RationalNumber(2,6),
                new RationalNumber(1,5)
           };

            RationalNumber mul = Task.Multiplying(arr) as RationalNumber;

            Assert.AreEqual(0, mul.Numerator);
            Assert.AreEqual(60, mul.Denominator);
        }

        [TestMethod()]
        public void AvgNumberTest()
        {
            INumber[] arr = new IntegerNumber[]
              {
                new IntegerNumber(1),
                new IntegerNumber(1),
                new IntegerNumber(20),
                new IntegerNumber(-2)
              };

            IntegerNumber mul = Task.AvgNumber(arr) as IntegerNumber;

            Assert.AreEqual(5, mul.Number);
        }
    }
}