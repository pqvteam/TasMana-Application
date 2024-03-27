using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class NhanSuService
    {
        NhanSuRepository nhanSuRepository = new NhanSuRepository();
        public NhanSu findMember(string ID)
        {
            return nhanSuRepository.findMember(ID);
        }

        public List<NhanSu> getAllMembersOfDepartment(string departmentID)
        {
            return nhanSuRepository.getAllMembersOfDepartment(departmentID);
        }
    }
}
