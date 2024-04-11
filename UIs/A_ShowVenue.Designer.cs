namespace UIs
{
    partial class A_ShowVenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_ShowVenue));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            elipseControl1 = new CustomComponent.ElipseControl();
            customButton10 = new CustomComponent.CustomButton();
            cancelButton = new CustomComponent.CustomButton();
            saveButton = new CustomComponent.CustomButton();
            venuesGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)venuesGrid).BeginInit();
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
            customButton10.Text = "WORKPLACE";
            customButton10.TextAlign = ContentAlignment.MiddleRight;
            customButton10.TextColor = Color.Yellow;
            customButton10.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton10.UseVisualStyleBackColor = false;
            customButton10.Click += customButton10_Click;
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
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(35, 211, 35);
            saveButton.BackgroundColor = Color.FromArgb(35, 211, 35);
            saveButton.BorderColor = Color.PaleVioletRed;
            saveButton.BorderRadius = 12;
            saveButton.BorderSize = 0;
            saveButton.Cursor = Cursors.Hand;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(635, 387);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(122, 48);
            saveButton.TabIndex = 54;
            saveButton.Text = "SAVE";
            saveButton.TextColor = Color.White;
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // venuesGrid
            // 
            venuesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            venuesGrid.BackgroundColor = Color.FromArgb(24, 23, 23);
            venuesGrid.BorderStyle = BorderStyle.None;
            venuesGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(24, 23, 23);
            dataGridViewCellStyle1.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            venuesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            venuesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(24, 23, 23);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(46, 48, 50);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            venuesGrid.DefaultCellStyle = dataGridViewCellStyle2;
            venuesGrid.EnableHeadersVisualStyles = false;
            venuesGrid.GridColor = Color.FromArgb(24, 23, 23);
            venuesGrid.Location = new Point(12, 73);
            venuesGrid.Name = "venuesGrid";
            venuesGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            venuesGrid.RowHeadersVisible = false;
            venuesGrid.RowHeadersWidth = 51;
            venuesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            venuesGrid.Size = new Size(776, 301);
            venuesGrid.TabIndex = 55;
            venuesGrid.CellClick += venuesGrid_CellContentClick;
            venuesGrid.CellContentClick += venuesGrid_CellContentClick;
            // 
            // A_ShowVenue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 23, 23);
            ClientSize = new Size(800, 450);
            Controls.Add(venuesGrid);
            Controls.Add(saveButton);
            Controls.Add(cancelButton);
            Controls.Add(customButton10);
            ForeColor = Color.CornflowerBlue;
            FormBorderStyle = FormBorderStyle.None;
            Name = "A_ShowVenue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "A_ShowMember";
            Load += A_ShowVenue_Load;
            ((System.ComponentModel.ISupportInitialize)venuesGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomComponent.ElipseControl elipseControl1;
        private CustomComponent.CustomButton customButton10;
        private CustomComponent.CustomButton cancelButton;
        private CustomComponent.CustomButton saveButton;
        private DataGridView venuesGrid;
    }
}