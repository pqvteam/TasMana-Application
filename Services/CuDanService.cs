using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CuDanService
    {
        CuDanRepositoty cuDanRepositoty = new CuDanRepositoty();

        public CuDan? getResident(string ID)
        {
            return cuDanRepositoty.Get(ID);
        }

        public List<CuDan> getAllResidents()
        {
            return cuDanRepositoty.GetAll();
        }

        public List<string> getCuDanHoldHouseInFo(string maCanHo)
        {
            List<string> list = new List<string>();
            
            if (cuDanRepositoty.getCuDanHoldHouse(maCanHo) != "This department does not exist" && cuDanRepositoty.getCuDanHoldHouse(maCanHo) != "Connection Failed!")
            {
                string[] rs = cuDanRepositoty.getCuDanHoldHouse(maCanHo).Split(", ,");
                foreach (string s in rs)
                {
                    list.Add(s);
                }
            }
            return list;
        }

        public List<string> getCuDanHoldHouseIDs()
        {
            return cuDanRepositoty.getCuDanHoldHouseID();
        }

        public List<string> getCuDanAuthorizedInFo(string maCanHo)
        {
            List<string> list = new List<string>();

            if (cuDanRepositoty.getCuDanAuthorized(maCanHo) != "This department does not exist" && cuDanRepositoty.getCuDanAuthorized(maCanHo) != "Connection Failed!")
            {
                string[] rs = cuDanRepositoty.getCuDanAuthorized(maCanHo).Split(", ,");
                foreach (string s in rs)
                {
                    list.Add(s);
                }
            }
            return list;
        }

        public List<string> getCuDanAuthorizedIDs()
        {
            return cuDanRepositoty.getCuDanAuthorizedID();
        }

        public List<string> getCuDanTenantInFo(string maCanHo)
        {
            List<string> list = new List<string>();

            if (cuDanRepositoty.getCuDanTenant(maCanHo) != "This department does not exist" && cuDanRepositoty.getCuDanTenant(maCanHo) != "Connection Failed!")
            {
                string[] rs = cuDanRepositoty.getCuDanTenant(maCanHo).Split(", ,");
                foreach (string s in rs)
                {
                    list.Add(s);
                }
            }
            return list;
        }

        public List<string> getCuDanTenantIDs()
        {
            return cuDanRepositoty.getCuDanTenantID();
        }

        public List<string> getCuDanCommercialInFo(string maCanHo)
        {
            List<string> list = new List<string>();

            if (cuDanRepositoty.getCuDanCommercial(maCanHo) != "This department does not exist" && cuDanRepositoty.getCuDanCommercial(maCanHo) != "Connection Failed!")
            {
                string[] rs = cuDanRepositoty.getCuDanCommercial(maCanHo).Split(", ,");
                foreach (string s in rs)
                {
                    list.Add(s);
                }
            }
            return list;
        }

        public List<string> getCuDanCommercialIDs()
        {
            return cuDanRepositoty.getCuDanCommercialID();
        }
    }
}
