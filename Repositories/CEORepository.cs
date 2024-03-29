using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CEORepository
    {
        TasManaContext db = new TasManaContext();
        public Ceo? Find(string ID)
        {
            return db.Ceos.FirstOrDefault(x => x.MaThanhVien == ID);
        }
    }
}
