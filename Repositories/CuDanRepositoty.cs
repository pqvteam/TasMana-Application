using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CuDanRepositoty
    {
        TasManaContext db = new TasManaContext();

        public CuDan? Get(string ID)
        {
            return db.CuDans.FirstOrDefault(x => x.MaCuDan == ID);
        }
        public List<CuDan> GetAll()
        {
            return db.CuDans.ToList();
        }
    }
}
