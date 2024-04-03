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
            label_ForgotPassword = new Label();
            panel1 = new Panel();
            button_Back = new Button();
            button_ConfirmCode = new Button();
            button_SendCode = new Button();
            pictureBox1 = new PictureBox();
            box_NumericCode = new TextBox();
            pictureBox_username = new PictureBox();
            box_username = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_username).BeginInit();
            SuspendLayout();
            // 
            // label_ForgotPassword
            // 
            label_ForgotPassword.AutoSize = true;
            label_ForgotPassword.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_ForgotPassword.Location = new Point(179, 60);
            label_ForgotPassword.Name = "label_ForgotPassword";
            label_ForgotPassword.Size = new Size(427, 45);
            label_ForgotPassword.TabIndex = 1;
            label_ForgotPassword.Text = "FORGOT PASSWORD";
            // 
            // panel1
            // 
            panel1.Controls.Add(button_Back);
            panel1.Controls.Add(button_ConfirmCode);
            panel1.Controls.Add(button_SendCode);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(box_NumericCode);
            panel1.Controls.Add(pictureBox_username);
            panel1.Controls.Add(box_username);
            panel1.Controls.Add(label_ForgotPassword);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 2;
            // 
            // button_Back
            // 
            button_Back.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Back.Location = new Point(648, 379);
            button_Back.Name = "button_Back";
            button_Back.Size = new Size(128, 44);
            button_Back.TabIndex = 13;
            button_Back.Text = "Back";
            button_Back.UseVisualStyleBackColor = true;
            button_Back.Click += button_Back_Click;
            // 
            // button_ConfirmCode
            // 
            button_ConfirmCode.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_ConfirmCode.Location = new Point(513, 214);
            button_ConfirmCode.Name = "button_ConfirmCode";
            button_ConfirmCode.Size = new Size(128, 44);
            button_ConfirmCode.TabIndex = 12;
            button_ConfirmCode.Text = "Confirm";
            button_ConfirmCode.UseVisualStyleBackColor = true;
            button_ConfirmCode.Click += button_ConfirmCode_Click;
            // 
            // button_SendCode
            // 
            button_SendCode.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_SendCode.Location = new Point(513, 162);
            button_SendCode.Name = "button_SendCode";
            button_SendCode.Size = new Size(128, 44);
            button_SendCode.TabIndex = 11;
            button_SendCode.Text = "Send code";
            button_SendCode.UseVisualStyleBackColor = true;
            button_SendCode.Click += button_SendCode_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.code_icon;
            pictureBox1.Location = new Point(71, 225);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // box_NumericCode
            // 
            box_NumericCode.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Italic, GraphicsUnit.Point, 0);
            box_NumericCode.Location = new Point(122, 225);
            box_NumericCode.Name = "box_NumericCode";
            box_NumericCode.Size = new Size(340, 33);
            box_NumericCode.TabIndex = 0;
            box_NumericCode.TabStop = false;
            box_NumericCode.Text = "Enter Code";
            box_NumericCode.Enter += box_NumericCode_Enter;
            box_NumericCode.Leave += box_NumericCode_Leave;
            // 
            // pictureBox_username
            // 
            pictureBox_username.Image = Properties.Resources.user_icon;
            pictureBox_username.Location = new Point(71, 162);
            pictureBox_username.Name = "pictureBox_username";
            pictureBox_username.Size = new Size(35, 33);
            pictureBox_username.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_username.TabIndex = 8;
            pictureBox_username.TabStop = false;
            // 
            // box_username
            // 
            box_username.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Italic, GraphicsUnit.Point, 0);
            box_username.Location = new Point(122, 162);
            box_username.Name = "box_username";
            box_username.Size = new Size(340, 33);
            box_username.TabIndex = 0;
            box_username.TabStop = false;
            box_username.Text = "User ID";
            box_username.Enter += box_username_Enter;
            box_username.Leave += box_username_Leave;
            // 
            // G_ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "G_ForgotPassword";
            Text = "G_ForgotPassword";
            FormClosed += G_ForgotPassword_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_username).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label_ForgotPassword;
        private Panel panel1;
        private TextBox box_NumericCode;
        private PictureBox pictureBox_username;
        private TextBox box_username;
        private PictureBox pictureBox1;
        private Button button_SendCode;
        private Button button_ConfirmCode;
        private Button button_Back;
    }
}