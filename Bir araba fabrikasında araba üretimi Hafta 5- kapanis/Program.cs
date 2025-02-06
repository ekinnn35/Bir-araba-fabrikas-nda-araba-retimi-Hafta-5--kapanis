using Bir_araba_fabrikasında_araba_üretimi_Hafta_5__kapanis;

class Program
{
    static void Main()
    {
        CarFactory carFactory = new CarFactory();

        while (true)
        {
            Console.Write("Araba üretmek ister misiniz? (E/H): ");
            string response = Console.ReadLine().Trim().ToUpper();

            if (response == "E")
            {
                carFactory.CreateCar();
            }
            else if (response == "H")
            {
                carFactory.DisplayAllCars();
                Console.WriteLine("Program Sonlandırıldı.");
                break;
            }
            else
            {
                Console.WriteLine("Geçersiz giriş! Lütfen 'E' (Evet) veya 'H' (Hayır) giriniz.");
            }
        }
    }
}
