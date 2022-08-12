using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Bioskop.Models
{
    public partial class BioskopContext : DbContext
    {
        public BioskopContext()
        {
        }

        public BioskopContext(DbContextOptions<BioskopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MsBioskop> MsBioskops { get; set; }
        public virtual DbSet<MsFilm> MsFilms { get; set; }
        public virtual DbSet<MsKategori> MsKategoris { get; set; }
        public virtual DbSet<MsPayment> MsPayments { get; set; }
        public virtual DbSet<MsPemesanan> MsPemesanans { get; set; }
        public virtual DbSet<MsPenayangan> MsPenayangans { get; set; }
        public virtual DbSet<MsPromo> MsPromos { get; set; }
        public virtual DbSet<MsSeat> MsSeats { get; set; }
        public virtual DbSet<MsStudio> MsStudios { get; set; }
        public virtual DbSet<MsTiket> MsTikets { get; set; }
        public virtual DbSet<MsUser> MsUsers { get; set; }
        public virtual DbSet<TrDetailPemesanan> TrDetailPemesanans { get; set; }
        public virtual DbSet<TrDetailPromosiPayment> TrDetailPromosiPayments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<MsBioskop>(entity =>
            {
                

                entity.ToTable("MsBioskop");

                entity.Property(e => e.NamaLokasi)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MsFilm>(entity =>
            {
                

                entity.ToTable("MsFilm");

                entity.Property(e => e.Cast)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Director)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.JudulFilm)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sinopsis)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MsKategori>(entity =>
            {
                

                entity.ToTable("MsKategori");

                entity.Property(e => e.NamaKategori)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MsPayment>(entity =>
            {
                

                entity.ToTable("MsPayment");

                entity.Property(e => e.NamaPayment)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MsPemesanan>(entity =>
            {
                

                entity.ToTable("MsPemesanan");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WaktuPembayaran).HasColumnType("datetime");

                entity.Property(e => e.WaktuPemesanan).HasColumnType("datetime");
            });

            modelBuilder.Entity<MsPenayangan>(entity =>
            {
                

                entity.ToTable("MsPenayangan");

                entity.Property(e => e.TanggalWaktu).HasColumnType("datetime");
            });

            modelBuilder.Entity<MsPromo>(entity =>
            {
                

                entity.ToTable("MsPromo");

                entity.Property(e => e.AkhirPromo).HasColumnType("datetime");

                entity.Property(e => e.MulaiPromo).HasColumnType("datetime");

                entity.Property(e => e.NamaPromo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MsSeat>(entity =>
            {
                

                entity.ToTable("MsSeat");

                entity.Property(e => e.NoSeat)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MsStudio>(entity =>
            {
                

                entity.ToTable("MsStudio");

                entity.Property(e => e.NamaStudio)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TypeStudio)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MsTiket>(entity =>
            {
                

                entity.ToTable("MsTiket");
            });

            modelBuilder.Entity<MsUser>(entity =>
            {
                

                entity.ToTable("MsUser");

                entity.Property(e => e.Alamat)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Kota)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nama)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NoTelepon)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrDetailPemesanan>(entity =>
            {
                

                entity.ToTable("TrDetailPemesanan");
            });

            modelBuilder.Entity<TrDetailPromosiPayment>(entity =>
            {
               

                entity.ToTable("TrDetailPromosiPayment");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
