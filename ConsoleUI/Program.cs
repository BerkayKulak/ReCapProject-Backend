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


           // UserTest();

            //CustomerTest();

            //RentalTest();

            //GetRentailDetailsTest();










            /* CarTest();
             ColorTest();
             BrandTest();*/



            //CarTest();

            //DTO = Data transformation object => taşıyacağımız objeler
            // Ioc

            /* CarManager carManager = new CarManager(new EfCarDal());

             foreach (var car in carManager.GetAll())
             {
                 Console.WriteLine(car.Description);
             }*/


            /*CarManager carManager1 = new CarManager(new EfCarDal());

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
            Console.WriteLine("Araç eklendi");*/



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


        /*private static void CarTest()
        {
 
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
        }*/


        /*private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Insert(new Car { CarName = "Hyundai i20", BrandId = 9, ColorId = 3, ModelYear = 2013, DailyPrice = 200.55m,Description="Available on weekends"});
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("{0} / {1} / {2} / {3}", car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
            }
        }*/


        /*
        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result8 = rentalManager.Add(new Rental
            { CustomerId = 1, CarId = 3, RentDate = DateTime.Now, ReturnDate = new DateTime(2021, 4, 8) });
            Console.WriteLine(result8.Message);
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result7 = customerManager.Add(new Customer { UserId = 2, CompanyName = "Simurg" });
            Console.WriteLine(result7.Message);
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result6 = userManager.Add(new User
            { FirstName = "Ethem", LastName = "Buyuksacli", Email = "ethem@mail.com", Password = "75524" });
            Console.WriteLine(result6.Message);
        }

        private static void GetRentailDetailsTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result9 = rentalManager.GetRentalDetails();
            if (result9.Success)
            {
                foreach (var rental in result9.Data)
                {
                    Console.WriteLine(rental.UserName + rental.RentDate + "\t " + rental.ReturnDate);
                }
            }
            else
            {
                Console.WriteLine(result9.Message);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            foreach (var brand in result.Data)
            {
                Console.WriteLine(brand.BrandId + brand.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAll();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Description + "\t\n" + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetCarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result5 = carManager.GetCarDetails();
            foreach (var car in result5.Data)
            {
                Console.WriteLine(car.BrandName + "\t " + car.CarName + "\t\t\n " + car.ColorName + "\t  " + car.DailyPrice + "Tl");
            }
        }

        private static void DeleteTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result4 = carManager.Delete(new Car { CarId = 6 });
            Console.WriteLine(result4.Message);
        }

        private static void AddedTest()
        {

            CarManager carManager = new CarManager(new EfCarDal());
            var resul3 = carManager.Add(new Car { BrandId = 4, ColorId = 3, DailyPrice = 0, CarName = "None" });
            Console.WriteLine(resul3.Message);
        }

        private static void GetCarsByColorId()
        {

            CarManager carManager = new CarManager(new EfCarDal());
            var result2 = carManager.GetCarsByColorId((1));
            foreach (var car in result2.Data)
            {
                Console.WriteLine(car.ModelYear + " " + car.Description + " " + car.ColorId);
            }
        }

        private static void GetCarsById()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result1 = carManager.GetCarsByBrandId((3));
            foreach (var car in result1.Data)
            {
                Console.WriteLine(car.ModelYear + " " + car.Description + " " + car.CarName);
            }
        }*/



    }
}