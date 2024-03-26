using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
   public class PhongBanRepository
    {
        TasManaContext db = new TasManaContext();
        public List<PhongBan>? GetAllDepartment()
        {
            // Access DB
            return db.PhongBans.ToList();
        }

        public PhongBan? getDepartment(string ID)
        {
            // Access DB
            return db.PhongBans.Find(ID);
        }
    }
}
