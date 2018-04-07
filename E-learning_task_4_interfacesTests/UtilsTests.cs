using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace E_learning_task_4_interfaces.Tests
{
    [TestClass()]
    public class UtilsTests
    {
        private TestContext testContext;

        public TestContext TestContext { get => testContext; set => testContext = value; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                   "|DataDirectory|\\GcdDataTests.csv", "GcdDataTests#csv", DataAccessMethod.Sequential),
           DeploymentItem("TestsData\\GcdDataTests.csv"), TestMethod]
        public void GcdTest()
        {
            int a = Int32.Parse(TestContext.DataRow["a"].ToString());
            int b = Int32.Parse(TestContext.DataRow["b"].ToString());
            int result = Int32.Parse(TestContext.DataRow["result"].ToString());

            int actual = Utils.Gcd(a, b);

            Assert.AreEqual(result, actual);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    "|DataDirectory|\\LcmDataTests.csv", "LcmDataTests#csv", DataAccessMethod.Sequential),
            DeploymentItem("TestsData\\LcmDataTests.csv"), TestMethod]
        public void LcmTest()
        {
            int a = Int32.Parse(TestContext.DataRow["a"].ToString());
            int b = Int32.Parse(TestContext.DataRow["b"].ToString());
            int result = Int32.Parse(TestContext.DataRow["result"].ToString());

            int actual = Utils.Lcm(a, b);

            Assert.AreEqual(result, actual);
        }
    }
}