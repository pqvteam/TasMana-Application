using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;
using Repositories.Entities;

namespace Services
{
    public class NhomService
    {
        NhomRepository repository = new NhomRepository();
        public Nhom? findGroup(string groupID)
        {
            Nhom? group = repository.Get(groupID);
            if (groupID == null) return null;
            return group;
        }

        public List<Nhom> findGroups()
        {
            return repository.GetAll();
        }
    }
}
