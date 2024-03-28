using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Repositories.Entities;
using Services;

namespace UIs
{
    public partial class E_Information : Form
    {
        string connectionString = @"Data Source=LAPTOP-BQI9C1O9;Initial Catalog=TasMana;Integrated Security=True";
        string employeeName;
        string employeeID;
        string employeeMobile;
        string employeeCID;
        string employeeBirth;
        string employeeGender;
        string employeeAddress;
        string employeeEmail;
        string employeeStart;
        string employeeDepartment;
        string employeeGroup;
        bool isTeamLeader;

        public E_Information()
        {
            InitializeComponent();
        }

        private void E_Information_Load(object sender, EventArgs e)
        {
            displayEmployeeData();
        }

        private void displayEmployeeData()
        {
            // UserID
            string managerID = "DV-102";

            NhanSuService currentEmployee = new NhanSuService();
            currentEmployee.findMember(managerID);

            UserName.Text = currentEmployee.GetType("maThanhVien");
        }
    }
}
