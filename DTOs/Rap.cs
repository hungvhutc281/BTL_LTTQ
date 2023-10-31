using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_btl.DTOs
{
    class Rap
    {
        public Rap() { }
        public Rap(string maRap, string tenRap, string diaChi, string dienThoai, int tongSoPhong, int tongSoGhe)
        {
            MaRap = maRap;
            TenRap = tenRap;
            DiaChi = diaChi;
            DienThoai = dienThoai;
            TongSoPhong = tongSoPhong;
            TongSoGhe = tongSoGhe;
        }

        public string MaRap { get; set; }
        public string TenRap { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public int TongSoPhong { get; set; }
        public int TongSoGhe { get; set; }

    }
}
