using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class CuDan
{
    public string MaCuDan { get; set; } = null!;

    public string HoVaTen { get; set; } = null!;

    public DateOnly NamSinh { get; set; }

    public string Cccd { get; set; } = null!;

    public string Sdt { get; set; } = null!;

    public string? Email { get; set; }

    public string QuocTich { get; set; } = null!;

    public string SoTheTamTru { get; set; } = null!;

    public DateOnly NgayBanGiao { get; set; }

    public DateOnly? NgayChuyenVao { get; set; }

    public DateOnly? NgayChuyenDi { get; set; }

    public string? ThanhVienLuuTruCung { get; set; }

    public double SoLieuDnbanDau { get; set; }

    public string? SdtnguoiThan { get; set; }

    public double PhiQlhangThang { get; set; }

    public double PhiDichVu { get; set; }

    public double CongNo { get; set; }

    public bool? ThuCung { get; set; }

    public string? DuLieuDoXe { get; set; }

    public virtual ICollection<CanHo> CanHos { get; set; } = new List<CanHo>();

    public virtual ChuHo? ChuHo { get; set; }

    public virtual KhachThueKhuThuongMai? KhachThueKhuThuongMai { get; set; }

    public virtual NguoiDuocUyQuyenCuaChuHo? NguoiDuocUyQuyenCuaChuHo { get; set; }

    public virtual NhanVienCuaChuHoHoacKhachThueHoacKhachVangLaiLuuTruNganNgay? NhanVienCuaChuHoHoacKhachThueHoacKhachVangLaiLuuTruNganNgay { get; set; }
}
