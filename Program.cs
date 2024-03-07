using System;
using System.Collections.Generic;
using System.Linq;

namespace BTCsharpVehicle
{
    class Program
    {
        static List<Car> cars = new List<Car>
        {
            new Car("Toyota", "Corolla", 1999, 120000, "Nguyen Van An", "Sedan"),
            new Car("Honda", "Accord", 1989, 90000, "Tran Van Bac", "Sedan"),
            new Car("Ford", "Focus", 2005, 180000, "Le Van Cai", "Hatchback"),
            new Car("Mazda", "6", 1995, 110000, "Pham Thi Dinh", "Sedan"),
            new Car("BMW", "3 Series", 2008, 250000, "Hoang Van Ngo", "Sedan"),
            new Car("Audi", "A4", 2021, 300000, "Bui Thi Tien", "Sedan")
        };
        static List<Truck> trucks = new List<Truck>
        {
            new Truck("Hyundai", "Xcient", 2018, 350000, "Cty TNHH ABC", 10000),
            new Truck("Ford", "F-150", 2020, 450000, "Cty TNHH XYZ", 5000),
            new Truck("Isuzu", "N-Series", 2015, 220000, "Doanh Nghiep EFG", 8000),
            new Truck("Mercedes-Benz", "Actros", 2012, 330000, "Cong Ty MNOP", 15000),
            new Truck("Volvo", "FH", 2019, 600000, "Cong Ty QRST", 12000),
            new Truck("Scania", "R-Series", 2017, 500000, "Cong Ty UVWX", 11000)
        };
        static void Main(string[] args)
        {
            bool continueProgram = true;
            while (continueProgram)
            {
                Console.WriteLine("Chon mot lua chon tu menu:");
                Console.WriteLine("1. Hien thi tat ca cac xe hoi");
                Console.WriteLine("2. Hien thi cac xe hoi co gia trong khoang 100.000 den 250.000");
                Console.WriteLine("3. Hien thi cac xe hoi co nam san xuat > 1990");
                Console.WriteLine("4. Gom cac xe hoi theo hang san xuat va tinh tong gia tri theo nhom");
                Console.WriteLine("5. Hien thi tat ca cac xe tai");
                Console.WriteLine("6. Hien thi danh sach xe tai theo thu tu nam san xuat moi nhat");
                Console.WriteLine("7. Hien thi ten cty chu quan cua xe tai");
                Console.WriteLine("0. Thoat chuong trinh");
                Console.Write("Nhap lua chon cua ban:");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DisplayAllCars();
                        break;
                    case 2:
                        DisplayCarsInPriceRange();
                        break;
                    case 3:
                        DisplayCarsAfter1990();
                        break;
                    case 4:
                        GroupCarsByMake();
                        break;
                    case 5:
                        DisplayAllTrucks();
                        break;
                    case 6:
                        DisplayTrucksByYearDesc();
                        break;
                    case 7:
                        DisplayTruckOwners();
                        break;
                    case 0:
                        continueProgram = false;
                        break;
                    default:
                        Console.WriteLine("Khong co lua chon nay. Vui long nhap lai.");
                        break;
                }

                if (continueProgram)
                {
                    Console.WriteLine("\nBan co muon tiep tuc? (y/n)");
                    continueProgram = Console.ReadLine().ToLower() == "y";
                }
            }
        }
        static void DisplayAllCars()
        {
            Console.WriteLine("------Tat ca cac xe hoi:");
            foreach (var car in cars)
            {
                car.HienThiThongTin();
            }
        }
        static void DisplayCarsInPriceRange()
        {
            Console.WriteLine("------Cac xe co gia tu 100.000 den 250.000:");
            var carsInPriceRange = cars.Where(car => car.GiaBan >= 100000 && car.GiaBan <= 250000);
            foreach (var car in carsInPriceRange)
            {
                car.HienThiThongTin();
            }
        }
        static void DisplayCarsAfter1990()
        {
            Console.WriteLine("------Cac xe co nam san xuat > 1990:");
            var carsAfter1990 = cars.Where(car => car.NamSanXuat > 1990);
            foreach (var car in carsAfter1990)
            {
                car.HienThiThongTin();
            }
        }
        static void GroupCarsByMake()
        {
            Console.WriteLine("------Tong gia tri xe theo hang san xuat:");
            var carsGroupedByMake = cars.GroupBy(car => car.HangSanXuat)
                                        .Select(group => new
                                        {
                                            HangSanXuat = group.Key,
                                            TongGiaTri = group.Sum(car => car.GiaBan)
                                        });

            foreach (var group in carsGroupedByMake)
            {
                Console.WriteLine($"Hang: {group.HangSanXuat}, Tong gia tri: {group.TongGiaTri}");
            }
        }
        static void DisplayAllTrucks()
        {
            Console.WriteLine("------Tat ca cac xe tai:");
            foreach (var truck in trucks)
            {
                truck.HienThiThongTin();
            }
        }

        static void DisplayTrucksByYearDesc()
        {
            Console.WriteLine("------Danh sach Truck theo thu tu nam san xuat moi nhat:");
            var trucksByYearDesc = trucks.OrderByDescending(truck => truck.NamSanXuat);
            foreach (var truck in trucksByYearDesc)
            {
                truck.HienThiThongTin();
            }
        }
        static void DisplayTruckOwners()
        {
            Console.WriteLine("------Ten cty chu quan cua Truck:");
            foreach (var truck in trucks)
            {
                Console.WriteLine($"Chu so huu: {truck.ChuSoHuu}");
            }
        }
    }
}
