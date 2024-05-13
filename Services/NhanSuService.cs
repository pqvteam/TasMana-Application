using Microsoft.Data.SqlClient;
using Repositories;
using Repositories.Entities;
using Repositories.Utilities;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class NhanSuService
    {
        NhanSuRepository nhanSuRepository;
        public NhanSu findMember(string ID)
        {
            nhanSuRepository = new NhanSuRepository();
            return nhanSuRepository.findMember(ID);
        }

        public List<NhanSu> getAllMembersOfDepartment(string departmentID)
        {
            nhanSuRepository = new NhanSuRepository();
            return nhanSuRepository.getAllMembersOfDepartment(departmentID);
        }

        public List<NhanSu> getAllMembers()
        {
            nhanSuRepository = new NhanSuRepository();
            return nhanSuRepository.getAllMembers();
        }

        public List<NhanSu> getAllStaffs()
        {
            nhanSuRepository = new NhanSuRepository();
            return nhanSuRepository.getAllStaffs();
        }

        public bool updateInformation(string ID, string newUserName, string newNumber, string newBirth, string newCID, string newEmail, string newAddress, string newGender)
        {
            nhanSuRepository = new NhanSuRepository();
            return nhanSuRepository.EditInformation(ID, newUserName, newNumber, newBirth, newCID, newEmail, newAddress, newGender);
        }

        public void insertImage(byte[] image, string ID)
        {
            nhanSuRepository = new NhanSuRepository();
            nhanSuRepository.insertAvatar(image, ID);
        }
        public void insertType(string type, string ID)
        {
            nhanSuRepository = new NhanSuRepository();
            nhanSuRepository.insertType(type, ID);
        }

        public bool createEmployee(string ID, string password, string name, string phone, string birthdate, string citizenID, string email, string maPB, string sex, string address, string datenow, string type, string passport)
        {
            nhanSuRepository = new NhanSuRepository();
            return nhanSuRepository.createEmployee(ID, password, name, phone, birthdate, citizenID, email, maPB, sex, address, datenow, type, passport);
        }

        public string createIDEmployee(string maPB)
        {
            nhanSuRepository = new NhanSuRepository();
            return nhanSuRepository.createIDEmployye(maPB);
        }
        public byte[] convertImageToByte(Image<Rgba32> img)
        {
            nhanSuRepository = new NhanSuRepository();
            return nhanSuRepository.convertImageToByte(img);
        }

        public Image<Rgba32> convertByteToImage(byte[] data)
        {
            nhanSuRepository = new NhanSuRepository();
            return nhanSuRepository.convertByteToImage(data);
        }
    }
}
