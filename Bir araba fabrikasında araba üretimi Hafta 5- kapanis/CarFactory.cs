using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bir_araba_fabrikasında_araba_üretimi_Hafta_5__kapanis
{
    public class CarFactory
    {
        private List<Car> cars = new List<Car>();

        public void CreateCar()
        {
            Console.Write("Seri Numarasını Giriniz: ");
            string serialNumber = Console.ReadLine();

            Console.Write("Markayı Giriniz: ");
            string brand = Console.ReadLine();

            Console.Write("Modeli Giriniz: ");
            string model = Console.ReadLine();

            Console.Write("Rengi Giriniz: ");
            string color = Console.ReadLine();

            Console.Write("Kapı Sayısını Giriniz (2-5 arasında): ");
            int doorCount;
            while (!int.TryParse(Console.ReadLine(), out doorCount) || doorCount < 2 || doorCount > 5)
            {
                Console.WriteLine("Hatalı giriş! Kapı sayısını 2 ile 5 arasında bir tam sayı olarak giriniz.");
            }

            Car newCar = new Car(serialNumber, brand, model, color, doorCount);
            cars.Add(newCar);
            Console.WriteLine("Araba başarıyla üretildi!\n");
        }

        public void DisplayAllCars()
        {
            Console.WriteLine("\nÜretilen Arabalar:");
            foreach (var car in cars)
            {
                car.DisplayCarInfo();
            }
        }
    }

}
