namespace UIs
{
    partial class A_ShowMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_ShowMember));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            elipseControl1 = new CustomComponent.ElipseControl();
            customButton10 = new CustomComponent.CustomButton();
            hrButton = new CustomComponent.CustomButton();
            saButton = new CustomComponent.CustomButton();
            fiButton = new CustomComponent.CustomButton();
            coButton = new CustomComponent.CustomButton();
            maButton = new CustomComponent.CustomButton();
            seButton = new CustomComponent.CustomButton();
            cancelButton = new CustomComponent.CustomButton();
            customButton8 = new CustomComponent.CustomButton();
            membersGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)membersGrid).BeginInit();
            SuspendLayout();
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 100;
            elipseControl1.TargetControl = this;
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
            customButton10.Location = new Point(243, 12);
            customButton10.Name = "customButton10";
            customButton10.Padding = new Padding(12, 0, 0, 0);
            customButton10.Size = new Size(282, 51);
            customButton10.TabIndex = 46;
            customButton10.Text = "IMPLEMENTOR";
            customButton10.TextAlign = ContentAlignment.MiddleRight;
            customButton10.TextColor = Color.Yellow;
            customButton10.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton10.UseVisualStyleBackColor = false;
            // 
            // hrButton
            // 
            hrButton.BackColor = Color.FromArgb(24, 23, 23);
            hrButton.BackgroundColor = Color.FromArgb(24, 23, 23);
            hrButton.BorderColor = Color.FromArgb(0, 190, 255);
            hrButton.BorderRadius = 0;
            hrButton.BorderSize = 2;
            hrButton.Cursor = Cursors.Hand;
            hrButton.FlatAppearance.BorderSize = 0;
            hrButton.FlatStyle = FlatStyle.Flat;
            hrButton.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hrButton.ForeColor = Color.White;
            hrButton.Location = new Point(10, 87);
            hrButton.Name = "hrButton";
            hrButton.Size = new Size(130, 50);
            hrButton.TabIndex = 47;
            hrButton.Text = "HR & RS";
            hrButton.TextColor = Color.White;
            hrButton.UseVisualStyleBackColor = false;
            hrButton.Click += hrButton_Click;
            // 
            // saButton
            // 
            saButton.BackColor = Color.FromArgb(24, 23, 23);
            saButton.BackgroundColor = Color.FromArgb(24, 23, 23);
            saButton.BorderColor = Color.FromArgb(0, 190, 255);
            saButton.BorderRadius = 0;
            saButton.BorderSize = 2;
            saButton.Cursor = Cursors.Hand;
            saButton.FlatAppearance.BorderSize = 0;
            saButton.FlatStyle = FlatStyle.Flat;
            saButton.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saButton.ForeColor = Color.White;
            saButton.Location = new Point(658, 87);
            saButton.Name = "saButton";
            saButton.Size = new Size(130, 50);
            saButton.TabIndex = 52;
            saButton.Text = "SANTINATION";
            saButton.TextColor = Color.White;
            saButton.UseVisualStyleBackColor = false;
            saButton.Click += saButton_Click;
            // 
            // fiButton
            // 
            fiButton.BackColor = Color.FromArgb(24, 23, 23);
            fiButton.BackgroundColor = Color.FromArgb(24, 23, 23);
            fiButton.BorderColor = Color.FromArgb(0, 190, 255);
            fiButton.BorderRadius = 0;
            fiButton.BorderSize = 2;
            fiButton.Cursor = Cursors.Hand;
            fiButton.FlatAppearance.BorderSize = 0;
            fiButton.FlatStyle = FlatStyle.Flat;
            fiButton.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fiButton.ForeColor = Color.White;
            fiButton.Location = new Point(528, 87);
            fiButton.Name = "fiButton";
            fiButton.Size = new Size(130, 50);
            fiButton.TabIndex = 51;
            fiButton.Text = "FINANCIAL ACOUNTING";
            fiButton.TextColor = Color.White;
            fiButton.UseVisualStyleBackColor = false;
            fiButton.Click += fiButton_Click;
            // 
            // coButton
            // 
            coButton.BackColor = Color.FromArgb(24, 23, 23);
            coButton.BackgroundColor = Color.FromArgb(24, 23, 23);
            coButton.BorderColor = Color.FromArgb(0, 190, 255);
            coButton.BorderRadius = 0;
            coButton.BorderSize = 2;
            coButton.Cursor = Cursors.Hand;
            coButton.FlatAppearance.BorderSize = 0;
            coButton.FlatStyle = FlatStyle.Flat;
            coButton.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            coButton.ForeColor = Color.White;
            coButton.Location = new Point(398, 87);
            coButton.Name = "coButton";
            coButton.Size = new Size(130, 50);
            coButton.TabIndex = 50;
            coButton.Text = "CONSTRUCTION";
            coButton.TextColor = Color.White;
            coButton.UseVisualStyleBackColor = false;
            coButton.Click += coButton_Click;
            // 
            // maButton
            // 
            maButton.BackColor = Color.FromArgb(24, 23, 23);
            maButton.BackgroundColor = Color.FromArgb(24, 23, 23);
            maButton.BorderColor = Color.FromArgb(0, 190, 255);
            maButton.BorderRadius = 0;
            maButton.BorderSize = 2;
            maButton.Cursor = Cursors.Hand;
            maButton.FlatAppearance.BorderSize = 0;
            maButton.FlatStyle = FlatStyle.Flat;
            maButton.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maButton.ForeColor = Color.White;
            maButton.Location = new Point(268, 87);
            maButton.Name = "maButton";
            maButton.Size = new Size(130, 50);
            maButton.TabIndex = 49;
            maButton.Text = "MAINTAINANCE";
            maButton.TextColor = Color.White;
            maButton.UseVisualStyleBackColor = false;
            maButton.Click += maButton_Click;
            // 
            // seButton
            // 
            seButton.BackColor = Color.FromArgb(24, 23, 23);
            seButton.BackgroundColor = Color.FromArgb(24, 23, 23);
            seButton.BorderColor = Color.FromArgb(0, 190, 255);
            seButton.BorderRadius = 0;
            seButton.BorderSize = 2;
            seButton.Cursor = Cursors.Hand;
            seButton.FlatAppearance.BorderSize = 0;
            seButton.FlatStyle = FlatStyle.Flat;
            seButton.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            seButton.ForeColor = Color.White;
            seButton.Location = new Point(138, 87);
            seButton.Name = "seButton";
            seButton.Size = new Size(130, 50);
            seButton.TabIndex = 48;
            seButton.Text = "SECURITY";
            seButton.TextColor = Color.White;
            seButton.UseVisualStyleBackColor = false;
            seButton.Click += seButton_Click;
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
            cancelButton.Location = new Point(507, 387);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(122, 48);
            cancelButton.TabIndex = 53;
            cancelButton.Text = "CANCEL";
            cancelButton.TextColor = Color.White;
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // customButton8
            // 
            customButton8.BackColor = Color.FromArgb(35, 211, 35);
            customButton8.BackgroundColor = Color.FromArgb(35, 211, 35);
            customButton8.BorderColor = Color.PaleVioletRed;
            customButton8.BorderRadius = 12;
            customButton8.BorderSize = 0;
            customButton8.Cursor = Cursors.Hand;
            customButton8.FlatAppearance.BorderSize = 0;
            customButton8.FlatStyle = FlatStyle.Flat;
            customButton8.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton8.ForeColor = Color.White;
            customButton8.Location = new Point(635, 387);
            customButton8.Name = "customButton8";
            customButton8.Size = new Size(122, 48);
            customButton8.TabIndex = 54;
            customButton8.Text = "SAVE";
            customButton8.TextColor = Color.White;
            customButton8.UseVisualStyleBackColor = false;
            customButton8.Click += saveButton_Click;
            // 
            // membersGrid
            // 
            membersGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            membersGrid.BackgroundColor = Color.FromArgb(24, 23, 23);
            membersGrid.BorderStyle = BorderStyle.None;
            membersGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(24, 23, 23);
            dataGridViewCellStyle1.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            membersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            membersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(24, 23, 23);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(46, 48, 50);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            membersGrid.DefaultCellStyle = dataGridViewCellStyle2;
            membersGrid.EnableHeadersVisualStyles = false;
            membersGrid.GridColor = Color.FromArgb(24, 23, 23);
            membersGrid.Location = new Point(12, 158);
            membersGrid.Name = "membersGrid";
            membersGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            membersGrid.RowHeadersVisible = false;
            membersGrid.RowHeadersWidth = 51;
            membersGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            membersGrid.Size = new Size(776, 223);
            membersGrid.TabIndex = 55;
            membersGrid.CellClick += membersGrid_RowContentClick;
            membersGrid.CellContentClick += membersGrid_RowContentClick;
            // 
            // A_ShowMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 23, 23);
            ClientSize = new Size(800, 450);
            Controls.Add(membersGrid);
            Controls.Add(customButton8);
            Controls.Add(cancelButton);
            Controls.Add(seButton);
            Controls.Add(maButton);
            Controls.Add(coButton);
            Controls.Add(fiButton);
            Controls.Add(saButton);
            Controls.Add(hrButton);
            Controls.Add(customButton10);
            ForeColor = Color.CornflowerBlue;
            FormBorderStyle = FormBorderStyle.None;
            Name = "A_ShowMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "A_ShowMember";
            Load += A_ShowMember_Load;
            ((System.ComponentModel.ISupportInitialize)membersGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomComponent.ElipseControl elipseControl1;
        private CustomComponent.CustomButton customButton10;
        private CustomComponent.CustomButton hrButton;
        private CustomComponent.CustomButton cancelButton;
        private CustomComponent.CustomButton seButton;
        private CustomComponent.CustomButton maButton;
        private CustomComponent.CustomButton coButton;
        private CustomComponent.CustomButton fiButton;
        private CustomComponent.CustomButton saButton;
        private CustomComponent.CustomButton customButton8;
        private DataGridView membersGrid;
    }
}