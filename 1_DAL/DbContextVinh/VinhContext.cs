using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using _1_DAL.Models;

namespace _1_DAL.DbContext
{
    public partial class VinhContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public VinhContext()
        {
        }

        public VinhContext(DbContextOptions<VinhContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ban> Bans { get; set; } = null!;
        public virtual DbSet<ChucVu> ChucVus { get; set; } = null!;
        public virtual DbSet<LoaiSp> LoaiSps { get; set; } = null!;
        public virtual DbSet<LoaiXm> LoaiXms { get; set; } = null!;
        public virtual DbSet<MoiQuanHe> MoiQuanHes { get; set; } = null!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        public virtual DbSet<Nxb> Nxbs { get; set; } = null!;
        public virtual DbSet<Sach> Saches { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;
        public virtual DbSet<XeMay> XeMays { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-CFK23F4\\SQLEXPRESS;Initial Catalog=FINALASS_FPOLY_NET_JAVA_SM22_BL2;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ban>(entity =>
            {
                entity.ToTable("Ban");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.GioiTinh).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdMqh).HasColumnName("IdMQH");

                entity.Property(e => e.Ma)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.SoThich).HasMaxLength(30);

                entity.Property(e => e.Ten).HasMaxLength(30);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdMqhNavigation)
                    .WithMany(p => p.Bans)
                    .HasForeignKey(d => d.IdMqh)
                    .HasConstraintName("FK1_MQH");
            });

            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.ToTable("ChucVu");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ten).HasMaxLength(50);
            });

            modelBuilder.Entity<LoaiSp>(entity =>
            {
                entity.ToTable("LoaiSP");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ten).HasMaxLength(50);
            });

            modelBuilder.Entity<LoaiXm>(entity =>
            {
                entity.ToTable("LoaiXM");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ten).HasMaxLength(50);
            });

            modelBuilder.Entity<MoiQuanHe>(entity =>
            {
                entity.ToTable("MoiQuanHe");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ten).HasMaxLength(50);
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.ToTable("NhanVien");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DiaChi).HasMaxLength(100);

                entity.Property(e => e.GioiTinh).HasMaxLength(10);

                entity.Property(e => e.Ho).HasMaxLength(30);

                entity.Property(e => e.IdCv).HasColumnName("IdCV");

                entity.Property(e => e.Ma)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MatKhau).IsUnicode(false);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ten).HasMaxLength(30);

                entity.Property(e => e.TenDem).HasMaxLength(30);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdCvNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.IdCv)
                    .HasConstraintName("FK1_NV");
            });

            modelBuilder.Entity<Nxb>(entity =>
            {
                entity.ToTable("NXB");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ten).HasMaxLength(50);
            });

            modelBuilder.Entity<Sach>(entity =>
            {
                entity.ToTable("Sach");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DonGia)
                    .HasColumnType("decimal(20, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdNxb).HasColumnName("IdNXB");

                entity.Property(e => e.Ma)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NgayXuatBan).HasColumnType("date");

                entity.Property(e => e.SoTrang).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ten).HasMaxLength(30);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdNxbNavigation)
                    .WithMany(p => p.Saches)
                    .HasForeignKey(d => d.IdNxb)
                    .HasConstraintName("FK1_NXB");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.ToTable("SanPham");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.GiaBan)
                    .HasColumnType("decimal(20, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdLoaiSp).HasColumnName("IdLoaiSP");

                entity.Property(e => e.Ma)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mota).HasMaxLength(30);

                entity.Property(e => e.NgaySx)
                    .HasColumnType("date")
                    .HasColumnName("NgaySX");

                entity.Property(e => e.SoLuong).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ten).HasMaxLength(30);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.Property(e => e.Website).HasMaxLength(30);

                entity.HasOne(d => d.IdLoaiSpNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.IdLoaiSp)
                    .HasConstraintName("FK1_LSP");
            });

            modelBuilder.Entity<XeMay>(entity =>
            {
                entity.ToTable("XeMay");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.GiaBan)
                    .HasColumnType("decimal(20, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GiaNhap)
                    .HasColumnType("decimal(20, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdLxm).HasColumnName("IdLXM");

                entity.Property(e => e.Ma)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mota).HasMaxLength(30);

                entity.Property(e => e.NgaySx)
                    .HasColumnType("date")
                    .HasColumnName("NgaySX");

                entity.Property(e => e.SoLuong).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ten).HasMaxLength(30);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.Property(e => e.Website).HasMaxLength(30);

                entity.HasOne(d => d.IdLxmNavigation)
                    .WithMany(p => p.XeMays)
                    .HasForeignKey(d => d.IdLxm)
                    .HasConstraintName("FK1_LXM");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
