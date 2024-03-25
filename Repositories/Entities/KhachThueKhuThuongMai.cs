using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class KhachThueKhuThuongMai
{
    public string MaCuDan { get; set; } = null!;

    public virtual CuDan MaCuDanNavigation { get; set; } = null!;
}
