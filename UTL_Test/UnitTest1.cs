using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingLab;
using UnitTestingLab.PersonsModels;


namespace UTL_Test
{

    [TestClass]
    public class UnitTest1
    {
      

        [TestMethod]
        public void CheckBalance()
        {
            BankUser user = new BankUser("Igor", "Ivaov", 100m);
            decimal expected = 100m;
            decimal actual = user.AmmountOfMoney;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckMoneyAfterDeposit()
        {
            BankUser user = new BankUser("Igor", "Ivaov", 100m);
            Bank bank = new Bank();
            bank.BankUsers.Add(0, user);

            bank.Deposit(0, 100m, 12);

            double expected = 891.61;
            double actual = System.Convert.ToDouble(user.StoryOfMoney[user.StoryOfMoney.Count-1]);


            Assert.AreEqual(expected,actual,0.01);


        }

        [TestMethod]
        public void CheckMoneyAfterCredit()
        {
            BankUser user = new BankUser("Igor", "Ivaov", 100m);
            Bank bank = new Bank();
            bank.BankUsers.Add(0, user);

            bank.Credit(0, 1000m);

            double expected = 900;
            double actual = System.Convert.ToDouble  (user.StoryOfMoney[user.StoryOfMoney.Count - 1]);
            Assert.AreEqual(expected, actual, 0.001);

        }
    }
}