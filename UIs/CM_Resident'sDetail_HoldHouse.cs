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
    public partial class CM_Resident_sDetail : Form
    {
        public CM_Resident_sDetail()
        {
            InitializeComponent();
        }

        private void customButton13_Click(object sender, EventArgs e)
        {
            if (Session.Instance.UserName.Contains("GD") || Session.Instance.laQuanLi)
            {
                M_Information information = new M_Information();
                information.ShowDialog();
            }
            else
            {
                E_Information information = new E_Information();
                information.ShowDialog();
            }
        }

        private void customButton14_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanel3.Visible == false)
            {
                tableLayoutPanel3.Visible = true;
            }
            else
            {
                tableLayoutPanel3.Visible = false;
            }
        }

        private void customButton7_Click(object sender, EventArgs e)
        {
            C_AllTaskList c_AllTaskList = new C_AllTaskList();
            c_AllTaskList.ShowDialog();
        }

        private void customButton17_Click(object sender, EventArgs e)
        {
            C_AccountManagement c_AccountManagement = new C_AccountManagement();
            c_AccountManagement.ShowDialog();
        }

        private void customButton18_Click(object sender, EventArgs e)
        {
            CM_Resident_sDetail cM = new CM_Resident_sDetail();
            cM.ShowDialog();
        }

        private void label39_Click(object sender, EventArgs e)
        {
            if (Session.Instance.UserName.Contains("GD") || Session.Instance.laQuanLi)
            {
                M_Information information = new M_Information();
                information.ShowDialog();
            }
            else
            {
                E_Information information = new E_Information();
                information.ShowDialog();
            }
        }

        private void label38_Click(object sender, EventArgs e)
        {
            G_ForgotPassword g_ForgotPassword = new G_ForgotPassword();
            g_ForgotPassword.ShowDialog();
        }

        private void label37_Click(object sender, EventArgs e)
        {
            List<Form> formsToClose = new List<Form>();

            foreach (Form form in Application.OpenForms)
            {
                if (form != this) // Assuming "this" refers to the main form
                {
                    formsToClose.Add(form);
                }
            }

            foreach (Form form in formsToClose)
            {
                form.Close();
            }

            G_Login g_Login = new G_Login();
            g_Login.ShowDialog();
        }

        private void customButton5_Click(object sender, EventArgs e)
        {
            CM_Resident_sDetail_Commercial cM = new CM_Resident_sDetail_Commercial();
            cM.ShowDialog();
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            CM_Resident_sDetail_Authorized cM = new CM_Resident_sDetail_Authorized();
            cM.ShowDialog();
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            CM_Resident_sDetail_Tenant_StaffOf cM = new CM_Resident_sDetail_Tenant_StaffOf();
            cM.ShowDialog();
        }
    }
}
