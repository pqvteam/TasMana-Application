using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Nhom
{
    public string MaNhom { get; set; } = null!;

    public string TenNhom { get; set; } = null!;

    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
}
