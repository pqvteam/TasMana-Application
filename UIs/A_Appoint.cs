using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIs
{
    public partial class A_Appoint : Form
    {
        NhomService nhomService = new NhomService();
        NhanSuService nhanSuService = new NhanSuService();
        CeoService ceoService = new CeoService();
        private string staffID = "";
        private string appointerID = "";
        public A_Appoint()
        {
            InitializeComponent();
        }

        public A_Appoint(string staffID, string appointerID)
        {
            this.staffID = staffID;
            this.appointerID = appointerID;
            InitializeComponent();
        }

        private void departmentsBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (rolesBox.SelectedItem != null && rolesBox.SelectedItem.ToString() == "Leader")
            {
                groupsBox.Enabled = true;
            }
        }

        private void A_Appoint_Load(object sender, EventArgs e)
        {
            NhanSu member = nhanSuService.findMember(staffID);

            List<Nhom> groups = nhomService.findGroups();
            groupsBox.Items.Clear();
            foreach (Nhom group in groups)
            {
                groupsBox.Items.Add(group.TenNhom);
            }

            idBox.Text = staffID;
            nameBox.Text = member.HoVaTen;
            groupsBox.Enabled = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string selectedRole = rolesBox.SelectedItem == null ? "" : rolesBox.SelectedItem.ToString();
            if (selectedRole == "Manager")
            {
                bool isSuccess = ceoService.appointManager(staffID, appointerID);
                if (isSuccess)
                {
                    MessageBox.Show("Appoint manager successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something wrong!");
                }
            }
            else if (selectedRole == "Leader")
            {
            }
        }

        private void groupsBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
