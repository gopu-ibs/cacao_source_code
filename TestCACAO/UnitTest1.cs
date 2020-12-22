using NUnit.Framework;
using CACAO.Model;
using CACAO;

namespace TestCACAO
{
    public class TestAMC
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test(Description = "Test valid amc number")]
        public void TestValidAMCNumber_Normal()
        {

            AMC amc = new AMC();
            amc.amcNumber = "123456";
            Assert.IsTrue(amc.ValivateAMC());
        }

        [Test(Description = "Test amc number is null")]
        public void TestValidAMCNumber_Except()
        {   
            AMC amc = new AMC();
            amc.amcNumber = null;
            Assert.IsFalse(amc.ValivateAMC());
        }

        [Test(Description = "Test Push")]
        public void TestPush_Normal()
        {
            Assert.AreEqual("Successfully pushed to Marvel.", AMC.Push());
        }

        [Test(Description = "Test Pull")]
        public void TestPull_Normal()
        {
            Assert.AreEqual("Successfully pulled data from CACAO.", AMC.Pull());
        }

        [Test(Description = "Test Data Normal")]
        public void TestData_Normal()
        {
            AMC amc = new AMC();
            Assert.IsNotNull(amc.GetData(@"C:\amc.json"));
        }

        [Test(Description = "Test Data Exception")]
        public void TestData_Except()
        {
            AMC amc = new AMC();
            Assert.Throws<System.IO.FileNotFoundException>(() => amc.GetData(@"C:\amc1.json"));
        }
    }
}