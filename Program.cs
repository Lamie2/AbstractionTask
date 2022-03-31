using System;

namespace AbstractionTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zehmet olmasa car sayini daxil edin : ");
            
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{count} sayda masinin datalari : {Car.Show.Info}");

            Car[] cars = new Car[count];
            for (int i = 0; i < count; i++)
            {
                cars[i] = new Car();

                Console.WriteLine($"{i + 1}. Masinin rengini daxil edin  : ");
                string color = Console.ReadLine();
                Console.WriteLine($"{i + 1}. Masinin brandini daxil edin  : ");
                string brand = Console.ReadLine();
                Console.WriteLine($"{i + 1}. Masinin millage-ni daxil edin  : ");
                double millage = double.Parse(Console.ReadLine());
                Console.WriteLine($"{i + 1}. Masinin fuel capasicty- ni daxil edin  : ");
                double fuelCapacity = double.Parse(Console.ReadLine());
                Console.WriteLine($"{i + 1}. Masinin Current Fuel-ni daxil edin  : ");
                double currentFuel = double.Parse(Console.ReadLine());
                Console.WriteLine($"{i + 1}. Masinin Fuel For 1km-ni daxil edin  : ");
                double fuelFor1km = double.Parse(Console.ReadLine()); ;

            }

            bool check = true;
            while (check)
            {

            Console.WriteLine("1. Maşınları millage - e göre filtirle \n 2. Butuun masinlari goster \n  3. Prosesi bitir");
            Console.WriteLine("Zehmet olmasa secimizi daxil edin : ");
            string answer =  Console.ReadLine();

            switch (answer)
            {
                case "1":
                    Console.WriteLine("Zehmet olmasa max ve min millage deyerleri daxil edin");
                    double MaxMillage = double.Parse(Console.ReadLine());
                    double MinMillage = double.Parse(Console.ReadLine());
                    for (int i = 0; i < cars.Length; i++)
                    {
                        int counter = 0;
                        if (cars[i].Millage >= MinMillage && cars[i].Millage <= MaxMillage)
                            counter++;
                        if (counter > 0)
                            Console.WriteLine($"Deyerlere uygun masin:{cars[i].Brand},{cars[i].Millage}\n");
                    }
                    break;

                case "2":
                    foreach (var item in cars)
                        Console.WriteLine($"{item.Brand},{item.Color},{item.Millage },{item.FuelCapacity},{item.CurrentFuel },{item.FuelFor1km}\n");
                    break;

                case "3":
                    check = false;
                    break;
                default:
                        Console.WriteLine("    1,2 ve 3 secimi etmelisiz!  ");
                        break;
                }
            }

        }
    }
}
