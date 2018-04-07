using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace E_learning_task_4_interfaces.Tests
{
    [TestClass()]
    public class IntegerNumberTests
    {
        private TestContext testContext;

        public TestContext TestContext { get => testContext; set => testContext = value; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                 "|DataDirectory|\\AddDataTests.csv", "AddDataTests#csv", DataAccessMethod.Sequential),
         DeploymentItem("TestsData\\IntegerNumberData\\AddDataTests.csv"), TestMethod]
        public void AddTest()
        {
            int left = Int32.Parse(TestContext.DataRow["left"].ToString());
            IntegerNumber numL = new IntegerNumber(left);

            int right = Int32.Parse(TestContext.DataRow["right"].ToString());
            IntegerNumber numR = new IntegerNumber(right);

            int expected = Int32.Parse(TestContext.DataRow["expected"].ToString());

            IntegerNumber actual = numL.Add(numR) as IntegerNumber;

            Assert.AreEqual(expected, actual.Number);
        }


        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                 "|DataDirectory|\\DivideDataTests.csv", "DivideDataTests#csv", DataAccessMethod.Sequential),
         DeploymentItem("TestsData\\IntegerNumberData\\DivideDataTests.csv"), TestMethod]
        public void DivideTest()
        {
            int left = Int32.Parse(TestContext.DataRow["left"].ToString());
            IntegerNumber numL = new IntegerNumber(left);

            int right = Int32.Parse(TestContext.DataRow["right"].ToString());
            IntegerNumber numR = new IntegerNumber(right);

            int expected = Int32.Parse(TestContext.DataRow["expected"].ToString());

            IntegerNumber actual = numL.Divide(numR) as IntegerNumber;

            Assert.AreEqual(expected, actual.Number);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                 "|DataDirectory|\\MultiplyDataTests.csv", "MultiplyDataTests#csv", DataAccessMethod.Sequential),
         DeploymentItem("TestsData\\IntegerNumberData\\MultiplyDataTests.csv"), TestMethod]
        public void MultiplyTest()
        {
            int left = Int32.Parse(TestContext.DataRow["left"].ToString());
            IntegerNumber numL = new IntegerNumber(left);

            int right = Int32.Parse(TestContext.DataRow["right"].ToString());
            IntegerNumber numR = new IntegerNumber(right);

            int expected = Int32.Parse(TestContext.DataRow["expected"].ToString());

            IntegerNumber actual = numL.Multiply(numR) as IntegerNumber;

            Assert.AreEqual(expected, actual.Number);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                "|DataDirectory|\\SubtractDataTests.csv", "SubtractDataTests#csv", DataAccessMethod.Sequential),
        DeploymentItem("TestsData\\IntegerNumberData\\SubtractDataTests.csv"), TestMethod]
        public void SubtractTest()
        {
            int left = Int32.Parse(TestContext.DataRow["left"].ToString());
            IntegerNumber numL = new IntegerNumber(left);

            int right = Int32.Parse(TestContext.DataRow["right"].ToString());
            IntegerNumber numR = new IntegerNumber(right);

            int expected = Int32.Parse(TestContext.DataRow["expected"].ToString());

            IntegerNumber actual = numL.Subtract(numR) as IntegerNumber;

            Assert.AreEqual(expected, actual.Number);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                 "|DataDirectory|\\CompareToDataTests.csv", "CompareToDataTests#csv", DataAccessMethod.Sequential),
         DeploymentItem("TestsData\\IntegerNumberData\\CompareToDataTests.csv"), TestMethod]
        public void CompareToTest()
        {
            int left = Int32.Parse(TestContext.DataRow["left"].ToString());
            IntegerNumber numL = new IntegerNumber(left);

            int right = Int32.Parse(TestContext.DataRow["right"].ToString());
            IntegerNumber numR = new IntegerNumber(right);

            int expected = Int32.Parse(TestContext.DataRow["expected"].ToString());

            int actual = numL.CompareTo(numR);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CloneTest()
        {
            IntegerNumber original = new IntegerNumber(10);
            IntegerNumber copy = original.Clone() as IntegerNumber;

            Assert.AreEqual(original.Number, copy.Number);

            original = new IntegerNumber(11);

            Assert.AreNotEqual(original.Number, copy.Number);
        }
    }
}