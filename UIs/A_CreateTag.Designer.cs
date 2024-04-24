namespace UIs
{
    partial class A_CreateTag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_CreateTag));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            customButton1 = new CustomComponent.CustomButton();
            label2 = new Label();
            customButton2 = new CustomComponent.CustomButton();
            customButton10 = new CustomComponent.CustomButton();
            saveButton = new CustomComponent.CustomButton();
            cancelButton = new CustomComponent.CustomButton();
            tagsGrid = new DataGridView();
            label3 = new Label();
            nameBox = new TextBox();
            descriptionBox = new TextBox();
            elipseControl1 = new CustomComponent.ElipseControl();
            ((System.ComponentModel.ISupportInitialize)tagsGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 176, 240);
            label1.Location = new Point(354, 153);
            label1.Name = "label1";
            label1.Size = new Size(142, 19);
            label1.TabIndex = 110;
            label1.Text = "DESCRIPTION";
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
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(348, 175);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(429, 197);
            customButton1.TabIndex = 112;
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 176, 240);
            label2.Location = new Point(354, 74);
            label2.Name = "label2";
            label2.Size = new Size(67, 19);
            label2.TabIndex = 107;
            label2.Text = "NAME";
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
            customButton2.Location = new Point(348, 96);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(429, 45);
            customButton2.TabIndex = 109;
            customButton2.TextColor = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            // 
            // customButton10
            // 
            customButton10.BackColor = Color.Transparent;
            customButton10.BackgroundColor = Color.Transparent;
            customButton10.BorderColor = Color.PaleVioletRed;
            customButton10.BorderRadius = 28;
            customButton10.BorderSize = 0;
            customButton10.Enabled = false;
            customButton10.FlatAppearance.BorderSize = 0;
            customButton10.FlatStyle = FlatStyle.Flat;
            customButton10.Font = new Font("Copperplate Gothic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton10.ForeColor = Color.Yellow;
            customButton10.Image = (Image)resources.GetObject("customButton10.Image");
            customButton10.ImageAlign = ContentAlignment.MiddleLeft;
            customButton10.Location = new Point(276, 12);
            customButton10.Name = "customButton10";
            customButton10.Padding = new Padding(12, 0, 0, 0);
            customButton10.Size = new Size(258, 51);
            customButton10.TabIndex = 114;
            customButton10.Text = "CREATE TAG";
            customButton10.TextColor = Color.Yellow;
            customButton10.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton10.UseVisualStyleBackColor = false;
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
            saveButton.Location = new Point(654, 390);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(122, 48);
            saveButton.TabIndex = 122;
            saveButton.Text = "SAVE";
            saveButton.TextColor = Color.White;
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
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
            cancelButton.Location = new Point(526, 390);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(122, 48);
            cancelButton.TabIndex = 121;
            cancelButton.Text = "CANCEL";
            cancelButton.TextColor = Color.White;
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // tagsGrid
            // 
            tagsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tagsGrid.BackgroundColor = Color.FromArgb(24, 23, 23);
            tagsGrid.BorderStyle = BorderStyle.None;
            tagsGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            tagsGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(24, 23, 23);
            dataGridViewCellStyle1.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tagsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tagsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(24, 23, 23);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(46, 48, 50);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tagsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            tagsGrid.EnableHeadersVisualStyles = false;
            tagsGrid.GridColor = Color.FromArgb(24, 23, 23);
            tagsGrid.Location = new Point(28, 96);
            tagsGrid.Name = "tagsGrid";
            tagsGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tagsGrid.RowHeadersVisible = false;
            tagsGrid.RowHeadersWidth = 51;
            tagsGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tagsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tagsGrid.Size = new Size(288, 276);
            tagsGrid.TabIndex = 0;
            tagsGrid.CellContentClick += tagsGrid_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 176, 240);
            label3.Location = new Point(28, 72);
            label3.Name = "label3";
            label3.Size = new Size(148, 19);
            label3.TabIndex = 118;
            label3.Text = "CURRENT TAG";
            // 
            // nameBox
            // 
            nameBox.BackColor = Color.FromArgb(42, 42, 42);
            nameBox.BorderStyle = BorderStyle.None;
            nameBox.Cursor = Cursors.IBeam;
            nameBox.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameBox.ForeColor = Color.White;
            nameBox.Location = new Point(364, 110);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(399, 19);
            nameBox.TabIndex = 119;
            // 
            // descriptionBox
            // 
            descriptionBox.BackColor = Color.FromArgb(42, 42, 42);
            descriptionBox.BorderStyle = BorderStyle.None;
            descriptionBox.Cursor = Cursors.IBeam;
            descriptionBox.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionBox.ForeColor = Color.White;
            descriptionBox.Location = new Point(364, 190);
            descriptionBox.Multiline = true;
            descriptionBox.Name = "descriptionBox";
            descriptionBox.Size = new Size(399, 170);
            descriptionBox.TabIndex = 120;
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 100;
            elipseControl1.TargetControl = this;
            // 
            // A_CreateTag
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 23, 23);
            ClientSize = new Size(800, 450);
            Controls.Add(descriptionBox);
            Controls.Add(nameBox);
            Controls.Add(label3);
            Controls.Add(tagsGrid);
            Controls.Add(saveButton);
            Controls.Add(cancelButton);
            Controls.Add(customButton10);
            Controls.Add(label1);
            Controls.Add(customButton1);
            Controls.Add(label2);
            Controls.Add(customButton2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "A_CreateTag";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "A_CreateTag";
            Load += A_CreateTag_Load;
            ((System.ComponentModel.ISupportInitialize)tagsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CustomComponent.CustomButton customButton1;
        private Label label2;
        private CustomComponent.CustomButton customButton2;
        private CustomComponent.CustomButton customButton10;
        private CustomComponent.CustomButton saveButton;
        private CustomComponent.CustomButton cancelButton;
        private DataGridView tagsGrid;
        private Label label3;
        private TextBox nameBox;
        private TextBox descriptionBox;
        private CustomComponent.ElipseControl elipseControl1;
    }
}