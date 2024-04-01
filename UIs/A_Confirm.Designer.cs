namespace UIs
{
    partial class A_Confirm
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
            elipseControl1 = new CustomComponent.ElipseControl();
            customPanel1 = new CustomComponent.CustomPanel();
            messageText = new Label();
            confirmButton = new CustomComponent.CustomButton();
            cancelButton = new CustomComponent.CustomButton();
            customButton1 = new CustomComponent.CustomButton();
            customPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 24;
            elipseControl1.TargetControl = this;
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.FromArgb(37, 37, 37);
            customPanel1.BackgroundColor = Color.Transparent;
            customPanel1.BorderColor = Color.Black;
            customPanel1.BorderRadius = 20;
            customPanel1.BorderWidth = 1;
            customPanel1.Controls.Add(messageText);
            customPanel1.GradientAngle = 0F;
            customPanel1.GradientEndColor = Color.White;
            customPanel1.GradientStartColor = Color.White;
            customPanel1.Location = new Point(45, 63);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(820, 109);
            customPanel1.TabIndex = 0;
            customPanel1.Paint += customPanel1_Paint;
            // 
            // messageText
            // 
            messageText.AutoSize = true;
            messageText.Font = new Font("Copperplate Gothic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            messageText.ForeColor = Color.Red;
            messageText.Location = new Point(114, 37);
            messageText.Name = "messageText";
            messageText.Size = new Size(572, 25);
            messageText.TabIndex = 0;
            messageText.Text = "ARE YOU SURE TO DELETE THIS ACCOUNT?";
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.Red;
            confirmButton.BackgroundColor = Color.Red;
            confirmButton.BorderColor = Color.PaleVioletRed;
            confirmButton.BorderRadius = 12;
            confirmButton.BorderSize = 0;
            confirmButton.FlatAppearance.BorderSize = 0;
            confirmButton.FlatStyle = FlatStyle.Flat;
            confirmButton.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmButton.ForeColor = Color.White;
            confirmButton.Location = new Point(742, 187);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(122, 48);
            confirmButton.TabIndex = 58;
            confirmButton.Text = "CONTINUTE";
            confirmButton.TextColor = Color.White;
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += saveButton_Click;
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
            cancelButton.Location = new Point(614, 187);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(122, 48);
            cancelButton.TabIndex = 57;
            cancelButton.Text = "CANCEL";
            cancelButton.TextColor = Color.White;
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.Red;
            customButton1.BackgroundColor = Color.Red;
            customButton1.BorderColor = Color.PaleVioletRed;
            customButton1.BorderRadius = 12;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(860, 8);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(58, 48);
            customButton1.TabIndex = 59;
            customButton1.Text = "X";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += cancelButton_Click;
            // 
            // A_Confirm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 23, 23);
            ClientSize = new Size(925, 254);
            Controls.Add(customButton1);
            Controls.Add(confirmButton);
            Controls.Add(cancelButton);
            Controls.Add(customPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "A_Confirm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "A_Confirm";
            Load += A_Confirm_Load;
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CustomComponent.ElipseControl elipseControl1;
        private CustomComponent.CustomPanel customPanel1;
        private Label messageText;
        private CustomComponent.CustomButton confirmButton;
        private CustomComponent.CustomButton cancelButton;
        private CustomComponent.CustomButton customButton1;
    }
}