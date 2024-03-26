using Repositories.Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CanHoService
    {
        public List<CanHo> getAllApartments()
        {
            CanHoRepository repository = new CanHoRepository();
            List<CanHo> foundApartments = repository.GetAllApartment();
            return foundApartments;
        }

        public CanHo? findApartment(string apartmentID)
        {
            CanHoRepository repository = new CanHoRepository();
            CanHo? foundApartment = repository.find(apartmentID);
            return foundApartment;
        }
    }
}
