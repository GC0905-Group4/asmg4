using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asmg4.Models
{
    public class LoaiSach
    {
        public string maLoai { get; set; }
        public string tenLoai { get; set; }

        public LoaiSach(string maLoai, string tenLoai)
        {
            this.maLoai = maLoai;
            this.tenLoai = tenLoai;
        }
    }
}