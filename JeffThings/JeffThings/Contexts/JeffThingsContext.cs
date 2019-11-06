using System;
using JeffThings.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace JeffThings.Contexts
{
    public partial class JeffThingsContext : DbContext
    {
        public JeffThingsContext()
        {
        }

        public JeffThingsContext(DbContextOptions<JeffThingsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Jogos> Jogos { get; set; }
        public virtual DbSet<JogosPlataformas> JogosPlataformas { get; set; }
        public virtual DbSet<Plataformas> Plataformas { get; set; }
        public virtual DbSet<TiposJogos> TiposJogos { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=JeffThings;Trusted_Connection=True;");
            //}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jogos>(entity =>
            {
                entity.ToTable("JOGOS");

                entity.HasIndex(e => e.Nome)
                    .HasName("UQ__JOGOS__E2AB1FF4595C6044")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Coop).HasColumnName("COOP");

                entity.Property(e => e.DataLancamento)
                    .HasColumnName("DATA_LANCAMENTO")
                    .HasColumnType("date");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("DESCRICAO")
                    .HasColumnType("text");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("NOME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Preco)
                    .HasColumnName("PRECO")
                    .HasColumnType("smallmoney");

                entity.Property(e => e.TiposJogosId).HasColumnName("TIPOS_JOGOS_ID");

                entity.HasOne(d => d.TiposJogos)
                    .WithMany(p => p.Jogos)
                    .HasForeignKey(d => d.TiposJogosId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__JOGOS__TIPOS_JOG__59063A47");
            });

            modelBuilder.Entity<JogosPlataformas>(entity =>
            {
                entity.ToTable("JOGOS_PLATAFORMAS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdJogo).HasColumnName("ID_JOGO");

                entity.Property(e => e.IdPlataforma).HasColumnName("ID_PLATAFORMA");

                entity.HasOne(d => d.IdJogoNavigation)
                    .WithMany(p => p.JogosPlataformas)
                    .HasForeignKey(d => d.IdJogo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__JOGOS_PLA__ID_JO__60A75C0F");

                entity.HasOne(d => d.IdPlataformaNavigation)
                    .WithMany(p => p.JogosPlataformas)
                    .HasForeignKey(d => d.IdPlataforma)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__JOGOS_PLA__ID_PL__619B8048");
            });

            modelBuilder.Entity<Plataformas>(entity =>
            {
                entity.ToTable("PLATAFORMAS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("NOME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiposJogos>(entity =>
            {
                entity.ToTable("TIPOS_JOGOS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("NOME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.ToTable("USUARIOS");

                entity.HasIndex(e => e.Email)
                    .HasName("UQ__USUARIOS__161CF72416821025")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("NOME")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasColumnName("SENHA")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });
        }
    }
}
