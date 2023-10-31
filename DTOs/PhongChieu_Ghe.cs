using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_btl.DTOs
{
    class PhongChieu_Ghe
    {
        public PhongChieu_Ghe() { }
        public PhongChieu_Ghe(string maRap, string maPhong, string maGhe)
        {
            MaRap = maRap;
            MaPhong = maPhong;
            MaGhe = maGhe;
        }

        public string MaRap { get; set; }
        public string MaPhong { get; set; }
        public string MaGhe { get; set; }
    }
}
