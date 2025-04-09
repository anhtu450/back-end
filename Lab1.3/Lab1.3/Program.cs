using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1._3;

//namespace Lab1._3
//{
//    internal class Program
//    {
//        public static void NhapPhanSo(PhanSo phanSo1, PhanSo phanSo2)
//        {
//            Console.WriteLine("Phan so 1: ");
//            phanSo1.Nhap();
//            Console.WriteLine("Phan so 2: ");
//            phanSo2.Nhap();
//        }
//        static void Main(string[] args)
//        {
//            PhanSo ps1 = new PhanSo();
//            PhanSo ps2 = new PhanSo();
//            PhanSo ps3 = new PhanSo();
//            int x;
//            Console.WriteLine("Cac phep toan cua phan so:");
//            Console.WriteLine("\t1. Nhap 1 neu muon cong");
//            Console.WriteLine("\t2. Nhap 2 neu muon tru");
//            Console.WriteLine("\t3. Nhap 3 neu muon nhan");
//            Console.WriteLine("\t4. Nhap 4 neu muon chia");
//            Console.WriteLine("\t5. Nhap 5 neu toi gian");
//            Console.Write("- Moi ban nhap lua chon: ");
//            x = int.Parse(Console.ReadLine());
//            switch (x)
//            {
//                case 1:
//                    {
//                        NhapPhanSo(ps1, ps2);
//                        ps3 = ps1 + ps2;
//                        Console.WriteLine($"Ket qua: {ps1.TuSo}/{ps1.MauSo} + {ps2.TuSo}/{ps2.MauSo} = {ps3.TuSo}/{ps3.MauSo}");
//                     } 
//                    break;
//                case 2:
//                    {
//                        NhapPhanSo(ps1, ps2);
//                        ps3 = ps1 - ps2;
//                        Console.WriteLine($"Ket qua: {ps1.TuSo}/{ps1.MauSo} - { ps2.TuSo}/{ ps2.MauSo} = { ps3.TuSo}/{ ps3.MauSo}");
//                    }
//                    break;
//                case 3:
//                    {
//                        NhapPhanSo(ps1, ps2);
//                        ps3 = ps1 * ps2;
//                        Console.WriteLine($"Ket qua: {ps1.TuSo}/{ps1.MauSo} * { ps2.TuSo}/{ ps2.MauSo} = { ps3.TuSo}/{ ps3.MauSo}");
//                }
//                    break;
//                case 4:
//                    {
//                        NhapPhanSo(ps1, ps2);
//                        ps3 = ps1 / ps2;
//                        Console.WriteLine($"Ket qua: {ps1.TuSo}/{ps1.MauSo} / { ps2.TuSo}/{ ps2.MauSo} = { ps3.TuSo}/{ ps3.MauSo}");
//                }
//                    break;
//                case 5:
//                    {
//                        Console.WriteLine("Nhap phan so muon toi gian: ");
//                        ps1.Nhap();
//                        ps1.KiemTra();
//                        if (ps1.KiemTra())
//                            Console.WriteLine("Phan so da toi gian.");
//                        else
//                        {
//                            ps1.ToiGian();
//                            Console.WriteLine("Sau khi toi gian: " + ps1.TuSo + "/" + ps1.MauSo);
//                        }
//                    }
//                    break;
//                default:
//                    Console.WriteLine("Nhap sai !!!");
//                    break;
//            }
//        }
//    }
//}
//Bài 1: Một đơn vị sản xuất gồm có các cán bộ là công nhân, kỹ sư, nhân viên.
//+Mỗi cán bộ cần quản lý các thuộc tính: Họ tên, năm sinh, giới tính, địa chỉ
//+ Các công nhân cần quản lý: Bậc(công nhân bậc 3 / 7, bậc 4 / 7...)
//+ Các kỹ sư cần quản lý: Ngành đào tạo
//+ Các nhân viên phục vụ cần quản lý thông tin: công việc
//1. Xây dựng các lớp NhanVien, CongNhan, KySu kế thừa từ lớp CanBo
//2. Xây dựng các phương thức nhập, hiển thị thông tin và kiểm tra về các thuộc tính của các lớp.
//3. Xây dựng lớp QLCB cài đặt các phương thức thực hiện các chức sau:
//-Nhập thông tin mới cho cán bộ (Hỏi người dùng muốn nhập cho: công nhân, kỹ sư hay nhân viên và nhập đúng thông tin cho đối tượng đó).
//- Tìm kiếm theo họ tên
//- Hiển thị thông tin về danh sách các cán bộ
//- Thoát khỏi chương trình.
//class Program
//{
//    static void Main(string[] args)
//    {
//        QLCB qlcb = new QLCB();

//        while (true)
//        {
//            Console.WriteLine("\n====== QUAN LY CAN BO ======");
//            Console.WriteLine("1. Nhap can bo moi");
//            Console.WriteLine("2. Tim kiem theo ho ten");
//            Console.WriteLine("3. Hien thi danh sach can bo");
//            Console.WriteLine("4. Thoat");
//            Console.Write("Chon chuc nang (1-4): ");
//            string choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    qlcb.NhapCanBoMoi();
//                    break;
//                case "2":
//                    qlcb.TimKiemTheoHoTen();
//                    break;
//                case "3":
//                    qlcb.HienThiDanhSach();
//                    break;
//                case "4":
//                    Console.WriteLine("Thoat chuong trinh.");
//                    return;
//                default:
//                    Console.WriteLine("Lua chon khong hop le!");
//                    break;
//            }
//        }
//    }
//}
//Bài 2: Một thư viện cần quản lý các tài liệu bao gồm, Sách, Tạp chí, Báo
//+Mỗi tài liệu có các thuộc tính: Mã tài liệu, Tên nhà xuất bản, Số bản phát hành.
//+ Các loại sách cần quản lý: Tên tác giả, số trang
//+ Các tạp chí cần quản lý: Số phát hành, tháng phát hành
//+ Các báo cần quản lý: ngày phát hành.
//1. Xây dựng các lớp để quản lý các loại tài liệu trên sao cho việc sử dụng lại được nhiều nhất.
//2. Xây dựng lớp QuanLyTailieu cài đặt các phương thức thực hiện các công việc sau:
//-Nhập thông tin về các tài liệu (Hỏi người dùng muốn nhập thông tin cho loại tài liệu
//nào: Sách, Tạp chí hay Báo và nhập đúng thông tin cho loại tài liệu đó).
//- Hiển thị thông tin về các tài liệu
//- Tìm kiếm tài liệu theo loại
//- Thoát khỏi chương trình
