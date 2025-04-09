using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._3
{
    internal class CanBo
    {
        public string HoTen { get; set; }
        public string NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }

        public CanBo(string hoTen, string namSinh, string gioiTinh, string diaChi)
        {
            HoTen = hoTen;
            NamSinh = namSinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
        }

        public virtual void HienThiThongTin()
        {
            Console.WriteLine($"Ho ten: {HoTen}");
            Console.WriteLine($"Nam sinh: {NamSinh}");
            Console.WriteLine($"Gioi tinh: {GioiTinh}");
            Console.WriteLine($"Dia chi: {DiaChi}");
        }
    }

    class CongNhan : CanBo
    {
        public string Bac { get; set; }

        public CongNhan(string hoTen, string namSinh, string gioiTinh, string diaChi, string bac)
            : base(hoTen, namSinh, gioiTinh, diaChi)
        {
            Bac = bac;
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Bac: {Bac}");
        }
    }

    class KySu : CanBo
    {
        public string NganhDaoTao { get; set; }

        public KySu(string hoTen, string namSinh, string gioiTinh, string diaChi, string nganhDaoTao)
            : base(hoTen, namSinh, gioiTinh, diaChi)
        {
            NganhDaoTao = nganhDaoTao;
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Nganh dao tao: {NganhDaoTao}");
        }
    }

    class NhanVien : CanBo
    {
        public string CongViec { get; set; }

        public NhanVien(string hoTen, string namSinh, string gioiTinh, string diaChi, string congViec)
            : base(hoTen, namSinh, gioiTinh, diaChi)
        {
            CongViec = congViec;
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Cong viec: {CongViec}");
        }
    }
}