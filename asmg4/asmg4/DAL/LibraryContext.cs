using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using asmg4.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace asmg4.DAL
{
    public class LibraryContext : DbContext
    {
        public LibraryContext()
            : base("LibraryContext")
        {

        }
        public DbSet<Sach> sach { get; set; }
        public DbSet<LoaiSach> loaiSach { get; set; }
        public DbSet<NhaXB> nhaXB { get; set; }
        public DbSet<TacGia> tacGia { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}