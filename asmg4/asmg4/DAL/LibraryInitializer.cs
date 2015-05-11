using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using asmg4.Models;

namespace asmg4.DAL
{
    public class LibraryInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {
            var sach = new List<Sach>
            {
            new Sach{maSach="Nino",maLoai="Olivetto",tenSach="???", tomTat="???", maTG="???", maNXB="???"},
            };

            sach.ForEach(s => context.sach.Add(s));
            context.SaveChanges();
        }
    }
}