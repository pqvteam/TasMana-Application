namespace UIs
{
    partial class SplashScreeen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreeen));
            customPictureBox2 = new CustomComponent.CustomPictureBox();
            label1 = new Label();
            customButton1 = new CustomComponent.CustomButton();
            elipseControl1 = new CustomComponent.ElipseControl();
            timer1 = new System.Windows.Forms.Timer(components);
            progressBar1 = new CustomControls.CustomControls.CustomProgressBar();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)customPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // customPictureBox2
            // 
            customPictureBox2.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            customPictureBox2.BorderColor = Color.RoyalBlue;
            customPictureBox2.BorderColor2 = Color.HotPink;
            customPictureBox2.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            customPictureBox2.BorderSize = 2;
            customPictureBox2.GradientAngle = 50F;
            customPictureBox2.Image = (Image)resources.GetObject("customPictureBox2.Image");
            customPictureBox2.Location = new Point(573, 122);
            customPictureBox2.Name = "customPictureBox2";
            customPictureBox2.Size = new Size(254, 254);
            customPictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            customPictureBox2.TabIndex = 1;
            customPictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(600, 410);
            label1.Name = "label1";
            label1.Size = new Size(200, 39);
            label1.TabIndex = 2;
            label1.Text = "TAS MANA";
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.Black;
            customButton1.BackgroundColor = Color.Black;
            customButton1.BorderColor = Color.MediumOrchid;
            customButton1.BorderRadius = 20;
            customButton1.BorderSize = 3;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(395, 481);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(617, 78);
            customButton1.TabIndex = 3;
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 200;
            elipseControl1.TargetControl = this;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tag = "progressBar1";
            timer1.Tick += timer1_Tick;
            // 
            // progressBar1
            // 
            progressBar1.ChannelColor = Color.White;
            progressBar1.ChannelHeight = 30;
            progressBar1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            progressBar1.ForeBackColor = Color.Purple;
            progressBar1.ForeColor = Color.White;
            progressBar1.Location = new Point(423, 504);
            progressBar1.Name = "progressBar1";
            progressBar1.ShowMaximun = false;
            progressBar1.ShowValue = CustomControls.CustomControls.TextPosition.Right;
            progressBar1.Size = new Size(561, 30);
            progressBar1.SliderColor = Color.Purple;
            progressBar1.SliderHeight = 30;
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.SymbolAfter = "";
            progressBar1.SymbolBefore = "";
            progressBar1.TabIndex = 4;
            progressBar1.Click += progressBar1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(-5, 410);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(375, 395);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1094, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(323, 240);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(927, 493);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(470, 342);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // SplashScreeen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1400, 800);
            Controls.Add(pictureBox2);
            Controls.Add(progressBar1);
            Controls.Add(customButton1);
            Controls.Add(label1);
            Controls.Add(customPictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreeen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashScreeen";
            Load += SplashScreeen_Load;
            ((System.ComponentModel.ISupportInitialize)customPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CustomComponent.CustomPictureBox customPictureBox2;
        private Label label1;
        private CustomComponent.CustomButton customButton1;
        private CustomComponent.ElipseControl elipseControl1;
        private System.Windows.Forms.Timer timer1;
        private CustomControls.CustomControls.CustomProgressBar progressBar1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}