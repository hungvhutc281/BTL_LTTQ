using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_btl.DTOs
{
    class Ve
    {
        public Ve() { }
        public Ve(string maShow, string maGhe)
        {
            MaShow = maShow;
            MaGhe = maGhe;
        }

        public string MaShow { get; set; }
        public string MaGhe {get; set; }

    }
}
