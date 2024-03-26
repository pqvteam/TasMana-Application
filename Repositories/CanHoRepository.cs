using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CanHoRepository
    {
        public List<CanHo>? GetAllApartment()
        {
            // Access DB
            TasManaContext db = new TasManaContext();
            return db.CanHos.ToList();
        }

        public CanHo? find(string apartmentID)
        {
            // Access DB
            TasManaContext db = new TasManaContext();
            return db.CanHos.FirstOrDefault(x => x.MaCh == apartmentID);
        }
    }
}
