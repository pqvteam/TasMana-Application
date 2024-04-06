﻿using Repositories.Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;
using System.Net.Mail;
using System.Reflection.Metadata;

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
            string mailAddress = repository.getEmail(username);
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
        public string getEmailAccount(string username)
        {
            string mailAddress = repository.getEmail(username);
            if (mailAddress != "Lỗi kết nối dữ liệu" && mailAddress != "Nhân viên này không tồn tại")
            {
                return mailAddress;
            }
            else
            {
                return "Không tìm thấy mail của nhân viên này! Kiểm tra lại mã đăng nhập!";
            }
        }
        public bool laQuanLi(string username)
        {
            if(repository.laQuanLi(username) == "1")
            { return true; }
            return false;
        }
        public bool laTruongNhom(string username)
        {
            if (repository.laTruongNhom(username) == "1")
            { return true; }
            return false;
        }
        public bool laCEO(string username)
        {
            if (repository.laCEO(username) == "1")
            { return true; }
            return false;
        }
        public bool daNghiViec(string username)
        {
            if (repository.daNghiViec(username) == "1")
            { return true; }
            return false;
        }
    }
}
