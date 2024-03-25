﻿using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class NhanSu
{
    public string MaThanhVien { get; set; } = null!;

    public string? MatKhau { get; set; }

    public string HoVaTen { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string Sdt { get; set; } = null!;

    public DateOnly NamSinh { get; set; }

    public string Cccd { get; set; } = null!;

    public string Email { get; set; } = null!;

    public bool NghiViec { get; set; }

    public string AnhDaiDien { get; set; } = null!;

    public bool LaQuanLi { get; set; }

    public virtual Ceo? Ceo { get; set; }

    public virtual NhanVien? NhanVien { get; set; }

    public virtual QuanLi? QuanLi { get; set; }
}
