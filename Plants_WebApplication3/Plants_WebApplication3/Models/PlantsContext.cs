using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Plants_WebApplication3.Models
{
    public partial class PlantsContext : DbContext
    {
        public PlantsContext()
        {
        }

        public PlantsContext(DbContextOptions<PlantsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Flowers> Flowers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#pragma warning disable CS1030 // #warning directive
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Plants;Trusted_Connection=True;");
#pragma warning restore CS1030 // #warning directive
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flowers>(entity =>
            {
                entity.HasKey(e => e.SNo);

                entity.HasIndex(e => e.BinomialName)
                    .HasName("UQ__Flowers__36A52F7519505684")
                    .IsUnique();

                entity.Property(e => e.SNo)
                    .HasColumnName("S_no")
                    .ValueGeneratedNever();

                entity.Property(e => e.BinomialName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}
