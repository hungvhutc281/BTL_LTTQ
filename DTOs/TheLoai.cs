using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_btl.DTOs
{
    class TheLoai
    {
        public TheLoai() { }
        public TheLoai(string maTheLoai, string tenTheLoai)
        {
            MaTheLoai = maTheLoai;
            TenTheLoai = tenTheLoai;
        }

        public string MaTheLoai { get; set; }
        public string TenTheLoai { get; set; }
    }
}
