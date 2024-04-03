using Microsoft.EntityFrameworkCore;
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

        public List<NhanVien> getAllStaffOfDepartment(string departmentID)
        {
            return db.NhanViens.Where(x => x.MaThanhVien.Contains(departmentID)).ToList();
        }

        public List<NhanVien> getAllNoGroup()
        {
            return db.NhanViens.Where(x => x.MaNhom == null && x.LaQuanLi == false).ToList();
        }

        public NhanVien? findLeaderOfGroup(string groupID)
        {
            return db.NhanViens.FirstOrDefault(x => x.MaNhom == groupID && x.LaTruongNhom == true);
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

        public bool checkLeader(string ID)
        {
            return db.NhanViens.FirstOrDefault(x => x.MaThanhVien == ID && x.LaTruongNhom == true) != null ? true : false;
        }
    }
}
