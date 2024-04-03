using Repositories.Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class DanhNhapService
    {
        DangNhapRepository repository = new DangNhapRepository();
        public string checkLogin(string username, string password)
        {
            return repository.check(username, password);
        }
        public bool savePassword(string username, string password)
        {
            return repository.save(username, password);
        }
    }
}
