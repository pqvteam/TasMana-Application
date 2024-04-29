namespace UIs
{
    partial class A_ShowDepartment
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_ShowDepartment));
            membersGrid = new DataGridView();
            customButton8 = new CustomComponent.CustomButton();
            cancelButton = new CustomComponent.CustomButton();
            customButton10 = new CustomComponent.CustomButton();
            elipseControl1 = new CustomComponent.ElipseControl();
            ((System.ComponentModel.ISupportInitialize)membersGrid).BeginInit();
            SuspendLayout();
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
            membersGrid.Location = new Point(12, 69);
            membersGrid.Name = "membersGrid";
            membersGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            membersGrid.RowHeadersVisible = false;
            membersGrid.RowHeadersWidth = 51;
            membersGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            membersGrid.Size = new Size(776, 312);
            membersGrid.TabIndex = 59;
            membersGrid.CellContentClick += membersGrid_RowContentClick;
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
            customButton8.Location = new Point(635, 389);
            customButton8.Name = "customButton8";
            customButton8.Size = new Size(122, 48);
            customButton8.TabIndex = 58;
            customButton8.Text = "SAVE";
            customButton8.TextColor = Color.White;
            customButton8.UseVisualStyleBackColor = false;
            customButton8.Click += saveButton_Click;
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
            cancelButton.Location = new Point(507, 389);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(122, 48);
            cancelButton.TabIndex = 57;
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
            customButton10.Location = new Point(270, 21);
            customButton10.Name = "customButton10";
            customButton10.Padding = new Padding(12, 0, 0, 0);
            customButton10.Size = new Size(282, 51);
            customButton10.TabIndex = 56;
            customButton10.Text = "DEPARTMENT";
            customButton10.TextAlign = ContentAlignment.MiddleRight;
            customButton10.TextColor = Color.Yellow;
            customButton10.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton10.UseVisualStyleBackColor = false;
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 100;
            elipseControl1.TargetControl = this;
            // 
            // A_ShowDepartment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 23, 23);
            ClientSize = new Size(800, 450);
            Controls.Add(membersGrid);
            Controls.Add(customButton8);
            Controls.Add(cancelButton);
            Controls.Add(customButton10);
            FormBorderStyle = FormBorderStyle.None;
            Name = "A_ShowDepartment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "A_ShowDepartment";
            Load += A_ShowDepartment_Load;
            ((System.ComponentModel.ISupportInitialize)membersGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView membersGrid;
        private CustomComponent.CustomButton customButton8;
        private CustomComponent.CustomButton cancelButton;
        private CustomComponent.CustomButton customButton10;
        private CustomComponent.ElipseControl elipseControl1;
    }
}