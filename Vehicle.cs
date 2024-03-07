using System;

namespace BTCsharpVehicle
{
    public class Vehicle
    {
        private string hangSanXuat;
        private string model;
        private int namSanXuat;
        private decimal giaBan;
        private string chuSoHuu;

        public string HangSanXuat { get => hangSanXuat; set => hangSanXuat = value; }
        public string Model { get => model; set => model = value; }
        public int NamSanXuat { get => namSanXuat; set => namSanXuat = value; }
        public decimal GiaBan { get => giaBan; set => giaBan = value; }
        public string ChuSoHuu { get => chuSoHuu; set => chuSoHuu = value; }

        public Vehicle()
        {
        }

        public Vehicle(string hangSanXuat, string model, int namSanXuat, decimal giaBan, string chuSoHuu)
        {
            this.hangSanXuat = hangSanXuat;
            this.model = model;
            this.namSanXuat = namSanXuat;
            this.giaBan = giaBan;
            this.chuSoHuu = chuSoHuu;
        }

        public virtual void HienThiThongTin()
        {
            Console.WriteLine("-Hang san xuat: " + this.hangSanXuat);
            Console.WriteLine("Model: " + this.model);
            Console.WriteLine("Nam san xuat: " + this.namSanXuat);
            Console.WriteLine("Gia ban: " + this.giaBan);
            Console.WriteLine("Chu so huu: " + this.chuSoHuu);
        }

        public virtual void NhapThongTin()
        {
            Console.WriteLine("Nhap hang san xuat: ");
            this.hangSanXuat = Console.ReadLine();
            Console.WriteLine("Nhap model: ");
            this.model = Console.ReadLine();
            Console.WriteLine("Nhap nam san xuat: ");
            this.namSanXuat = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Nhap gia ban: ");
            this.giaBan = decimal.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Nhap chủ so huu: ");
            this.chuSoHuu = Console.ReadLine();
        }
    }
}
