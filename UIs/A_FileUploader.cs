using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;

namespace UIs
{
    public partial class A_FileUploader : Form
    {
        public A_FileUploader()
        {
            InitializeComponent();
        }

        struct FtpSetting
        {
            public string Server { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Filename { get; set; }
            public string Fullname { get; set; }
        }

        FtpSetting _inputParameters;

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string fileName = ((FtpSetting)e.Argument).Filename;
            string fullName = ((FtpSetting)e.Argument).Fullname;
            string userName = ((FtpSetting)e.Argument).Username;
            string password = ((FtpSetting)e.Argument).Password;
            string server = ((FtpSetting)e.Argument).Server;

            FtpWebRequest request = (FtpWebRequest)
                WebRequest.Create(new Uri(string.Format("{0}/{1}", server, fileName)));
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential(userName, password);
            Stream ftpStream = request.GetRequestStream();
            FileStream fs = File.OpenRead(fullName);
            byte[] buffet = new byte[1024];
            double total = (double)fs.Length;
            int byteRead = 0;
            double read = 0;

            do
            {
                if (!backgroundWorker.CancellationPending)
                {
                    byteRead = fs.Read(buffet, 0, 1024);
                    ftpStream.Write(buffet, 0, byteRead);
                    read += (double)byteRead;
                    double percentage = read / total * 100;
                    backgroundWorker.ReportProgress((int)percentage);
                }
            } while (byteRead != 0);
            fs.Close();
            ftpStream.Close();
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            statusLabel.Text = $"Uploaded {e.ProgressPercentage} %";
            progressBar.Value = e.ProgressPercentage;
            progressBar.Update();
        }

        private void backgroundWorker_RunWorkerCompleted(
            object sender,
            RunWorkerCompletedEventArgs e
        )
        {
            MessageBox.Show("Complete");

            statusLabel.Text = "Upload completed!";
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            using (
                OpenFileDialog ofd = new OpenFileDialog()
                {
                    Multiselect = false,
                    ValidateNames = true,
                    Filter = "All files|*.*"
                }
            )
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(ofd.FileName);
                    _inputParameters.Username = "user";
                    _inputParameters.Password = "123456";
                    _inputParameters.Server = "ftp://192.168.1.4/";
                    _inputParameters.Filename = fi.Name;
                    _inputParameters.Fullname = fi.FullName;

                    backgroundWorker.RunWorkerAsync(_inputParameters);
                }
            }
        }

        private void A_FileUploader_Load(object sender, EventArgs e) { }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            DownloadService download = new DownloadService();
            // download.getDataFromServer("Guide.txt", "ftp://192.168.1.4/");
            string folderPath =
                @"C:\Users\ASUS\source\repos\TasMana-Application\UIs\bin\Debug\net8.0-windows";
            string fileName = "Guild.txt";

            string filePath = System.IO.Path.Combine(folderPath, fileName);

            if (filePath.EndsWith("txt"))
            {
                Process.Start("notepad.exe", filePath);
            }
            else if (filePath.EndsWith("pptx"))
            {
                MessageBox.Show(filePath);
                OpenPowerPointWithRegistry(filePath);
            }
            else if (filePath.EndsWith("pdf"))
            {
                MessageBox.Show(filePath);
                OpenPdfWithRegistry(filePath);
            }
            else if (filePath.EndsWith("docx") || filePath.EndsWith("doc"))
            {
                MessageBox.Show(filePath);
                OpenWordWithRegistry(filePath);
            } else if (filePath.EndsWith("xlsx"))
            {
                MessageBox.Show(filePath);

                string excelPath = GetExcelPath();

                if (File.Exists(excelPath))
                {
                    System.Diagnostics.Process.Start(excelPath, fileName);
                }
                else
                {
                    MessageBox.Show("Không thể tìm thấy Microsoft Excel trên máy tính của bạn.");
                }
            }
        }

        private string GetExcelPath()
        {
            const string excelPathKey =
                @"Software\Microsoft\Windows\CurrentVersion\App Paths\excel.exe";

            using (
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    excelPathKey
                )
            )
            {
                if (key != null)
                {
                    Object o = key.GetValue("");
                    if (o != null)
                    {
                        return o.ToString();
                    }
                }
            }

            return null;
        }

        private void OpenPowerPointWithRegistry(string filePath)
        {
            const string powerpointPathKey = @"Software\Microsoft\Windows\CurrentVersion\App Paths\POWERPNT.EXE";

            using (Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(powerpointPathKey))
            {
                if (key != null)
                {
                    Object o = key.GetValue("");
                    if (o != null)
                    {
                        string powerpointPath = o.ToString();
                        Process.Start(powerpointPath, filePath);
                    }
                    else
                    {
                        MessageBox.Show("Không thể tìm thấy Microsoft PowerPoint trên máy tính của bạn.");
                    }
                }
                else
                {
                    MessageBox.Show("Không thể tìm thấy Microsoft PowerPoint trên máy tính của bạn.");
                }
            }
        }

        private void OpenWordWithRegistry(string filePath)
        {
            const string wordPathKey = @"Software\Microsoft\Windows\CurrentVersion\App Paths\WINWORD.EXE";

            using (Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(wordPathKey))
            {
                if (key != null)
                {
                    Object o = key.GetValue("");
                    if (o != null)
                    {
                        string wordPath = o.ToString();
                        Process.Start(wordPath, filePath);
                    }
                    else
                    {
                        MessageBox.Show("Không thể tìm thấy Microsoft Word trên máy tính của bạn.");
                    }
                }
                else
                {
                    MessageBox.Show("Không thể tìm thấy Microsoft Word trên máy tính của bạn.");
                }
            }
        }

        private void OpenPdfWithRegistry(string filePath)
        {
            // Tạo một đối tượng RegistryKey cho khóa HKEY_CLASSES_ROOT của file PDF
            using (var pdfKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(".pdf"))
            {
                if (pdfKey != null)
                {
                    // Đọc giá trị của khóa mở rộng PDF
                    string fileTypeValue = pdfKey.GetValue(null)?.ToString();

                    if (!string.IsNullOrEmpty(fileTypeValue))
                    {
                        // Tìm giá trị của phần mở rộng PDF trong khóa HKEY_CLASSES_ROOT
                        using (var defaultPdfKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(fileTypeValue))
                        {
                            if (defaultPdfKey != null)
                            {
                                // Đọc giá trị của khóa mở rộng PDF
                                string edgeExePath = defaultPdfKey
                                    .OpenSubKey(@"shell\open\command")
                                    ?.GetValue(null)
                                    ?.ToString();

                                if (!string.IsNullOrEmpty(edgeExePath))
                                {
                                    // Tạo đường dẫn cho Microsoft Edge
                                    string edgePath = edgeExePath.Replace("\"%1\"", $"\"{filePath}\"");

                                    // Mở file PDF bằng Microsoft Edge
                                    Process.Start(edgePath);
                                }
                            }
                        }
                    }
                }
            }
        }

    }
}
