using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Entities;

namespace Repositories
{
    public class NhomRepository
    {
        TasManaContext db = new TasManaContext();
        public Nhom? Get(string groupID)
        {
            // Access DB
            return db.Nhoms.FirstOrDefault(x => x.MaNhom.Equals(groupID));
        }
    }
}
