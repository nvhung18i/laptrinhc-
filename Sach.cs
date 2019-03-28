using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sach
{
    class Sach
    {
        protected String maSach;
        protected int NgayNhap;
        protected int Dongia;
        protected int Soluong;
        public Sach() { }
        public Sach(String maSach, DateTime Ngaynhap, int Dongia, int Soluong)
        {
            this.maSach = maSach;
            this.NgayNhap = NgayNhap;
            this.Dongia = Dongia;
            this.Soluong = Soluong;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap ma sach:");
            this.maSach = Console.ReadLine();
            Console.WriteLine("Nhap Ngay nhap:");
            this.NgayNhap = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap gia:");
            this.Dongia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so luong:");
            this.Soluong = Convert.ToInt32(Console.ReadLine());
        }
        public void In()
        {
            Console.WriteLine("Sach co ma {0}, ngay nhap {1}, don gia {2} va so luong {3}", this.maSach, this.NgayNhap, this.Dongia, this.Soluong);
        }
    }
}


