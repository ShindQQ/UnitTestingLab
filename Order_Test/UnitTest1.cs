using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeddingServices;


namespace Order_Test
{

    [TestClass]
    public class OrderLTest
    {


        [TestMethod]
        public void CheckChengesClothes()
        {
            order Some = new order();
            bool actual = Some.AddCloth("test", 322);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckSummary()
        {
            order Some = new order();
            Some.AddCloth("test", 322);
            Some.AddCar("test2", 10);
            double expected = 322 + 10;
            double actual = Some.Summary();

            Assert.AreEqual(expected, actual);
        }

    }


}