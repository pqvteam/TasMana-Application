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
            headerPanel = new Panel();
            panel1 = new Panel();
            membersGrid = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)membersGrid).BeginInit();
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