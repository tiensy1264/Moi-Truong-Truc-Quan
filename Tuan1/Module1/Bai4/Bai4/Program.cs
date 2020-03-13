using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            int dai, rong, chuvi = 0, dientich = 0;
            Console.WriteLine("************Tinh chu vi & Dien tich************");
            Console.Write("Nhap vao chieu Dai : ");
            dai = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao chieu Rong : ");
            rong = Convert.ToInt32(Console.ReadLine());
            chuvi = (dai + rong) * 2;
            dientich = dai * rong;
            Console.WriteLine("Chu vi = " + chuvi);
            Console.WriteLine("Dien tich = " + dientich);
            Console.ReadLine();
        }
    }
}
