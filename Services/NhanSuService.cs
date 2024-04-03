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

        public List<NhanSu> getAllStaffs()
        {
            return nhanSuRepository.getAllStaffs();
        }

        public bool updateInformation(string ID, string newUserName, string newNumber, string newBirth, string newCID, string newEmail, string newAddress, string newGender)
        {
            return nhanSuRepository.EditInformation(ID, newUserName, newNumber, newBirth, newCID, newEmail, newAddress, newGender);
        }

        public void insertImage(byte[] image, string ID)
        {
            nhanSuRepository.insertAvatar(image, ID);
        }

        public byte[] convertImageToByte(Image<Rgba32> img)
        {
            return nhanSuRepository.convertImageToByte(img);
        }

        public Image<Rgba32> convertByteToImage(byte[] data)
        {
            return nhanSuRepository.convertByteToImage(data);
        }
    }
}
