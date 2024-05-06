namespace UIs
{
    partial class G_ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(G_ForgotPassword));
            button_back2 = new Button();
            button_VerifyCode = new Button();
            button_SendCode = new Button();
            box_NumericCode = new TextBox();
            box_username = new TextBox();
            panel_forgotPassword = new Panel();
            label_back = new Label();
            button1 = new Button();
            pictureBox_logo = new PictureBox();
            label_login = new Label();
            panel_verify = new Panel();
            label_Please1 = new Label();
            label_resendCode = new Label();
            label_please2 = new Label();
            pictureBox_mail = new PictureBox();
            pictureBox1 = new PictureBox();
            panel_resetPassword = new Panel();
            button_save = new Button();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            label_Please3 = new Label();
            button_back3 = new Button();
            box_confirmPassword = new TextBox();
            pictureBox3 = new PictureBox();
            box_newPassword = new TextBox();
            pictureBox5 = new PictureBox();
            customButton5 = new CustomComponent.CustomButton();
            panel_forgotPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo).BeginInit();
            panel_verify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_mail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_resetPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // button_back2
            // 
            button_back2.BackColor = Color.Transparent;
            button_back2.BackgroundImage = Properties.Resources.back_icon1;
            button_back2.BackgroundImageLayout = ImageLayout.Zoom;
            button_back2.FlatStyle = FlatStyle.Popup;
            button_back2.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_back2.Location = new Point(12, 19);
            button_back2.Name = "button_back2";
            button_back2.Size = new Size(108, 76);
            button_back2.TabIndex = 14;
            button_back2.UseVisualStyleBackColor = false;
            button_back2.Click += button_back2_Click;
            // 
            // button_VerifyCode
            // 
            button_VerifyCode.BackColor = Color.Red;
            button_VerifyCode.FlatStyle = FlatStyle.Flat;
            button_VerifyCode.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_VerifyCode.Location = new Point(172, 374);
            button_VerifyCode.Name = "button_VerifyCode";
            button_VerifyCode.Size = new Size(165, 57);
            button_VerifyCode.TabIndex = 13;
            button_VerifyCode.Text = "VERIFY";
            button_VerifyCode.UseVisualStyleBackColor = false;
            button_VerifyCode.Click += button_VerifyCode_Click;
            // 
            // button_SendCode
            // 
            button_SendCode.BackColor = Color.Red;
            button_SendCode.FlatStyle = FlatStyle.Flat;
            button_SendCode.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_SendCode.Location = new Point(182, 359);
            button_SendCode.Name = "button_SendCode";
            button_SendCode.Size = new Size(165, 57);
            button_SendCode.TabIndex = 11;
            button_SendCode.Text = "SEND";
            button_SendCode.UseVisualStyleBackColor = false;
            button_SendCode.Click += button_SendCode_Click;
            // 
            // box_NumericCode
            // 
            box_NumericCode.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Italic, GraphicsUnit.Point, 0);
            box_NumericCode.Location = new Point(102, 247);
            box_NumericCode.Name = "box_NumericCode";
            box_NumericCode.Size = new Size(340, 33);
            box_NumericCode.TabIndex = 1;
            box_NumericCode.Text = "Verification code";
            box_NumericCode.Enter += box_NumericCode_Enter;
            box_NumericCode.Leave += box_NumericCode_Leave;
            // 
            // box_username
            // 
            box_username.BackColor = SystemColors.HighlightText;
            box_username.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Italic, GraphicsUnit.Point, 0);
            box_username.Location = new Point(94, 221);
            box_username.Name = "box_username";
            box_username.Size = new Size(340, 33);
            box_username.TabIndex = 0;
            box_username.TabStop = false;
            box_username.Text = "User ID";
            box_username.Enter += box_username_Enter;
            box_username.Leave += box_username_Leave;
            // 
            // panel_forgotPassword
            // 
            panel_forgotPassword.BackgroundImage = Properties.Resources.background_input_userid;
            panel_forgotPassword.BackgroundImageLayout = ImageLayout.Stretch;
            panel_forgotPassword.Controls.Add(label_back);
            panel_forgotPassword.Controls.Add(button1);
            panel_forgotPassword.Controls.Add(pictureBox_logo);
            panel_forgotPassword.Controls.Add(button_SendCode);
            panel_forgotPassword.Controls.Add(label_login);
            panel_forgotPassword.Controls.Add(box_username);
            panel_forgotPassword.Location = new Point(938, 182);
            panel_forgotPassword.Name = "panel_forgotPassword";
            panel_forgotPassword.Size = new Size(458, 476);
            panel_forgotPassword.TabIndex = 9;
            // 
            // label_back
            // 
            label_back.AutoSize = true;
            label_back.BackColor = Color.Transparent;
            label_back.Font = new Font("Times New Roman", 16.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label_back.ForeColor = Color.White;
            label_back.Location = new Point(182, 275);
            label_back.Name = "label_back";
            label_back.Size = new Size(165, 33);
            label_back.TabIndex = 12;
            label_back.Text = "Back to login";
            label_back.Click += label_back_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.snapedit_1712151680966;
            button1.Enabled = false;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(34, 218);
            button1.Name = "button1";
            button1.Size = new Size(43, 41);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox_logo
            // 
            pictureBox_logo.BackColor = Color.Transparent;
            pictureBox_logo.Image = Properties.Resources.Picture1;
            pictureBox_logo.Location = new Point(182, 13);
            pictureBox_logo.Name = "pictureBox_logo";
            pictureBox_logo.Size = new Size(138, 90);
            pictureBox_logo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_logo.TabIndex = 8;
            pictureBox_logo.TabStop = false;
            // 
            // label_login
            // 
            label_login.AutoSize = true;
            label_login.BackColor = Color.Transparent;
            label_login.Font = new Font("Copperplate Gothic Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_login.ForeColor = Color.White;
            label_login.Location = new Point(45, 122);
            label_login.Name = "label_login";
            label_login.Size = new Size(413, 38);
            label_login.TabIndex = 0;
            label_login.Text = "FORGOT PASSWORD";
            // 
            // panel_verify
            // 
            panel_verify.BackgroundImage = Properties.Resources.background_input_userid;
            panel_verify.BackgroundImageLayout = ImageLayout.Stretch;
            panel_verify.Controls.Add(label_Please1);
            panel_verify.Controls.Add(label_resendCode);
            panel_verify.Controls.Add(label_please2);
            panel_verify.Controls.Add(button_back2);
            panel_verify.Controls.Add(button_VerifyCode);
            panel_verify.Controls.Add(pictureBox_mail);
            panel_verify.Controls.Add(pictureBox1);
            panel_verify.Controls.Add(box_NumericCode);
            panel_verify.Location = new Point(930, 206);
            panel_verify.Name = "panel_verify";
            panel_verify.Size = new Size(458, 476);
            panel_verify.TabIndex = 10;
            panel_verify.Visible = false;
            // 
            // label_Please1
            // 
            label_Please1.AutoSize = true;
            label_Please1.BackColor = Color.Transparent;
            label_Please1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Please1.ForeColor = Color.White;
            label_Please1.Location = new Point(61, 178);
            label_Please1.Name = "label_Please1";
            label_Please1.Size = new Size(381, 33);
            label_Please1.TabIndex = 15;
            label_Please1.Text = "Please enter the verification code";
            // 
            // label_resendCode
            // 
            label_resendCode.AutoSize = true;
            label_resendCode.BackColor = Color.Transparent;
            label_resendCode.Font = new Font("Times New Roman", 16.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label_resendCode.ForeColor = Color.White;
            label_resendCode.Location = new Point(181, 310);
            label_resendCode.Name = "label_resendCode";
            label_resendCode.Size = new Size(156, 33);
            label_resendCode.TabIndex = 12;
            label_resendCode.Text = "Resend code";
            label_resendCode.Click += label_resendCode_Click;
            // 
            // label_please2
            // 
            label_please2.AutoSize = true;
            label_please2.BackColor = Color.Transparent;
            label_please2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_please2.ForeColor = Color.White;
            label_please2.Location = new Point(161, 211);
            label_please2.Name = "label_please2";
            label_please2.Size = new Size(201, 33);
            label_please2.TabIndex = 14;
            label_please2.Text = "sent to your mail";
            // 
            // pictureBox_mail
            // 
            pictureBox_mail.BackColor = Color.Transparent;
            pictureBox_mail.Image = Properties.Resources.forgotpassword_icon5;
            pictureBox_mail.Location = new Point(153, 19);
            pictureBox_mail.Name = "pictureBox_mail";
            pictureBox_mail.Size = new Size(209, 158);
            pictureBox_mail.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_mail.TabIndex = 8;
            pictureBox_mail.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.forgotpassword_icon6;
            pictureBox1.Location = new Point(42, 234);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel_resetPassword
            // 
            panel_resetPassword.BackgroundImage = Properties.Resources.background_input_userid;
            panel_resetPassword.BackgroundImageLayout = ImageLayout.Stretch;
            panel_resetPassword.Controls.Add(button_save);
            panel_resetPassword.Controls.Add(pictureBox4);
            panel_resetPassword.Controls.Add(pictureBox2);
            panel_resetPassword.Controls.Add(label_Please3);
            panel_resetPassword.Controls.Add(button_back3);
            panel_resetPassword.Controls.Add(box_confirmPassword);
            panel_resetPassword.Controls.Add(pictureBox3);
            panel_resetPassword.Controls.Add(box_newPassword);
            panel_resetPassword.Location = new Point(944, 150);
            panel_resetPassword.Name = "panel_resetPassword";
            panel_resetPassword.Size = new Size(458, 476);
            panel_resetPassword.TabIndex = 11;
            panel_resetPassword.Visible = false;
            // 
            // button_save
            // 
            button_save.BackColor = Color.Red;
            button_save.FlatStyle = FlatStyle.Flat;
            button_save.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_save.Location = new Point(146, 360);
            button_save.Name = "button_save";
            button_save.Size = new Size(165, 57);
            button_save.TabIndex = 18;
            button_save.Text = "SAVE";
            button_save.UseVisualStyleBackColor = false;
            button_save.Click += button_save_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.forgotpassword_icon6;
            pictureBox4.Location = new Point(12, 291);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(45, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.forgotpassword_icon31;
            pictureBox2.Location = new Point(12, 228);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // label_Please3
            // 
            label_Please3.AutoSize = true;
            label_Please3.BackColor = Color.Transparent;
            label_Please3.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Please3.ForeColor = Color.White;
            label_Please3.Location = new Point(78, 186);
            label_Please3.Name = "label_Please3";
            label_Please3.Size = new Size(313, 33);
            label_Please3.TabIndex = 16;
            label_Please3.Text = "Please reset your password";
            // 
            // button_back3
            // 
            button_back3.BackColor = Color.Transparent;
            button_back3.BackgroundImage = Properties.Resources.back_icon1;
            button_back3.BackgroundImageLayout = ImageLayout.Zoom;
            button_back3.FlatStyle = FlatStyle.Popup;
            button_back3.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_back3.Location = new Point(16, 13);
            button_back3.Name = "button_back3";
            button_back3.Size = new Size(108, 76);
            button_back3.TabIndex = 16;
            button_back3.UseVisualStyleBackColor = false;
            button_back3.Click += button_back3_Click;
            // 
            // box_confirmPassword
            // 
            box_confirmPassword.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Italic, GraphicsUnit.Point, 0);
            box_confirmPassword.Location = new Point(63, 298);
            box_confirmPassword.Name = "box_confirmPassword";
            box_confirmPassword.Size = new Size(340, 33);
            box_confirmPassword.TabIndex = 14;
            box_confirmPassword.TabStop = false;
            box_confirmPassword.Text = "Confirm password";
            box_confirmPassword.Enter += box_confirmPassword_Enter;
            box_confirmPassword.KeyDown += box_confirmPassword_KeyDown;
            box_confirmPassword.Leave += box_confirmPassword_Leave;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.forgotpassword_icon1;
            pictureBox3.Location = new Point(130, 25);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(209, 158);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // box_newPassword
            // 
            box_newPassword.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Italic, GraphicsUnit.Point, 0);
            box_newPassword.Location = new Point(63, 236);
            box_newPassword.Name = "box_newPassword";
            box_newPassword.Size = new Size(340, 33);
            box_newPassword.TabIndex = 0;
            box_newPassword.TabStop = false;
            box_newPassword.Text = "New password";
            box_newPassword.Enter += box_newPassword_Enter;
            box_newPassword.KeyDown += box_newPassword_KeyDown;
            box_newPassword.Leave += box_newPassword_Leave;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.background_login;
            pictureBox5.InitialImage = (Image)resources.GetObject("pictureBox5.InitialImage");
            pictureBox5.Location = new Point(71, 52);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(948, 699);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // customButton5
            // 
            customButton5.BackColor = Color.Red;
            customButton5.BackgroundColor = Color.Red;
            customButton5.BorderColor = Color.PaleVioletRed;
            customButton5.BorderRadius = 12;
            customButton5.BorderSize = 0;
            customButton5.FlatAppearance.BorderSize = 0;
            customButton5.FlatStyle = FlatStyle.Flat;
            customButton5.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton5.ForeColor = Color.White;
            customButton5.Location = new Point(1272, 30);
            customButton5.Name = "customButton5";
            customButton5.Size = new Size(58, 48);
            customButton5.TabIndex = 70;
            customButton5.Text = "X";
            customButton5.TextColor = Color.White;
            customButton5.UseVisualStyleBackColor = false;
            customButton5.Click += customButton5_Click;
            // 
            // G_ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1400, 800);
            Controls.Add(panel_verify);
            Controls.Add(panel_forgotPassword);
            Controls.Add(panel_resetPassword);
            Controls.Add(customButton5);
            Controls.Add(pictureBox5);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "G_ForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "G_ForgotPassword";
            panel_forgotPassword.ResumeLayout(false);
            panel_forgotPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo).EndInit();
            panel_verify.ResumeLayout(false);
            panel_verify.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_mail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_resetPassword.ResumeLayout(false);
            panel_resetPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox box_NumericCode;
        private TextBox box_username;
        private Button button_SendCode;
        private Button button_VerifyCode;
        private Button button_back2;
        private Panel panel_forgotPassword;
        private PictureBox pictureBox_logo;
        private Label label_login;
        private Button button1;
        private PictureBox pictureBox1;
        private Panel panel_verify;
        private PictureBox pictureBox_mail;
        private Panel panel_resetPassword;
        private TextBox box_confirmPassword;
        private Button button4;
        private PictureBox pictureBox3;
        private Button button5;
        private TextBox box_newPassword;
        private Label label_back;
        private Label label_please2;
        private Label label_resendCode;
        private Label label_Please1;
        private Label label_Please3;
        private Button button_back3;
        private Button button_save;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private CustomComponent.CustomButton customButton5;
    }
}