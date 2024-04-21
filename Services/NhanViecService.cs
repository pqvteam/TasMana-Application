using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class NhanViecService
    {
        NhanViecRepository nhanViecRepository = new NhanViecRepository();
        public string getInplementor(string ID)
        {
            return nhanViecRepository.getImplementor(ID);
        }
    }
}
