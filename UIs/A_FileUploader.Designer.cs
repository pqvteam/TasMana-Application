namespace UIs
{
    partial class A_FileUploader
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
            uploadButton = new CustomComponent.CustomButton();
            progressBar = new ProgressBar();
            statusLabel = new Label();
            backgroundWorker = new System.ComponentModel.BackgroundWorker();
            downloadButton = new CustomComponent.CustomButton();
            SuspendLayout();
            // 
            // uploadButton
            // 
            uploadButton.BackColor = Color.Green;
            uploadButton.BackgroundColor = Color.Green;
            uploadButton.BorderColor = Color.PaleVioletRed;
            uploadButton.BorderRadius = 20;
            uploadButton.BorderSize = 0;
            uploadButton.FlatAppearance.BorderSize = 0;
            uploadButton.FlatStyle = FlatStyle.Flat;
            uploadButton.Font = new Font("Copperplate Gothic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uploadButton.ForeColor = Color.Black;
            uploadButton.Location = new Point(300, 265);
            uploadButton.Name = "uploadButton";
            uploadButton.Size = new Size(204, 45);
            uploadButton.TabIndex = 8;
            uploadButton.Text = "UPLOAD";
            uploadButton.TextColor = Color.Black;
            uploadButton.UseVisualStyleBackColor = false;
            uploadButton.Click += uploadButton_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(42, 334);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(717, 47);
            progressBar.TabIndex = 9;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(354, 406);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(99, 20);
            statusLabel.TabIndex = 10;
            statusLabel.Text = "Uploaded 0%";
            // 
            // backgroundWorker
            // 
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += backgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
            // 
            // downloadButton
            // 
            downloadButton.BackColor = Color.MediumSlateBlue;
            downloadButton.BackgroundColor = Color.MediumSlateBlue;
            downloadButton.BorderColor = Color.PaleVioletRed;
            downloadButton.BorderRadius = 8;
            downloadButton.BorderSize = 0;
            downloadButton.FlatAppearance.BorderSize = 0;
            downloadButton.FlatStyle = FlatStyle.Flat;
            downloadButton.ForeColor = Color.White;
            downloadButton.Location = new Point(317, 149);
            downloadButton.Name = "downloadButton";
            downloadButton.Size = new Size(175, 62);
            downloadButton.TabIndex = 11;
            downloadButton.Text = "Download";
            downloadButton.TextColor = Color.White;
            downloadButton.UseVisualStyleBackColor = false;
            downloadButton.Click += downloadButton_Click;
            // 
            // A_FileUploader
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(downloadButton);
            Controls.Add(statusLabel);
            Controls.Add(progressBar);
            Controls.Add(uploadButton);
            Name = "A_FileUploader";
            Text = "A_FileUploader";
            Load += A_FileUploader_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomComponent.CustomButton uploadButton;
        private ProgressBar progressBar;
        private Label statusLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private CustomComponent.CustomButton downloadButton;
    }
}