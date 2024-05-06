namespace UIs
{
    partial class M_Information
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(M_Information));
            headerPanel = new Panel();
            languageSelect = new CustomComponent.CustomComboBox();
            panel2 = new Panel();
            customButton22 = new CustomComponent.CustomButton();
            currentAvatarSmall = new CustomComponent.CustomPictureBox();
            customButton18 = new CustomComponent.CustomButton();
            customButton17 = new CustomComponent.CustomButton();
            customButton12 = new CustomComponent.CustomButton();
            customButton9 = new CustomComponent.CustomButton();
            customButton8 = new CustomComponent.CustomButton();
            customButton7 = new CustomComponent.CustomButton();
            customButton6 = new CustomComponent.CustomButton();
            panel1 = new Panel();
            Number = new Label();
            Email = new Label();
            CID = new Label();
            Add = new Label();
            Birth = new Label();
            Gender = new Label();
            UserName = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            customPanel2 = new CustomComponent.CustomPanel();
            EDIT = new CustomComponent.CustomButton();
            avatarBox = new CustomComponent.CustomPictureBox();
            UserID = new Label();
            heading = new Label();
            UserName1 = new Label();
            customPanel1 = new CustomComponent.CustomPanel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            headerPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)currentAvatarSmall).BeginInit();
            customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avatarBox).BeginInit();
            customPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(13, 13, 13);
            headerPanel.Controls.Add(languageSelect);
            headerPanel.Controls.Add(panel2);
            headerPanel.Controls.Add(customButton18);
            headerPanel.Controls.Add(customButton17);
            headerPanel.Controls.Add(customButton12);
            headerPanel.Controls.Add(customButton9);
            headerPanel.Controls.Add(customButton8);
            headerPanel.Controls.Add(customButton7);
            headerPanel.Controls.Add(customButton6);
            headerPanel.Controls.Add(panel1);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1382, 59);
            headerPanel.TabIndex = 21;
            // 
            // languageSelect
            // 
            languageSelect.BackColor = Color.Black;
            languageSelect.BorderColor = Color.MediumSlateBlue;
            languageSelect.BorderSize = 0;
            languageSelect.DropDownStyle = ComboBoxStyle.DropDown;
            languageSelect.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            languageSelect.ForeColor = Color.White;
            languageSelect.IconColor = Color.White;
            languageSelect.Items.AddRange(new object[] { "ENGLISH", "VIETNAMESE" });
            languageSelect.ListBackColor = Color.Black;
            languageSelect.ListTextColor = Color.White;
            languageSelect.Location = new Point(1070, 3);
            languageSelect.MinimumSize = new Size(30, 30);
            languageSelect.Name = "languageSelect";
            languageSelect.Size = new Size(132, 52);
            languageSelect.TabIndex = 54;
            languageSelect.Texts = "";
            languageSelect.OnSelectedIndexChanged += languageSelect_OnSelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(customButton22);
            panel2.Controls.Add(currentAvatarSmall);
            panel2.Location = new Point(1260, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(117, 59);
            panel2.TabIndex = 53;
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
            customButton22.TabIndex = 25;
            customButton22.TextColor = Color.White;
            customButton22.TextImageRelation = TextImageRelation.TextBeforeImage;
            customButton22.UseVisualStyleBackColor = false;
            customButton22.Click += customButton22_Click_1;
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
            // customButton18
            // 
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
            customButton18.Location = new Point(884, 5);
            customButton18.Name = "customButton18";
            customButton18.Size = new Size(188, 48);
            customButton18.TabIndex = 25;
            customButton18.Text = "APARTMENT & RESIDENT";
            customButton18.TextAlign = ContentAlignment.MiddleRight;
            customButton18.TextColor = Color.White;
            customButton18.UseVisualStyleBackColor = false;
            customButton18.Click += customButton18_Click;
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
            customButton17.ForeColor = Color.White;
            customButton17.Image = (Image)resources.GetObject("customButton17.Image");
            customButton17.ImageAlign = ContentAlignment.MiddleLeft;
            customButton17.Location = new Point(639, 8);
            customButton17.Name = "customButton17";
            customButton17.Size = new Size(202, 48);
            customButton17.TabIndex = 24;
            customButton17.Text = "ACCOUNTING MANAGEMENT";
            customButton17.TextAlign = ContentAlignment.MiddleRight;
            customButton17.TextColor = Color.White;
            customButton17.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton17.UseVisualStyleBackColor = false;
            customButton17.Click += customButton17_Click;
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
            customButton9.Location = new Point(452, 8);
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
            customButton8.Location = new Point(252, 8);
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
            customButton7.Location = new Point(100, 8);
            customButton7.Name = "customButton7";
            customButton7.Size = new Size(117, 48);
            customButton7.TabIndex = 17;
            customButton7.Text = "WORK";
            customButton7.TextAlign = ContentAlignment.MiddleRight;
            customButton7.TextColor = Color.White;
            customButton7.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton7.UseVisualStyleBackColor = false;
            customButton7.Click += customButton7_Click;
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
            customButton6.Location = new Point(12, 0);
            customButton6.Name = "customButton6";
            customButton6.Size = new Size(60, 60);
            customButton6.TabIndex = 16;
            customButton6.TextAlign = ContentAlignment.MiddleRight;
            customButton6.TextColor = Color.White;
            customButton6.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton6.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(694, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 2;
            // 
            // Number
            // 
            Number.AutoSize = true;
            Number.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Number.ForeColor = Color.White;
            Number.Location = new Point(397, 448);
            Number.Name = "Number";
            Number.Size = new Size(152, 28);
            Number.TabIndex = 28;
            Number.Text = "Phone Number";
            Number.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Email.ForeColor = Color.White;
            Email.Location = new Point(397, 398);
            Email.Name = "Email";
            Email.Size = new Size(62, 28);
            Email.TabIndex = 27;
            Email.Text = "Email";
            Email.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CID
            // 
            CID.AutoSize = true;
            CID.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CID.ForeColor = Color.White;
            CID.Location = new Point(397, 348);
            CID.Name = "CID";
            CID.Size = new Size(44, 28);
            CID.TabIndex = 26;
            CID.Text = "CID";
            CID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Add
            // 
            Add.AutoSize = true;
            Add.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add.ForeColor = Color.White;
            Add.Location = new Point(397, 298);
            Add.Name = "Add";
            Add.Size = new Size(86, 28);
            Add.TabIndex = 25;
            Add.Text = "Address";
            Add.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Birth
            // 
            Birth.AutoSize = true;
            Birth.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Birth.ForeColor = Color.White;
            Birth.Location = new Point(397, 248);
            Birth.Name = "Birth";
            Birth.Size = new Size(130, 28);
            Birth.TabIndex = 24;
            Birth.Text = "Date of birth";
            Birth.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Gender
            // 
            Gender.AutoSize = true;
            Gender.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Gender.ForeColor = Color.White;
            Gender.Location = new Point(397, 198);
            Gender.Name = "Gender";
            Gender.Size = new Size(81, 28);
            Gender.TabIndex = 23;
            Gender.Text = "Gender";
            Gender.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserName.ForeColor = Color.White;
            UserName.Location = new Point(397, 148);
            UserName.Name = "UserName";
            UserName.Size = new Size(115, 28);
            UserName.TabIndex = 22;
            UserName.Text = "User Name";
            UserName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Copperplate Gothic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(234, 448);
            label14.Name = "label14";
            label14.Size = new Size(121, 25);
            label14.TabIndex = 17;
            label14.Text = "MOBILE:";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Copperplate Gothic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(234, 348);
            label13.Name = "label13";
            label13.Size = new Size(156, 25);
            label13.TabIndex = 16;
            label13.Text = "CITIZEN ID:";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Copperplate Gothic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(234, 398);
            label12.Name = "label12";
            label12.Size = new Size(101, 25);
            label12.TabIndex = 15;
            label12.Text = "EMAIL:";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Copperplate Gothic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(234, 298);
            label11.Name = "label11";
            label11.Size = new Size(146, 25);
            label11.TabIndex = 14;
            label11.Text = "ADDRESS:";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // customPanel2
            // 
            customPanel2.BackColor = Color.FromArgb(42, 42, 42);
            customPanel2.BackgroundColor = Color.Transparent;
            customPanel2.BorderColor = Color.Black;
            customPanel2.BorderRadius = 28;
            customPanel2.BorderWidth = 1;
            customPanel2.Controls.Add(EDIT);
            customPanel2.Controls.Add(avatarBox);
            customPanel2.Controls.Add(UserID);
            customPanel2.Controls.Add(heading);
            customPanel2.Controls.Add(UserName1);
            customPanel2.GradientAngle = 0F;
            customPanel2.GradientEndColor = Color.White;
            customPanel2.GradientStartColor = Color.White;
            customPanel2.Location = new Point(12, 122);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(432, 552);
            customPanel2.TabIndex = 19;
            // 
            // EDIT
            // 
            EDIT.BackColor = Color.Green;
            EDIT.BackgroundColor = Color.Green;
            EDIT.BorderColor = Color.PaleVioletRed;
            EDIT.BorderRadius = 20;
            EDIT.BorderSize = 0;
            EDIT.Cursor = Cursors.Hand;
            EDIT.FlatAppearance.BorderSize = 0;
            EDIT.FlatStyle = FlatStyle.Flat;
            EDIT.Font = new Font("Copperplate Gothic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EDIT.ForeColor = Color.Black;
            EDIT.Location = new Point(113, 456);
            EDIT.Name = "EDIT";
            EDIT.Size = new Size(204, 45);
            EDIT.TabIndex = 7;
            EDIT.Text = "EDIT";
            EDIT.TextColor = Color.Black;
            EDIT.UseVisualStyleBackColor = false;
            EDIT.Click += EDIT_Click;
            // 
            // avatarBox
            // 
            avatarBox.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            avatarBox.BorderColor = Color.RoyalBlue;
            avatarBox.BorderColor2 = Color.HotPink;
            avatarBox.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            avatarBox.BorderSize = 2;
            avatarBox.GradientAngle = 50F;
            avatarBox.Image = (Image)resources.GetObject("avatarBox.Image");
            avatarBox.InitialImage = null;
            avatarBox.Location = new Point(94, 70);
            avatarBox.Name = "avatarBox";
            avatarBox.Size = new Size(248, 248);
            avatarBox.SizeMode = PictureBoxSizeMode.StretchImage;
            avatarBox.TabIndex = 4;
            avatarBox.TabStop = false;
            avatarBox.Click += customPictureBox1_Click;
            // 
            // UserID
            // 
            UserID.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            UserID.ForeColor = Color.White;
            UserID.Location = new Point(0, 397);
            UserID.Name = "UserID";
            UserID.Size = new Size(432, 34);
            UserID.TabIndex = 6;
            UserID.Text = "#ID";
            UserID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // heading
            // 
            heading.Font = new Font("Copperplate Gothic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            heading.ForeColor = Color.FromArgb(250, 86, 87);
            heading.Location = new Point(126, 24);
            heading.Name = "heading";
            heading.Size = new Size(191, 34);
            heading.TabIndex = 3;
            heading.Text = "MANAGER";
            heading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserName1
            // 
            UserName1.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            UserName1.ForeColor = Color.White;
            UserName1.Location = new Point(0, 338);
            UserName1.Name = "UserName1";
            UserName1.Size = new Size(432, 34);
            UserName1.TabIndex = 5;
            UserName1.Text = "#USERNAME";
            UserName1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.FromArgb(42, 42, 42);
            customPanel1.BackgroundColor = Color.Transparent;
            customPanel1.BorderColor = Color.Black;
            customPanel1.BorderRadius = 28;
            customPanel1.BorderWidth = 1;
            customPanel1.Controls.Add(Number);
            customPanel1.Controls.Add(Email);
            customPanel1.Controls.Add(CID);
            customPanel1.Controls.Add(Add);
            customPanel1.Controls.Add(Birth);
            customPanel1.Controls.Add(Gender);
            customPanel1.Controls.Add(UserName);
            customPanel1.Controls.Add(label14);
            customPanel1.Controls.Add(label13);
            customPanel1.Controls.Add(label12);
            customPanel1.Controls.Add(label11);
            customPanel1.Controls.Add(label10);
            customPanel1.Controls.Add(label9);
            customPanel1.Controls.Add(label8);
            customPanel1.Controls.Add(label7);
            customPanel1.GradientAngle = 0F;
            customPanel1.GradientEndColor = Color.White;
            customPanel1.GradientStartColor = Color.White;
            customPanel1.Location = new Point(456, 122);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(914, 552);
            customPanel1.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Copperplate Gothic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(234, 248);
            label10.Name = "label10";
            label10.Size = new Size(155, 25);
            label10.TabIndex = 13;
            label10.Text = "BIRTHDAY:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Copperplate Gothic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(234, 198);
            label9.Name = "label9";
            label9.Size = new Size(131, 25);
            label9.TabIndex = 12;
            label9.Text = "GENDER:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Copperplate Gothic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(234, 148);
            label8.Name = "label8";
            label8.Size = new Size(97, 25);
            label8.TabIndex = 11;
            label8.Text = "NAME:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Copperplate Gothic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(250, 86, 87);
            label7.Location = new Point(347, 65);
            label7.Name = "label7";
            label7.Size = new Size(317, 34);
            label7.TabIndex = 10;
            label7.Text = "PROFILE DETAILS";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Location = new Point(1073, 60);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(305, 125);
            tableLayoutPanel1.TabIndex = 65;
            tableLayoutPanel1.Visible = false;
            // 
            // label1
            // 
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Copperplate Gothic Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(5, 82);
            label1.Name = "label1";
            label1.Size = new Size(295, 38);
            label1.TabIndex = 65;
            label1.Text = "SIGN OUT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Copperplate Gothic Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(5, 42);
            label2.Name = "label2";
            label2.Size = new Size(295, 38);
            label2.TabIndex = 64;
            label2.Text = "CHANGE PASSWORD";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Copperplate Gothic Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(5, 2);
            label3.Name = "label3";
            label3.Size = new Size(295, 38);
            label3.TabIndex = 63;
            label3.Text = "INFORMATION";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // M_Information
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 32);
            ClientSize = new Size(1382, 753);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(headerPanel);
            Controls.Add(customPanel2);
            Controls.Add(customPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "M_Information";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "M_Information";
            Load += M_Information_Load;
            headerPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)currentAvatarSmall).EndInit();
            customPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)avatarBox).EndInit();
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private CustomComponent.CustomButton customButton18;
        private CustomComponent.CustomButton customButton17;
        private CustomComponent.CustomButton customButton12;
        private CustomComponent.CustomButton customButton9;
        private CustomComponent.CustomButton customButton8;
        private CustomComponent.CustomButton customButton7;
        private CustomComponent.CustomButton customButton6;
        private Panel panel1;
        private Label Number;
        private Label Email;
        private Label CID;
        private Label Add;
        private Label Birth;
        private Label Gender;
        private Label UserName;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private ContextMenuStrip contextMenuStrip1;
        private CustomComponent.CustomPanel customPanel2;
        private CustomComponent.CustomButton EDIT;
        private CustomComponent.CustomPictureBox avatarBox;
        private Label UserID;
        private Label heading;
        private Label UserName1;
        private CustomComponent.CustomPanel customPanel1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Panel panel2;
        private CustomComponent.CustomPictureBox currentAvatarSmall;
        private CustomComponent.CustomButton customButton22;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private CustomComponent.CustomComboBox languageSelect;
    }
}