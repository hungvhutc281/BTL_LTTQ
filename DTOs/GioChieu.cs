using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_btl.DTOs
{
    class GioChieu
    {
        public GioChieu() { }
        public GioChieu(string maRap, string maGioChieu, decimal donGia)
        {
            MaRap = maRap;
            MaGioChieu = maGioChieu;
            DonGia = donGia;
        }

        private string maRap;
        private string maGioChieu;
        private decimal donGia;
        public string MaRap { get => maRap; set => maRap = value; }
        public string MaGioChieu { get => maGioChieu; set => maGioChieu = value; }
        public decimal DonGia { get => donGia; set => donGia = value; }
    }
}
