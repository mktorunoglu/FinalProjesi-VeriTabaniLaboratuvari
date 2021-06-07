using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CodeFirstProject
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Bolumler> Bolumlers { get; set; }
        public virtual DbSet<Dersler> Derslers { get; set; }
        public virtual DbSet<Fakulteler> Fakultelers { get; set; }
        public virtual DbSet<Notlar> Notlars { get; set; }
        public virtual DbSet<Ogrenciler> Ogrencilers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bolumler>()
                .Property(e => e.bolumAd)
                .IsUnicode(false);

            modelBuilder.Entity<Dersler>()
                .Property(e => e.dersAd)
                .IsUnicode(false);

            modelBuilder.Entity<Fakulteler>()
                .Property(e => e.fakulteAd)
                .IsUnicode(false);

            modelBuilder.Entity<Notlar>()
                .Property(e => e.yil)
                .IsUnicode(false);

            modelBuilder.Entity<Notlar>()
                .Property(e => e.yariyil)
                .IsUnicode(false);

            modelBuilder.Entity<Ogrenciler>()
                .Property(e => e.ad)
                .IsUnicode(false);

            modelBuilder.Entity<Ogrenciler>()
                .Property(e => e.soyad)
                .IsUnicode(false);
        }
    }
}
