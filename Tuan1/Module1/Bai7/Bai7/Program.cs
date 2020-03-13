using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, a;
            Console.WriteLine("***** CAC HAM LUONG GIAC *****");
            Console.Write("Nhap vao 1 goc: ");
            x = Convert.ToInt32(Console.ReadLine());
            a = x * Math.PI / 180;

            Console.WriteLine("Sin({0}) = {1}", x, Math.Sin(a));
            Console.WriteLine("Cos({0}) = {1}", x, Math.Cos(a));
            Console.WriteLine("Tan({0}) = {1}", x, Math.Tan(a));
            Console.WriteLine("CogTan({0}) = {1}", x, 1 / Math.Tan(a));
            Console.ReadLine();

        }
    }
}
