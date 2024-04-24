using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CeoService
    {
        CEORepository repository = new CEORepository();
        public Ceo? getCeo(string ID) {
            return repository.Find(ID);
        }

        public bool appointManager(string staffID, string CEOID)
        {
            return repository.AppointManager(staffID, CEOID);
        }

        public bool deposeManager(string staffID, string CEOID)
        {
            return repository.DeposeManager(staffID, CEOID);
        }
        public bool firedStaff(string staffID, string CEOID)
        {
            return repository.DeactiveStaff(staffID, CEOID);
        }
    }
}
