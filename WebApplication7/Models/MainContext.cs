using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WebApplication7.Models
{
    public partial class MainContext : IdentityDbContext
    {
        public MainContext()
        {
        }

        public MainContext(DbContextOptions<MainContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<Model> Model { get; set; }
        public virtual DbSet<Techlist> Techlist { get; set; }
        public virtual DbSet<Order> Order { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=HomeVideo;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.IdCat);

                entity.Property(e => e.IdCat).HasColumnName("Id_cat");

                entity.Property(e => e.NameCat).HasColumnName("Name_cat");
            });

            modelBuilder.Entity<Manufacturer>(entity =>
            {
                entity.HasKey(e => e.IdMan);

                entity.Property(e => e.IdMan).HasColumnName("Id_man");

                entity.Property(e => e.NameMan).HasColumnName("Name_man");
            });

            modelBuilder.Entity<Model>(entity =>
            {
                entity.HasKey(e => e.IdMod);

                entity.Property(e => e.IdMod).HasColumnName("Id_mod");

                entity.Property(e => e.NameMod).HasColumnName("Name_mod");
            });

            modelBuilder.Entity<Techlist>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });
            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");
            });
            base.OnModelCreating(modelBuilder);
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
