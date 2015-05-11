using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asmg4.Models
{
    public class TacGia
    {
        public string maTG { get; set; }
        public string tenTG { get; set; }
        public string diaChi { get; set; }
        public string sdt { get; set; }
        public string email { get; set; }

        public virtual ICollection<Sach> sach { get; set; }

        public TacGia(string maTG, string tenTG, string diaChi, string sdt, string email)
        {
            this.maTG = maTG;
            this.tenTG = tenTG;
            this.diaChi = diaChi;
            this.sdt = sdt;
            this.email = email;
        }
    }
}