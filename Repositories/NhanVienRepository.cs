using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class NhanVienRepository
    {
        private TasManaContext db = new TasManaContext();
        public NhanVien? get(string ID)
        {   
            return db.NhanViens.Find(ID);
        }

        public List<NhanVien> getAll()
        {
            return db.NhanViens.ToList();
        }

        public void create(NhanVien nhanVien)
        {
            db.NhanViens.Add(nhanVien);
            db.SaveChanges();
        }

        public void update(NhanVien nhanVien)
        {
            db.NhanViens.Update(nhanVien);
            db.SaveChanges();
        }

        public void delete(string ID)
        {
            var foundStaff = db.NhanViens.FirstOrDefault(x => x.MaThanhVien == ID);
            if (foundStaff != null)
            {
                db.NhanViens.Remove(foundStaff);
                db.SaveChanges();
            }
        }
    }
}
