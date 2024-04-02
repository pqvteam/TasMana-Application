﻿namespace UIs
{
    partial class CM_CreateGroup
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CM_CreateGroup));
            elipseControl1 = new CustomComponent.ElipseControl();
            confirmButton = new CustomComponent.CustomButton();
            cancelButton = new CustomComponent.CustomButton();
            customButton10 = new CustomComponent.CustomButton();
            membersGrid = new DataGridView();
            label1 = new Label();
            typeAccountBox = new CustomComponent.CustomComboBox();
            customButton3 = new CustomComponent.CustomButton();
            departmentsBox = new CustomComponent.CustomComboBox();
            label5 = new Label();
            label6 = new Label();
            pictureBox6 = new PictureBox();
            searchBox = new TextBox();
            headerPanel = new Panel();
            customButton18 = new CustomComponent.CustomButton();
            customButton17 = new CustomComponent.CustomButton();
            panel2 = new Panel();
            customButton14 = new CustomComponent.CustomButton();
            customButton13 = new CustomComponent.CustomButton();
            customButton12 = new CustomComponent.CustomButton();
            customButton11 = new CustomComponent.CustomButton();
            customButton1 = new CustomComponent.CustomButton();
            customButton9 = new CustomComponent.CustomButton();
            customButton8 = new CustomComponent.CustomButton();
            customButton7 = new CustomComponent.CustomButton();
            customButton6 = new CustomComponent.CustomButton();
            customButton2 = new CustomComponent.CustomButton();
            customButton4 = new CustomComponent.CustomButton();
            titleBox = new Label();
            chosenMembersBox = new CustomComponent.CustomComboBox();
            label2 = new Label();
            label3 = new Label();
            groupNameBox = new TextBox();
            customButton5 = new CustomComponent.CustomButton();
            customButton15 = new CustomComponent.CustomButton();
            customComboBox2 = new CustomComponent.CustomComboBox();
            customButton16 = new CustomComponent.CustomButton();
            ((System.ComponentModel.ISupportInitialize)membersGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            headerPanel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 20;
            elipseControl1.TargetControl = this;
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.FromArgb(35, 211, 35);
            confirmButton.BackgroundColor = Color.FromArgb(35, 211, 35);
            confirmButton.BorderColor = Color.PaleVioletRed;
            confirmButton.BorderRadius = 12;
            confirmButton.BorderSize = 0;
            confirmButton.FlatAppearance.BorderSize = 0;
            confirmButton.FlatStyle = FlatStyle.Flat;
            confirmButton.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmButton.ForeColor = Color.White;
            confirmButton.Location = new Point(1217, 741);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(122, 48);
            confirmButton.TabIndex = 81;
            confirmButton.Text = "DONE";
            confirmButton.TextColor = Color.White;
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FromArgb(175, 171, 171);
            cancelButton.BackgroundColor = Color.FromArgb(175, 171, 171);
            cancelButton.BorderColor = Color.PaleVioletRed;
            cancelButton.BorderRadius = 12;
            cancelButton.BorderSize = 0;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(1089, 741);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(122, 48);
            cancelButton.TabIndex = 80;
            cancelButton.Text = "CANCEL";
            cancelButton.TextColor = Color.White;
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // customButton10
            // 
            customButton10.BackColor = Color.Transparent;
            customButton10.BackgroundColor = Color.Transparent;
            customButton10.BorderColor = Color.PaleVioletRed;
            customButton10.BorderRadius = 28;
            customButton10.BorderSize = 0;
            customButton10.FlatAppearance.BorderSize = 0;
            customButton10.FlatStyle = FlatStyle.Flat;
            customButton10.Font = new Font("Copperplate Gothic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton10.ForeColor = Color.Yellow;
            customButton10.Image = (Image)resources.GetObject("customButton10.Image");
            customButton10.ImageAlign = ContentAlignment.MiddleLeft;
            customButton10.Location = new Point(509, 383);
            customButton10.Name = "customButton10";
            customButton10.Padding = new Padding(12, 0, 0, 0);
            customButton10.Size = new Size(289, 51);
            customButton10.TabIndex = 70;
            customButton10.Text = "CREATE GROUP";
            customButton10.TextAlign = ContentAlignment.MiddleRight;
            customButton10.TextColor = Color.Yellow;
            customButton10.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton10.UseVisualStyleBackColor = false;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(24, 23, 23);
            dataGridViewCellStyle3.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Yellow;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            membersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            membersGrid.ColumnHeadersHeight = 50;
            membersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(24, 23, 23);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(46, 48, 50);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            membersGrid.DefaultCellStyle = dataGridViewCellStyle4;
            membersGrid.EnableHeadersVisualStyles = false;
            membersGrid.GridColor = Color.FromArgb(24, 23, 23);
            membersGrid.Location = new Point(74, 339);
            membersGrid.Name = "membersGrid";
            membersGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            membersGrid.RowHeadersVisible = false;
            membersGrid.RowHeadersWidth = 51;
            membersGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            membersGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            membersGrid.Size = new Size(1264, 382);
            membersGrid.TabIndex = 87;
            membersGrid.CellContentClick += membersGrid_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(73, 307);
            label1.Name = "label1";
            label1.Size = new Size(212, 23);
            label1.TabIndex = 88;
            label1.Text = "CHOOSE MEMBER";
            // 
            // typeAccountBox
            // 
            typeAccountBox.BackColor = Color.FromArgb(42, 42, 42);
            typeAccountBox.BorderColor = Color.FromArgb(42, 42, 42);
            typeAccountBox.BorderSize = 1;
            typeAccountBox.DropDownStyle = ComboBoxStyle.DropDown;
            typeAccountBox.Font = new Font("Segoe UI", 10F);
            typeAccountBox.ForeColor = Color.DimGray;
            typeAccountBox.IconColor = Color.White;
            typeAccountBox.Items.AddRange(new object[] { "CEO", "Manager", "Staff", "All" });
            typeAccountBox.ListBackColor = Color.FromArgb(230, 228, 245);
            typeAccountBox.ListTextColor = Color.DimGray;
            typeAccountBox.Location = new Point(876, 173);
            typeAccountBox.MinimumSize = new Size(200, 30);
            typeAccountBox.Name = "typeAccountBox";
            typeAccountBox.Padding = new Padding(1);
            typeAccountBox.Size = new Size(282, 36);
            typeAccountBox.TabIndex = 101;
            typeAccountBox.Texts = "";
            typeAccountBox.Visible = false;
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
            customButton3.Location = new Point(865, 166);
            customButton3.Name = "customButton3";
            customButton3.Size = new Size(304, 50);
            customButton3.TabIndex = 102;
            customButton3.TextColor = Color.White;
            customButton3.UseVisualStyleBackColor = false;
            customButton3.Visible = false;
            // 
            // departmentsBox
            // 
            departmentsBox.BackColor = Color.FromArgb(42, 42, 42);
            departmentsBox.BorderColor = Color.FromArgb(42, 42, 42);
            departmentsBox.BorderSize = 1;
            departmentsBox.DropDownStyle = ComboBoxStyle.DropDown;
            departmentsBox.Font = new Font("Segoe UI", 10F);
            departmentsBox.ForeColor = Color.DimGray;
            departmentsBox.IconColor = Color.White;
            departmentsBox.ListBackColor = Color.FromArgb(230, 228, 245);
            departmentsBox.ListTextColor = Color.DimGray;
            departmentsBox.Location = new Point(717, 173);
            departmentsBox.MinimumSize = new Size(200, 30);
            departmentsBox.Name = "departmentsBox";
            departmentsBox.Padding = new Padding(1);
            departmentsBox.Size = new Size(613, 36);
            departmentsBox.TabIndex = 98;
            departmentsBox.Texts = "";
            departmentsBox.OnSelectedIndexChanged += departmentsBox_OnSelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(703, 144);
            label5.Name = "label5";
            label5.Size = new Size(143, 19);
            label5.TabIndex = 97;
            label5.Text = "DEPARTMENT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(74, 225);
            label6.Name = "label6";
            label6.Size = new Size(91, 19);
            label6.TabIndex = 96;
            label6.Text = "SEARCH";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(42, 42, 42);
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.Location = new Point(649, 255);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(35, 35);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 94;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.FromArgb(42, 42, 42);
            searchBox.BorderStyle = BorderStyle.None;
            searchBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchBox.ForeColor = Color.White;
            searchBox.Location = new Point(95, 262);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Enter an account name...";
            searchBox.Size = new Size(545, 20);
            searchBox.TabIndex = 93;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(13, 13, 13);
            headerPanel.Controls.Add(customButton18);
            headerPanel.Controls.Add(customButton17);
            headerPanel.Controls.Add(panel2);
            headerPanel.Controls.Add(customButton12);
            headerPanel.Controls.Add(customButton11);
            headerPanel.Controls.Add(customButton1);
            headerPanel.Controls.Add(customButton9);
            headerPanel.Controls.Add(customButton8);
            headerPanel.Controls.Add(customButton7);
            headerPanel.Controls.Add(customButton6);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1400, 62);
            headerPanel.TabIndex = 91;
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
            // panel2
            // 
            panel2.Controls.Add(customButton14);
            panel2.Controls.Add(customButton13);
            panel2.Location = new Point(1261, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(117, 59);
            panel2.TabIndex = 23;
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
            // customButton11
            // 
            customButton11.BackColor = Color.Black;
            customButton11.BackgroundColor = Color.Black;
            customButton11.BorderColor = Color.PaleVioletRed;
            customButton11.BorderRadius = 28;
            customButton11.BorderSize = 0;
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
            // customButton1
            // 
            customButton1.BackColor = Color.Black;
            customButton1.BackgroundColor = Color.Black;
            customButton1.BorderColor = Color.PaleVioletRed;
            customButton1.BorderRadius = 28;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton1.ForeColor = Color.White;
            customButton1.Image = (Image)resources.GetObject("customButton1.Image");
            customButton1.ImageAlign = ContentAlignment.MiddleLeft;
            customButton1.Location = new Point(908, 2);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(156, 51);
            customButton1.TabIndex = 20;
            customButton1.Text = "RESIDENT SERVICE";
            customButton1.TextAlign = ContentAlignment.MiddleRight;
            customButton1.TextColor = Color.White;
            customButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton1.UseVisualStyleBackColor = false;
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
            customButton6.Location = new Point(12, 3);
            customButton6.Name = "customButton6";
            customButton6.Size = new Size(57, 56);
            customButton6.TabIndex = 16;
            customButton6.TextAlign = ContentAlignment.MiddleRight;
            customButton6.TextColor = Color.White;
            customButton6.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton6.UseVisualStyleBackColor = false;
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
            customButton2.Location = new Point(72, 247);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(626, 50);
            customButton2.TabIndex = 95;
            customButton2.TextColor = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            // 
            // customButton4
            // 
            customButton4.BackColor = Color.FromArgb(42, 42, 42);
            customButton4.BackgroundColor = Color.FromArgb(42, 42, 42);
            customButton4.BorderColor = Color.White;
            customButton4.BorderRadius = 8;
            customButton4.BorderSize = 1;
            customButton4.Enabled = false;
            customButton4.FlatAppearance.BorderSize = 0;
            customButton4.FlatStyle = FlatStyle.Flat;
            customButton4.ForeColor = Color.White;
            customButton4.Location = new Point(706, 166);
            customButton4.Name = "customButton4";
            customButton4.Size = new Size(635, 50);
            customButton4.TabIndex = 99;
            customButton4.TextColor = Color.White;
            customButton4.UseVisualStyleBackColor = false;
            customButton4.Click += customButton4_Click;
            // 
            // titleBox
            // 
            titleBox.AutoSize = true;
            titleBox.Font = new Font("Copperplate Gothic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleBox.ForeColor = Color.Yellow;
            titleBox.Location = new Point(549, 75);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(290, 25);
            titleBox.TabIndex = 103;
            titleBox.Text = "CREATE NEW GROUP";
            // 
            // chosenMembersBox
            // 
            chosenMembersBox.BackColor = Color.FromArgb(42, 42, 42);
            chosenMembersBox.BorderColor = Color.FromArgb(42, 42, 42);
            chosenMembersBox.BorderSize = 1;
            chosenMembersBox.DropDownStyle = ComboBoxStyle.DropDown;
            chosenMembersBox.Font = new Font("Segoe UI", 10F);
            chosenMembersBox.ForeColor = Color.DimGray;
            chosenMembersBox.IconColor = Color.White;
            chosenMembersBox.ListBackColor = Color.FromArgb(230, 228, 245);
            chosenMembersBox.ListTextColor = Color.DimGray;
            chosenMembersBox.Location = new Point(717, 254);
            chosenMembersBox.MinimumSize = new Size(200, 30);
            chosenMembersBox.Name = "chosenMembersBox";
            chosenMembersBox.Padding = new Padding(1);
            chosenMembersBox.Size = new Size(613, 36);
            chosenMembersBox.TabIndex = 109;
            chosenMembersBox.Texts = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(703, 225);
            label2.Name = "label2";
            label2.Size = new Size(89, 19);
            label2.TabIndex = 108;
            label2.Text = "LEADER";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(74, 144);
            label3.Name = "label3";
            label3.Size = new Size(142, 19);
            label3.TabIndex = 107;
            label3.Text = "GROUP NAME";
            // 
            // groupNameBox
            // 
            groupNameBox.BackColor = Color.FromArgb(42, 42, 42);
            groupNameBox.BorderStyle = BorderStyle.None;
            groupNameBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupNameBox.ForeColor = Color.White;
            groupNameBox.Location = new Point(95, 181);
            groupNameBox.Name = "groupNameBox";
            groupNameBox.PlaceholderText = "Enter an group name...";
            groupNameBox.Size = new Size(589, 20);
            groupNameBox.TabIndex = 104;
            // 
            // customButton5
            // 
            customButton5.BackColor = Color.FromArgb(42, 42, 42);
            customButton5.BackgroundColor = Color.FromArgb(42, 42, 42);
            customButton5.BorderColor = Color.White;
            customButton5.BorderRadius = 8;
            customButton5.BorderSize = 1;
            customButton5.Enabled = false;
            customButton5.FlatAppearance.BorderSize = 0;
            customButton5.FlatStyle = FlatStyle.Flat;
            customButton5.ForeColor = Color.White;
            customButton5.Location = new Point(72, 166);
            customButton5.Name = "customButton5";
            customButton5.Size = new Size(626, 50);
            customButton5.TabIndex = 106;
            customButton5.TextColor = Color.White;
            customButton5.UseVisualStyleBackColor = false;
            // 
            // customButton15
            // 
            customButton15.BackColor = Color.FromArgb(42, 42, 42);
            customButton15.BackgroundColor = Color.FromArgb(42, 42, 42);
            customButton15.BorderColor = Color.White;
            customButton15.BorderRadius = 8;
            customButton15.BorderSize = 1;
            customButton15.Enabled = false;
            customButton15.FlatAppearance.BorderSize = 0;
            customButton15.FlatStyle = FlatStyle.Flat;
            customButton15.ForeColor = Color.White;
            customButton15.Location = new Point(706, 247);
            customButton15.Name = "customButton15";
            customButton15.Size = new Size(635, 50);
            customButton15.TabIndex = 110;
            customButton15.TextColor = Color.White;
            customButton15.UseVisualStyleBackColor = false;
            // 
            // customComboBox2
            // 
            customComboBox2.BackColor = Color.FromArgb(42, 42, 42);
            customComboBox2.BorderColor = Color.FromArgb(42, 42, 42);
            customComboBox2.BorderSize = 1;
            customComboBox2.DropDownStyle = ComboBoxStyle.DropDown;
            customComboBox2.Font = new Font("Segoe UI", 10F);
            customComboBox2.ForeColor = Color.DimGray;
            customComboBox2.IconColor = Color.White;
            customComboBox2.Items.AddRange(new object[] { "CEO", "Manager", "Staff", "All" });
            customComboBox2.ListBackColor = Color.FromArgb(230, 228, 245);
            customComboBox2.ListTextColor = Color.DimGray;
            customComboBox2.Location = new Point(876, 173);
            customComboBox2.MinimumSize = new Size(200, 30);
            customComboBox2.Name = "customComboBox2";
            customComboBox2.Padding = new Padding(1);
            customComboBox2.Size = new Size(282, 36);
            customComboBox2.TabIndex = 111;
            customComboBox2.Texts = "";
            customComboBox2.Visible = false;
            // 
            // customButton16
            // 
            customButton16.BackColor = Color.FromArgb(42, 42, 42);
            customButton16.BackgroundColor = Color.FromArgb(42, 42, 42);
            customButton16.BorderColor = Color.White;
            customButton16.BorderRadius = 8;
            customButton16.BorderSize = 1;
            customButton16.Enabled = false;
            customButton16.FlatAppearance.BorderSize = 0;
            customButton16.FlatStyle = FlatStyle.Flat;
            customButton16.ForeColor = Color.White;
            customButton16.Location = new Point(865, 166);
            customButton16.Name = "customButton16";
            customButton16.Size = new Size(304, 50);
            customButton16.TabIndex = 112;
            customButton16.TextColor = Color.White;
            customButton16.UseVisualStyleBackColor = false;
            customButton16.Visible = false;
            // 
            // CM_CreateGroup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 23, 23);
            ClientSize = new Size(1400, 800);
            Controls.Add(chosenMembersBox);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(groupNameBox);
            Controls.Add(customButton5);
            Controls.Add(customButton15);
            Controls.Add(titleBox);
            Controls.Add(departmentsBox);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(pictureBox6);
            Controls.Add(searchBox);
            Controls.Add(headerPanel);
            Controls.Add(customButton2);
            Controls.Add(customButton4);
            Controls.Add(label1);
            Controls.Add(membersGrid);
            Controls.Add(confirmButton);
            Controls.Add(cancelButton);
            Controls.Add(customButton10);
            Controls.Add(typeAccountBox);
            Controls.Add(customButton3);
            Controls.Add(customComboBox2);
            Controls.Add(customButton16);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CM_CreateGroup";
            Text = "CM_CreateGroup";
            Load += CM_CreateGroup_Load;
            ((System.ComponentModel.ISupportInitialize)membersGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            headerPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomComponent.ElipseControl elipseControl1;
        private CustomComponent.CustomButton createButton;
        private CustomComponent.CustomButton confirmButton;
        private CustomComponent.CustomButton cancelButton;
        private CustomComponent.CustomButton customButton10;
        private Label label1;
        private DataGridView membersGrid;
        private CustomComponent.CustomComboBox typeAccountBox;
        private CustomComponent.CustomButton customButton3;
        private CustomComponent.CustomComboBox departmentsBox;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox6;
        private TextBox searchBox;
        private Panel headerPanel;
        private CustomComponent.CustomButton customButton18;
        private CustomComponent.CustomButton customButton17;
        private Panel panel2;
        private CustomComponent.CustomButton customButton14;
        private CustomComponent.CustomButton customButton13;
        private CustomComponent.CustomButton customButton12;
        private CustomComponent.CustomButton customButton11;
        private CustomComponent.CustomButton customButton1;
        private CustomComponent.CustomButton customButton9;
        private CustomComponent.CustomButton customButton8;
        private CustomComponent.CustomButton customButton7;
        private CustomComponent.CustomButton customButton6;
        private CustomComponent.CustomButton customButton2;
        private CustomComponent.CustomButton customButton4;
        private Label titleBox;
        private CustomComponent.CustomComboBox chosenMembersBox;
        private Label label2;
        private Label label3;
        private TextBox groupNameBox;
        private CustomComponent.CustomButton customButton5;
        private CustomComponent.CustomButton customButton15;
        private CustomComponent.CustomComboBox customComboBox2;
        private CustomComponent.CustomButton customButton16;
    }
}