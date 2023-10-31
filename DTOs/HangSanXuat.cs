using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_btl.DTOs
{
    class HangSanXuat
    {
        public HangSanXuat() { }
        public HangSanXuat(string maHangSX, string tenHangSX)
        {
            MaHangSX = maHangSX;
            TenHangSX = tenHangSX;
        }

        public string MaHangSX { get; set; }
         public string TenHangSX { get; set; }
    }
}
