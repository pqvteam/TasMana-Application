using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class ChuHo
{
    public DateOnly? NgayChuyenChuMoi { get; set; }

    public string ThongTinChuHoMoi { get; set; } = null!;

    public string MaCuDan { get; set; } = null!;

    public virtual CuDan MaCuDanNavigation { get; set; } = null!;
}
