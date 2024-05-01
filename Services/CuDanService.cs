using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CuDanService
    {
        CuDanRepositoty cuDanRepositoty = new CuDanRepositoty();

        public CuDan? getResident(string ID)
        {
            return cuDanRepositoty.Get(ID);
        }

        public List<CuDan> getAllResidents()
        {
            return cuDanRepositoty.GetAll();
        }
    }
}
