namespace UIs
{
    partial class C_InformationEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(C_InformationEdit));
            changeAvatarButton = new CustomComponent.CustomButton();
            SUBMIT = new CustomComponent.CustomButton();
            avatarBox = new CustomComponent.CustomPictureBox();
            UserID = new Label();
            UserName1 = new Label();
            customPanel1 = new CustomComponent.CustomPanel();
            Birth = new CustomComponent.CustomDateTimePicker();
            Number = new TextBox();
            Email = new TextBox();
            CID = new TextBox();
            Add = new TextBox();
            Gender = new TextBox();
            UserName = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            customPanel2 = new CustomComponent.CustomPanel();
            heading = new Label();
            customButton14 = new CustomComponent.CustomButton();
            customButton13 = new CustomComponent.CustomButton();
            customButton18 = new CustomComponent.CustomButton();
            customButton17 = new CustomComponent.CustomButton();
            headerPanel = new Panel();
            languageSelect = new CustomComponent.CustomComboBox();
            panel2 = new Panel();
            customButton12 = new CustomComponent.CustomButton();
            customButton10 = new CustomComponent.CustomButton();
            customButton9 = new CustomComponent.CustomButton();
            customButton8 = new CustomComponent.CustomButton();
            customButton7 = new CustomComponent.CustomButton();
            customButton6 = new CustomComponent.CustomButton();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)avatarBox).BeginInit();
            customPanel1.SuspendLayout();
            customPanel2.SuspendLayout();
            headerPanel.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // changeAvatarButton
            // 
            changeAvatarButton.AutoSize = true;
            changeAvatarButton.BackColor = Color.White;
            changeAvatarButton.BackgroundColor = Color.White;
            changeAvatarButton.BorderColor = Color.PaleVioletRed;
            changeAvatarButton.BorderRadius = 20;
            changeAvatarButton.BorderSize = 0;
            changeAvatarButton.FlatAppearance.BorderSize = 0;
            changeAvatarButton.FlatStyle = FlatStyle.Flat;
            changeAvatarButton.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            changeAvatarButton.ForeColor = Color.Black;
            changeAvatarButton.Image = (Image)resources.GetObject("changeAvatarButton.Image");
            changeAvatarButton.Location = new Point(270, 273);
            changeAvatarButton.Name = "changeAvatarButton";
            changeAvatarButton.Size = new Size(47, 45);
            changeAvatarButton.TabIndex = 8;
            changeAvatarButton.TextAlign = ContentAlignment.MiddleRight;
            changeAvatarButton.TextColor = Color.Black;
            changeAvatarButton.UseVisualStyleBackColor = false;
            changeAvatarButton.Click += changeAvatarButton_Click;
            // 
            // SUBMIT
            // 
            SUBMIT.BackColor = Color.Green;
            SUBMIT.BackgroundColor = Color.Green;
            SUBMIT.BorderColor = Color.PaleVioletRed;
            SUBMIT.BorderRadius = 20;
            SUBMIT.BorderSize = 0;
            SUBMIT.FlatAppearance.BorderSize = 0;
            SUBMIT.FlatStyle = FlatStyle.Flat;
            SUBMIT.Font = new Font("Copperplate Gothic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SUBMIT.ForeColor = Color.Black;
            SUBMIT.Location = new Point(113, 453);
            SUBMIT.Name = "SUBMIT";
            SUBMIT.Size = new Size(204, 45);
            SUBMIT.TabIndex = 7;
            SUBMIT.Text = "SUBMIT";
            SUBMIT.TextColor = Color.Black;
            SUBMIT.UseVisualStyleBackColor = false;
            SUBMIT.Click += SUBMIT_Click;
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
            // 
            // UserID
            // 
            UserID.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            UserID.ForeColor = Color.White;
            UserID.Location = new Point(0, 407);
            UserID.Name = "UserID";
            UserID.Size = new Size(432, 34);
            UserID.TabIndex = 6;
            UserID.Text = "#ID";
            UserID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserName1
            // 
            UserName1.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            UserName1.ForeColor = Color.White;
            UserName1.Location = new Point(0, 348);
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
            customPanel1.Controls.Add(Birth);
            customPanel1.Controls.Add(Number);
            customPanel1.Controls.Add(Email);
            customPanel1.Controls.Add(CID);
            customPanel1.Controls.Add(Add);
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
            customPanel1.TabIndex = 27;
            // 
            // Birth
            // 
            Birth.AccessibleRole = AccessibleRole.None;
            Birth.BorderColor = Color.PaleVioletRed;
            Birth.BorderSize = 0;
            Birth.CalendarFont = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Birth.CustomFormat = "";
            Birth.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Birth.Format = DateTimePickerFormat.Short;
            Birth.Location = new Point(350, 244);
            Birth.MinimumSize = new Size(0, 35);
            Birth.Name = "Birth";
            Birth.Size = new Size(414, 36);
            Birth.SkinColor = SystemColors.ScrollBar;
            Birth.TabIndex = 29;
            Birth.TextColor = Color.Black;
            // 
            // Number
            // 
            Number.BackColor = SystemColors.ScrollBar;
            Number.BorderStyle = BorderStyle.None;
            Number.Font = new Font("Calibri", 13.8F);
            Number.ForeColor = SystemColors.InfoText;
            Number.Location = new Point(350, 448);
            Number.Name = "Number";
            Number.Size = new Size(414, 29);
            Number.TabIndex = 28;
            Number.TextAlign = HorizontalAlignment.Center;
            // 
            // Email
            // 
            Email.BackColor = SystemColors.ScrollBar;
            Email.BorderStyle = BorderStyle.None;
            Email.Font = new Font("Calibri", 13.8F);
            Email.ForeColor = SystemColors.InfoText;
            Email.Location = new Point(350, 398);
            Email.Name = "Email";
            Email.Size = new Size(414, 29);
            Email.TabIndex = 27;
            Email.TextAlign = HorizontalAlignment.Center;
            // 
            // CID
            // 
            CID.BackColor = SystemColors.ScrollBar;
            CID.BorderStyle = BorderStyle.None;
            CID.Font = new Font("Calibri", 13.8F);
            CID.ForeColor = SystemColors.InfoText;
            CID.Location = new Point(350, 348);
            CID.Name = "CID";
            CID.Size = new Size(414, 29);
            CID.TabIndex = 26;
            CID.TextAlign = HorizontalAlignment.Center;
            // 
            // Add
            // 
            Add.BackColor = SystemColors.ScrollBar;
            Add.BorderStyle = BorderStyle.None;
            Add.Font = new Font("Calibri", 13.8F);
            Add.ForeColor = SystemColors.InfoText;
            Add.Location = new Point(350, 298);
            Add.Name = "Add";
            Add.Size = new Size(414, 29);
            Add.TabIndex = 25;
            Add.TextAlign = HorizontalAlignment.Center;
            // 
            // Gender
            // 
            Gender.BackColor = SystemColors.ScrollBar;
            Gender.BorderStyle = BorderStyle.None;
            Gender.Font = new Font("Calibri", 13.8F);
            Gender.ForeColor = SystemColors.InfoText;
            Gender.Location = new Point(350, 198);
            Gender.Name = "Gender";
            Gender.Size = new Size(414, 29);
            Gender.TabIndex = 23;
            Gender.TextAlign = HorizontalAlignment.Center;
            // 
            // UserName
            // 
            UserName.BackColor = SystemColors.ScrollBar;
            UserName.BorderStyle = BorderStyle.None;
            UserName.Font = new Font("Calibri", 13.8F);
            UserName.ForeColor = SystemColors.InfoText;
            UserName.Location = new Point(350, 148);
            UserName.Name = "UserName";
            UserName.Size = new Size(414, 29);
            UserName.TabIndex = 22;
            UserName.TextAlign = HorizontalAlignment.Center;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Copperplate Gothic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(191, 448);
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
            label13.Location = new Point(191, 348);
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
            label12.Location = new Point(191, 398);
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
            label11.Location = new Point(191, 298);
            label11.Name = "label11";
            label11.Size = new Size(146, 25);
            label11.TabIndex = 14;
            label11.Text = "ADDRESS:";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Copperplate Gothic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(191, 248);
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
            label9.Location = new Point(191, 198);
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
            label8.Location = new Point(191, 148);
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
            label7.Location = new Point(304, 65);
            label7.Name = "label7";
            label7.Size = new Size(317, 34);
            label7.TabIndex = 10;
            label7.Text = "PROFILE DETAILS";
            // 
            // customPanel2
            // 
            customPanel2.BackColor = Color.FromArgb(42, 42, 42);
            customPanel2.BackgroundColor = Color.Transparent;
            customPanel2.BorderColor = Color.Black;
            customPanel2.BorderRadius = 28;
            customPanel2.BorderWidth = 1;
            customPanel2.Controls.Add(changeAvatarButton);
            customPanel2.Controls.Add(SUBMIT);
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
            customPanel2.TabIndex = 26;
            // 
            // heading
            // 
            heading.AutoSize = true;
            heading.Font = new Font("Copperplate Gothic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            heading.ForeColor = Color.FromArgb(250, 86, 87);
            heading.Location = new Point(174, 28);
            heading.Name = "heading";
            heading.Size = new Size(89, 34);
            heading.TabIndex = 3;
            heading.Text = "CEO";
            // 
            // customButton14
            // 
            customButton14.BackColor = Color.Black;
            customButton14.BackgroundColor = Color.Black;
            customButton14.BorderColor = Color.PaleVioletRed;
            customButton14.BorderRadius = 28;
            customButton14.BorderSize = 0;
            customButton14.FlatAppearance.BorderSize = 0;
            customButton14.FlatStyle = FlatStyle.Flat;
            customButton14.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton14.ForeColor = Color.White;
            customButton14.Image = Properties.Resources.triangle_icon;
            customButton14.ImageAlign = ContentAlignment.MiddleRight;
            customButton14.Location = new Point(67, 4);
            customButton14.Name = "customButton14";
            customButton14.Size = new Size(39, 51);
            customButton14.TabIndex = 24;
            customButton14.TextAlign = ContentAlignment.MiddleRight;
            customButton14.TextColor = Color.White;
            customButton14.TextImageRelation = TextImageRelation.TextBeforeImage;
            customButton14.UseVisualStyleBackColor = false;
            // 
            // customButton13
            // 
            customButton13.BackColor = Color.MediumSlateBlue;
            customButton13.BackgroundColor = Color.MediumSlateBlue;
            customButton13.BorderColor = Color.Transparent;
            customButton13.BorderRadius = 28;
            customButton13.BorderSize = 0;
            customButton13.FlatAppearance.BorderSize = 0;
            customButton13.FlatStyle = FlatStyle.Flat;
            customButton13.ForeColor = Color.White;
            customButton13.Image = Properties.Resources.kimi_no_nawa;
            customButton13.Location = new Point(14, 3);
            customButton13.Name = "customButton13";
            customButton13.Size = new Size(50, 50);
            customButton13.TabIndex = 37;
            customButton13.TextColor = Color.White;
            customButton13.UseVisualStyleBackColor = false;
            // 
            // customButton18
            // 
            customButton18.AutoEllipsis = true;
            customButton18.BackColor = Color.Black;
            customButton18.BackgroundColor = Color.Black;
            customButton18.BorderColor = Color.PaleVioletRed;
            customButton18.BorderRadius = 28;
            customButton18.BorderSize = 0;
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
            customButton17.FlatAppearance.BorderSize = 0;
            customButton17.FlatStyle = FlatStyle.Flat;
            customButton17.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton17.ForeColor = Color.White;
            customButton17.Image = (Image)resources.GetObject("customButton17.Image");
            customButton17.ImageAlign = ContentAlignment.MiddleLeft;
            customButton17.Location = new Point(509, 5);
            customButton17.Name = "customButton17";
            customButton17.Size = new Size(202, 48);
            customButton17.TabIndex = 24;
            customButton17.Text = "ACCOUNTING MANAGEMENT";
            customButton17.TextAlign = ContentAlignment.MiddleRight;
            customButton17.TextColor = Color.White;
            customButton17.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton17.UseVisualStyleBackColor = false;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(13, 13, 13);
            headerPanel.Controls.Add(languageSelect);
            headerPanel.Controls.Add(customButton18);
            headerPanel.Controls.Add(customButton17);
            headerPanel.Controls.Add(panel2);
            headerPanel.Controls.Add(customButton12);
            headerPanel.Controls.Add(customButton10);
            headerPanel.Controls.Add(customButton9);
            headerPanel.Controls.Add(customButton8);
            headerPanel.Controls.Add(customButton7);
            headerPanel.Controls.Add(customButton6);
            headerPanel.Controls.Add(panel1);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1382, 59);
            headerPanel.TabIndex = 25;
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
            languageSelect.Location = new Point(1070, -1);
            languageSelect.MinimumSize = new Size(30, 30);
            languageSelect.Name = "languageSelect";
            languageSelect.Size = new Size(132, 57);
            languageSelect.TabIndex = 65;
            languageSelect.Texts = "";
            languageSelect.OnSelectedIndexChanged += languageSelect_OnSelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(customButton14);
            panel2.Controls.Add(customButton13);
            panel2.Location = new Point(1261, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(117, 59);
            panel2.TabIndex = 23;
            // 
            // customButton12
            // 
            customButton12.BackColor = Color.Black;
            customButton12.BackgroundColor = Color.Black;
            customButton12.BorderColor = Color.PaleVioletRed;
            customButton12.BorderRadius = 28;
            customButton12.BorderSize = 0;
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
            // customButton10
            // 
            customButton10.BackColor = Color.Black;
            customButton10.BackgroundColor = Color.Black;
            customButton10.BorderColor = Color.PaleVioletRed;
            customButton10.BorderRadius = 28;
            customButton10.BorderSize = 0;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Location = new Point(1073, 61);
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
            // C_InformationEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 32);
            ClientSize = new Size(1382, 753);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(customPanel1);
            Controls.Add(customPanel2);
            Controls.Add(headerPanel);
            Name = "C_InformationEdit";
            Text = "C_InformationEdit";
            Load += C_InformationEdit_Load;
            ((System.ComponentModel.ISupportInitialize)avatarBox).EndInit();
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            headerPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CustomComponent.CustomButton changeAvatarButton;
        private CustomComponent.CustomButton SUBMIT;
        private CustomComponent.CustomPictureBox avatarBox;
        private Label UserID;
        private Label UserName1;
        private CustomComponent.CustomPanel customPanel1;
        private CustomComponent.CustomDateTimePicker Birth;
        private TextBox Number;
        private TextBox Email;
        private TextBox CID;
        private TextBox Add;
        private TextBox Gender;
        private TextBox UserName;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private CustomComponent.CustomPanel customPanel2;
        private Label heading;
        private CustomComponent.CustomButton customButton14;
        private CustomComponent.CustomButton customButton13;
        private CustomComponent.CustomButton customButton18;
        private CustomComponent.CustomButton customButton17;
        private Panel headerPanel;
        private Panel panel2;
        private CustomComponent.CustomButton customButton12;
        private CustomComponent.CustomButton customButton10;
        private CustomComponent.CustomButton customButton9;
        private CustomComponent.CustomButton customButton8;
        private CustomComponent.CustomButton customButton7;
        private CustomComponent.CustomButton customButton6;
        private Panel panel1;
        private CustomComponent.CustomComboBox languageSelect;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}