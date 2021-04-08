using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace btapvidu.Models
{
    public partial class btapvidu : DbContext
    {
        public btapvidu()
            : base("name=btapvidu")
        {
        }

        public virtual DbSet<sach> saches { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tacgia> tacgias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<sach>()
                .Property(e => e.masach)
                .IsFixedLength();

            modelBuilder.Entity<sach>()
                .Property(e => e.tensach)
                .IsFixedLength();

            modelBuilder.Entity<sach>()
                .Property(e => e.Matacgia)
                .IsFixedLength();

            modelBuilder.Entity<tacgia>()
                .Property(e => e.Matacgia)
                .IsFixedLength();

            modelBuilder.Entity<tacgia>()
                .Property(e => e.Tentacgia)
                .IsFixedLength();
        }
    }
}
