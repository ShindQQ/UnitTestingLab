using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingServices
{

    public class order
    {

        List<ceremonies> ceremonie { get; set; } = new List<ceremonies>();

        List<clothes> cloth { get; set; } = new List<clothes>();

        List<cars> car { get; set; } = new List<cars>();

        public bool AddCeremonie(string Place, double Price)
        {
            ceremonies temp = new ceremonies(Place, Price);
            ceremonie.Add(temp);
            return true;
        }

        public bool RemoveCeremonie(string Place, double Price)
        {
            ceremonies temp = new ceremonies(Place, Price);
            ceremonie.Remove(temp);
            return true;
        }

        public bool AddCloth(string Name, double Price)
        {
            clothes temp = new clothes(Name, Price);
            cloth.Add(temp);
            return true;
        }

        public bool RemoveCloth(string Name, double Price)
        {
            clothes temp = new clothes(Name, Price);
            cloth.Remove(temp);
            return true;
        }

        public bool AddCar(string Name, double Price)
        {
            cars temp = new cars(Name, Price);
            car.Add(temp);
            return true;
        }

        public bool RemoveCar(string Name, double Price)
        {
            cars temp = new cars(Name, Price);
            car.Remove(temp);
            return true;
        }

        public double Summary()
        {
            double sum = 0;

            sum += ceremonie.Sum(item => item.price);
            sum += cloth.Sum(item => item.price);
            sum += car.Sum(item => item.price);
            return sum;
        }

        public void DescendingPrice()
        {
            double sum = 0;
            List<Services> orders = new();
            orders.AddRange(cloth);
            orders.AddRange(car);
            orders.AddRange(ceremonie);
            orders.OrderByDescending(item => item.price);

        }

    }
}
