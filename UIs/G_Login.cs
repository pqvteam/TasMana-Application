using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;

namespace UIs
{
    public partial class G_Login : Form
    {
        public G_Login()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            DanhNhapService service = new DanhNhapService();
            string userID = box_username.Text;
            string password = box_password.Text;
            string result = service.checkLogin(userID, password);
            MessageBox.Show(result);
        }
    }
}
