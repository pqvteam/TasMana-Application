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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(G_Login));
            label_login = new Label();
            box_username = new TextBox();
            box_password = new TextBox();
            label_forgotPassword = new Label();
            checkbox_Remember = new CheckBox();
            button_Login = new Button();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            pictureBox_logo = new PictureBox();
            elipseControl1 = new CustomComponent.ElipseControl();
            pictureBox1 = new PictureBox();
            elipseControl2 = new CustomComponent.ElipseControl();
            customButton5 = new CustomComponent.CustomButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label_login
            // 
            label_login.AutoSize = true;
            label_login.BackColor = Color.Transparent;
            label_login.Font = new Font("Copperplate Gothic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_login.ForeColor = Color.White;
            label_login.Location = new Point(167, 78);
            label_login.Name = "label_login";
            label_login.Size = new Size(163, 44);
            label_login.TabIndex = 0;
            label_login.Text = "LOGIN";
            // 
            // box_username
            // 
            box_username.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Italic, GraphicsUnit.Point, 0);
            box_username.Location = new Point(79, 151);
            box_username.Name = "box_username";
            box_username.Size = new Size(340, 33);
            box_username.TabIndex = 0;
            box_username.TabStop = false;
            box_username.Text = "User ID";
            box_username.Enter += box_username_Enter;
            box_username.Leave += box_username_Leave;
            // 
            // box_password
            // 
            box_password.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Italic, GraphicsUnit.Point, 0);
            box_password.Location = new Point(79, 204);
            box_password.Name = "box_password";
            box_password.Size = new Size(340, 33);
            box_password.TabIndex = 0;
            box_password.TabStop = false;
            box_password.Text = "Password";
            box_password.Enter += box_password_Enter;
            box_password.KeyDown += box_password_KeyDown;
            box_password.Leave += box_password_Leave;
            // 
            // label_forgotPassword
            // 
            label_forgotPassword.AutoSize = true;
            label_forgotPassword.BackColor = Color.Transparent;
            label_forgotPassword.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_forgotPassword.ForeColor = Color.White;
            label_forgotPassword.Location = new Point(252, 263);
            label_forgotPassword.Name = "label_forgotPassword";
            label_forgotPassword.Size = new Size(207, 29);
            label_forgotPassword.TabIndex = 3;
            label_forgotPassword.Text = "Forgot password?";
            label_forgotPassword.Click += label_forgotPassword_Click;
            // 
            // checkbox_Remember
            // 
            checkbox_Remember.AutoSize = true;
            checkbox_Remember.BackColor = Color.Transparent;
            checkbox_Remember.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkbox_Remember.ForeColor = Color.White;
            checkbox_Remember.Location = new Point(38, 263);
            checkbox_Remember.Name = "checkbox_Remember";
            checkbox_Remember.Size = new Size(156, 33);
            checkbox_Remember.TabIndex = 4;
            checkbox_Remember.Text = "Remember";
            checkbox_Remember.UseVisualStyleBackColor = false;
            // 
            // button_Login
            // 
            button_Login.BackColor = Color.Red;
            button_Login.FlatAppearance.BorderSize = 0;
            button_Login.FlatStyle = FlatStyle.Flat;
            button_Login.Font = new Font("Copperplate Gothic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Login.ForeColor = SystemColors.ControlText;
            button_Login.Location = new Point(130, 330);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(204, 43);
            button_Login.TabIndex = 5;
            button_Login.Text = "LOGIN";
            button_Login.UseVisualStyleBackColor = false;
            button_Login.Click += button_Login_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.background_input_userid;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox_logo);
            panel1.Controls.Add(button_Login);
            panel1.Controls.Add(checkbox_Remember);
            panel1.Controls.Add(label_forgotPassword);
            panel1.Controls.Add(box_password);
            panel1.Controls.Add(box_username);
            panel1.Controls.Add(label_login);
            panel1.Location = new Point(941, 212);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 476);
            panel1.TabIndex = 8;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(37, 204);
            button2.Name = "button2";
            button2.Size = new Size(43, 41);
            button2.TabIndex = 10;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.snapedit_1712151680966;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(35, 145);
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
            pictureBox_logo.Size = new Size(125, 62);
            pictureBox_logo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_logo.TabIndex = 8;
            pictureBox_logo.TabStop = false;
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 200;
            elipseControl1.TargetControl = this;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.background_login;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(71, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(948, 699);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // elipseControl2
            // 
            elipseControl2.CornerRadius = 60;
            elipseControl2.TargetControl = panel1;
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
            customButton5.TabIndex = 69;
            customButton5.Text = "X";
            customButton5.TextColor = Color.White;
            customButton5.UseVisualStyleBackColor = false;
            customButton5.Click += customButton5_Click;
            // 
            // G_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1400, 800);
            Controls.Add(customButton5);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "G_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Interface";
            Load += G_Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label_login;
        private TextBox box_username;
        private TextBox box_password;
        private Label label_forgotPassword;
        private CheckBox checkbox_Remember;
        private Button button_Login;
        private Panel panel1;
        private PictureBox pictureBox_logo;
        private CustomComponent.ElipseControl elipseControl1;
        private PictureBox pictureBox1;
        private CustomComponent.ElipseControl elipseControl2;
        private CustomComponent.CustomButton customButton5;
        private Button button2;
        private Button button1;
    }
}