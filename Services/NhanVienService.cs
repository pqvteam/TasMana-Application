using Repositories.Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class NhanVienService
    {
        NhanVienRepository nhanVienRepository = new NhanVienRepository();

        public NhanVien? get(string ID)
        {
            return nhanVienRepository.get(ID);
        }

        public List<NhanVien> getAllStaffs()
        {
            return nhanVienRepository.getAll();
        }
    }
}
