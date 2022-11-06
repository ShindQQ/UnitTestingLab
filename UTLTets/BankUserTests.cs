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
        public void Deposit_1year100mUserWithValidAmountOfMoneyAndId_ShouldReturnTrueAndCalculateCorrectAmount()
        {
            var user = new BankUser("Igor", "Ivaov", 100m);
            var sut = new Bank();
            sut.BankUsers.Add(0, user);

            var actual = sut.Deposit(0, 100m, 12);

            double expected = 891.61;
            double actualAmount = System.Convert.ToDouble(sut.BankUsers[0].AmmountOfMoney);

            Assert.IsTrue(actual);
            Assert.AreEqual(expected, actualAmount, 0.01);
        }

        [TestMethod]
        public void Deposit_1year100mUserWithInValidAmountOfMoney_ShouldReturnFalse()
        {
            var user = new BankUser("Igor", "Ivaov", 100m);
            var sut = new Bank();
            sut.BankUsers.Add(0, user);

            var actual = sut.Deposit(0, -100m, 12);
            Assert.IsFalse(actual);
           
        }

        [TestMethod]
        public void Deposit_1year100mUserWithInValidID_ShouldReturnFalse()
        {
            var user = new BankUser("Igor", "Ivaov", 100m);
            var sut = new Bank();
            sut.BankUsers.Add(0, user);

            var actual = sut.Deposit(-1, 100m, 12);
            Assert.IsFalse(actual);

        }

        [TestMethod]
        public void Deposit_1year100mUserWithInValidTimeInMonths_ShouldReturnFalse()
        {
            var user = new BankUser("Igor", "Ivaov", 100m);
            var sut = new Bank();
            sut.BankUsers.Add(0, user);

            var actual = sut.Deposit(0, 100m, -12);
            Assert.IsFalse(actual);

        }

        [TestMethod]
        public void Deposit_1year100mUserWithInValidAmmountOfMoneyMoreThenUserHas_ShouldReturnFalse()
        {
            var user = new BankUser("Igor", "Ivaov", 100m);
            var sut = new Bank();
            sut.BankUsers.Add(0, user);

            var actual = sut.Deposit(0, 200m, -12);
            Assert.IsFalse(actual);

        }

        [TestMethod]
        public void Credit_1000m_UserWithValidAmountOfMoneyAndId_ShouldReturnTrueAndCalculateCorrectAmount()
        {
            var user = new BankUser("Igor", "Ivaov", 100m);
            Bank sut = new Bank();
            sut.BankUsers.Add(0, user);

            var actual = sut.Credit(0, 1000m);

            double expected = 900;
            double actualAmount = System.Convert.ToDouble  (user.StoryOfMoney[user.StoryOfMoney.Count - 1]);

            Assert.IsTrue(actual);
            Assert.AreEqual(expected, actualAmount, 0.001);
        }


        [TestMethod]
        public void Credit_1000m_UserWithInValidAmountOfMoney_ShouldReturnFalse()
        {
            var user = new BankUser("Igor", "Ivaov", 100m);
            Bank sut = new Bank();
            sut.BankUsers.Add(0, user);

            var actual = sut.Credit(0, -1000m);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Credit_1000m_UserWithInValidID_ShouldReturnFalse()
        {
            var user = new BankUser("Igor", "Ivaov", 100m);
            Bank sut = new Bank();
            sut.BankUsers.Add(0, user);

            var actual = sut.Credit(-1, 1000m);

            Assert.IsFalse(actual);
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
