namespace WeddingServices
{

    public sealed class clothes : Services
    {
        public readonly string name;


        public clothes(string Name, double Price)
        {
            name = Name;
            price = Price;

        }
        public override void Print()
        {
            Console.WriteLine("Name = " + name + " ,price = " + price);
        }

    }
}
