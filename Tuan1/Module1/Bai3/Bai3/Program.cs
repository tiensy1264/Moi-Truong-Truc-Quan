using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            int nSo1, nSo2, nTong = 0, nHieu = 0, nTich = 0, nThuong = 0;
            Console.Clear();
            Console.Write("{0}", "Nhap so thu nhat: ");
            nSo1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            nSo2 = Convert.ToInt32(Console.ReadLine());
            nTong = nSo1 + nSo2;
            nHieu = nSo1 - nSo2;
            nThuong = nSo1 / nSo2;
            nTich = nSo1 * nSo2;
            Console.WriteLine("Tong cua " + nSo1 + " va " + nSo2 + " La: " + nTong);
            Console.WriteLine("Hieu cua " + nSo1 + " va " + nSo2 + " la " + nHieu);
            Console.WriteLine("Tich cua " + nSo1 + " va " + nSo2 + " la " + nTich);
            Console.WriteLine("Thuong cua " + nSo1 + " va " + nSo2 + " la " + nThuong);
            Console.ReadLine();
        }
    }
}
