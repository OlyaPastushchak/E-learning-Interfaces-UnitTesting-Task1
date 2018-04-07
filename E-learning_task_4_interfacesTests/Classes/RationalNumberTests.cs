using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace E_learning_task_4_interfaces.Tests
{
    [TestClass()]
    public class RationalNumberTests
    {
        private TestContext testContext;

        public TestContext TestContext { get => testContext; set => testContext = value; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                 "|DataDirectory|\\AddDataTests.csv", "AddDataTest#csv", DataAccessMethod.Sequential),
         DeploymentItem("TestsData\\RationalNumberData\\AddDataTest.csv"), TestMethod]
        public void AddTest()
        {
            int leftNumerator = Int32.Parse(TestContext.DataRow["leftNumerator"].ToString());
            int leftDenominator = Int32.Parse(TestContext.DataRow["leftDenominator"].ToString());
            RationalNumber numL = new RationalNumber(leftNumerator, leftDenominator);
            /*leftNumerator,leftDenominator,rightNumerator,rightDenominator,expectedNumerator,expectedDenominator*/
            int rightNumerator = Int32.Parse(TestContext.DataRow["rightNumerator"].ToString());
            int rightDenominator = Int32.Parse(TestContext.DataRow["rightDenominator"].ToString());
            RationalNumber numR = new RationalNumber(rightNumerator, rightDenominator);

            int expectedNumerator = Int32.Parse(TestContext.DataRow["expectedNumerator"].ToString());
            int expectedDenominator = Int32.Parse(TestContext.DataRow["expectedDenominator"].ToString());
            RationalNumber expected = new RationalNumber(expectedNumerator, expectedDenominator);

            RationalNumber actual = numL.Add(numR) as RationalNumber;

            Assert.AreEqual(expected.Numerator, actual.Numerator);
            Assert.AreEqual(expected.Denominator, actual.Denominator);
        }



        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                 "|DataDirectory|\\DevideDataTest.csv", "DevideDataTest#csv", DataAccessMethod.Sequential),
         DeploymentItem("TestsData\\RationalNumberData\\DevideDataTest.csv"), TestMethod]
        public void DivideTest()
        {
            int leftNumerator = Int32.Parse(TestContext.DataRow["leftNumerator"].ToString());
            int leftDenominator = Int32.Parse(TestContext.DataRow["leftDenominator"].ToString());
            RationalNumber numL = new RationalNumber(leftNumerator, leftDenominator);
            /*leftNumerator,leftDenominator,rightNumerator,rightDenominator,expectedNumerator,expectedDenominator*/
            int rightNumerator = Int32.Parse(TestContext.DataRow["rightNumerator"].ToString());
            int rightDenominator = Int32.Parse(TestContext.DataRow["rightDenominator"].ToString());
            RationalNumber numR = new RationalNumber(rightNumerator, rightDenominator);

            int expectedNumerator = Int32.Parse(TestContext.DataRow["expectedNumerator"].ToString());
            int expectedDenominator = Int32.Parse(TestContext.DataRow["expectedDenominator"].ToString());
            RationalNumber expected = new RationalNumber(expectedNumerator, expectedDenominator);

            RationalNumber actual = numL.Divide(numR) as RationalNumber;

          
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                 "|DataDirectory|\\MultiplyDataTest.csv", "MultiplyDataTest#csv", DataAccessMethod.Sequential),
         DeploymentItem("TestsData\\RationalNumberData\\MultiplyDataTest.csv"), TestMethod]
        public void MultiplyTest()
        {
            int leftNumerator = Int32.Parse(TestContext.DataRow["leftNumerator"].ToString());
            int leftDenominator = Int32.Parse(TestContext.DataRow["leftDenominator"].ToString());
            RationalNumber numL = new RationalNumber(leftNumerator, leftDenominator);
            /*leftNumerator,leftDenominator,rightNumerator,rightDenominator,expectedNumerator,expectedDenominator*/
            int rightNumerator = Int32.Parse(TestContext.DataRow["rightNumerator"].ToString());
            int rightDenominator = Int32.Parse(TestContext.DataRow["rightDenominator"].ToString());
            RationalNumber numR = new RationalNumber(rightNumerator, rightDenominator);

            int expectedNumerator = Int32.Parse(TestContext.DataRow["expectedNumerator"].ToString());
            int expectedDenominator = Int32.Parse(TestContext.DataRow["expectedDenominator"].ToString());
            RationalNumber expected = new RationalNumber(expectedNumerator, expectedDenominator);

            RationalNumber actual = numL.Multiply(numR) as RationalNumber;


            Assert.AreEqual(expected.Numerator, actual.Numerator);
            Assert.AreEqual(expected.Denominator, actual.Denominator);

        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                "|DataDirectory|\\SubtractDataTest.csv", "SubtractDataTest#csv", DataAccessMethod.Sequential),
        DeploymentItem("TestsData\\RationalNumberData\\SubtractDataTest.csv"), TestMethod]
        public void SubtractTest()
        {
            int leftNumerator = Int32.Parse(TestContext.DataRow["leftNumerator"].ToString());
            int leftDenominator = Int32.Parse(TestContext.DataRow["leftDenominator"].ToString());
            RationalNumber numL = new RationalNumber(leftNumerator, leftDenominator);
            /*leftNumerator,leftDenominator,rightNumerator,rightDenominator,expectedNumerator,expectedDenominator*/
            int rightNumerator = Int32.Parse(TestContext.DataRow["rightNumerator"].ToString());
            int rightDenominator = Int32.Parse(TestContext.DataRow["rightDenominator"].ToString());
            RationalNumber numR = new RationalNumber(rightNumerator, rightDenominator);

            int expectedNumerator = Int32.Parse(TestContext.DataRow["expectedNumerator"].ToString());
            int expectedDenominator = Int32.Parse(TestContext.DataRow["expectedDenominator"].ToString());
            RationalNumber expected = new RationalNumber(expectedNumerator, expectedDenominator);

            RationalNumber actual = numL.Subtract(numR) as RationalNumber;


            Assert.AreEqual(expected.Numerator, actual.Numerator);
            Assert.AreEqual(expected.Denominator, actual.Denominator);
        }

        
    
        [TestMethod()]
        public void CloneTest()
        {
            RationalNumber original = new RationalNumber(10,19);
            RationalNumber copy = original.Clone() as RationalNumber;

            Assert.AreEqual(original.Denominator, copy.Denominator);
            Assert.AreEqual(original.Numerator, copy.Numerator);

            original = new RationalNumber(8,9);
            Assert.AreNotEqual(original.Denominator, copy.Denominator);
            Assert.AreNotEqual(original.Numerator, copy.Numerator);
        }
    }
}