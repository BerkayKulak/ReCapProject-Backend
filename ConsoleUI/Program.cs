using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            //DTO = Data transformation object => taşıyacağımız objeler
            // Ioc

           /* CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }*/


            CarManager carManager1 = new CarManager(new EfCarDal());

            foreach (var car in carManager1.GetCarDetails())
            {
                Console.WriteLine(car.CarName + "/" + car.ColorName);
            }

            Console.WriteLine("-------------------");

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("color id " + car.ColorId);
            }



            Console.WriteLine("----------Tüm renkler---------");

            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine("color name " + color.ColorName);
            }


            Console.WriteLine("----------İstenilen arabanın Açıklaması---------");
            CarManager carManager2 = new CarManager(new EfCarDal());
            Console.WriteLine("Hangi marka araçların Açıklamasını görmek istiyorsunuz?");
            Console.WriteLine("Marka seçin--> 1:Mercedes 2:Tofas");
            int markaSecim = Convert.ToInt32(Console.ReadLine());
            foreach (var cars in carManager2.GetCarsByBrandId(markaSecim))
            {
                Console.WriteLine("araba açıklaması " + cars.Description);
            }

            Console.WriteLine("----------İstenilen arabanın Rengi---------");
            CarManager carManager3 = new CarManager(new EfCarDal());
            Console.WriteLine("Hangi marka araçların Renk İdsini görmek istiyorsunuz?");
            Console.WriteLine("Renk seçin--> 1:Kırmızı 2:Beyaz");
            int renkSecim = Convert.ToInt32(Console.ReadLine());
            foreach (var cars in carManager3.GetCarsByColorId(renkSecim))
            {
                Console.WriteLine("arabanın renk idsi = " + cars.ColorId + " araba açıklaması = "+ cars.Description);
            }

            
            Console.WriteLine("----------Araba ekle---------");
            Car car2 = new Car();
            CarManager carManager4 = new CarManager(new EfCarDal());
            Console.Write("Aracın  Id sini giriniz:");
            car2.CarId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Aracın marka Id sini giriniz:");
            car2.BrandId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Aracın renk Id sini giriniz:");
            car2.ColorId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen Günlük Kiralama Ücretini Giriniz:");
            car2.DailyPrice = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Lütfen Açıklama Giriniz:");
            car2.Description = Convert.ToString(Console.ReadLine());
            Console.Write("Lütfen Yıl Giriniz:");
            car2.ModelYear = Convert.ToString(Console.ReadLine());
            carManager4.Add(car2);
            Console.WriteLine("Araç eklendi");



            /*
            GetCars();
            GetRenkSecenekleri();
            GetCarByColorId();
            GetCarByBrandId();
            AddCar();
            Console.ReadKey();
        }

        static void GetCars()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine("Araç kiralama sistemimize hoşgeldiniz");
            Console.WriteLine("<<<<<<<<<< Araçlarımız >>>>>>>>>> \n");

            foreach (var car in carManager.GetAll())
            {

                Console.WriteLine("<<<" + car.Description + ">>>");
                Console.WriteLine("Günlük fiyatı: " + car.DailyPrice);
                Console.WriteLine("Model yılı: " + car.ModelYear);
                Console.WriteLine();
            }
        }

        static void GetRenkSecenekleri()
        {
            Console.WriteLine("<<<<<<<<<< Renk seçenekleri >>>>>>>>>> \n");

            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine("<<<" + color.ColorName + ">>>");
            }
            Console.WriteLine();
        }

        static void GetCarByColorId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("Hangi renkteki araçları görmek istiyorsunuz?");
            Console.WriteLine("Renk seçin--> 1:kırmızı 2:beyaz");

            int renkSecim = Convert.ToInt32(Console.ReadLine());

            foreach (var cars in carManager.GetCarsByColorId(renkSecim))
            {
                Console.WriteLine("Araç tanımı " + cars.Description);
            }
        }

        static void GetCarByBrandId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("Hangi marka araçları görmek istiyorsunuz?");
            Console.WriteLine("Marka seçin--> 1:Mercedes 2:Tofas");

            int markaSecim = Convert.ToInt32(Console.ReadLine());

            foreach (var cars in carManager.GetCarsByBrandId(markaSecim))
            {
                Console.WriteLine(cars.Description);
            }
        }
        static void AddCar()
        {
            Car car = new Car();

            CarManager carManager = new CarManager(new EfCarDal());

            Console.Write("Aracın marka Id sini giriniz:");
            car.BrandId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Aracın renk Id sini giriniz:");
            car.ColorId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen Günlük Kiralama Ücretini Giriniz:");
            car.DailyPrice = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Lütfen Açıklama Giriniz:");
            car.Description = Convert.ToString(Console.ReadLine());

            Console.Write("Lütfen Yıl Giriniz:");
            car.ModelYear = Convert.ToString(Console.ReadLine());



            carManager.Add(car);*/


        }
    }
}