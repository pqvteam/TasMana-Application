using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class DownloadService
    {
        public string getDataFromServer(string fileName, string server)
        { 
            String result = String.Empty;
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(server + fileName);
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            request.Credentials = new NetworkCredential("user", "123456");
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream reponseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(reponseStream, Encoding.UTF8);
            result = reader.ReadToEnd();
            using (StreamWriter file = File.CreateText(fileName))
            {
                file.WriteLine(result);
                file.Close();
            }

            reader.Close();
            response.Close();
            return result;
        }

        //public void DownloadPdfFromServer(string fileName, string savePath, string server)
        //{
        //    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(server + fileName);
        //    request.Method = WebRequestMethods.Ftp.DownloadFile;
        //    request.Credentials = new NetworkCredential("user", "123456");

        //    using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
        //    using (Stream responseStream = response.GetResponseStream())
        //    {
        //        Đọc nội dung PDF từ phản hồi
        //        using (PdfReader reader = new PdfReader(responseStream))
        //        {
        //            Tạo file PDF mới trên máy của bạn
        //            using (FileStream fileStream = new FileStream(savePath, FileMode.Create))
        //            {
        //                using (PdfStamper stamper = new PdfStamper(reader, fileStream))
        //                {
        //                    Đảm bảo rằng không có gì cần thay đổi trong file PDF
        //                }
        //            }
        //        }
        //    }
        //}

        //public void getDataFromServer(string fileName)
        //{
        //    FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://172.16.49.219/" + fileName);
        //    request.Method = WebRequestMethods.Ftp.DownloadFile;
        //    request.Credentials = new NetworkCredential("user", "123456");

        //    using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
        //    using (Stream responseStream = response.GetResponseStream())
        //    using (StreamReader reader = new StreamReader(responseStream))
        //    {
        //        string result = reader.ReadToEnd();

        //        File.WriteAllText(fileName, result);
        //    }
        //}
    }
}
