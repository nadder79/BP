using Microsoft.VisualStudio.TestTools.UnitTesting;
using BPCalculator;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void whenLowDiastolicAndLowSysThenLowBP()
        {
            BloodPressure test = new BloodPressure();
            test.Diastolic = 50;
            test.Systolic = 80;

            BPCategory bPCategory= test.Category;

            Assert.AreEqual(BPCategory.Low, bPCategory, "Incorrect");

        }

        [TestMethod]
        public void TestMethod2()
        {
            BloodPressure test = new BloodPressure();
            test.Diastolic = 50;
            test.Systolic = 110;

            BPCategory bPCategory = test.Category;

            Assert.AreEqual(BPCategory.Normal, bPCategory, "Incorrect");

        }

    }
}
