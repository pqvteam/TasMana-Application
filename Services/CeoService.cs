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
    }
}
