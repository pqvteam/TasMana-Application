using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class NhanVien
{
    public bool LaTruongNhom { get; set; }

    public string MaThanhVien { get; set; } = null!;

    public string MaPb { get; set; } = null!;

    public string? MaNhom { get; set; }

    public virtual Nhom? MaNhomNavigation { get; set; }

    public virtual PhongBan MaPbNavigation { get; set; } = null!;

    public virtual NhanSu MaThanhVienNavigation { get; set; } = null!;

    public virtual ICollection<GiaoViec> MaGiaoViecs { get; set; } = new List<GiaoViec>();
}
