//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LAB1._5
//{
//    public class Bai1
//    {
//        static void Main()
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;

//            List<PhanSo> danhSachPhanSo = new List<PhanSo>();

//            Console.Write("Nhập số lượng phân số: ");
//            int n = int.Parse(Console.ReadLine());

//            for (int i = 0; i < n; i++)
//            {
//                Console.WriteLine($"\nNhập phân số thứ {i + 1}:");
//                PhanSo ps = new PhanSo();
//                ps.Nhap();
//                danhSachPhanSo.Add(ps);
//            }

//            // Tính tổng phân số
//            PhanSo tong = new PhanSo(0, 1);
//            foreach (var ps in danhSachPhanSo)
//            {
//                tong = PhanSo.Cong(tong, ps);
//            }

//            Console.WriteLine("\nTổng các phân số là:");
//            tong.HienThi();

//            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
//            Console.ReadKey();
//        }

//    }
//}
