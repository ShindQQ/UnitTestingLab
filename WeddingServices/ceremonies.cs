namespace WeddingServices
{
    public sealed class Ceremonies : Services
    {
        public readonly string Place;

        public Ceremonies(string place, double price)
        {
            Place = place;
            Price = price;

        }

        public override void Print()
        {
            Console.WriteLine("Place = " + Place + " ,price = " + Price);
        }
    }
}
