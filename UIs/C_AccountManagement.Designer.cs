namespace UIs
{
    partial class C_AccountManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(C_AccountManagement));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            headerPanel = new Panel();
            panel2 = new Panel();
            currentAvatarSmall = new CustomComponent.CustomPictureBox();
            customButton22 = new CustomComponent.CustomButton();
            customButton18 = new CustomComponent.CustomButton();
            customButton17 = new CustomComponent.CustomButton();
            customButton12 = new CustomComponent.CustomButton();
            customButton11 = new CustomComponent.CustomButton();
            customButton10 = new CustomComponent.CustomButton();
            customButton9 = new CustomComponent.CustomButton();
            customButton8 = new CustomComponent.CustomButton();
            customButton7 = new CustomComponent.CustomButton();
            customButton6 = new CustomComponent.CustomButton();
            customPanel1 = new CustomComponent.CustomPanel();
            button3 = new Button();
            button2 = new Button();
            pictureBox6 = new PictureBox();
            searchBox = new TextBox();
            customButton1 = new CustomComponent.CustomButton();
            label2 = new Label();
            departmentsBox = new CustomComponent.CustomComboBox();
            customButton2 = new CustomComponent.CustomButton();
            typeAccountBox = new CustomComponent.CustomComboBox();
            label3 = new Label();
            customButton3 = new CustomComponent.CustomButton();
            customButton19 = new CustomComponent.CustomButton();
            membersGrid = new DataGridView();
            label1 = new Label();
            customButton4 = new CustomComponent.CustomButton();
            headerPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)currentAvatarSmall).BeginInit();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)membersGrid).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(13, 13, 13);
            headerPanel.Controls.Add(panel2);
            headerPanel.Controls.Add(customButton18);
            headerPanel.Controls.Add(customButton17);
            headerPanel.Controls.Add(customButton12);
            headerPanel.Controls.Add(customButton11);
            headerPanel.Controls.Add(customButton10);
            headerPanel.Controls.Add(customButton9);
            headerPanel.Controls.Add(customButton8);
            headerPanel.Controls.Add(customButton7);
            headerPanel.Controls.Add(customButton6);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1382, 62);
            headerPanel.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(currentAvatarSmall);
            panel2.Controls.Add(customButton22);
            panel2.Location = new Point(1261, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(117, 59);
            panel2.TabIndex = 51;
            // 
            // currentAvatarSmall
            // 
            currentAvatarSmall.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            currentAvatarSmall.BorderColor = Color.RoyalBlue;
            currentAvatarSmall.BorderColor2 = Color.HotPink;
            currentAvatarSmall.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            currentAvatarSmall.BorderSize = 0;
            currentAvatarSmall.GradientAngle = 50F;
            currentAvatarSmall.Image = (Image)resources.GetObject("currentAvatarSmall.Image");
            currentAvatarSmall.Location = new Point(10, 5);
            currentAvatarSmall.Name = "currentAvatarSmall";
            currentAvatarSmall.Size = new Size(49, 49);
            currentAvatarSmall.SizeMode = PictureBoxSizeMode.StretchImage;
            currentAvatarSmall.TabIndex = 25;
            currentAvatarSmall.TabStop = false;
            // 
            // customButton22
            // 
            customButton22.BackColor = Color.Black;
            customButton22.BackgroundColor = Color.Black;
            customButton22.BorderColor = Color.PaleVioletRed;
            customButton22.BorderRadius = 28;
            customButton22.BorderSize = 0;
            customButton22.Cursor = Cursors.Hand;
            customButton22.FlatAppearance.BorderSize = 0;
            customButton22.FlatStyle = FlatStyle.Flat;
            customButton22.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton22.ForeColor = Color.White;
            customButton22.Image = Properties.Resources.triangle_icon;
            customButton22.Location = new Point(67, 4);
            customButton22.Name = "customButton22";
            customButton22.Size = new Size(51, 51);
            customButton22.TabIndex = 24;
            customButton22.TextColor = Color.White;
            customButton22.TextImageRelation = TextImageRelation.TextBeforeImage;
            customButton22.UseVisualStyleBackColor = false;
            customButton22.Click += customButton22_Click;
            // 
            // customButton18
            // 
            customButton18.AutoEllipsis = true;
            customButton18.BackColor = Color.Black;
            customButton18.BackgroundColor = Color.Black;
            customButton18.BorderColor = Color.PaleVioletRed;
            customButton18.BorderRadius = 28;
            customButton18.BorderSize = 0;
            customButton18.Cursor = Cursors.Hand;
            customButton18.FlatAppearance.BorderSize = 0;
            customButton18.FlatStyle = FlatStyle.Flat;
            customButton18.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton18.ForeColor = Color.White;
            customButton18.Image = (Image)resources.GetObject("customButton18.Image");
            customButton18.ImageAlign = ContentAlignment.MiddleLeft;
            customButton18.Location = new Point(717, 4);
            customButton18.Name = "customButton18";
            customButton18.Size = new Size(188, 48);
            customButton18.TabIndex = 25;
            customButton18.Text = "APARTMENT & RESIDENT";
            customButton18.TextAlign = ContentAlignment.MiddleRight;
            customButton18.TextColor = Color.White;
            customButton18.UseVisualStyleBackColor = false;
            // 
            // customButton17
            // 
            customButton17.BackColor = Color.Black;
            customButton17.BackgroundColor = Color.Black;
            customButton17.BorderColor = Color.PaleVioletRed;
            customButton17.BorderRadius = 28;
            customButton17.BorderSize = 0;
            customButton17.Cursor = Cursors.Hand;
            customButton17.FlatAppearance.BorderSize = 0;
            customButton17.FlatStyle = FlatStyle.Flat;
            customButton17.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton17.ForeColor = Color.Yellow;
            customButton17.Image = (Image)resources.GetObject("customButton17.Image");
            customButton17.ImageAlign = ContentAlignment.MiddleLeft;
            customButton17.Location = new Point(509, 5);
            customButton17.Name = "customButton17";
            customButton17.Size = new Size(202, 48);
            customButton17.TabIndex = 24;
            customButton17.Text = "ACCOUNTING MANAGEMENT";
            customButton17.TextAlign = ContentAlignment.MiddleRight;
            customButton17.TextColor = Color.Yellow;
            customButton17.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton17.UseVisualStyleBackColor = false;
            // 
            // customButton12
            // 
            customButton12.BackColor = Color.Black;
            customButton12.BackgroundColor = Color.Black;
            customButton12.BorderColor = Color.PaleVioletRed;
            customButton12.BorderRadius = 28;
            customButton12.BorderSize = 0;
            customButton12.Cursor = Cursors.Hand;
            customButton12.FlatAppearance.BorderSize = 0;
            customButton12.FlatStyle = FlatStyle.Flat;
            customButton12.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton12.ForeColor = Color.White;
            customButton12.Image = Properties.Resources.bell_icon;
            customButton12.Location = new Point(1208, 8);
            customButton12.Name = "customButton12";
            customButton12.Size = new Size(51, 40);
            customButton12.TabIndex = 22;
            customButton12.TextAlign = ContentAlignment.MiddleRight;
            customButton12.TextColor = Color.White;
            customButton12.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton12.UseVisualStyleBackColor = false;
            // 
            // customButton11
            // 
            customButton11.BackColor = Color.Black;
            customButton11.BackgroundColor = Color.Black;
            customButton11.BorderColor = Color.PaleVioletRed;
            customButton11.BorderRadius = 28;
            customButton11.BorderSize = 0;
            customButton11.Cursor = Cursors.Hand;
            customButton11.FlatAppearance.BorderSize = 0;
            customButton11.FlatStyle = FlatStyle.Flat;
            customButton11.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton11.ForeColor = Color.White;
            customButton11.Image = Properties.Resources.triangle_icon;
            customButton11.ImageAlign = ContentAlignment.MiddleRight;
            customButton11.Location = new Point(1077, 0);
            customButton11.Name = "customButton11";
            customButton11.Size = new Size(120, 51);
            customButton11.TabIndex = 21;
            customButton11.Text = "English";
            customButton11.TextAlign = ContentAlignment.MiddleRight;
            customButton11.TextColor = Color.White;
            customButton11.TextImageRelation = TextImageRelation.TextBeforeImage;
            customButton11.UseVisualStyleBackColor = false;
            // 
            // customButton10
            // 
            customButton10.BackColor = Color.Black;
            customButton10.BackgroundColor = Color.Black;
            customButton10.BorderColor = Color.PaleVioletRed;
            customButton10.BorderRadius = 28;
            customButton10.BorderSize = 0;
            customButton10.Cursor = Cursors.Hand;
            customButton10.FlatAppearance.BorderSize = 0;
            customButton10.FlatStyle = FlatStyle.Flat;
            customButton10.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton10.ForeColor = Color.White;
            customButton10.Image = (Image)resources.GetObject("customButton10.Image");
            customButton10.ImageAlign = ContentAlignment.MiddleLeft;
            customButton10.Location = new Point(908, 2);
            customButton10.Name = "customButton10";
            customButton10.Size = new Size(156, 51);
            customButton10.TabIndex = 20;
            customButton10.Text = "RESIDENT SERVICE";
            customButton10.TextAlign = ContentAlignment.MiddleRight;
            customButton10.TextColor = Color.White;
            customButton10.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton10.UseVisualStyleBackColor = false;
            // 
            // customButton9
            // 
            customButton9.BackColor = Color.Black;
            customButton9.BackgroundColor = Color.Black;
            customButton9.BorderColor = Color.PaleVioletRed;
            customButton9.BorderRadius = 28;
            customButton9.BorderSize = 0;
            customButton9.Cursor = Cursors.Hand;
            customButton9.FlatAppearance.BorderSize = 0;
            customButton9.FlatStyle = FlatStyle.Flat;
            customButton9.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton9.ForeColor = Color.White;
            customButton9.Image = (Image)resources.GetObject("customButton9.Image");
            customButton9.ImageAlign = ContentAlignment.MiddleLeft;
            customButton9.Location = new Point(367, 6);
            customButton9.Name = "customButton9";
            customButton9.Size = new Size(137, 48);
            customButton9.TabIndex = 19;
            customButton9.Text = "REPORT";
            customButton9.TextAlign = ContentAlignment.MiddleRight;
            customButton9.TextColor = Color.White;
            customButton9.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton9.UseVisualStyleBackColor = false;
            // 
            // customButton8
            // 
            customButton8.BackColor = Color.Black;
            customButton8.BackgroundColor = Color.Black;
            customButton8.BorderColor = Color.PaleVioletRed;
            customButton8.BorderRadius = 28;
            customButton8.BorderSize = 0;
            customButton8.Cursor = Cursors.Hand;
            customButton8.FlatAppearance.BorderSize = 0;
            customButton8.FlatStyle = FlatStyle.Flat;
            customButton8.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton8.ForeColor = Color.White;
            customButton8.Image = (Image)resources.GetObject("customButton8.Image");
            customButton8.ImageAlign = ContentAlignment.MiddleLeft;
            customButton8.Location = new Point(202, 8);
            customButton8.Name = "customButton8";
            customButton8.Size = new Size(158, 48);
            customButton8.TabIndex = 18;
            customButton8.Text = "STATISTIC";
            customButton8.TextAlign = ContentAlignment.MiddleRight;
            customButton8.TextColor = Color.White;
            customButton8.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton8.UseVisualStyleBackColor = false;
            // 
            // customButton7
            // 
            customButton7.BackColor = Color.Black;
            customButton7.BackgroundColor = Color.Black;
            customButton7.BorderColor = Color.PaleVioletRed;
            customButton7.BorderRadius = 28;
            customButton7.BorderSize = 0;
            customButton7.Cursor = Cursors.Hand;
            customButton7.FlatAppearance.BorderSize = 0;
            customButton7.FlatStyle = FlatStyle.Flat;
            customButton7.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton7.ForeColor = Color.White;
            customButton7.Image = (Image)resources.GetObject("customButton7.Image");
            customButton7.ImageAlign = ContentAlignment.MiddleLeft;
            customButton7.Location = new Point(75, 8);
            customButton7.Name = "customButton7";
            customButton7.Size = new Size(117, 48);
            customButton7.TabIndex = 17;
            customButton7.Text = "WORK";
            customButton7.TextAlign = ContentAlignment.MiddleRight;
            customButton7.TextColor = Color.White;
            customButton7.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton7.UseVisualStyleBackColor = false;
            // 
            // customButton6
            // 
            customButton6.BackColor = Color.Black;
            customButton6.BackgroundColor = Color.Black;
            customButton6.BorderColor = Color.PaleVioletRed;
            customButton6.BorderRadius = 28;
            customButton6.BorderSize = 0;
            customButton6.Cursor = Cursors.Hand;
            customButton6.FlatAppearance.BorderSize = 0;
            customButton6.FlatStyle = FlatStyle.Flat;
            customButton6.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton6.ForeColor = Color.White;
            customButton6.Image = (Image)resources.GetObject("customButton6.Image");
            customButton6.ImageAlign = ContentAlignment.MiddleLeft;
            customButton6.Location = new Point(12, 3);
            customButton6.Name = "customButton6";
            customButton6.Size = new Size(60, 60);
            customButton6.TabIndex = 16;
            customButton6.TextAlign = ContentAlignment.MiddleRight;
            customButton6.TextColor = Color.White;
            customButton6.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton6.UseVisualStyleBackColor = false;
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.FromArgb(59, 56, 56);
            customPanel1.BackgroundColor = Color.Transparent;
            customPanel1.BorderColor = Color.Black;
            customPanel1.BorderRadius = 0;
            customPanel1.BorderWidth = 1;
            customPanel1.Controls.Add(button3);
            customPanel1.Controls.Add(button2);
            customPanel1.GradientAngle = 0F;
            customPanel1.GradientEndColor = Color.White;
            customPanel1.GradientStartColor = Color.White;
            customPanel1.Location = new Point(0, 62);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(1382, 48);
            customPanel1.TabIndex = 3;
            customPanel1.Paint += customPanel1_Paint;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(3, 1);
            button3.Name = "button3";
            button3.Size = new Size(264, 44);
            button3.TabIndex = 6;
            button3.Text = "ACTIVED ACCOUNT";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(270, 1);
            button2.Name = "button2";
            button2.Size = new Size(258, 44);
            button2.TabIndex = 5;
            button2.Text = "INACTIVED ACCOUNT";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(42, 42, 42);
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Location = new Point(419, 166);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(35, 35);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 47;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.FromArgb(42, 42, 42);
            searchBox.BorderStyle = BorderStyle.None;
            searchBox.Cursor = Cursors.IBeam;
            searchBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchBox.ForeColor = Color.White;
            searchBox.Location = new Point(41, 171);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Enter an account name...";
            searchBox.Size = new Size(375, 20);
            searchBox.TabIndex = 46;
            searchBox.TextChanged += textBox2_TextChanged;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.FromArgb(42, 42, 42);
            customButton1.BackgroundColor = Color.FromArgb(42, 42, 42);
            customButton1.BorderColor = Color.White;
            customButton1.BorderRadius = 8;
            customButton1.BorderSize = 1;
            customButton1.Enabled = false;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(10, 156);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(456, 50);
            customButton1.TabIndex = 48;
            customButton1.TextColor = Color.White;
            customButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(482, 134);
            label2.Name = "label2";
            label2.Size = new Size(143, 19);
            label2.TabIndex = 53;
            label2.Text = "DEPARTMENT";
            // 
            // departmentsBox
            // 
            departmentsBox.BackColor = Color.FromArgb(42, 42, 42);
            departmentsBox.BorderColor = Color.FromArgb(42, 42, 42);
            departmentsBox.BorderSize = 1;
            departmentsBox.Cursor = Cursors.Hand;
            departmentsBox.DropDownStyle = ComboBoxStyle.DropDown;
            departmentsBox.Font = new Font("Segoe UI", 10F);
            departmentsBox.ForeColor = Color.DimGray;
            departmentsBox.IconColor = Color.White;
            departmentsBox.ListBackColor = Color.FromArgb(230, 228, 245);
            departmentsBox.ListTextColor = Color.DimGray;
            departmentsBox.Location = new Point(493, 163);
            departmentsBox.MinimumSize = new Size(200, 30);
            departmentsBox.Name = "departmentsBox";
            departmentsBox.Padding = new Padding(1);
            departmentsBox.Size = new Size(282, 36);
            departmentsBox.TabIndex = 54;
            departmentsBox.Texts = "";
            departmentsBox.OnSelectedIndexChanged += departmentsBox_OnSelectedIndexChanged;
            // 
            // customButton2
            // 
            customButton2.BackColor = Color.FromArgb(42, 42, 42);
            customButton2.BackgroundColor = Color.FromArgb(42, 42, 42);
            customButton2.BorderColor = Color.White;
            customButton2.BorderRadius = 8;
            customButton2.BorderSize = 1;
            customButton2.Enabled = false;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.ForeColor = Color.White;
            customButton2.Location = new Point(482, 156);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(304, 50);
            customButton2.TabIndex = 55;
            customButton2.TextColor = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            // 
            // typeAccountBox
            // 
            typeAccountBox.BackColor = Color.FromArgb(42, 42, 42);
            typeAccountBox.BorderColor = Color.FromArgb(42, 42, 42);
            typeAccountBox.BorderSize = 1;
            typeAccountBox.Cursor = Cursors.Hand;
            typeAccountBox.DropDownStyle = ComboBoxStyle.DropDown;
            typeAccountBox.Font = new Font("Segoe UI", 10F);
            typeAccountBox.ForeColor = Color.DimGray;
            typeAccountBox.IconColor = Color.White;
            typeAccountBox.Items.AddRange(new object[] { "CEO", "Manager", "Staff", "All" });
            typeAccountBox.ListBackColor = Color.FromArgb(230, 228, 245);
            typeAccountBox.ListTextColor = Color.DimGray;
            typeAccountBox.Location = new Point(812, 163);
            typeAccountBox.MinimumSize = new Size(200, 30);
            typeAccountBox.Name = "typeAccountBox";
            typeAccountBox.Padding = new Padding(1);
            typeAccountBox.Size = new Size(282, 36);
            typeAccountBox.TabIndex = 57;
            typeAccountBox.Texts = "";
            typeAccountBox.OnSelectedIndexChanged += typeAccountBox_OnSelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(801, 134);
            label3.Name = "label3";
            label3.Size = new Size(159, 19);
            label3.TabIndex = 56;
            label3.Text = "TYPE ACCOUNT";
            // 
            // customButton3
            // 
            customButton3.BackColor = Color.FromArgb(42, 42, 42);
            customButton3.BackgroundColor = Color.FromArgb(42, 42, 42);
            customButton3.BorderColor = Color.White;
            customButton3.BorderRadius = 8;
            customButton3.BorderSize = 1;
            customButton3.Enabled = false;
            customButton3.FlatAppearance.BorderSize = 0;
            customButton3.FlatStyle = FlatStyle.Flat;
            customButton3.ForeColor = Color.White;
            customButton3.Location = new Point(801, 156);
            customButton3.Name = "customButton3";
            customButton3.Size = new Size(304, 50);
            customButton3.TabIndex = 58;
            customButton3.TextColor = Color.White;
            customButton3.UseVisualStyleBackColor = false;
            // 
            // customButton19
            // 
            customButton19.BackColor = Color.Black;
            customButton19.BackgroundColor = Color.Black;
            customButton19.BorderColor = Color.PaleVioletRed;
            customButton19.BorderRadius = 28;
            customButton19.BorderSize = 0;
            customButton19.Cursor = Cursors.Hand;
            customButton19.FlatAppearance.BorderSize = 0;
            customButton19.FlatStyle = FlatStyle.Flat;
            customButton19.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton19.ForeColor = Color.White;
            customButton19.Image = (Image)resources.GetObject("customButton19.Image");
            customButton19.ImageAlign = ContentAlignment.MiddleLeft;
            customButton19.Location = new Point(1116, 153);
            customButton19.Name = "customButton19";
            customButton19.Padding = new Padding(12, 0, 0, 0);
            customButton19.Size = new Size(155, 59);
            customButton19.TabIndex = 59;
            customButton19.Text = "CREATE";
            customButton19.TextAlign = ContentAlignment.MiddleRight;
            customButton19.TextColor = Color.White;
            customButton19.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton19.UseVisualStyleBackColor = false;
            customButton19.Click += customButton19_Click;
            // 
            // membersGrid
            // 
            membersGrid.AllowUserToAddRows = false;
            membersGrid.AllowUserToResizeColumns = false;
            membersGrid.AllowUserToResizeRows = false;
            membersGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            membersGrid.BackgroundColor = Color.FromArgb(24, 23, 23);
            membersGrid.BorderStyle = BorderStyle.None;
            membersGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(24, 23, 23);
            dataGridViewCellStyle1.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            membersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            membersGrid.ColumnHeadersHeight = 50;
            membersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(24, 23, 23);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(46, 48, 50);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            membersGrid.DefaultCellStyle = dataGridViewCellStyle2;
            membersGrid.EnableHeadersVisualStyles = false;
            membersGrid.GridColor = Color.FromArgb(24, 23, 23);
            membersGrid.Location = new Point(10, 224);
            membersGrid.Name = "membersGrid";
            membersGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            membersGrid.RowHeadersVisible = false;
            membersGrid.RowHeadersWidth = 51;
            membersGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            membersGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            membersGrid.Size = new Size(1357, 517);
            membersGrid.TabIndex = 60;
            membersGrid.CellContentClick += membersGrid_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 134);
            label1.Name = "label1";
            label1.Size = new Size(91, 19);
            label1.TabIndex = 49;
            label1.Text = "SEARCH";
            // 
            // customButton4
            // 
            customButton4.BackColor = Color.Black;
            customButton4.BackgroundColor = Color.Black;
            customButton4.BorderColor = Color.PaleVioletRed;
            customButton4.BorderRadius = 28;
            customButton4.BorderSize = 0;
            customButton4.Cursor = Cursors.Hand;
            customButton4.FlatAppearance.BorderSize = 0;
            customButton4.FlatStyle = FlatStyle.Flat;
            customButton4.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton4.ForeColor = Color.White;
            customButton4.Image = (Image)resources.GetObject("customButton4.Image");
            customButton4.ImageAlign = ContentAlignment.MiddleLeft;
            customButton4.Location = new Point(1277, 151);
            customButton4.Name = "customButton4";
            customButton4.Padding = new Padding(12, 0, 0, 0);
            customButton4.Size = new Size(79, 59);
            customButton4.TabIndex = 61;
            customButton4.TextColor = Color.White;
            customButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton4.UseVisualStyleBackColor = false;
            customButton4.Click += customButton4_Click;
            // 
            // C_AccountManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 32);
            ClientSize = new Size(1382, 753);
            Controls.Add(customButton4);
            Controls.Add(membersGrid);
            Controls.Add(customButton19);
            Controls.Add(typeAccountBox);
            Controls.Add(label3);
            Controls.Add(customButton3);
            Controls.Add(departmentsBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox6);
            Controls.Add(searchBox);
            Controls.Add(customPanel1);
            Controls.Add(headerPanel);
            Controls.Add(customButton1);
            Controls.Add(customButton2);
            Name = "C_AccountManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "C_AccountManagement";
            Load += C_AccountManagement_Load;
            headerPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)currentAvatarSmall).EndInit();
            customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)membersGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel headerPanel;
        private CustomComponent.CustomButton customButton18;
        private CustomComponent.CustomButton customButton17;
        private CustomComponent.CustomButton customButton12;
        private CustomComponent.CustomButton customButton11;
        private CustomComponent.CustomButton customButton10;
        private CustomComponent.CustomButton customButton9;
        private CustomComponent.CustomButton customButton8;
        private CustomComponent.CustomButton customButton7;
        private CustomComponent.CustomButton customButton6;
        private CustomComponent.CustomPanel customPanel1;
        private Button button2;
        private PictureBox pictureBox6;
        private TextBox searchBox;
        private CustomComponent.CustomButton customButton1;
        private Label label2;
        private CustomComponent.CustomComboBox departmentsBox;
        private CustomComponent.CustomButton customButton2;
        private CustomComponent.CustomComboBox typeAccountBox;
        private Label label3;
        private CustomComponent.CustomButton customButton3;
        private CustomComponent.CustomButton customButton19;
        private DataGridView membersGrid;
        private Label label1;
        private Button button3;
        private CustomComponent.CustomButton customButton4;
        private Panel panel2;
        private CustomComponent.CustomPictureBox currentAvatarSmall;
        private CustomComponent.CustomButton customButton22;
    }
}