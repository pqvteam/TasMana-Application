using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class MailService
    {
        /*
         * name: sendMail
         * usage: send mail to a person
         * params: mailSubject - the subject of mail, content: mail's content, mailAddress: address of receiver
         * return: none
         */
        public void sendMail(string mailSubject, string content, string mailAddress)
        {
            try
            {
                var fromAddress = new MailAddress("pqvcorporation@gmail.com");
                var toAddress = new MailAddress(mailAddress);
                const string frompass = "cmvc xgbi qatz ppno";
                var subject = mailSubject;
                string body = content;

                var smtp = new SmtpClient()
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, frompass),
                    Timeout = 200000
                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
