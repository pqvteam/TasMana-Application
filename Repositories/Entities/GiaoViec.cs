using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class GiaoViec
{
    public string MoTaCongViec { get; set; } = null!;

    public DateOnly NgayGiao { get; set; }

    public DateOnly HanHoanThanh { get; set; }

    public string TinhTrangCongViec { get; set; } = null!;

    public byte[] DinhKemFile { get; set; }

    public string MaGiaoViec { get; set; } = null!;

    public bool? CheDo { get; set; }

    public string? TenCongViec { get; set; }

    public string? UyQuyenBoi { get; set; }

    public bool? DungHan { get; set; }

    public string? PhongBanChoPhep { get; set; }

    public virtual ICollection<CanHo> MaChes { get; set; } = new List<CanHo>();

    public virtual ICollection<NhanVien> MaThanhViens { get; set; } = new List<NhanVien>();
}
