using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCsharpVehicle
{
    public class Car : Vehicle
    {
        private string loaiXe; // ví dụ: sedan, hatchback, SUV, ...

        public string LoaiXe { get => loaiXe; set => loaiXe = value; }

        public Car() { }

        public Car(string hangSanXuat, string model, int namSanXuat, decimal giaBan, string chuSoHuu, string loaiXe)
        : base(hangSanXuat, model, namSanXuat, giaBan, chuSoHuu)
        {
            this.loaiXe = loaiXe;
        }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.WriteLine("Nhap loai xe: ");
            this.loaiXe = Console.ReadLine();
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine("Loai xe: " + this.loaiXe);
        }
    }
}
