using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moyka
{
    public class Car 
    {
        public string quality;
        public void Quality(string q)
        {
            quality = q;
        }
    }

    public class Garage
    {
        public  List<Car> cars=new List<Car>();
    }

    public class Moica
    {
        public static void Wash(List<Car> cars)
        {
            Console.WriteLine("Все машины помыли");
        }
    }

    delegate void MoicaDelegate(List<Car> cars);

    internal class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            string[] qualityArray = new string[5] {"Норм","Средне","Мегакрутая","Кринж","Ваще ужас" };
            for (int i = 0; i < 5; i++)
            {
                Car bup= new Car();
                bup.Quality(qualityArray[i]);
                garage.cars.Add(bup);
            }

            Console.WriteLine(garage.cars.Count);

            MoicaDelegate moica = Moica.Wash;

            moica(garage.cars);
        }
    }
}
