using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIs
{
    public partial class C_AssignTask : Form
    {
        public C_AssignTask()
        {
            InitializeComponent();
        }

        private void userPanel_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 30;
            int diameter = radius * 2;

            Rectangle rectTopLeft = new Rectangle(0, 0, diameter, diameter);
            Rectangle rectTopRight = new Rectangle(userPanel.Width - diameter, 0, diameter, diameter);
            Rectangle rectBottomLeft = new Rectangle(0, userPanel.Height - diameter, diameter, diameter);
            Rectangle rectBottomRight = new Rectangle(userPanel.Width - diameter, userPanel.Height - diameter, diameter, diameter);

            // Vẽ góc trên bên trái
            path.AddArc(rectTopLeft, 180, 90);
            // Vẽ đoạn thẳng ở trên
            path.AddLine(radius, 0, userPanel.Width - radius, 0);
            // Vẽ góc trên bên phải
            path.AddArc(rectTopRight, 270, 90);
            // Vẽ đoạn thẳng ở phải
            path.AddLine(userPanel.Width, radius, userPanel.Width, userPanel.Height - radius);
            // Vẽ góc dưới bên phải
            path.AddArc(rectBottomRight, 0, 90);
            // Vẽ đoạn thẳng ở dưới
            path.AddLine(userPanel.Width - radius, userPanel.Height, radius, userPanel.Height);
            // Vẽ góc dưới bên trái
            path.AddArc(rectBottomLeft, 90, 90);
            // Vẽ đoạn thẳng ở trái
            path.AddLine(0, userPanel.Height - radius, 0, radius);
            // Kết thúc
            path.CloseFigure();

            userPanel.Region = new Region(path);
        }

    }
}
