using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingLab;
using UnitTestingLab.PersonsModels;

namespace UTL_Test
{
    [TestClass]
    public class BankUserTests
    {
        [TestMethod]
        public void Balance_Input100_Return100()
        {
            var sut = new BankUser("Igor", "Ivaov", 100m);
            decimal expected = 100m;
            decimal actual = sut.AmmountOfMoney;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Deposit_1year100m_Return891_61()
        {
            var sut = new BankUser("Igor", "Ivaov", 100m);
            Bank bank = new Bank();
            bank.BankUsers.Add(0, sut);

            bank.Deposit(0, 100m, 12);

            double expected = 891.61;
            double actual = System.Convert.ToDouble(sut.StoryOfMoney[sut.StoryOfMoney.Count-1]);

            Assert.AreEqual(expected,actual,0.01);
        }

        [TestMethod]
        public void Credit_1000m_Return900()
        {
            var sut = new BankUser("Igor", "Ivaov", 100m);
            Bank bank = new Bank();
            bank.BankUsers.Add(0, sut);

            bank.Credit(0, 1000m);

            double expected = 900;
            double actual = System.Convert.ToDouble  (sut.StoryOfMoney[sut.StoryOfMoney.Count - 1]);
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        public void BankUsers_HaveUsers()
        {
            var sut = new BankUser("Igor", "Ivaov", 100m);
            Bank bank = new Bank();
            bank.BankUsers.Add(0, sut);

            CollectionAssert.Contains(bank.BankUsers.Values, sut);
        }

        [TestMethod]
        public void CreateBankWorker_ShouldReturnBankWorker()
        {

            var sut = new BankWorker("Zero","Null");

            Assert.IsInstanceOfType(sut, typeof(Person));
        }

        [TestMethod]
        public void CreateWorker_ShouldCreateSeperateInstance()
        {
            var sut_1 = new BankWorker("sut", "sut");
            var sut_2 = new BankWorker("sut", "sut");

            Assert.AreNotSame(sut_2, sut_1);
        }
    }
}
