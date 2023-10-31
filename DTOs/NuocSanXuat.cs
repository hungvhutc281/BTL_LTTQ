using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_btl.DTOs
{
    class NuocSanXuat
    {
        public NuocSanXuat() { }
        public NuocSanXuat(string maNuocSX, string tenNuocSX)
        {
            MaNuocSX = maNuocSX;
            TenNuocSX = tenNuocSX;
        }

        public string MaNuocSX { get; set; }
        public string TenNuocSX { get;set; }
    }
}
