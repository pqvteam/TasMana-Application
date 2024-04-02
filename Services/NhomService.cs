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

        public bool createGroup(string name, string IDs, string ID)
        {
            return repository.Create(name, IDs, ID);
        }

        public bool appointLeader(string staffID, string ID)
        {
            return repository.Appoint(staffID, ID);
        }

        public bool deposeLeader(string staffID, string ID)
        {
            return repository.Depose(staffID, ID);
        }
    }
}
