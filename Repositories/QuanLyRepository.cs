using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class QuanLyRepository
    {
        public QuanLi? getManager(string departmentID)
        {
            TasManaContext db = new TasManaContext();
            return db.QuanLis.FirstOrDefault(x => x.MaThanhVien.IndexOf(departmentID) != -1);
        }

        public List<QuanLi>? getAllManager(string departmentID)
        {
            TasManaContext db = new TasManaContext();
            return db.QuanLis.Where(x => x.MaThanhVien.IndexOf(departmentID) != -1).ToList();
        }
    }
}
