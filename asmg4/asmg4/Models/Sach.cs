﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asmg4.Models
{
    public class Sach
    {
        public string maSach { get; set; }
        public string maLoai{ get; set;}
        public string tenSach { get; set; }
        public string tomTat { get; set; }
        public string maTG { get; set; }
        public string maNXB { get; set; }

        public virtual LoaiSach loaiSach { get; set; }
        public virtual NhaXB nhaXB { get; set; }
        public virtual TacGia tacGia { get; set; }

        public Sach(string maSach, string maLoai, string tenSach, string tomTat, string maTG, string maNXB)
        {
            this.maSach = maSach;
            this.maLoai = maLoai;
            this.tenSach = tenSach;
            this.tomTat = tomTat;
            this.maTG = maTG;
            this.maNXB = maNXB;
        }
        public Sach();
    }
}