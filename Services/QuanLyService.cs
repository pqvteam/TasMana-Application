using Repositories.Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class QuanLyService
    {
        QuanLyRepository repository = new QuanLyRepository();
        public QuanLi? findManager(string departmentID)
        {
            QuanLi? foundManager = repository.getManager(departmentID);
            if (foundManager == null) return null;
            return foundManager;
        }

        public List<QuanLi>? findAllManager(string departmentID)
        {
            List<QuanLi>? foundManager = repository.getAllManager(departmentID);
            return foundManager;
        }
    }
}
