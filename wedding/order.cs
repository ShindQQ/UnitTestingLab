using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wedding
{

    public class order
    {
        List<ceremonies> ceremonie = new List<ceremonies>();

        List<clothes> cloth = new List<clothes>();

        List<cars> car = new List<cars>();

        public bool GetCeremonies()
        {
            return true;
        }

        public bool GetClothes()
        {
            return true;
        }

        public bool GetCars()
        {
            return true;
        }

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

            ceremonie.Select(item => sum += item.price);
            cloth.Select(item => sum += item.price);
            car.Select(item => sum += item.price);
            return sum;
        }

    }
}
