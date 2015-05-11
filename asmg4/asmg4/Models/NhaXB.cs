using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asmg4.Models
{
    public class NhaXB
    {
        public string maNXB { get; set; }
        public string tenNXB { get; set; }
        public string diaChi { get; set; }
        public string sdt { get; set; }
        public string email { get; set; }

        public NhaXB(string maNXB, string tenNXB, string diaChi, string sdt, string email)
        {
            this.maNXB = maNXB;
            this.tenNXB = tenNXB;
            this.diaChi = diaChi;
            this.sdt = sdt;
            this.email = email;
        }
    }
}