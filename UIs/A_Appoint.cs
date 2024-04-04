﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositories.Entities;
using Services;

namespace UIs
{
    public partial class A_Appoint : Form
    {
        NhomService nhomService = new NhomService();
        NhanSuService nhanSuService = new NhanSuService();
        CeoService ceoService = new CeoService();
        NhanVienService nhanVienService = new NhanVienService();
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
            if (rolesBox.SelectedItem != null && rolesBox.SelectedItem.ToString() == "Manager")
            {
                groupsBox.Visible = false;
                groupButton.Visible = false;
                groupLabel.Visible = false;

            } else if (rolesBox.SelectedItem != null && rolesBox.SelectedItem.ToString() == "Leader")
            {
                groupsBox.Visible = true;
                groupButton.Visible = true;
                groupLabel.Visible = true;
            }
        }

        private void A_Appoint_Load(object sender, EventArgs e)
        {
            rolesBox.SelectedItem = "Leader";
            NhanSu member = nhanSuService.findMember(staffID);
            NhanVien? staff = nhanVienService.get(staffID);

            List<Nhom> groups = nhomService.findGroups();
            groupsBox.Items.Clear();
            foreach (Nhom group in groups)
            {
                if (group.MaNhom == staff.MaNhom)
                {
                    groupsBox.Items.Add(group.MaNhom + " - " + group.TenNhom);
                }
            }

            idBox.Text = staffID;
            nameBox.Text = member.HoVaTen;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string selectedRole =
                rolesBox.SelectedItem == null ? "" : rolesBox.SelectedItem.ToString();
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
                string selectedGroup =
                    groupsBox.SelectedItem != null
                        ? groupsBox.SelectedItem.ToString().Split(" - ")[0].Trim()
                        : "";
                MessageBox.Show(selectedGroup);
                NhanVien? leader = nhanVienService.getLeaderOfGroup(selectedGroup);
                if (leader == null) { }
                else
                {
                    NhanSu currentLeader = nhanSuService.findMember(leader.MaThanhVien);
                    string confirmMessage =
                        $"This group has {currentLeader.MaThanhVien + " " + currentLeader.HoVaTen} is current leader! Do you want to change leader?".ToUpper();
                    A_Confirm confirmForm = new A_Confirm(confirmMessage, "warning");
                    confirmForm.ConfirmClicked += (confirmSender, confirmArgs) =>
                    {
                        bool success = nhomService.deposeLeader(leader.MaThanhVien, appointerID);
                        if (success)
                        {
                            bool isSuccess = nhomService.appointLeader(staffID, appointerID);
                            if (isSuccess)
                            {
                                MessageBox.Show("Appoint leader successfully");
                            }
                            else
                            {
                                MessageBox.Show("Appoint leader failure");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Depose leader failure");
                        }
                    };
                    confirmForm.ShowDialog();
                }
            }
        }

        private void groupsBox_OnSelectedIndexChanged(object sender, EventArgs e) { }

        private void createButton_Click(object sender, EventArgs e)
        {
            CM_CreateGroup createGroupForm = new CM_CreateGroup();
            createGroupForm.ShowDialog();
        }
    }
}
