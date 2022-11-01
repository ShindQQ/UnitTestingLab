using System.Collections.Generic;
using System.Linq;

namespace WeddingServices
{
    public class Orders
    {
        List<Ceremonies> Ceremonies { get; set; } = new List<Ceremonies>();

        List<Clothes> Clothes { get; set; } = new List<Clothes>();

        List<Cars> Cars { get; set; } = new List<Cars>();

        public bool AddCeremonie(string Place, double Price)
        {
            Ceremonies temp = new Ceremonies(Place, Price);

            Ceremonies.Add(temp);

            return true;
        }

        public bool RemoveCeremonie(string Place, double Price)
        {
            Ceremonies temp = new Ceremonies(Place, Price);

            Ceremonies.Remove(temp);

            return true;
        }

        public bool AddCloth(string Name, double Price)
        {
            Clothes temp = new Clothes(Name, Price);

            Clothes.Add(temp);

            return true;
        }

        public bool RemoveCloth(string Name, double Price)
        {
            Clothes temp = new Clothes(Name, Price);

            Clothes.Remove(temp);

            return true;
        }

        public bool AddCar(string Name, double Price)
        {
            Cars temp = new Cars(Name, Price);

            Cars.Add(temp);

            return true;
        }

        public bool RemoveCar(string Name, double Price)
        {
            Cars temp = new Cars(Name, Price);

            Cars.Remove(temp);

            return true;
        }

        public double Summary()
        {
            double sum = 0;

            sum += Ceremonies.Sum(item => item.Price);
            sum += Clothes.Sum(item => item.Price);
            sum += Cars.Sum(item => item.Price);

            return sum;
        }

        public void DescendingPrice()
        {
            List<Services> orders = new List<Services>();

            orders.AddRange(Clothes);
            orders.AddRange(Cars);
            orders.AddRange(Ceremonies);
            orders.OrderByDescending(item => item.Price);
        }
    }
}
