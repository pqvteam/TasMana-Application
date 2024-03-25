using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class QuanLi
{
    public string MaThanhVien { get; set; } = null!;

    public virtual NhanSu MaThanhVienNavigation { get; set; } = null!;
}
