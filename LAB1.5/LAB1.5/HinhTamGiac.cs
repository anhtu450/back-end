using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1._5
{
    public class HinhTamGiac : Hinh
    {
        public double a, b, c;

        public HinhTamGiac(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double TinhChuVi()
        {
            return a + b + c;
        }

        public override double TinhDienTich()
        {
            double p = TinhChuVi() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
