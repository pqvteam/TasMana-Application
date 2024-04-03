﻿using Microsoft.Data.SqlClient;
using Repositories;
using Repositories.Entities;
using Repositories.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class NhanSuService
    {
        NhanSuRepository nhanSuRepository = new NhanSuRepository();
        public NhanSu findMember(string ID)
        {
            return nhanSuRepository.findMember(ID);
        }

        public List<NhanSu> getAllMembersOfDepartment(string departmentID)
        {
            return nhanSuRepository.getAllMembersOfDepartment(departmentID);
        }

        public List<NhanSu> getAllMembers()
        {
            return nhanSuRepository.getAllMembers();
        }

        public bool updateInformation(string UserID, string newUserName, string newNumber, string newBirth, string newCID, string newEmail, string newAddress, string newGender)
        {
            return nhanSuRepository.EditInformation(UserID, newUserName, newNumber, newBirth, newCID, newEmail, newAddress, newGender);
        }
    }
}
