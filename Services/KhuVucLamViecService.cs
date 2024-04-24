using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class KhuVucLamViecService
    {
        KhuVucLamViecRepository khuVucLamViecRepository = new KhuVucLamViecRepository();
        public string getVenue(string ID)
        {
            return khuVucLamViecRepository.getVenue(ID);
        }
    }
}
