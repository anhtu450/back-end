//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LAB1._5
//{
//    internal class Bai2
//    {
//        static void Main()
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;
//            List<Hinh> danhSachHinh = new();

//            danhSachHinh.Add(new HinhTron(5));
//            danhSachHinh.Add(new HinhVuong(4));
//            danhSachHinh.Add(new HinhChuNhat(3, 6));
//            danhSachHinh.Add(new HinhTamGiac(3, 4, 5));

//            double tongChuVi = 0;
//            double tongDienTich = 0;

//            Console.WriteLine("Danh sách các hình và thông tin:");

//            foreach (var hinh in danhSachHinh)
//            {
//                double cv = hinh.TinhChuVi();
//                double dt = hinh.TinhDienTich();
//                Console.WriteLine($"- Chu vi: {cv:F2}, Diện tích: {dt:F2}");
//                tongChuVi += cv;
//                tongDienTich += dt;
//            }

//            Console.WriteLine("\nTổng chu vi các hình: {0:F2}", tongChuVi);
//            Console.WriteLine("Tổng diện tích các hình: {0:F2}", tongDienTich);

//            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
//            Console.ReadKey();
//        }
//    }
//}
