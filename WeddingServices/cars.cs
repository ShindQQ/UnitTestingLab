using System.Security.Claims;

namespace WeddingServices
{

    public sealed class cars : Services
    {
        public readonly string name;

        public cars(string Name, double Price)
        {
            name = Name;
            price = Price;

        }
        public override void Print()
        {
            Console.WriteLine("Name = "+name+" ,price = "+price);
        }
    }
}