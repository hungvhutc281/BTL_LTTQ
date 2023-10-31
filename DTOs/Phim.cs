using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_btl.DTOs
{
    class Phim
    {
        public Phim() { }
        public Phim(string maPhim, string tenPhim, string maNuocSX, string maHangSX, string maTheLoai, string daoDien, DateTime ngayKhoiChieu, DateTime ngayKetChieu, string nuDienVienChinh, string namDienVienChinh, string noiDungChinh, decimal tongChiPhi, decimal tongThu, string anh)
        {
            MaPhim = maPhim;
            TenPhim = tenPhim;
            MaNuocSX = maNuocSX;
            MaHangSX = maHangSX;
            MaTheLoai = maTheLoai;
            DaoDien = daoDien;
            NgayKhoiChieu = ngayKhoiChieu;
            NgayKetChieu = ngayKetChieu;
            NuDienVienChinh = nuDienVienChinh;
            NamDienVienChinh = namDienVienChinh;
            NoiDungChinh = noiDungChinh;
            TongChiPhi = tongChiPhi;
            TongThu = tongThu;
            Anh = anh;
        }

        public string MaPhim { get; set; }
        public string TenPhim { get; set; }
        public string MaNuocSX { get; set; }
        public string MaHangSX { get; set; }
        public string MaTheLoai { get; set; }
        public string DaoDien { get; set; }
        public DateTime NgayKhoiChieu { get; set; }
        public DateTime NgayKetChieu { get; set; }
        public string NuDienVienChinh { get; set; }
        public string NamDienVienChinh { get; set; }
        public string NoiDungChinh { get; set; }
        public decimal TongChiPhi { get; set; }
        public decimal TongThu { get; set; }
        public string Anh { get; set; }


    }
}
