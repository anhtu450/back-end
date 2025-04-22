using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1._5
{
    public class PhanSo
    {
    public int TuSo { get; set; }
    public int MauSo { get; set; }

    // Hàm khởi tạo mặc định
    public PhanSo()
    {
        TuSo = 0;
        MauSo = 1;
    }

    // Hàm khởi tạo có tham số
    public PhanSo(int tu, int mau)
    {
        TuSo = tu;
        MauSo = mau == 0 ? 1 : mau;
    }

    // Nhập phân số từ bàn phím
    public void Nhap()
    {
        Console.Write("- Nhập tử số: ");
        TuSo = int.Parse(Console.ReadLine());

        Console.Write("- Nhập mẫu số: ");
        MauSo = int.Parse(Console.ReadLine());

        if (MauSo == 0)
        {
            Console.WriteLine("Mẫu số không được bằng 0. Gán mẫu số = 1.");
            MauSo = 1;
        }
    }

    // Rút gọn phân số
    public void RutGon()
    {
        int ucln = UCLN(TuSo, MauSo);
        TuSo /= ucln;
        MauSo /= ucln;

        // Đưa dấu âm lên tử số nếu cần
        if (MauSo < 0)
        {
            TuSo *= -1;
            MauSo *= -1;
        }
    }

    // Cộng hai phân số
    public static PhanSo Cong(PhanSo a, PhanSo b)
    {
        int tu = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
        int mau = a.MauSo * b.MauSo;
        PhanSo kq = new PhanSo(tu, mau);
        kq.RutGon();
        return kq;
    }

    // Hiển thị phân số
    public void HienThi()
    {
        Console.WriteLine($"{TuSo}/{MauSo}");
    }

    // Tính UCLN
    private int UCLN(int a, int b)
    {
        while (b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }
        return Math.Abs(a);
    }
    }
}
