using System.Xml.Linq;

namespace WeddingServices
{

    public sealed class ceremonies : Services
    {
        public readonly string place;

        public ceremonies(string Place, double Price)
        {
            place = Place;
            price = Price;

        }
        public override void Print()
        {
            Console.WriteLine("Place = " + place + " ,price = " + price);
        }
    }
}
