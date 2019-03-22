using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinhvien
{
    class sinhvien
    {
        public String masv;
        float toan;
        float ly;
        float hoa;
        //default constructors
        public sinhvien()
        {
            this.masv = "01";
            this.toan = (float)7.5;
            this.ly = (float)8.5;
            this.hoa = (float)6.0;
        }
        public sinhvien(String masv, float toan, float ly, float hoa)
        {
            this.masv = masv;
            this.toan = toan;
            this.ly = ly;
            this.hoa = hoa;
        }
        public void nhap()
        {
            Console.WriteLine("nhap masv:");
            this.masv =Console.ReadLine();
            Console.WriteLine("nhap diem toan:");
            this.toan = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap diem ly:");
            this.ly = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap diem hoa:");
            this.hoa = float.Parse(Console.ReadLine());
        }
        public float tinhdtb()
        {
            return (float)(this.toan + this.ly + this.hoa) / 3;
        }
        public void IN()
            {
              Console.WriteLine("masv {0} co dtb la {1}",this.masv,this.tinhdtb());
           


            Console.ReadLine();
        }
    }
}
