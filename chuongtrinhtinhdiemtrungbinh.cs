using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinhvien
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("nhap so sv:");
            n = Int32.Parse(Console.ReadLine());
            sinhvien[] sv = new sinhvien[n];
            for (int i = 0; i < n; i++)
            {
                sv[i] = new sinhvien();
                sv[i].nhap();
                sv[i].IN();
            }
            float min = sv[0].tinhdtb();
            for (int i = 1; i < n; i++)
            {
                if (sv[i].tinhdtb() < min)
                    min = sv[i].tinhdtb();
            }
            Console.WriteLine("sv co diem thap nhat la{0}" ,min);

            for (int j = 0; j < n; j++)
            {
                for (int x = j + 1; x < n; x++)
                {
                    if (sv[x].tinhdtb() < sv[j].tinhdtb())
                    {
                        sinhvien sx = new sinhvien();
                        sx = sv[j];
                        sv[j] = sv[x];
                        sv[x] = sx;
                    }
                }
            }
            Console.WriteLine("  sinh vien sau khi xap sep tang dan la:");
            for (int j = 0; j < n; j++)
                Console.WriteLine("sinh vien ma {0} co diem TB la : {1}", sv[j].masv, sv[j].tinhdtb());

            for (int i = 0; i < n; i++)
            {
                if (sv[i].masv.Contains("IT"))
                    Console.WriteLine("sinh vien ma {0} co diem TB la:{1}", sv[i].masv, sv[i].tinhdtb());

            }
            Console.ReadLine();
        }
    }
}
