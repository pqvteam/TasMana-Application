namespace UIs
{
    partial class A_Statistic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_Statistic));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            languageSelect = new CustomComponent.CustomComboBox();
            apartmentHeader = new CustomComponent.CustomButton();
            accountManagementHeader = new CustomComponent.CustomButton();
            residentServiceHeader = new CustomComponent.CustomButton();
            reportHeader = new CustomComponent.CustomButton();
            statisticHeader = new CustomComponent.CustomButton();
            workHeader = new CustomComponent.CustomButton();
            customButton6 = new CustomComponent.CustomButton();
            customPictureBox1 = new CustomComponent.CustomPictureBox();
            customButton1 = new CustomComponent.CustomButton();
            headerPanel = new Panel();
            panel1 = new Panel();
            membersGrid = new DataGridView();
            elipseControl1 = new CustomComponent.ElipseControl();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)customPictureBox1).BeginInit();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)membersGrid).BeginInit();
            SuspendLayout();
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
            languageSelect.Location = new Point(1116, 8);
            languageSelect.MinimumSize = new Size(30, 30);
            languageSelect.Name = "languageSelect";
            languageSelect.Size = new Size(141, 43);
            languageSelect.TabIndex = 34;
            languageSelect.Texts = "";
            // 
            // apartmentHeader
            // 
            apartmentHeader.BackColor = Color.Black;
            apartmentHeader.BackgroundColor = Color.Black;
            apartmentHeader.BorderColor = Color.PaleVioletRed;
            apartmentHeader.BorderRadius = 28;
            apartmentHeader.BorderSize = 0;
            apartmentHeader.Cursor = Cursors.Hand;
            apartmentHeader.FlatAppearance.BorderSize = 0;
            apartmentHeader.FlatStyle = FlatStyle.Flat;
            apartmentHeader.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            apartmentHeader.ForeColor = Color.White;
            apartmentHeader.Image = (Image)resources.GetObject("apartmentHeader.Image");
            apartmentHeader.ImageAlign = ContentAlignment.MiddleLeft;
            apartmentHeader.Location = new Point(733, 3);
            apartmentHeader.Name = "apartmentHeader";
            apartmentHeader.Size = new Size(199, 48);
            apartmentHeader.TabIndex = 31;
            apartmentHeader.Text = "APARTMENT & RESIDENT";
            apartmentHeader.TextAlign = ContentAlignment.MiddleRight;
            apartmentHeader.TextColor = Color.White;
            apartmentHeader.TextImageRelation = TextImageRelation.ImageBeforeText;
            apartmentHeader.UseVisualStyleBackColor = false;
            // 
            // accountManagementHeader
            // 
            accountManagementHeader.BackColor = Color.Black;
            accountManagementHeader.BackgroundColor = Color.Black;
            accountManagementHeader.BorderColor = Color.PaleVioletRed;
            accountManagementHeader.BorderRadius = 28;
            accountManagementHeader.BorderSize = 0;
            accountManagementHeader.Cursor = Cursors.Hand;
            accountManagementHeader.FlatAppearance.BorderSize = 0;
            accountManagementHeader.FlatStyle = FlatStyle.Flat;
            accountManagementHeader.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountManagementHeader.ForeColor = Color.White;
            accountManagementHeader.Image = (Image)resources.GetObject("accountManagementHeader.Image");
            accountManagementHeader.ImageAlign = ContentAlignment.MiddleLeft;
            accountManagementHeader.Location = new Point(514, 4);
            accountManagementHeader.Name = "accountManagementHeader";
            accountManagementHeader.Size = new Size(210, 48);
            accountManagementHeader.TabIndex = 30;
            accountManagementHeader.Text = "ACCOUNTING MANAGEMENT";
            accountManagementHeader.TextAlign = ContentAlignment.MiddleRight;
            accountManagementHeader.TextColor = Color.White;
            accountManagementHeader.TextImageRelation = TextImageRelation.ImageBeforeText;
            accountManagementHeader.UseVisualStyleBackColor = false;
            // 
            // residentServiceHeader
            // 
            residentServiceHeader.BackColor = Color.Black;
            residentServiceHeader.BackgroundColor = Color.Black;
            residentServiceHeader.BorderColor = Color.PaleVioletRed;
            residentServiceHeader.BorderRadius = 28;
            residentServiceHeader.BorderSize = 0;
            residentServiceHeader.Cursor = Cursors.Hand;
            residentServiceHeader.FlatAppearance.BorderSize = 0;
            residentServiceHeader.FlatStyle = FlatStyle.Flat;
            residentServiceHeader.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            residentServiceHeader.ForeColor = Color.White;
            residentServiceHeader.Image = (Image)resources.GetObject("residentServiceHeader.Image");
            residentServiceHeader.ImageAlign = ContentAlignment.MiddleLeft;
            residentServiceHeader.Location = new Point(938, 1);
            residentServiceHeader.Name = "residentServiceHeader";
            residentServiceHeader.Size = new Size(172, 51);
            residentServiceHeader.TabIndex = 32;
            residentServiceHeader.Text = "RESIDENT SERVICE";
            residentServiceHeader.TextAlign = ContentAlignment.MiddleRight;
            residentServiceHeader.TextColor = Color.White;
            residentServiceHeader.TextImageRelation = TextImageRelation.ImageBeforeText;
            residentServiceHeader.UseVisualStyleBackColor = false;
            // 
            // reportHeader
            // 
            reportHeader.BackColor = Color.Black;
            reportHeader.BackgroundColor = Color.Black;
            reportHeader.BorderColor = Color.PaleVioletRed;
            reportHeader.BorderRadius = 28;
            reportHeader.BorderSize = 0;
            reportHeader.Cursor = Cursors.Hand;
            reportHeader.FlatAppearance.BorderSize = 0;
            reportHeader.FlatStyle = FlatStyle.Flat;
            reportHeader.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reportHeader.ForeColor = Color.White;
            reportHeader.Image = (Image)resources.GetObject("reportHeader.Image");
            reportHeader.ImageAlign = ContentAlignment.MiddleLeft;
            reportHeader.Location = new Point(368, 5);
            reportHeader.Name = "reportHeader";
            reportHeader.Size = new Size(146, 48);
            reportHeader.TabIndex = 29;
            reportHeader.Text = "REPORT";
            reportHeader.TextAlign = ContentAlignment.MiddleRight;
            reportHeader.TextColor = Color.White;
            reportHeader.TextImageRelation = TextImageRelation.ImageBeforeText;
            reportHeader.UseVisualStyleBackColor = false;
            // 
            // statisticHeader
            // 
            statisticHeader.BackColor = Color.Black;
            statisticHeader.BackgroundColor = Color.Black;
            statisticHeader.BorderColor = Color.PaleVioletRed;
            statisticHeader.BorderRadius = 28;
            statisticHeader.BorderSize = 0;
            statisticHeader.Cursor = Cursors.Hand;
            statisticHeader.FlatAppearance.BorderSize = 0;
            statisticHeader.FlatStyle = FlatStyle.Flat;
            statisticHeader.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statisticHeader.ForeColor = Color.Yellow;
            statisticHeader.Image = (Image)resources.GetObject("statisticHeader.Image");
            statisticHeader.ImageAlign = ContentAlignment.MiddleLeft;
            statisticHeader.Location = new Point(198, 7);
            statisticHeader.Name = "statisticHeader";
            statisticHeader.Size = new Size(163, 48);
            statisticHeader.TabIndex = 28;
            statisticHeader.Text = "STATISTIC";
            statisticHeader.TextAlign = ContentAlignment.MiddleRight;
            statisticHeader.TextColor = Color.Yellow;
            statisticHeader.TextImageRelation = TextImageRelation.ImageBeforeText;
            statisticHeader.UseVisualStyleBackColor = false;
            // 
            // workHeader
            // 
            workHeader.BackColor = Color.Black;
            workHeader.BackgroundColor = Color.Black;
            workHeader.BorderColor = Color.PaleVioletRed;
            workHeader.BorderRadius = 28;
            workHeader.BorderSize = 0;
            workHeader.Cursor = Cursors.Hand;
            workHeader.FlatAppearance.BorderSize = 0;
            workHeader.FlatStyle = FlatStyle.Flat;
            workHeader.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            workHeader.ForeColor = Color.White;
            workHeader.Image = (Image)resources.GetObject("workHeader.Image");
            workHeader.ImageAlign = ContentAlignment.MiddleLeft;
            workHeader.Location = new Point(71, 7);
            workHeader.Name = "workHeader";
            workHeader.Size = new Size(121, 48);
            workHeader.TabIndex = 27;
            workHeader.Text = "WORK";
            workHeader.TextAlign = ContentAlignment.MiddleRight;
            workHeader.TextColor = Color.White;
            workHeader.TextImageRelation = TextImageRelation.ImageBeforeText;
            workHeader.UseVisualStyleBackColor = false;
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
            customButton6.Location = new Point(6, 2);
            customButton6.Name = "customButton6";
            customButton6.Size = new Size(59, 54);
            customButton6.TabIndex = 26;
            customButton6.TextAlign = ContentAlignment.MiddleRight;
            customButton6.TextColor = Color.White;
            customButton6.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton6.UseVisualStyleBackColor = false;
            // 
            // customPictureBox1
            // 
            customPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            customPictureBox1.BorderColor = Color.RoyalBlue;
            customPictureBox1.BorderColor2 = Color.HotPink;
            customPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            customPictureBox1.BorderSize = 0;
            customPictureBox1.Cursor = Cursors.Hand;
            customPictureBox1.GradientAngle = 50F;
            customPictureBox1.Image = (Image)resources.GetObject("customPictureBox1.Image");
            customPictureBox1.Location = new Point(1280, 6);
            customPictureBox1.Name = "customPictureBox1";
            customPictureBox1.Size = new Size(49, 49);
            customPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            customPictureBox1.TabIndex = 37;
            customPictureBox1.TabStop = false;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.Black;
            customButton1.BackgroundColor = Color.Black;
            customButton1.BorderColor = Color.PaleVioletRed;
            customButton1.BorderRadius = 28;
            customButton1.BorderSize = 0;
            customButton1.Cursor = Cursors.Hand;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton1.ForeColor = Color.White;
            customButton1.Image = Properties.Resources.triangle_icon;
            customButton1.Location = new Point(1335, 3);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(51, 51);
            customButton1.TabIndex = 36;
            customButton1.TextColor = Color.White;
            customButton1.TextImageRelation = TextImageRelation.TextBeforeImage;
            customButton1.UseVisualStyleBackColor = false;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(13, 13, 13);
            headerPanel.Controls.Add(panel1);
            headerPanel.Controls.Add(customPictureBox1);
            headerPanel.Controls.Add(languageSelect);
            headerPanel.Controls.Add(accountManagementHeader);
            headerPanel.Controls.Add(customButton6);
            headerPanel.Controls.Add(apartmentHeader);
            headerPanel.Controls.Add(workHeader);
            headerPanel.Controls.Add(reportHeader);
            headerPanel.Controls.Add(residentServiceHeader);
            headerPanel.Controls.Add(customButton1);
            headerPanel.Controls.Add(statisticHeader);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1400, 59);
            headerPanel.TabIndex = 38;
            // 
            // panel1
            // 
            panel1.Location = new Point(694, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 0;
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
            membersGrid.Location = new Point(28, 271);
            membersGrid.Name = "membersGrid";
            membersGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            membersGrid.RowHeadersVisible = false;
            membersGrid.RowHeadersWidth = 51;
            membersGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            membersGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            membersGrid.Size = new Size(1345, 517);
            membersGrid.TabIndex = 62;
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 30;
            elipseControl1.TargetControl = this;
            // 
            // A_Statistic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1400, 800);
            Controls.Add(membersGrid);
            Controls.Add(headerPanel);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "A_Statistic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "A_Statistic";
            Load += A_Statistic_Load;
            ((System.ComponentModel.ISupportInitialize)customPictureBox1).EndInit();
            headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)membersGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomComponent.CustomComboBox languageSelect;
        private CustomComponent.CustomButton apartmentHeader;
        private CustomComponent.CustomButton accountManagementHeader;
        private CustomComponent.CustomButton residentServiceHeader;
        private CustomComponent.CustomButton reportHeader;
        private CustomComponent.CustomButton statisticHeader;
        private CustomComponent.CustomButton workHeader;
        private CustomComponent.CustomButton customButton6;
        private CustomComponent.CustomPictureBox customPictureBox1;
        private CustomComponent.CustomButton customButton1;
        private Panel headerPanel;
        private Panel panel1;
        private DataGridView membersGrid;
        private CustomComponent.ElipseControl elipseControl1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}