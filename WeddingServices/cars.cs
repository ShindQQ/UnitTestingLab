namespace WeddingServices
{
    public sealed class Cars : Services
    {
        public readonly string Name;

        public Cars(string name, double price)
        {
            Name = name;
            Price = price;

        }

        public override void Print()
        {
            Console.WriteLine("Name = " + Name + " ,price = " + Price);
        }
    }
}