using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_btl.DTOs
{
    class PhongChieu
    {
        public PhongChieu() { }
        public PhongChieu(string maRap, string maPhong, string tenPhong, int tongSoGhe)
        {
            MaRap = maRap;
            MaPhong = maPhong;
            TenPhong = tenPhong;
            TongSoGhe = tongSoGhe;
        }

        public string MaRap { get; set; }
        public string MaPhong { get; set;}
        public string TenPhong { get; set;}
        public int TongSoGhe { get; set;}

    }
}
