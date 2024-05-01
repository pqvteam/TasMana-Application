using System;
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
            changelanguage();

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
                    showToast("SUCCESS", "Appoint manager successfully");
                    this.Close();
                }
                else
                {
                    showToast("ERROR", "Something wrong!");
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
                                showToast("SUCCESS", "Appoint leader successfully");
                            }
                            else
                            {
                                showToast("ERROR", "Appoint leader failure");
                            }
                        }
                        else
                        {
                            showToast("ERROR", "Depose leader failure");
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

        private void changelanguage()
        {
            Font font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            Font fontSmaller = new Font("Copperplate Gothic Bold", 9);
            if (Session.Instance.Language == "vi")
            {
                customButton10.Text = "BỔ NHIỆM";
                customButton10.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);

                label3.Text = "TÊN";
                label1.Text = "CHỨC VỤ";
                groupLabel.Text = "NHÓM";
                font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

                createButton.Text = "TẠO NHÓM MỚI";
                cancelButton.Text = "HỦY";
                confirmButton.Text = "TIẾP TỤC";
                fontSmaller = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            }
            else
            {
                customButton10.Text = "APPOINT";
                customButton10.Font = new Font("Copperplate Gothic Bold", 14);

                label3.Text = "NAME";
                label1.Text = "ROLE";
                groupLabel.Text = "GROUP";
                font = new Font("Copperplate Gothic Bold", 10);

                createButton.Text = "CREATE NEW GROUP";
                cancelButton.Text = "CANCEL";
                confirmButton.Text = "CONTINUE";
                fontSmaller = new Font("Copperplate Gothic Bold", 9);
            }
            label3.Font = font;
            label1.Font = font;
            groupLabel.Font = font;

            createButton.Font = fontSmaller;
            cancelButton.Font = fontSmaller;
            confirmButton.Font = fontSmaller;
        }
        public void showToast(string type, string message)
        {
            ToastForm show = new ToastForm(type, message);
            show.Show();
        }
    }
}
