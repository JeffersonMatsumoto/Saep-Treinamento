using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Senai.LanHouse.Web.Razor.Dominios;

namespace Senai.LanHouse.Web.Razor.Contextos
{
    public partial class LanHouseContext : DbContext
    {
        public LanHouseContext()
        {
        }

        public LanHouseContext(DbContextOptions<LanHouseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<RegistrosDefeitos> RegistrosDefeitos { get; set; }
        public virtual DbSet<TiposDefeitos> TiposDefeitos { get; set; }
        public virtual DbSet<TiposEquipamentos> TiposEquipamentos { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
                optionsBuilder.UseSqlServer("Server=.\\SqlExpress01;Database=Lan_House;user id=sa; password=info@132");
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RegistrosDefeitos>(entity =>
            {
                entity.ToTable("Registros_Defeitos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DataDefeito).HasColumnName("data_defeito");

                entity.Property(e => e.Observação)
                    .IsRequired()
                    .HasColumnName("observação")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TiposDefeitosId).HasColumnName("tipos_defeitos_id");

                entity.Property(e => e.TiposEquipamentosId).HasColumnName("tipos_equipamentos_id");

                entity.HasOne(d => d.TiposDefeitos)
                    .WithMany(p => p.RegistrosDefeitos)
                    .HasForeignKey(d => d.TiposDefeitosId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Registros__tipos__4E88ABD4");

                entity.HasOne(d => d.TiposEquipamentos)
                    .WithMany(p => p.RegistrosDefeitos)
                    .HasForeignKey(d => d.TiposEquipamentosId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Registros__tipos__4D94879B");
            });

            modelBuilder.Entity<TiposDefeitos>(entity =>
            {
                entity.ToTable("Tipos_Defeitos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiposEquipamentos>(entity =>
            {
                entity.ToTable("Tipos_Equipamentos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasColumnName("senha")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
