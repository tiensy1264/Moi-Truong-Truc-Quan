using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, p, chuVi, dienTich;
            Console.WriteLine("****** Chu Vi Dien Tich Tam Giac *****");
            Console.Write("Nhap vao canh a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao canh b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao canh c: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("Khong tao thanh tam giac");
            }
            else
            {
                chuVi = a + b + c;
                p = chuVi / 2;
                dienTich = (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("Chu vi hinh:" + chuVi + "\nDien tich hinh: " + dienTich);
                Console.ReadLine();
            }
        }
    }
}
