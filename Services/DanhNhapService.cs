using Repositories.Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;

namespace Services
{
    public class DanhNhapService
    {
        DangNhapRepository repository = new DangNhapRepository();
        public string checkLogin(string username, string password)
        {
            return repository.check(username, password);
        }
        public bool savePassword(string username, string password)
        {
            return repository.savePassword(username, password);
        }
        public string sendConfirmCode(string username)
        {
            MailService mailService = new MailService();
            Random random = new Random();

            // Tạo số ngẫu nhiên có 6 chữ số
            int randomNumber = random.Next(100000, 999999);
            string mailAddress = repository.sendCode(username);
            repository.saveCode(username, randomNumber.ToString());
            string content = "Mã xác nhận tài khoản đăng nhập của bạn là: " + randomNumber.ToString();
            if (mailAddress != "Lỗi kết nối dữ liệu" && mailAddress != "Nhân viên này không tồn tại")
            {
                mailService.sendMail("Gửi mã xã nhận khôi phục mật khẩu", content, mailAddress);
                return "Mã xác nhận đã được gửi đến email của bạn";
            }
            else
            {
                return "Không tìm thấy mail của nhân viên này! Kiểm tra lại mã đăng nhập!";
            }
        }
        public string confirmCode(string username, string code) 
        { 
            if(repository.confirmCode(username, code))
            {
                return repository.getPassword(username);
            }
            return "Mã xác nhận sai!";
        }
    }
}
