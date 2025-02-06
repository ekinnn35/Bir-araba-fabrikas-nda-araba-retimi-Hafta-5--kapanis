using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bir_araba_fabrikasında_araba_üretimi_Hafta_5__kapanis
{
    public class Car
    {
        public int ProductionYear { get; private set; }
        public string SerialNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int DoorCount { get; set; }

        public Car(string serialNumber, string brand, string model, string color, int doorCount)
        {
            ProductionYear = DateTime.Now.Year; // Arabanın üretim yılı otomatik olarak atanır
            SerialNumber = serialNumber;
            Brand = brand;
            Model = model;
            Color = color;
            DoorCount = ValidateDoorCount(doorCount);
        }

        private int ValidateDoorCount(int doorCount)
        {
            if (doorCount < 2 || doorCount > 5)
            {
                Console.WriteLine("Geçersiz kapı sayısı! Lütfen 2 ile 5 arasında bir değer giriniz.");
                return 4; // Varsayılan olarak 4 kapılı atanır
            }
            return doorCount;
        }

        public void DisplayCarInfo()
        {
            Console.WriteLine($"Seri No: {SerialNumber}, Marka: {Brand}, Model: {Model}, Renk: {Color}, Kapı Sayısı: {DoorCount}, Üretim Yılı: {ProductionYear}");
        }
    }

}
