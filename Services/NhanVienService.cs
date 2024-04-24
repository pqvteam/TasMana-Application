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

        public NhanVien? getLeaderOfGroup(string ID)
        {
            return nhanVienRepository.findLeaderOfGroup(ID);
        }

        public List<NhanVien> getAllStaffs()
        {
            return nhanVienRepository.getAll();
        }

        public List<NhanVien> getAllStaffOfDepartments(string departmentID)
        {
            return nhanVienRepository.getAllStaffOfDepartment(departmentID);
        }

        public List<NhanVien> getStaffsDoNotHaveGroup()
        {
            return nhanVienRepository.getAllNoGroup();
        }

        public bool checkLeader(string ID)
        {
            return nhanVienRepository.checkLeader(ID);
        }

    }
}
