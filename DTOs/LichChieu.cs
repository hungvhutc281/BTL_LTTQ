using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_btl.DTOs
{
    class LichChieu
    {
        public LichChieu() { }
        public LichChieu(string maShow, string maPhim, string maRap, string maPhong, DateTime ngayChieu, string maGioChieu, decimal giaVe, int soVeDaBan, decimal tongTien)
        {
            MaShow = maShow;
            MaPhim = maPhim;
            MaRap = maRap;
            MaPhong = maPhong;
            NgayChieu = ngayChieu;
            MaGioChieu = maGioChieu;
            GiaVe = giaVe;
            SoVeDaBan = soVeDaBan;
            TongTien = tongTien;
        }

        public string MaShow { get; set; }
        public string MaPhim { get; set; }
        public string MaRap { get; set; }
        public string MaPhong { get; set; }
        public DateTime NgayChieu { get; set; }
        public string MaGioChieu { get; set; }
        public decimal GiaVe { get; set; }
        public int SoVeDaBan { get; set; }
        public decimal TongTien { get; set; }

    }
}
