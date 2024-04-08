namespace UIs
{
    partial class CM_CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CM_CreateAccount));
            elipseControl1 = new CustomComponent.ElipseControl();
            customButton10 = new CustomComponent.CustomButton();
            typeBox = new CustomComponent.CustomComboBox();
            label2 = new Label();
            customButton2 = new CustomComponent.CustomButton();
            deparmentsBox = new CustomComponent.CustomComboBox();
            label1 = new Label();
            customButton1 = new CustomComponent.CustomButton();
            label3 = new Label();
            customButton3 = new CustomComponent.CustomButton();
            label4 = new Label();
            customButton4 = new CustomComponent.CustomButton();
            label5 = new Label();
            customButton5 = new CustomComponent.CustomButton();
            label6 = new Label();
            customButton6 = new CustomComponent.CustomButton();
            label7 = new Label();
            customButton7 = new CustomComponent.CustomButton();
            label8 = new Label();
            customButton8 = new CustomComponent.CustomButton();
            label9 = new Label();
            customButton9 = new CustomComponent.CustomButton();
            label10 = new Label();
            customButton11 = new CustomComponent.CustomButton();
            cancelButton = new CustomComponent.CustomButton();
            customButton14 = new CustomComponent.CustomButton();
            panel1 = new Panel();
            citizenIDBox = new TextBox();
            panel2 = new Panel();
            emailBox = new TextBox();
            panel3 = new Panel();
            passPortBox = new TextBox();
            panel4 = new Panel();
            userNameBox = new TextBox();
            panel5 = new Panel();
            genderBox = new TextBox();
            panel6 = new Panel();
            mobileBox = new TextBox();
            panel8 = new Panel();
            addressBox = new TextBox();
            birthdateBox = new CustomComponent.CustomDateTimePicker();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
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
            customButton10.Enabled = false;
            customButton10.FlatAppearance.BorderSize = 0;
            customButton10.FlatStyle = FlatStyle.Flat;
            customButton10.Font = new Font("Copperplate Gothic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton10.ForeColor = Color.Yellow;
            customButton10.Image = (Image)resources.GetObject("customButton10.Image");
            customButton10.ImageAlign = ContentAlignment.MiddleLeft;
            customButton10.Location = new Point(370, 12);
            customButton10.Name = "customButton10";
            customButton10.Padding = new Padding(12, 0, 0, 0);
            customButton10.Size = new Size(334, 51);
            customButton10.TabIndex = 47;
            customButton10.Text = "CREATE ACCOUNT";
            customButton10.TextColor = Color.Yellow;
            customButton10.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton10.UseVisualStyleBackColor = false;
            customButton10.Click += customButton10_Click;
            // 
            // typeBox
            // 
            typeBox.BackColor = Color.FromArgb(42, 42, 42);
            typeBox.BorderColor = Color.FromArgb(42, 42, 42);
            typeBox.BorderSize = 1;
            typeBox.DropDownStyle = ComboBoxStyle.DropDown;
            typeBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            typeBox.ForeColor = Color.White;
            typeBox.IconColor = Color.White;
            typeBox.Items.AddRange(new object[] { "Intern", "Fulltime", "Partime" });
            typeBox.ListBackColor = Color.FromArgb(230, 228, 245);
            typeBox.ListTextColor = Color.DimGray;
            typeBox.Location = new Point(57, 139);
            typeBox.MinimumSize = new Size(200, 30);
            typeBox.Name = "typeBox";
            typeBox.Padding = new Padding(1);
            typeBox.Size = new Size(395, 40);
            typeBox.TabIndex = 57;
            typeBox.Texts = "";
            typeBox.OnSelectedIndexChanged += departmentsBox_OnSelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 176, 240);
            label2.Location = new Point(37, 113);
            label2.Name = "label2";
            label2.Size = new Size(162, 19);
            label2.TabIndex = 56;
            label2.Text = "1. Type Account";
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
            customButton2.Location = new Point(37, 135);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(429, 45);
            customButton2.TabIndex = 58;
            customButton2.TextColor = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            // 
            // deparmentsBox
            // 
            deparmentsBox.BackColor = Color.FromArgb(42, 42, 42);
            deparmentsBox.BorderColor = Color.FromArgb(42, 42, 42);
            deparmentsBox.BorderSize = 1;
            deparmentsBox.DropDownStyle = ComboBoxStyle.DropDown;
            deparmentsBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deparmentsBox.ForeColor = Color.White;
            deparmentsBox.IconColor = Color.White;
            deparmentsBox.ListBackColor = Color.FromArgb(230, 228, 245);
            deparmentsBox.ListTextColor = Color.DimGray;
            deparmentsBox.Location = new Point(57, 216);
            deparmentsBox.MinimumSize = new Size(200, 30);
            deparmentsBox.Name = "deparmentsBox";
            deparmentsBox.Padding = new Padding(1);
            deparmentsBox.Size = new Size(395, 40);
            deparmentsBox.TabIndex = 60;
            deparmentsBox.Texts = "";
            deparmentsBox.OnSelectedIndexChanged += departmentsBox_OnSelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 176, 240);
            label1.Location = new Point(37, 190);
            label1.Name = "label1";
            label1.Size = new Size(148, 19);
            label1.TabIndex = 59;
            label1.Text = "2. Department";
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
            customButton1.Location = new Point(37, 212);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(429, 45);
            customButton1.TabIndex = 61;
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 176, 240);
            label3.Location = new Point(37, 269);
            label3.Name = "label3";
            label3.Size = new Size(122, 19);
            label3.TabIndex = 62;
            label3.Text = "3. Citizen ID";
            // 
            // customButton3
            // 
            customButton3.BackColor = Color.FromArgb(42, 42, 42);
            customButton3.BackgroundColor = Color.FromArgb(42, 42, 42);
            customButton3.BorderColor = Color.White;
            customButton3.BorderRadius = 8;
            customButton3.BorderSize = 1;
            customButton3.Enabled = false;
            customButton3.FlatAppearance.BorderSize = 0;
            customButton3.FlatStyle = FlatStyle.Flat;
            customButton3.ForeColor = Color.White;
            customButton3.Location = new Point(37, 292);
            customButton3.Name = "customButton3";
            customButton3.Size = new Size(429, 45);
            customButton3.TabIndex = 64;
            customButton3.TextColor = Color.White;
            customButton3.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 176, 240);
            label4.Location = new Point(37, 347);
            label4.Name = "label4";
            label4.Size = new Size(84, 19);
            label4.TabIndex = 65;
            label4.Text = "4. Email";
            // 
            // customButton4
            // 
            customButton4.BackColor = Color.FromArgb(42, 42, 42);
            customButton4.BackgroundColor = Color.FromArgb(42, 42, 42);
            customButton4.BorderColor = Color.White;
            customButton4.BorderRadius = 8;
            customButton4.BorderSize = 1;
            customButton4.Enabled = false;
            customButton4.FlatAppearance.BorderSize = 0;
            customButton4.FlatStyle = FlatStyle.Flat;
            customButton4.ForeColor = Color.White;
            customButton4.Location = new Point(37, 369);
            customButton4.Name = "customButton4";
            customButton4.Size = new Size(429, 45);
            customButton4.TabIndex = 67;
            customButton4.TextColor = Color.White;
            customButton4.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 176, 240);
            label5.Location = new Point(37, 427);
            label5.Name = "label5";
            label5.Size = new Size(120, 19);
            label5.TabIndex = 68;
            label5.Text = "5. Passport";
            // 
            // customButton5
            // 
            customButton5.BackColor = Color.FromArgb(42, 42, 42);
            customButton5.BackgroundColor = Color.FromArgb(42, 42, 42);
            customButton5.BorderColor = Color.White;
            customButton5.BorderRadius = 8;
            customButton5.BorderSize = 1;
            customButton5.Enabled = false;
            customButton5.FlatAppearance.BorderSize = 0;
            customButton5.FlatStyle = FlatStyle.Flat;
            customButton5.ForeColor = Color.White;
            customButton5.Location = new Point(37, 451);
            customButton5.Name = "customButton5";
            customButton5.Size = new Size(429, 45);
            customButton5.TabIndex = 70;
            customButton5.TextColor = Color.White;
            customButton5.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 176, 240);
            label6.Location = new Point(579, 112);
            label6.Name = "label6";
            label6.Size = new Size(127, 19);
            label6.TabIndex = 71;
            label6.Text = "6. Username";
            // 
            // customButton6
            // 
            customButton6.BackColor = Color.FromArgb(42, 42, 42);
            customButton6.BackgroundColor = Color.FromArgb(42, 42, 42);
            customButton6.BorderColor = Color.White;
            customButton6.BorderRadius = 8;
            customButton6.BorderSize = 1;
            customButton6.Enabled = false;
            customButton6.FlatAppearance.BorderSize = 0;
            customButton6.FlatStyle = FlatStyle.Flat;
            customButton6.ForeColor = Color.White;
            customButton6.Location = new Point(579, 134);
            customButton6.Name = "customButton6";
            customButton6.Size = new Size(429, 45);
            customButton6.TabIndex = 73;
            customButton6.TextColor = Color.White;
            customButton6.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 176, 240);
            label7.Location = new Point(579, 189);
            label7.Name = "label7";
            label7.Size = new Size(104, 19);
            label7.TabIndex = 74;
            label7.Text = "7. Gender";
            // 
            // customButton7
            // 
            customButton7.BackColor = Color.FromArgb(42, 42, 42);
            customButton7.BackgroundColor = Color.FromArgb(42, 42, 42);
            customButton7.BorderColor = Color.White;
            customButton7.BorderRadius = 8;
            customButton7.BorderSize = 1;
            customButton7.Enabled = false;
            customButton7.FlatAppearance.BorderSize = 0;
            customButton7.FlatStyle = FlatStyle.Flat;
            customButton7.ForeColor = Color.White;
            customButton7.Location = new Point(579, 211);
            customButton7.Name = "customButton7";
            customButton7.Size = new Size(429, 45);
            customButton7.TabIndex = 76;
            customButton7.TextColor = Color.White;
            customButton7.UseVisualStyleBackColor = false;
            customButton7.Click += customButton7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(0, 176, 240);
            label8.Location = new Point(579, 268);
            label8.Name = "label8";
            label8.Size = new Size(96, 19);
            label8.TabIndex = 77;
            label8.Text = "8. Mobile";
            // 
            // customButton8
            // 
            customButton8.BackColor = Color.FromArgb(42, 42, 42);
            customButton8.BackgroundColor = Color.FromArgb(42, 42, 42);
            customButton8.BorderColor = Color.White;
            customButton8.BorderRadius = 8;
            customButton8.BorderSize = 1;
            customButton8.Enabled = false;
            customButton8.FlatAppearance.BorderSize = 0;
            customButton8.FlatStyle = FlatStyle.Flat;
            customButton8.ForeColor = Color.White;
            customButton8.Location = new Point(579, 290);
            customButton8.Name = "customButton8";
            customButton8.Size = new Size(429, 45);
            customButton8.TabIndex = 79;
            customButton8.TextColor = Color.White;
            customButton8.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(0, 176, 240);
            label9.Location = new Point(579, 343);
            label9.Name = "label9";
            label9.Size = new Size(134, 19);
            label9.TabIndex = 80;
            label9.Text = "9. Birth Date";
            // 
            // customButton9
            // 
            customButton9.BackColor = Color.FromArgb(42, 42, 42);
            customButton9.BackgroundColor = Color.FromArgb(42, 42, 42);
            customButton9.BorderColor = Color.White;
            customButton9.BorderRadius = 8;
            customButton9.BorderSize = 1;
            customButton9.Enabled = false;
            customButton9.FlatAppearance.BorderSize = 0;
            customButton9.FlatStyle = FlatStyle.Flat;
            customButton9.ForeColor = Color.White;
            customButton9.Location = new Point(579, 369);
            customButton9.Name = "customButton9";
            customButton9.Size = new Size(429, 45);
            customButton9.TabIndex = 82;
            customButton9.TextColor = Color.White;
            customButton9.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(0, 176, 240);
            label10.Location = new Point(579, 429);
            label10.Name = "label10";
            label10.Size = new Size(123, 19);
            label10.TabIndex = 83;
            label10.Text = "10. Address";
            // 
            // customButton11
            // 
            customButton11.BackColor = Color.FromArgb(42, 42, 42);
            customButton11.BackgroundColor = Color.FromArgb(42, 42, 42);
            customButton11.BorderColor = Color.White;
            customButton11.BorderRadius = 8;
            customButton11.BorderSize = 1;
            customButton11.Enabled = false;
            customButton11.FlatAppearance.BorderSize = 0;
            customButton11.FlatStyle = FlatStyle.Flat;
            customButton11.ForeColor = Color.White;
            customButton11.Location = new Point(579, 451);
            customButton11.Name = "customButton11";
            customButton11.Size = new Size(429, 45);
            customButton11.TabIndex = 85;
            customButton11.TextColor = Color.White;
            customButton11.UseVisualStyleBackColor = false;
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
            cancelButton.Location = new Point(760, 665);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(122, 32);
            cancelButton.TabIndex = 92;
            cancelButton.Text = "CANCEL";
            cancelButton.TextColor = Color.White;
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // customButton14
            // 
            customButton14.BackColor = Color.Red;
            customButton14.BackgroundColor = Color.Red;
            customButton14.BorderColor = Color.PaleVioletRed;
            customButton14.BorderRadius = 12;
            customButton14.BorderSize = 0;
            customButton14.FlatAppearance.BorderSize = 0;
            customButton14.FlatStyle = FlatStyle.Flat;
            customButton14.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton14.ForeColor = Color.White;
            customButton14.Location = new Point(895, 665);
            customButton14.Name = "customButton14";
            customButton14.Size = new Size(122, 32);
            customButton14.TabIndex = 93;
            customButton14.Text = "CREATE";
            customButton14.TextColor = Color.White;
            customButton14.UseVisualStyleBackColor = false;
            customButton14.Click += customButton14_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 42, 42);
            panel1.Controls.Add(citizenIDBox);
            panel1.Location = new Point(57, 304);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 22);
            panel1.TabIndex = 104;
            // 
            // citizenIDBox
            // 
            citizenIDBox.BackColor = Color.FromArgb(42, 42, 42);
            citizenIDBox.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            citizenIDBox.ForeColor = Color.White;
            citizenIDBox.Location = new Point(-2, -2);
            citizenIDBox.Name = "citizenIDBox";
            citizenIDBox.Size = new Size(399, 26);
            citizenIDBox.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(42, 42, 42);
            panel2.Controls.Add(emailBox);
            panel2.Location = new Point(54, 382);
            panel2.Name = "panel2";
            panel2.Size = new Size(395, 22);
            panel2.TabIndex = 105;
            // 
            // emailBox
            // 
            emailBox.BackColor = Color.FromArgb(42, 42, 42);
            emailBox.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailBox.ForeColor = Color.White;
            emailBox.Location = new Point(-2, -2);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(399, 26);
            emailBox.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(42, 42, 42);
            panel3.Controls.Add(passPortBox);
            panel3.Location = new Point(57, 465);
            panel3.Name = "panel3";
            panel3.Size = new Size(395, 22);
            panel3.TabIndex = 106;
            // 
            // passPortBox
            // 
            passPortBox.BackColor = Color.FromArgb(42, 42, 42);
            passPortBox.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passPortBox.ForeColor = Color.White;
            passPortBox.Location = new Point(-2, -2);
            passPortBox.Name = "passPortBox";
            passPortBox.Size = new Size(399, 26);
            passPortBox.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(42, 42, 42);
            panel4.Controls.Add(userNameBox);
            panel4.Location = new Point(595, 146);
            panel4.Name = "panel4";
            panel4.Size = new Size(395, 22);
            panel4.TabIndex = 107;
            // 
            // userNameBox
            // 
            userNameBox.BackColor = Color.FromArgb(42, 42, 42);
            userNameBox.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameBox.ForeColor = Color.White;
            userNameBox.Location = new Point(-2, -2);
            userNameBox.Name = "userNameBox";
            userNameBox.Size = new Size(399, 26);
            userNameBox.TabIndex = 0;
            userNameBox.TextChanged += textBox4_TextChanged;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(42, 42, 42);
            panel5.Controls.Add(genderBox);
            panel5.Location = new Point(595, 223);
            panel5.Name = "panel5";
            panel5.Size = new Size(395, 22);
            panel5.TabIndex = 108;
            // 
            // genderBox
            // 
            genderBox.BackColor = Color.FromArgb(42, 42, 42);
            genderBox.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genderBox.ForeColor = Color.White;
            genderBox.Location = new Point(-2, -2);
            genderBox.Name = "genderBox";
            genderBox.Size = new Size(399, 26);
            genderBox.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(42, 42, 42);
            panel6.Controls.Add(mobileBox);
            panel6.Location = new Point(595, 303);
            panel6.Name = "panel6";
            panel6.Size = new Size(395, 22);
            panel6.TabIndex = 109;
            // 
            // mobileBox
            // 
            mobileBox.BackColor = Color.FromArgb(42, 42, 42);
            mobileBox.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mobileBox.ForeColor = Color.White;
            mobileBox.Location = new Point(-2, -2);
            mobileBox.Name = "mobileBox";
            mobileBox.Size = new Size(399, 26);
            mobileBox.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(42, 42, 42);
            panel8.Controls.Add(addressBox);
            panel8.Location = new Point(597, 464);
            panel8.Name = "panel8";
            panel8.Size = new Size(395, 22);
            panel8.TabIndex = 111;
            // 
            // addressBox
            // 
            addressBox.BackColor = Color.FromArgb(42, 42, 42);
            addressBox.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressBox.ForeColor = Color.White;
            addressBox.Location = new Point(-2, -2);
            addressBox.Name = "addressBox";
            addressBox.Size = new Size(399, 26);
            addressBox.TabIndex = 0;
            // 
            // birthdateBox
            // 
            birthdateBox.BorderColor = Color.PaleVioletRed;
            birthdateBox.BorderSize = 0;
            birthdateBox.Font = new Font("Segoe UI", 9.5F);
            birthdateBox.Location = new Point(593, 374);
            birthdateBox.MinimumSize = new Size(0, 35);
            birthdateBox.Name = "birthdateBox";
            birthdateBox.Size = new Size(397, 35);
            birthdateBox.SkinColor = Color.FromArgb(42, 42, 42);
            birthdateBox.TabIndex = 112;
            birthdateBox.TextColor = Color.White;
            // 
            // CM_CreateAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 23, 23);
            ClientSize = new Size(1061, 730);
            Controls.Add(birthdateBox);
            Controls.Add(panel8);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(customButton14);
            Controls.Add(cancelButton);
            Controls.Add(label10);
            Controls.Add(customButton11);
            Controls.Add(label9);
            Controls.Add(customButton9);
            Controls.Add(label8);
            Controls.Add(customButton8);
            Controls.Add(label7);
            Controls.Add(customButton7);
            Controls.Add(label6);
            Controls.Add(customButton6);
            Controls.Add(label5);
            Controls.Add(customButton5);
            Controls.Add(label4);
            Controls.Add(customButton4);
            Controls.Add(label3);
            Controls.Add(customButton3);
            Controls.Add(deparmentsBox);
            Controls.Add(label1);
            Controls.Add(customButton1);
            Controls.Add(typeBox);
            Controls.Add(label2);
            Controls.Add(customButton2);
            Controls.Add(customButton10);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CM_CreateAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CM_CreateAccount";
            Load += CM_CreateAccount_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomComponent.ElipseControl elipseControl1;
        private CustomComponent.CustomButton customButton10;
        private CustomComponent.CustomComboBox typeBox;
        private Label label2;
        private CustomComponent.CustomButton customButton2;
        private Label label3;
        private CustomComponent.CustomButton customButton3;
        private CustomComponent.CustomComboBox deparmentsBox;
        private Label label1;
        private CustomComponent.CustomButton customButton1;
        private Label label10;
        private CustomComponent.CustomButton customButton11;
        private Label label9;
        private CustomComponent.CustomButton customButton9;
        private Label label8;
        private CustomComponent.CustomButton customButton8;
        private Label label7;
        private CustomComponent.CustomButton customButton7;
        private Label label6;
        private CustomComponent.CustomButton customButton6;
        private Label label5;
        private CustomComponent.CustomButton customButton5;
        private Label label4;
        private CustomComponent.CustomButton customButton4;
        private CustomComponent.CustomButton customButton14;
        private CustomComponent.CustomButton cancelButton;
        private Panel panel1;
        private TextBox citizenIDBox;
        private Panel panel8;
        private TextBox addressBox;
        private Panel panel6;
        private TextBox mobileBox;
        private Panel panel5;
        private TextBox genderBox;
        private Panel panel4;
        private TextBox userNameBox;
        private Panel panel3;
        private TextBox passPortBox;
        private Panel panel2;
        private TextBox emailBox;
        private CustomComponent.CustomDateTimePicker birthdateBox;
    }
}