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
    public partial class A_ShowDepartment : Form
    {
        private string selectedDepartment = "";
        public A_ShowDepartment()
        {
            InitializeComponent();
        }

        public event Action<string> DepartmentSelected;

        private void membersGrid_RowContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedDepartment = membersGrid.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedDepartment))
            {
                DepartmentSelected?.Invoke(selectedDepartment);
                this.Close();
            }
            else
            {
                showToast("WARNING", "Please select a member first.");
            }
        }

        private void membersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void A_ShowDepartment_Load(object sender, EventArgs e)
        {
            PhongBanService phongBanService = new PhongBanService();
            List<PhongBan> departments = phongBanService.getAllDepartment();
            membersGrid.Columns.Add("ID", "ID");
            membersGrid.Columns.Add("Name", "NAME");
            foreach (PhongBan department in departments)
            {
                membersGrid.Rows.Add(department.MaPb, department.TenPb);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void showToast(string type, string message)
        {
            ToastForm show = new ToastForm(type, message);
            show.Show();
        }
    }
}
