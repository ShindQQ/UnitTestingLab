using System;
namespace WeddingServices
{
    public sealed class Clothes : Services
    {
        public readonly string Name;

        public Clothes(string name, double price)
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
