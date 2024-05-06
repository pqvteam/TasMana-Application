namespace UIs
{
    partial class ToastForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToastForm));
            panel1 = new Panel();
            lbType = new Label();
            lbMessage = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Location = new Point(-29, -9);
            panel1.Name = "panel1";
            panel1.Size = new Size(37, 70);
            panel1.TabIndex = 0;
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbType.Location = new Point(53, 5);
            lbType.Name = "lbType";
            lbType.Size = new Size(44, 18);
            lbType.TabIndex = 2;
            lbType.Text = "Type";
            // 
            // lbMessage
            // 
            lbMessage.AutoSize = true;
            lbMessage.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMessage.Location = new Point(52, 31);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(69, 18);
            lbMessage.TabIndex = 3;
            lbMessage.Text = "message";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.accept__1_;
            pictureBox1.Location = new Point(15, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 10;
            timer2.Tick += timer2_Tick;
            // 
            // ToastForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 59);
            Controls.Add(pictureBox1);
            Controls.Add(lbMessage);
            Controls.Add(lbType);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ToastForm";
            Text = "ToastForm";
            Load += ToastForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lbType;
        private Label lbMessage;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}