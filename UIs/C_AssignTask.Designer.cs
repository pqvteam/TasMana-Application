namespace UIs
{
    partial class C_AssignTask
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            taskName = new TextBox();
            taskDeadline = new DateTimePicker();
            label4 = new Label();
            label7 = new Label();
            taskFile = new TextBox();
            label8 = new Label();
            taskDescription = new RichTextBox();
            assignButton = new Button();
            receiverTypeBox = new ComboBox();
            taskMode = new ComboBox();
            receiverBox = new ComboBox();
            apartmentsBox = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 23);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 2;
            label1.Text = "Giao cho";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(429, 23);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 4;
            label2.Text = "Công khai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 80);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 6;
            label3.Text = "Chọn người nhận";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(429, 144);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 10;
            label5.Text = "Hạn chót";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 144);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 8;
            label6.Text = "Công việc";
            // 
            // taskName
            // 
            taskName.Location = new Point(40, 167);
            taskName.Name = "taskName";
            taskName.Size = new Size(325, 27);
            taskName.TabIndex = 7;
            // 
            // taskDeadline
            // 
            taskDeadline.Location = new Point(431, 167);
            taskDeadline.Name = "taskDeadline";
            taskDeadline.Size = new Size(325, 27);
            taskDeadline.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(429, 209);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 14;
            label4.Text = "Thêm file";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 209);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 13;
            label7.Text = "Khu vực";
            // 
            // taskFile
            // 
            taskFile.Location = new Point(431, 232);
            taskFile.Name = "taskFile";
            taskFile.Size = new Size(325, 27);
            taskFile.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 277);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 16;
            label8.Text = "Mô tả";
            // 
            // taskDescription
            // 
            taskDescription.Location = new Point(40, 300);
            taskDescription.Name = "taskDescription";
            taskDescription.Size = new Size(716, 79);
            taskDescription.TabIndex = 17;
            taskDescription.Text = "";
            // 
            // assignButton
            // 
            assignButton.Location = new Point(586, 385);
            assignButton.Name = "assignButton";
            assignButton.Size = new Size(170, 39);
            assignButton.TabIndex = 18;
            assignButton.Text = "Giao việc";
            assignButton.UseVisualStyleBackColor = true;
            assignButton.Click += assignButton_Click;
            // 
            // receiverTypeBox
            // 
            receiverTypeBox.FormattingEnabled = true;
            receiverTypeBox.Items.AddRange(new object[] { "Phòng ban", "Nhân viên" });
            receiverTypeBox.Location = new Point(40, 46);
            receiverTypeBox.Name = "receiverTypeBox";
            receiverTypeBox.Size = new Size(325, 28);
            receiverTypeBox.TabIndex = 19;
            receiverTypeBox.SelectedIndexChanged += receiverTypeBox_SelectedIndexChanged;
            // 
            // taskMode
            // 
            taskMode.FormattingEnabled = true;
            taskMode.Items.AddRange(new object[] { "Có", "Không" });
            taskMode.Location = new Point(431, 46);
            taskMode.Name = "taskMode";
            taskMode.Size = new Size(325, 28);
            taskMode.TabIndex = 20;
            // 
            // receiverBox
            // 
            receiverBox.FormattingEnabled = true;
            receiverBox.Items.AddRange(new object[] { "Phòng ban", "Nhân viên" });
            receiverBox.Location = new Point(40, 103);
            receiverBox.Name = "receiverBox";
            receiverBox.Size = new Size(716, 28);
            receiverBox.TabIndex = 21;
            receiverBox.SelectedIndexChanged += receiverBox_SelectedIndexChanged;
            // 
            // apartmentsBox
            // 
            apartmentsBox.FormattingEnabled = true;
            apartmentsBox.Items.AddRange(new object[] { "Phòng ban", "Nhân viên" });
            apartmentsBox.Location = new Point(40, 231);
            apartmentsBox.Name = "apartmentsBox";
            apartmentsBox.Size = new Size(325, 28);
            apartmentsBox.TabIndex = 22;
            // 
            // C_AssignTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(apartmentsBox);
            Controls.Add(receiverBox);
            Controls.Add(taskMode);
            Controls.Add(receiverTypeBox);
            Controls.Add(assignButton);
            Controls.Add(taskDescription);
            Controls.Add(label8);
            Controls.Add(taskFile);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(taskDeadline);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(taskName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "C_AssignTask";
            Text = "Giao việc bởi CEO";
            Load += C_AssignTask_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox taskName;
        private DateTimePicker taskDeadline;
        private Label label4;
        private Label label7;
        private TextBox taskFile;
        private Label label8;
        private RichTextBox taskDescription;
        private Button assignButton;
        private ComboBox receiverTypeBox;
        private ComboBox taskMode;
        private ComboBox receiverBox;
        private ComboBox apartmentsBox;
    }
}