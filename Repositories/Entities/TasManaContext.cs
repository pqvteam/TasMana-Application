using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Repositories.Entities;

public partial class TasManaContext : DbContext
{
    public TasManaContext()
    {
    }

    public TasManaContext(DbContextOptions<TasManaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CanHo> CanHos { get; set; }

    public virtual DbSet<Ceo> Ceos { get; set; }

    public virtual DbSet<ChuHo> ChuHos { get; set; }

    public virtual DbSet<CuDan> CuDans { get; set; }

    public virtual DbSet<GiaoViec> GiaoViecs { get; set; }

    public virtual DbSet<KhachThueKhuThuongMai> KhachThueKhuThuongMais { get; set; }

    public virtual DbSet<NguoiDuocUyQuyenCuaChuHo> NguoiDuocUyQuyenCuaChuHos { get; set; }

    public virtual DbSet<NhanSu> NhanSus { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<NhanVienCuaChuHoHoacKhachThueHoacKhachVangLaiLuuTruNganNgay> NhanVienCuaChuHoHoacKhachThueHoacKhachVangLaiLuuTruNganNgays { get; set; }

    public virtual DbSet<Nhom> Nhoms { get; set; }

    public virtual DbSet<PhongBan> PhongBans { get; set; }

    public virtual DbSet<QuanLi> QuanLis { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("C:\\Users\\phuoc\\source\\repos\\pqvteam\\TasMana-Application\\UIs");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CanHo>(entity =>
        {
            entity.HasKey(e => e.MaCh).HasName("PK__CanHo__7A3E0CEE89CE2FD5");

            entity.ToTable("CanHo");
            entity.Property(e => e.MaCh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maCH");
            entity.Property(e => e.Gsa).HasColumnName("GSA");
            entity.Property(e => e.LichSuGd)
                .HasMaxLength(100)
                .HasColumnName("lichSuGD");
            entity.Property(e => e.MaCuDan)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maCuDan");
            entity.Property(e => e.Nsa).HasColumnName("NSA");
            entity.Property(e => e.PhiQl).HasColumnName("PhiQL");
            entity.Property(e => e.SlPhongNgu).HasColumnName("slPhongNgu");
            entity.Property(e => e.SlToilet).HasColumnName("slToilet");
            entity.Property(e => e.SoDoMatBang).HasColumnName("soDoMatBang");
            entity.Property(e => e.SoLuongTheTm).HasColumnName("soLuongTheTM");
            entity.Property(e => e.TinhTrangGd)
                .HasMaxLength(100)
                .HasColumnName("tinhTrangGD");
            entity.Property(e => e.ViTri)
                .HasMaxLength(100)
                .HasColumnName("viTri");

            entity.HasOne(d => d.MaCuDanNavigation).WithMany(p => p.CanHos)
                .HasForeignKey(d => d.MaCuDan)
                .HasConstraintName("FK__CanHo__maCuDan__1B0907CE");
        });

        modelBuilder.Entity<Ceo>(entity =>
        {
            entity.HasKey(e => e.MaThanhVien).HasName("PK__CEO__53586E49DCAA8166");

            entity.ToTable("CEO");

            entity.Property(e => e.MaThanhVien)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maThanhVien");
            entity.Property(e => e.HoVaTen)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("hoVaTen");

            entity.HasOne(d => d.MaThanhVienNavigation).WithOne(p => p.Ceo)
                .HasForeignKey<Ceo>(d => d.MaThanhVien)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CEO__maThanhVien__1273C1CD");
        });

        modelBuilder.Entity<ChuHo>(entity =>
        {
            entity.HasKey(e => e.MaCuDan).HasName("PK__ChuHo__7C7463679C537C73");

            entity.ToTable("ChuHo");

            entity.Property(e => e.MaCuDan)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maCuDan");
            entity.Property(e => e.NgayChuyenChuMoi).HasColumnName("ngayChuyenChuMoi");
            entity.Property(e => e.ThongTinChuHoMoi)
                .HasMaxLength(100)
                .HasColumnName("thongTinChuHoMoi");

            entity.HasOne(d => d.MaCuDanNavigation).WithOne(p => p.ChuHo)
                .HasForeignKey<ChuHo>(d => d.MaCuDan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChuHo__maCuDan__1DE57479");
        });

        modelBuilder.Entity<CuDan>(entity =>
        {
            entity.HasKey(e => e.MaCuDan).HasName("PK__CuDan__7C7463677D275677");

            entity.ToTable("CuDan");

            entity.Property(e => e.MaCuDan)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maCuDan");
            entity.Property(e => e.Cccd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CCCD");
            entity.Property(e => e.CongNo).HasColumnName("congNo");
            entity.Property(e => e.DuLieuDoXe)
                .HasMaxLength(100)
                .HasColumnName("duLieuDoXe");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.HoVaTen)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("hoVaTen");
            entity.Property(e => e.NamSinh).HasColumnName("namSinh");
            entity.Property(e => e.NgayBanGiao).HasColumnName("ngayBanGiao");
            entity.Property(e => e.NgayChuyenDi).HasColumnName("ngayChuyenDi");
            entity.Property(e => e.NgayChuyenVao).HasColumnName("ngayChuyenVao");
            entity.Property(e => e.PhiDichVu).HasColumnName("phiDichVu");
            entity.Property(e => e.PhiQlhangThang).HasColumnName("phiQLHangThang");
            entity.Property(e => e.QuocTich)
                .HasMaxLength(100)
                .HasColumnName("quocTich");
            entity.Property(e => e.Sdt)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.SdtnguoiThan)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SDTNguoiThan");
            entity.Property(e => e.SoLieuDnbanDau).HasColumnName("soLieuDNBanDau");
            entity.Property(e => e.SoTheTamTru)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("soTheTamTru");
            entity.Property(e => e.ThanhVienLuuTruCung)
                .HasMaxLength(100)
                .HasColumnName("thanhVienLuuTruCung");
            entity.Property(e => e.ThuCung).HasColumnName("thuCung");
        });

        modelBuilder.Entity<GiaoViec>(entity =>
        {
            entity.HasKey(e => e.MaGiaoViec).HasName("PK__GiaoViec__6C8109B53FC62F03");

            entity.ToTable("GiaoViec");

            entity.Property(e => e.MaGiaoViec)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maGiaoViec");
            entity.Property(e => e.CheDo).HasColumnName("cheDo");
            entity.Property(e => e.DinhKemFile)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("dinhKemFile");
            entity.Property(e => e.HanHoanThanh).HasColumnName("hanHoanThanh");
            entity.Property(e => e.MoTaCongViec)
                .HasMaxLength(500)
                .HasColumnName("moTaCongViec");
            entity.Property(e => e.NgayGiao).HasColumnName("ngayGiao");
            entity.Property(e => e.TenCongViec)
                .HasMaxLength(200)
                .HasColumnName("tenCongViec");
            entity.Property(e => e.TinhTrangCongViec)
                .HasMaxLength(100)
                .HasColumnName("tinhTrangCongViec");

            entity.HasMany(d => d.MaChes).WithMany(p => p.MaGiaoViecs)
                .UsingEntity<Dictionary<string, object>>(
                    "KhuVucLamViec",
                    r => r.HasOne<CanHo>().WithMany()
                        .HasForeignKey("MaCh")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__KhuVucLamV__maCH__33D4B598"),
                    l => l.HasOne<GiaoViec>().WithMany()
                        .HasForeignKey("MaGiaoViec")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__KhuVucLam__maGia__32E0915F"),
                    j =>
                    {
                        j.HasKey("MaGiaoViec", "MaCh").HasName("PK__KhuVucLa__9B22E97B18F459D8");
                        j.ToTable("KhuVucLamViec");
                        j.IndexerProperty<string>("MaGiaoViec")
                            .HasMaxLength(10)
                            .IsUnicode(false)
                            .HasColumnName("maGiaoViec");
                        j.IndexerProperty<string>("MaCh")
                            .HasMaxLength(10)
                            .IsUnicode(false)
                            .HasColumnName("maCH");
                    });

            entity.HasMany(d => d.MaThanhViens).WithMany(p => p.MaGiaoViecs)
                .UsingEntity<Dictionary<string, object>>(
                    "NhanViec",
                    r => r.HasOne<NhanVien>().WithMany()
                        .HasForeignKey("MaThanhVien")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__NhanViec__maThan__37A5467C"),
                    l => l.HasOne<GiaoViec>().WithMany()
                        .HasForeignKey("MaGiaoViec")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__NhanViec__maGiao__36B12243"),
                    j =>
                    {
                        j.HasKey("MaGiaoViec", "MaThanhVien").HasName("PK__NhanViec__E9B48F513D157BAE");
                        j.ToTable("NhanViec");
                        j.IndexerProperty<string>("MaGiaoViec")
                            .HasMaxLength(10)
                            .IsUnicode(false)
                            .HasColumnName("maGiaoViec");
                        j.IndexerProperty<string>("MaThanhVien")
                            .HasMaxLength(10)
                            .IsUnicode(false)
                            .HasColumnName("maThanhVien");
                    });
        });

        modelBuilder.Entity<KhachThueKhuThuongMai>(entity =>
        {
            entity.HasKey(e => e.MaCuDan).HasName("PK__KhachThu__7C74636741C47C31");

            entity.ToTable("KhachThueKhuThuongMai");

            entity.Property(e => e.MaCuDan)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maCuDan");

            entity.HasOne(d => d.MaCuDanNavigation).WithOne(p => p.KhachThueKhuThuongMai)
                .HasForeignKey<KhachThueKhuThuongMai>(d => d.MaCuDan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KhachThue__maCuD__267ABA7A");
        });

        modelBuilder.Entity<NguoiDuocUyQuyenCuaChuHo>(entity =>
        {
            entity.HasKey(e => e.MaCuDan).HasName("PK__NguoiDuo__7C74636788AA69F3");

            entity.ToTable("NguoiDuocUyQuyenCuaChuHo");

            entity.Property(e => e.MaCuDan)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maCuDan");
            entity.Property(e => e.TenNguoiUyQuyen)
                .HasMaxLength(100)
                .HasColumnName("tenNguoiUyQuyen");

            entity.HasOne(d => d.MaCuDanNavigation).WithOne(p => p.NguoiDuocUyQuyenCuaChuHo)
                .HasForeignKey<NguoiDuocUyQuyenCuaChuHo>(d => d.MaCuDan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__NguoiDuoc__maCuD__20C1E124");
        });

        modelBuilder.Entity<NhanSu>(entity =>
        {
            entity.HasKey(e => e.MaThanhVien).HasName("PK__NhanSu__53586E49FB6D3B16");

            entity.ToTable("NhanSu");

            entity.Property(e => e.MaThanhVien)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maThanhVien");
            entity.Property(e => e.AnhDaiDien)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("anhDaiDien");
            entity.Property(e => e.Cccd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CCCD");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(100)
                .HasColumnName("diaChi");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.GioiTinh)
                .HasMaxLength(10)
                .HasColumnName("gioiTinh");
            entity.Property(e => e.HoVaTen)
                .HasMaxLength(100)
                .HasColumnName("hoVaTen");
            entity.Property(e => e.LaQuanLi).HasColumnName("laQuanLi");
            entity.Property(e => e.MatKhau)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("matKhau");
            entity.Property(e => e.NamSinh).HasColumnName("namSinh");
            entity.Property(e => e.NgayBatDau).HasColumnName("ngayBatDau");
            entity.Property(e => e.NghiViec).HasColumnName("nghiViec");
            entity.Property(e => e.Sdt)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.UserId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("userID");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaThanhVien).HasName("PK__NhanVien__53586E4914B0BE4B");

            entity.ToTable("NhanVien");

            entity.Property(e => e.MaThanhVien)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maThanhVien");
            entity.Property(e => e.LaQuanLi).HasColumnName("laQuanLi");
            entity.Property(e => e.LaTruongNhom).HasColumnName("laTruongNhom");
            entity.Property(e => e.MaNhom)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maNhom");
            entity.Property(e => e.MaPb)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maPB");

            entity.HasOne(d => d.MaNhomNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.MaNhom)
                .HasConstraintName("FK__NhanVien__maNhom__2B3F6F97");

            entity.HasOne(d => d.MaPbNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.MaPb)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__NhanVien__maPB__2A4B4B5E");

            entity.HasOne(d => d.MaThanhVienNavigation).WithOne(p => p.NhanVien)
                .HasForeignKey<NhanVien>(d => d.MaThanhVien)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__NhanVien__maThan__29572725");
        });

        modelBuilder.Entity<NhanVienCuaChuHoHoacKhachThueHoacKhachVangLaiLuuTruNganNgay>(entity =>
        {
            entity.HasKey(e => e.MaCuDan).HasName("PK__NhanVien__7C746367696A415E");

            entity.ToTable("NhanVienCuaChuHoHoacKhachThueHoacKhachVangLaiLuuTruNganNgay");

            entity.Property(e => e.MaCuDan)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maCuDan");
            entity.Property(e => e.TenNguoiGioiThieu)
                .HasMaxLength(100)
                .HasColumnName("tenNguoiGioiThieu");

            entity.HasOne(d => d.MaCuDanNavigation).WithOne(p => p.NhanVienCuaChuHoHoacKhachThueHoacKhachVangLaiLuuTruNganNgay)
                .HasForeignKey<NhanVienCuaChuHoHoacKhachThueHoacKhachVangLaiLuuTruNganNgay>(d => d.MaCuDan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__NhanVienC__maCuD__239E4DCF");
        });

        modelBuilder.Entity<Nhom>(entity =>
        {
            entity.HasKey(e => e.MaNhom).HasName("PK__Nhom__8316C8AF635C2768");

            entity.ToTable("Nhom");

            entity.Property(e => e.MaNhom)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maNhom");
            entity.Property(e => e.TenNhom)
                .HasMaxLength(200)
                .HasColumnName("tenNhom");
        });

        modelBuilder.Entity<PhongBan>(entity =>
        {
            entity.HasKey(e => e.MaPb).HasName("PK__PhongBan__7A3ED78E4DFBF331");

            entity.ToTable("PhongBan");

            entity.Property(e => e.MaPb)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maPB");
            entity.Property(e => e.TenPb)
                .HasMaxLength(200)
                .HasColumnName("tenPB");
        });

        modelBuilder.Entity<QuanLi>(entity =>
        {
            entity.HasKey(e => e.MaThanhVien).HasName("PK__QuanLi__53586E49C851F26A");

            entity.ToTable("QuanLi");

            entity.Property(e => e.MaThanhVien)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maThanhVien");
            entity.Property(e => e.HoVaTen)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("hoVaTen");

            entity.HasOne(d => d.MaThanhVienNavigation).WithOne(p => p.QuanLi)
                .HasForeignKey<QuanLi>(d => d.MaThanhVien)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__QuanLi__maThanhV__2E1BDC42");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
