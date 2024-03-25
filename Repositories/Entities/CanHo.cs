using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class CanHo
{
    public string MaCh { get; set; } = null!;

    public double Gsa { get; set; }

    public double Nsa { get; set; }

    public string ViTri { get; set; } = null!;

    public int SlPhongNgu { get; set; }

    public int SlToilet { get; set; }

    public double SoDoMatBang { get; set; }

    public double PhiQl { get; set; }

    public int SoLuongTheTm { get; set; }

    public string LichSuGd { get; set; } = null!;

    public string TinhTrangGd { get; set; } = null!;

    public string? MaCuDan { get; set; }

    public virtual CuDan? MaCuDanNavigation { get; set; }

    public virtual ICollection<GiaoViec> MaGiaoViecs { get; set; } = new List<GiaoViec>();
}
