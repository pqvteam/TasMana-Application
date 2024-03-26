using Repositories.Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PhongBanService
    {
        PhongBanRepository repository = new PhongBanRepository();
        public List<PhongBan> getAllDepartment()
        {
            List<PhongBan> departments = repository.GetAllDepartment();
            return departments;
        }

        public PhongBan getDepartment(string ID)
        {
            return repository.getDepartment(ID);
        }
    }
}
