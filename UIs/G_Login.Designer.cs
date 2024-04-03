namespace UIs
{
    partial class G_Login
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
            label_login = new Label();
            box_username = new TextBox();
            box_password = new TextBox();
            label_forgotPassword = new Label();
            checkbox_remember = new CheckBox();
            button_Login = new Button();
            pictureBox_username = new PictureBox();
            pictureBox_password = new PictureBox();
            panel1 = new Panel();
            pictureBox_logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_username).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_password).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo).BeginInit();
            SuspendLayout();
            // 
            // label_login
            // 
            label_login.AutoSize = true;
            label_login.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_login.Location = new Point(167, 78);
            label_login.Name = "label_login";
            label_login.Size = new Size(154, 45);
            label_login.TabIndex = 0;
            label_login.Text = "LOGIN";
            // 
            // box_username
            // 
            box_username.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            box_username.Location = new Point(79, 151);
            box_username.Name = "box_username";
            box_username.Size = new Size(340, 33);
            box_username.TabIndex = 1;
            box_username.Text = "  User ID";
            // 
            // box_password
            // 
            box_password.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            box_password.Location = new Point(79, 204);
            box_password.Name = "box_password";
            box_password.Size = new Size(340, 33);
            box_password.TabIndex = 2;
            box_password.Text = "  Password";
            // 
            // label_forgotPassword
            // 
            label_forgotPassword.AutoSize = true;
            label_forgotPassword.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_forgotPassword.Location = new Point(252, 265);
            label_forgotPassword.Name = "label_forgotPassword";
            label_forgotPassword.Size = new Size(179, 26);
            label_forgotPassword.TabIndex = 3;
            label_forgotPassword.Text = "Forgot password?";
            // 
            // checkbox_remember
            // 
            checkbox_remember.AutoSize = true;
            checkbox_remember.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkbox_remember.Location = new Point(38, 263);
            checkbox_remember.Name = "checkbox_remember";
            checkbox_remember.Size = new Size(135, 30);
            checkbox_remember.TabIndex = 4;
            checkbox_remember.Text = "Remember";
            checkbox_remember.UseVisualStyleBackColor = true;
            // 
            // button_Login
            // 
            button_Login.BackColor = Color.Red;
            button_Login.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Login.ForeColor = SystemColors.ControlText;
            button_Login.Location = new Point(130, 330);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(204, 43);
            button_Login.TabIndex = 5;
            button_Login.Text = "LOGIN";
            button_Login.UseVisualStyleBackColor = false;
            button_Login.Click += button_Login_Click;
            // 
            // pictureBox_username
            // 
            pictureBox_username.Image = Properties.Resources.user_icon;
            pictureBox_username.Location = new Point(38, 151);
            pictureBox_username.Name = "pictureBox_username";
            pictureBox_username.Size = new Size(35, 33);
            pictureBox_username.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_username.TabIndex = 6;
            pictureBox_username.TabStop = false;
            // 
            // pictureBox_password
            // 
            pictureBox_password.Image = Properties.Resources.password_icon;
            pictureBox_password.Location = new Point(38, 204);
            pictureBox_password.Name = "pictureBox_password";
            pictureBox_password.Size = new Size(35, 33);
            pictureBox_password.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_password.TabIndex = 7;
            pictureBox_password.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.background_input_userid;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox_logo);
            panel1.Controls.Add(pictureBox_password);
            panel1.Controls.Add(pictureBox_username);
            panel1.Controls.Add(button_Login);
            panel1.Controls.Add(checkbox_remember);
            panel1.Controls.Add(label_forgotPassword);
            panel1.Controls.Add(box_password);
            panel1.Controls.Add(box_username);
            panel1.Controls.Add(label_login);
            panel1.Location = new Point(618, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 476);
            panel1.TabIndex = 8;
            // 
            // pictureBox_logo
            // 
            pictureBox_logo.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_logo.Image = Properties.Resources.Picture1;
            pictureBox_logo.Location = new Point(182, 13);
            pictureBox_logo.Name = "pictureBox_logo";
            pictureBox_logo.Size = new Size(125, 62);
            pictureBox_logo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_logo.TabIndex = 8;
            pictureBox_logo.TabStop = false;
            // 
            // G_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_login;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1088, 707);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "G_Login";
            Text = "Login Interface";
            ((System.ComponentModel.ISupportInitialize)pictureBox_username).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_password).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label_login;
        private TextBox box_username;
        private TextBox box_password;
        private Label label_forgotPassword;
        private CheckBox checkbox_remember;
        private Button button_Login;
        private PictureBox pictureBox_username;
        private PictureBox pictureBox_password;
        private Panel panel1;
        private PictureBox pictureBox_logo;
    }
}