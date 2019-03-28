using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sach
{
        class Sachgiaokhoa : Sach
        {
            String Tinhtrang;

            public Sachgiaokhoa() : base()
            {
                this.Tinhtrang = "moi";
            }
            public new void Nhap()
            {
                base.Nhap();
                Console.WriteLine("Nhap tinh trang sach:");
                this.Tinhtrang = Console.ReadLine();
            }
            public float Tinhtien()
            {
                if (this.Tinhtrang == "moi")
                {
                    return (this.Soluong * this.Dongia);
                }
                else
                {
                    return (this.Soluong * this.Dongia * 50 / 100);
                }
            }
            public void Hienthi()
            {
                Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}", this.maSach, this.Soluong, this.Dongia, this.Tinhtien());
            }
        }
    }


