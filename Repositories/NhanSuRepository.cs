using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class NhanSuRepository
    {
        TasManaContext tasManaContext = new TasManaContext();
        public NhanSu? findMember(string ID)
        {
            return tasManaContext.NhanSus.FirstOrDefault(x => x.MaThanhVien == ID);
        }
    }
}
