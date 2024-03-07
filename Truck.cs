using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCsharpVehicle
{
    public class Truck : Vehicle
    {
        private decimal taiTrong; // tải trọng của xe tải

        public decimal TaiTrong { get => taiTrong; set => taiTrong = value; }

        public Truck() { }

        public Truck(string hangSanXuat, string model, int namSanXuat, decimal giaBan, string chuSoHuu, decimal taiTrong)
        : base(hangSanXuat, model, namSanXuat, giaBan, chuSoHuu)
        {
            this.taiTrong = taiTrong;
        }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.WriteLine("Nhap tai trong: ");
            this.taiTrong = decimal.Parse(Console.ReadLine() ?? "0");
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine("Tai trong: " + this.taiTrong);
        }
    }
}
