using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._3
{
        class QLCB
        {
            private List<CanBo> danhSachCanBo = new List<CanBo>();

            public void NhapCanBoMoi()
            {
                Console.WriteLine("Chon loai can bo:");
                Console.WriteLine("1. Cong nhan");
                Console.WriteLine("2. Ky su");
                Console.WriteLine("3. Nhan vien");
                Console.Write("Lua chon (1-3): ");
                string choice = Console.ReadLine();

                Console.Write("Ho ten: ");
                string hoTen = Console.ReadLine();
                Console.Write("Nam sinh: ");
                string namSinh = Console.ReadLine();
                Console.Write("Gioi tinh: ");
                string gioiTinh = Console.ReadLine();
                Console.Write("Dia chi: ");
                string diaChi = Console.ReadLine();

                CanBo canBo = null;

                switch (choice)
                {
                    case "1":
                        Console.Write("Bac: ");
                        string bac = Console.ReadLine();
                        canBo = new CongNhan(hoTen, namSinh, gioiTinh, diaChi, bac);
                        break;
                    case "2":
                        Console.Write("Nganh dao tao: ");
                        string nganh = Console.ReadLine();
                        canBo = new KySu(hoTen, namSinh, gioiTinh, diaChi, nganh);
                        break;
                    case "3":
                        Console.Write("Cong viec: ");
                        string congViec = Console.ReadLine();
                        canBo = new NhanVien(hoTen, namSinh, gioiTinh, diaChi, congViec);
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le.");
                        return;
                }

                danhSachCanBo.Add(canBo);
                Console.WriteLine("Da them can bo thanh cong!");
            }

            public void TimKiemTheoHoTen()
            {
                Console.Write("Nhap ho ten can tim: ");
                string ten = Console.ReadLine().ToLower();
                bool found = false;

                foreach (var cb in danhSachCanBo)
                {
                    if (cb.HoTen.ToLower() == ten)
                    {
                        cb.HienThiThongTin();
                        found = true;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Khong tim thay can bo.");
                }
            }

            public void HienThiDanhSach()
            {
                if (danhSachCanBo.Count == 0)
                {
                    Console.WriteLine("Danh sach can bo rong.");
                    return;
                }

                Console.WriteLine("Danh sach can bo:");
                int i = 1;
                foreach (var cb in danhSachCanBo)
                {
                    Console.WriteLine($"\n--- Can bo #{i++} ---");
                    cb.HienThiThongTin();
                }
            }
        }

 }
