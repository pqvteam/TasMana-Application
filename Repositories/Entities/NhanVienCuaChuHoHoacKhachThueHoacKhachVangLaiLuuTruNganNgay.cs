using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class NhanVienCuaChuHoHoacKhachThueHoacKhachVangLaiLuuTruNganNgay
{
    public string? TenNguoiGioiThieu { get; set; }

    public string MaCuDan { get; set; } = null!;

    public virtual CuDan MaCuDanNavigation { get; set; } = null!;
}
