using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeddingServices;

namespace Order_Test
{
    [TestClass]
    public sealed class WeddingOrdersTest
    {
        [TestMethod]
        public void CheckChengesClothes()
        {
            Orders orders = new Orders();
            bool actual = orders.AddCloth("test", 322);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckSummary()
        {
            Orders orders = new Orders();

            orders.AddCloth("test", 322);
            orders.AddCar("test2", 10);
            double expected = 322 + 10;
            double actual = orders.Summary();

            Assert.AreEqual(expected, actual);
        }
    }
}