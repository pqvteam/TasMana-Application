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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_Statistic));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            staffSortContainer = new CustomComponent.CustomPanel();
            typeBox = new CustomComponent.CustomComboBox();
            typeLabel = new Label();
            customButton12 = new CustomComponent.CustomButton();
            filterLabel = new Label();
            taskCompeleteRateBox = new CustomComponent.CustomComboBox();
            taskCompleteRate = new Label();
            customButton3 = new CustomComponent.CustomButton();
            label1 = new Label();
            label2 = new Label();
            billLabel = new Label();
            apartmentBox = new CustomComponent.CustomComboBox();
            repairLabel = new Label();
            customButton8 = new CustomComponent.CustomButton();
            customPanel1 = new CustomComponent.CustomPanel();
            sContent = new Label();
            label12 = new Label();
            nContent = new Label();
            aContent = new Label();
            oContent = new Label();
            mContent = new Label();
            cancelButton = new CustomComponent.CustomButton();
            dContent = new Label();
            wContent = new Label();
            eContent = new Label();
            enwContent = new Label();
            label11 = new Label();
            label5 = new Label();
            label7 = new Label();
            label4 = new Label();
            apartmentStatusLabel = new Label();
            label3 = new Label();
            managementLabel = new Label();
            label6 = new Label();
            customButton4 = new CustomComponent.CustomButton();
            customPanel2 = new CustomComponent.CustomPanel();
            timePanel = new CustomComponent.CustomPanel();
            label9 = new Label();
            label10 = new Label();
            yearButton = new RadioButton();
            glassPicture = new PictureBox();
            monthButton = new RadioButton();
            quarterButton = new RadioButton();
            timeBox = new TextBox();
            dayButton = new RadioButton();
            timePanelBox = new CustomComponent.CustomButton();
            ((System.ComponentModel.ISupportInitialize)customPictureBox1).BeginInit();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)membersGrid).BeginInit();
            staffSortContainer.SuspendLayout();
            customPanel1.SuspendLayout();
            customPanel2.SuspendLayout();
            timePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)glassPicture).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(13, 13, 13);
            headerPanel.Controls.Add(panel1);
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
            membersGrid.Location = new Point(22, 20);
            membersGrid.Name = "membersGrid";
            membersGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            membersGrid.RowHeadersVisible = false;
            membersGrid.RowHeadersWidth = 51;
            membersGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            membersGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            membersGrid.Size = new Size(427, 178);
            membersGrid.TabIndex = 62;
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 30;
            elipseControl1.TargetControl = this;
            // 
            // staffSortContainer
            // 
            staffSortContainer.BackColor = Color.FromArgb(42, 42, 42);
            staffSortContainer.BackgroundColor = Color.Transparent;
            staffSortContainer.BorderColor = Color.Black;
            staffSortContainer.BorderRadius = 20;
            staffSortContainer.BorderWidth = 1;
            staffSortContainer.Controls.Add(typeBox);
            staffSortContainer.Controls.Add(typeLabel);
            staffSortContainer.Controls.Add(customButton12);
            staffSortContainer.Controls.Add(filterLabel);
            staffSortContainer.Controls.Add(taskCompeleteRateBox);
            staffSortContainer.Controls.Add(taskCompleteRate);
            staffSortContainer.Controls.Add(customButton3);
            staffSortContainer.GradientAngle = 0F;
            staffSortContainer.GradientEndColor = Color.White;
            staffSortContainer.GradientStartColor = Color.White;
            staffSortContainer.Location = new Point(25, 104);
            staffSortContainer.Name = "staffSortContainer";
            staffSortContainer.Size = new Size(864, 135);
            staffSortContainer.TabIndex = 113;
            // 
            // typeBox
            // 
            typeBox.BackColor = Color.FromArgb(42, 42, 42);
            typeBox.BorderColor = Color.FromArgb(42, 42, 42);
            typeBox.BorderSize = 1;
            typeBox.Cursor = Cursors.Hand;
            typeBox.DropDownStyle = ComboBoxStyle.DropDown;
            typeBox.Font = new Font("Segoe UI", 10F);
            typeBox.ForeColor = Color.White;
            typeBox.IconColor = Color.White;
            typeBox.Items.AddRange(new object[] { "STAFF", "DEPARTMENT" });
            typeBox.ListBackColor = Color.Black;
            typeBox.ListTextColor = Color.White;
            typeBox.Location = new Point(34, 70);
            typeBox.MinimumSize = new Size(200, 30);
            typeBox.Name = "typeBox";
            typeBox.Padding = new Padding(1);
            typeBox.Size = new Size(377, 36);
            typeBox.TabIndex = 125;
            typeBox.Texts = "";
            typeBox.OnSelectedIndexChanged += typeBox_OnSelectedIndexChanged;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            typeLabel.ForeColor = Color.White;
            typeLabel.Location = new Point(20, 41);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(62, 19);
            typeLabel.TabIndex = 123;
            typeLabel.Text = "TYPE ";
            // 
            // customButton12
            // 
            customButton12.BackColor = Color.FromArgb(42, 42, 42);
            customButton12.BackgroundColor = Color.FromArgb(42, 42, 42);
            customButton12.BorderColor = Color.White;
            customButton12.BorderRadius = 8;
            customButton12.BorderSize = 1;
            customButton12.Enabled = false;
            customButton12.FlatAppearance.BorderSize = 0;
            customButton12.FlatStyle = FlatStyle.Flat;
            customButton12.ForeColor = Color.White;
            customButton12.Location = new Point(23, 63);
            customButton12.Name = "customButton12";
            customButton12.Size = new Size(399, 50);
            customButton12.TabIndex = 124;
            customButton12.TextColor = Color.White;
            customButton12.UseVisualStyleBackColor = false;
            // 
            // filterLabel
            // 
            filterLabel.AutoSize = true;
            filterLabel.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterLabel.ForeColor = Color.Yellow;
            filterLabel.Location = new Point(23, 12);
            filterLabel.Name = "filterLabel";
            filterLabel.Size = new Size(299, 23);
            filterLabel.TabIndex = 122;
            filterLabel.Text = "STAFF AND DEPARTMENT";
            // 
            // taskCompeleteRateBox
            // 
            taskCompeleteRateBox.BackColor = Color.FromArgb(42, 42, 42);
            taskCompeleteRateBox.BorderColor = Color.FromArgb(42, 42, 42);
            taskCompeleteRateBox.BorderSize = 1;
            taskCompeleteRateBox.Cursor = Cursors.Hand;
            taskCompeleteRateBox.DropDownStyle = ComboBoxStyle.DropDown;
            taskCompeleteRateBox.Font = new Font("Segoe UI", 10F);
            taskCompeleteRateBox.ForeColor = Color.White;
            taskCompeleteRateBox.IconColor = Color.White;
            taskCompeleteRateBox.Items.AddRange(new object[] { "INTIME", "EARLY", "LATE", "DISQUALIFIED" });
            taskCompeleteRateBox.ListBackColor = Color.Black;
            taskCompeleteRateBox.ListTextColor = Color.White;
            taskCompeleteRateBox.Location = new Point(450, 70);
            taskCompeleteRateBox.MinimumSize = new Size(200, 30);
            taskCompeleteRateBox.Name = "taskCompeleteRateBox";
            taskCompeleteRateBox.Padding = new Padding(1);
            taskCompeleteRateBox.Size = new Size(377, 36);
            taskCompeleteRateBox.TabIndex = 116;
            taskCompeleteRateBox.Texts = "";
            taskCompeleteRateBox.OnSelectedIndexChanged += taskCompeleteRateBox_OnSelectedIndexChanged;
            // 
            // taskCompleteRate
            // 
            taskCompleteRate.AutoSize = true;
            taskCompleteRate.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taskCompleteRate.ForeColor = Color.White;
            taskCompleteRate.Location = new Point(439, 41);
            taskCompleteRate.Name = "taskCompleteRate";
            taskCompleteRate.Size = new Size(263, 19);
            taskCompleteRate.TabIndex = 114;
            taskCompleteRate.Text = "TASK COMPLETED STATUS";
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
            customButton3.Location = new Point(439, 63);
            customButton3.Name = "customButton3";
            customButton3.Size = new Size(399, 50);
            customButton3.TabIndex = 115;
            customButton3.TextColor = Color.White;
            customButton3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(23, 12);
            label1.Name = "label1";
            label1.Size = new Size(324, 23);
            label1.TabIndex = 122;
            label1.Text = "RESIDENT AND APARTMENT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(799, 162);
            label2.Name = "label2";
            label2.Size = new Size(61, 19);
            label2.TabIndex = 120;
            label2.Text = "DEBT";
            // 
            // billLabel
            // 
            billLabel.AutoSize = true;
            billLabel.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            billLabel.ForeColor = Color.White;
            billLabel.Location = new Point(25, 162);
            billLabel.Name = "billLabel";
            billLabel.Size = new Size(305, 19);
            billLabel.TabIndex = 117;
            billLabel.Text = "ELECTRICITY AND WATER BILL";
            billLabel.Click += billLabel_Click;
            // 
            // apartmentBox
            // 
            apartmentBox.BackColor = Color.FromArgb(42, 42, 42);
            apartmentBox.BorderColor = Color.FromArgb(42, 42, 42);
            apartmentBox.BorderSize = 1;
            apartmentBox.Cursor = Cursors.Hand;
            apartmentBox.DropDownStyle = ComboBoxStyle.DropDown;
            apartmentBox.Font = new Font("Segoe UI", 10F);
            apartmentBox.ForeColor = Color.White;
            apartmentBox.IconColor = Color.White;
            apartmentBox.ListBackColor = Color.Black;
            apartmentBox.ListTextColor = Color.White;
            apartmentBox.Location = new Point(35, 77);
            apartmentBox.MinimumSize = new Size(200, 30);
            apartmentBox.Name = "apartmentBox";
            apartmentBox.Padding = new Padding(1);
            apartmentBox.Size = new Size(1271, 36);
            apartmentBox.TabIndex = 116;
            apartmentBox.Texts = "";
            apartmentBox.OnSelectedIndexChanged += apartmentBox_OnSelectedIndexChanged;
            // 
            // repairLabel
            // 
            repairLabel.AutoSize = true;
            repairLabel.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            repairLabel.ForeColor = Color.White;
            repairLabel.Location = new Point(26, 44);
            repairLabel.Name = "repairLabel";
            repairLabel.Size = new Size(130, 19);
            repairLabel.TabIndex = 114;
            repairLabel.Text = "APARTMENT";
            // 
            // customButton8
            // 
            customButton8.BackColor = Color.FromArgb(42, 42, 42);
            customButton8.BackgroundColor = Color.FromArgb(42, 42, 42);
            customButton8.BorderColor = Color.White;
            customButton8.BorderRadius = 8;
            customButton8.BorderSize = 1;
            customButton8.Enabled = false;
            customButton8.FlatAppearance.BorderSize = 0;
            customButton8.FlatStyle = FlatStyle.Flat;
            customButton8.ForeColor = Color.White;
            customButton8.Location = new Point(24, 70);
            customButton8.Name = "customButton8";
            customButton8.Size = new Size(1293, 50);
            customButton8.TabIndex = 115;
            customButton8.TextColor = Color.White;
            customButton8.UseVisualStyleBackColor = false;
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.FromArgb(42, 42, 42);
            customPanel1.BackgroundColor = Color.Transparent;
            customPanel1.BorderColor = Color.Black;
            customPanel1.BorderRadius = 20;
            customPanel1.BorderWidth = 1;
            customPanel1.Controls.Add(sContent);
            customPanel1.Controls.Add(label12);
            customPanel1.Controls.Add(nContent);
            customPanel1.Controls.Add(aContent);
            customPanel1.Controls.Add(oContent);
            customPanel1.Controls.Add(mContent);
            customPanel1.Controls.Add(cancelButton);
            customPanel1.Controls.Add(dContent);
            customPanel1.Controls.Add(wContent);
            customPanel1.Controls.Add(eContent);
            customPanel1.Controls.Add(enwContent);
            customPanel1.Controls.Add(label11);
            customPanel1.Controls.Add(label5);
            customPanel1.Controls.Add(label7);
            customPanel1.Controls.Add(label4);
            customPanel1.Controls.Add(apartmentStatusLabel);
            customPanel1.Controls.Add(label3);
            customPanel1.Controls.Add(managementLabel);
            customPanel1.Controls.Add(label1);
            customPanel1.Controls.Add(label2);
            customPanel1.Controls.Add(billLabel);
            customPanel1.Controls.Add(apartmentBox);
            customPanel1.Controls.Add(repairLabel);
            customPanel1.Controls.Add(customButton8);
            customPanel1.GradientAngle = 0F;
            customPanel1.GradientEndColor = Color.White;
            customPanel1.GradientStartColor = Color.White;
            customPanel1.Location = new Point(25, 398);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(1352, 401);
            customPanel1.TabIndex = 123;
            // 
            // sContent
            // 
            sContent.AutoSize = true;
            sContent.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sContent.ForeColor = Color.MediumTurquoise;
            sContent.Location = new Point(608, 260);
            sContent.Name = "sContent";
            sContent.Size = new Size(90, 16);
            sContent.TabIndex = 144;
            sContent.Text = "CONTENT";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Yellow;
            label12.Location = new Point(23, 133);
            label12.Name = "label12";
            label12.Size = new Size(92, 23);
            label12.TabIndex = 143;
            label12.Text = "DETAIL";
            // 
            // nContent
            // 
            nContent.AutoSize = true;
            nContent.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nContent.ForeColor = Color.MediumTurquoise;
            nContent.Location = new Point(390, 263);
            nContent.Name = "nContent";
            nContent.Size = new Size(90, 16);
            nContent.TabIndex = 141;
            nContent.Text = "CONTENT";
            // 
            // aContent
            // 
            aContent.AutoSize = true;
            aContent.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aContent.ForeColor = Color.MediumTurquoise;
            aContent.Location = new Point(30, 265);
            aContent.Name = "aContent";
            aContent.Size = new Size(90, 16);
            aContent.TabIndex = 140;
            aContent.Text = "CONTENT";
            // 
            // oContent
            // 
            oContent.AutoSize = true;
            oContent.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            oContent.ForeColor = Color.MediumTurquoise;
            oContent.Location = new Point(1212, 194);
            oContent.Name = "oContent";
            oContent.Size = new Size(90, 16);
            oContent.TabIndex = 139;
            oContent.Text = "CONTENT";
            // 
            // mContent
            // 
            mContent.AutoSize = true;
            mContent.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mContent.ForeColor = Color.MediumTurquoise;
            mContent.Location = new Point(949, 194);
            mContent.Name = "mContent";
            mContent.Size = new Size(90, 16);
            mContent.TabIndex = 138;
            mContent.Text = "CONTENT";
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FromArgb(175, 171, 171);
            cancelButton.BackgroundColor = Color.FromArgb(175, 171, 171);
            cancelButton.BorderColor = Color.PaleVioletRed;
            cancelButton.BorderRadius = 12;
            cancelButton.BorderSize = 0;
            cancelButton.Cursor = Cursors.Hand;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(1219, 342);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(122, 48);
            cancelButton.TabIndex = 126;
            cancelButton.Text = "CANCEL";
            cancelButton.TextColor = Color.White;
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // dContent
            // 
            dContent.AutoSize = true;
            dContent.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dContent.ForeColor = Color.MediumTurquoise;
            dContent.Location = new Point(805, 194);
            dContent.Name = "dContent";
            dContent.Size = new Size(90, 16);
            dContent.TabIndex = 137;
            dContent.Text = "CONTENT";
            // 
            // wContent
            // 
            wContent.AutoSize = true;
            wContent.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            wContent.ForeColor = Color.MediumTurquoise;
            wContent.Location = new Point(608, 197);
            wContent.Name = "wContent";
            wContent.Size = new Size(90, 16);
            wContent.TabIndex = 136;
            wContent.Text = "CONTENT";
            // 
            // eContent
            // 
            eContent.AutoSize = true;
            eContent.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eContent.ForeColor = Color.MediumTurquoise;
            eContent.Location = new Point(381, 197);
            eContent.Name = "eContent";
            eContent.Size = new Size(90, 16);
            eContent.TabIndex = 135;
            eContent.Text = "CONTENT";
            // 
            // enwContent
            // 
            enwContent.AutoSize = true;
            enwContent.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            enwContent.ForeColor = Color.MediumTurquoise;
            enwContent.Location = new Point(31, 197);
            enwContent.Name = "enwContent";
            enwContent.Size = new Size(90, 16);
            enwContent.TabIndex = 134;
            enwContent.Text = "CONTENT";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(606, 162);
            label11.Name = "label11";
            label11.Size = new Size(128, 19);
            label11.TabIndex = 133;
            label11.Text = "WATER BILL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(377, 162);
            label5.Name = "label5";
            label5.Size = new Size(183, 19);
            label5.TabIndex = 132;
            label5.Text = "ELECTRICITY BILL";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(608, 233);
            label7.Name = "label7";
            label7.Size = new Size(70, 19);
            label7.TabIndex = 126;
            label7.Text = "STAFF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(381, 233);
            label4.Name = "label4";
            label4.Size = new Size(140, 19);
            label4.TabIndex = 131;
            label4.Text = "NATIONALITY";
            // 
            // apartmentStatusLabel
            // 
            apartmentStatusLabel.AutoSize = true;
            apartmentStatusLabel.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            apartmentStatusLabel.ForeColor = Color.White;
            apartmentStatusLabel.Location = new Point(29, 233);
            apartmentStatusLabel.Name = "apartmentStatusLabel";
            apartmentStatusLabel.Size = new Size(208, 19);
            apartmentStatusLabel.TabIndex = 130;
            apartmentStatusLabel.Text = "APARTMENT STATUS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1211, 162);
            label3.Name = "label3";
            label3.Size = new Size(119, 19);
            label3.TabIndex = 126;
            label3.Text = "OTHER FEE";
            // 
            // managementLabel
            // 
            managementLabel.AutoSize = true;
            managementLabel.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            managementLabel.ForeColor = Color.White;
            managementLabel.Location = new Point(947, 162);
            managementLabel.Name = "managementLabel";
            managementLabel.Size = new Size(199, 19);
            managementLabel.TabIndex = 123;
            managementLabel.Text = "MANAGEMENT BILL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Yellow;
            label6.Location = new Point(904, 71);
            label6.Name = "label6";
            label6.Size = new Size(98, 23);
            label6.TabIndex = 125;
            label6.Text = "RESULT";
            // 
            // customButton4
            // 
            customButton4.BackColor = Color.FromArgb(35, 211, 35);
            customButton4.BackgroundColor = Color.FromArgb(35, 211, 35);
            customButton4.BorderColor = Color.PaleVioletRed;
            customButton4.BorderRadius = 12;
            customButton4.BorderSize = 0;
            customButton4.Cursor = Cursors.Hand;
            customButton4.FlatAppearance.BorderSize = 0;
            customButton4.FlatStyle = FlatStyle.Flat;
            customButton4.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton4.ForeColor = Color.White;
            customButton4.Location = new Point(1256, 337);
            customButton4.Name = "customButton4";
            customButton4.Size = new Size(122, 48);
            customButton4.TabIndex = 127;
            customButton4.Text = "EXPORT TO EXCEL";
            customButton4.TextColor = Color.White;
            customButton4.UseVisualStyleBackColor = false;
            // 
            // customPanel2
            // 
            customPanel2.BackColor = Color.FromArgb(24, 23, 23);
            customPanel2.BackgroundColor = Color.Transparent;
            customPanel2.BorderColor = Color.Black;
            customPanel2.BorderRadius = 20;
            customPanel2.BorderWidth = 1;
            customPanel2.Controls.Add(membersGrid);
            customPanel2.GradientAngle = 0F;
            customPanel2.GradientEndColor = Color.White;
            customPanel2.GradientStartColor = Color.White;
            customPanel2.Location = new Point(906, 104);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(471, 216);
            customPanel2.TabIndex = 152;
            // 
            // timePanel
            // 
            timePanel.BackgroundColor = Color.FromArgb(42, 42, 42);
            timePanel.BorderColor = Color.Black;
            timePanel.BorderRadius = 20;
            timePanel.BorderWidth = 1;
            timePanel.Controls.Add(label9);
            timePanel.Controls.Add(label10);
            timePanel.Controls.Add(yearButton);
            timePanel.Controls.Add(glassPicture);
            timePanel.Controls.Add(monthButton);
            timePanel.Controls.Add(quarterButton);
            timePanel.Controls.Add(timeBox);
            timePanel.Controls.Add(dayButton);
            timePanel.Controls.Add(timePanelBox);
            timePanel.GradientAngle = 0F;
            timePanel.GradientEndColor = Color.White;
            timePanel.GradientStartColor = Color.White;
            timePanel.Location = new Point(25, 251);
            timePanel.Name = "timePanel";
            timePanel.Size = new Size(864, 70);
            timePanel.TabIndex = 151;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(42, 42, 42);
            label9.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(22, 15);
            label9.Name = "label9";
            label9.Size = new Size(101, 19);
            label9.TabIndex = 147;
            label9.Text = "TIMELINE";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(42, 42, 42);
            label10.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Yellow;
            label10.Location = new Point(159, 40);
            label10.Name = "label10";
            label10.Size = new Size(456, 16);
            label10.TabIndex = 142;
            label10.Text = "(Enter number after check, format: dd, MM, qq, yyyy)";
            // 
            // yearButton
            // 
            yearButton.AutoSize = true;
            yearButton.BackColor = Color.FromArgb(42, 42, 42);
            yearButton.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yearButton.Location = new Point(513, 10);
            yearButton.Name = "yearButton";
            yearButton.Size = new Size(92, 27);
            yearButton.TabIndex = 146;
            yearButton.TabStop = true;
            yearButton.Text = "YEAR";
            yearButton.UseVisualStyleBackColor = false;
            yearButton.CheckedChanged += yearButton_CheckedChanged;
            // 
            // glassPicture
            // 
            glassPicture.BackColor = Color.FromArgb(42, 42, 42);
            glassPicture.BackgroundImage = (Image)resources.GetObject("glassPicture.BackgroundImage");
            glassPicture.Cursor = Cursors.Hand;
            glassPicture.Location = new Point(790, 17);
            glassPicture.Name = "glassPicture";
            glassPicture.Size = new Size(36, 35);
            glassPicture.SizeMode = PictureBoxSizeMode.Zoom;
            glassPicture.TabIndex = 150;
            glassPicture.TabStop = false;
            glassPicture.Click += pictureBox2_Click;
            // 
            // monthButton
            // 
            monthButton.AutoSize = true;
            monthButton.BackColor = Color.FromArgb(42, 42, 42);
            monthButton.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthButton.Location = new Point(260, 10);
            monthButton.Name = "monthButton";
            monthButton.Size = new Size(114, 27);
            monthButton.TabIndex = 145;
            monthButton.TabStop = true;
            monthButton.Text = "MONTH";
            monthButton.UseVisualStyleBackColor = false;
            monthButton.CheckedChanged += monthButton_CheckedChanged;
            // 
            // quarterButton
            // 
            quarterButton.AutoSize = true;
            quarterButton.BackColor = Color.FromArgb(42, 42, 42);
            quarterButton.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quarterButton.Location = new Point(383, 10);
            quarterButton.Name = "quarterButton";
            quarterButton.Size = new Size(124, 27);
            quarterButton.TabIndex = 144;
            quarterButton.TabStop = true;
            quarterButton.Text = "QUATER";
            quarterButton.UseVisualStyleBackColor = false;
            quarterButton.CheckedChanged += quarterButton_CheckedChanged;
            // 
            // timeBox
            // 
            timeBox.BackColor = Color.FromArgb(42, 42, 42);
            timeBox.BorderStyle = BorderStyle.None;
            timeBox.Cursor = Cursors.IBeam;
            timeBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timeBox.ForeColor = Color.White;
            timeBox.Location = new Point(640, 22);
            timeBox.Name = "timeBox";
            timeBox.PlaceholderText = "Enter time...";
            timeBox.Size = new Size(137, 20);
            timeBox.TabIndex = 149;
            // 
            // dayButton
            // 
            dayButton.AutoSize = true;
            dayButton.BackColor = Color.FromArgb(42, 42, 42);
            dayButton.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dayButton.Location = new Point(176, 10);
            dayButton.Name = "dayButton";
            dayButton.Size = new Size(78, 27);
            dayButton.TabIndex = 143;
            dayButton.TabStop = true;
            dayButton.Text = "DAY";
            dayButton.UseVisualStyleBackColor = false;
            dayButton.CheckedChanged += dayButton_CheckedChanged;
            // 
            // timePanelBox
            // 
            timePanelBox.BackColor = Color.FromArgb(42, 42, 42);
            timePanelBox.BackgroundColor = Color.FromArgb(42, 42, 42);
            timePanelBox.BorderColor = Color.White;
            timePanelBox.BorderRadius = 8;
            timePanelBox.BorderSize = 1;
            timePanelBox.Enabled = false;
            timePanelBox.FlatAppearance.BorderSize = 0;
            timePanelBox.FlatStyle = FlatStyle.Flat;
            timePanelBox.ForeColor = Color.White;
            timePanelBox.Location = new Point(625, 8);
            timePanelBox.Name = "timePanelBox";
            timePanelBox.Size = new Size(213, 50);
            timePanelBox.TabIndex = 148;
            timePanelBox.TextColor = Color.White;
            timePanelBox.UseVisualStyleBackColor = false;
            // 
            // A_Statistic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1400, 800);
            Controls.Add(customButton4);
            Controls.Add(label6);
            Controls.Add(customPanel1);
            Controls.Add(staffSortContainer);
            Controls.Add(headerPanel);
            Controls.Add(timePanel);
            Controls.Add(customPanel2);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "A_Statistic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "A_Statistic";
            Load += A_Statistic_Load;
            headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)membersGrid).EndInit();
            staffSortContainer.ResumeLayout(false);
            staffSortContainer.PerformLayout();
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            customPanel2.ResumeLayout(false);
            timePanel.ResumeLayout(false);
            timePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)glassPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private CustomComponent.CustomPanel staffSortContainer;
        private CustomComponent.CustomComboBox taskCompeleteRateBox;
        private Label taskCompleteRate;
        private CustomComponent.CustomButton customButton3;
        private Label filterLabel;
        private CustomComponent.CustomPanel customPanel1;
        private Label label1;
        private Label label2;
        private CustomComponent.CustomComboBox electricityAndWaterBillBox;
        private Label billLabel;
        private CustomComponent.CustomButton customButton7;
        private CustomComponent.CustomComboBox apartmentBox;
        private Label repairLabel;
        private CustomComponent.CustomButton customButton8;
        private Label label3;
        private CustomComponent.CustomComboBox managementBox;
        private Label managementLabel;
        private CustomComponent.CustomButton customButton10;
        private Label apartmentStatusLabel;
        private Label label7;
        private Label label4;
        private Label label6;
        private CustomComponent.CustomButton customButton4;
        private CustomComponent.CustomButton cancelButton;
        private CustomComponent.CustomComboBox typeBox;
        private Label typeLabel;
        private CustomComponent.CustomButton customButton12;
        private CustomComponent.CustomPanel customPanel2;
        private Label label11;
        private Label label5;
        private Label label12;
        private Label nContent;
        private Label aContent;
        private Label oContent;
        private Label mContent;
        private Label dContent;
        private Label wContent;
        private Label eContent;
        private Label enwContent;
        private Label sContent;
        private Label label9;
        private RadioButton yearButton;
        private RadioButton monthButton;
        private RadioButton quarterButton;
        private RadioButton dayButton;
        private CustomComponent.CustomPanel timePanel;
        private Label label10;
        private PictureBox glassPicture;
        private TextBox timeBox;
        private CustomComponent.CustomButton timePanelBox;
    }
}