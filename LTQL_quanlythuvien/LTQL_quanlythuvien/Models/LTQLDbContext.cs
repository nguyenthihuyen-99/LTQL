using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LTQL_quanlythuvien.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext()
            : base("name=LTQLDbContext")
        {
        }

        public virtual DbSet <AccountModel> AccountModels { get; set; }
        public virtual DbSet <Docgia> Docgias { get; set; }
        public virtual DbSet <Muon> Muons { get; set; }
        public virtual DbSet <Nhanvien> Nhanviens { get; set; }
        public virtual DbSet <Sach> Saches { get; set; }
        public virtual DbSet <ChiTietMuon> ChitietMuons { get; set; }
        public virtual DbSet <Tacgia> Tacgias { get; set; }
        public virtual DbSet <Theloai> Theloais { get; set; }
        public virtual DbSet <NhaXuatBan> NhaXuatBans { get; set; }
        public virtual DbSet <person> Persons { get; set; }       
        public virtual DbSet <Tintuc> Tintucs { get; set; }       
        public virtual DbSet <Role> Roles { get; set; }       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountModel>()
                .Property(e => e.Username)
                .IsUnicode(false);
            modelBuilder.Entity<Docgia>()
               .Property(e => e.Madocgia);
            modelBuilder.Entity<Muon>()
               .Property(e => e.Mamuon);
            modelBuilder.Entity<Nhanvien>()
               .Property(e => e.MaNV);
            modelBuilder.Entity<Sach>()
               .Property(e => e.Masach);
            modelBuilder.Entity<ChiTietMuon>()
               .Property(e => e.MaCTmuon);
            modelBuilder.Entity<Tacgia>()
               .Property(e => e.Matacgia);
            modelBuilder.Entity<Theloai>()
               .Property(e => e.Matheloai);
            modelBuilder.Entity<NhaXuatBan>()
               .Property(e => e.MaNXB);
            modelBuilder.Entity<Tintuc>()
               .Property(e => e.TintucID);
            modelBuilder.Entity<Role>()
              .Property(e => e.RoleID);

        }

        public System.Data.Entity.DbSet<LTQL_quanlythuvien.Models.student> students { get; set; }

        public System.Data.Entity.DbSet<LTQL_quanlythuvien.Models.nghenghiep> nghenghieps { get; set; }
        public object Role { get; internal set; }
    }
}
