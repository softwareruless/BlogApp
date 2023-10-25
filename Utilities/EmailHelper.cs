using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using BlogApp.Data.Model;
using System;
using System.ComponentModel;
using System.Drawing;
using static System.Net.WebRequestMethods;

namespace BlogApp.Utilities
{
    public static class EmailHelper
    {
        private static readonly IConfiguration _configuration;
        private static readonly IHttpContextAccessor _httpContextAccessor;

        public static ResponseModel<string> SendVerificationMail(string Email)
        {
            try
            {
                var code = RandomHelper.CreateRandomDigits(new Random(), 6);
                // create email message
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse("mail"));
                email.To.Add(MailboxAddress.Parse(Email));
                email.Subject = "Email Doğrulama Kodunuz";
                email.Body = new TextPart(TextFormat.Html) { Text = "Doğrulama Kodunuz :" + code + "<br><a href='https://url.com/verify/" + code + "/" + Email + "'><button style='color:white; background-color: #3965f4; height : 40px; width : 100px; border-radius: 20px; border: none'>Doğrula</button></a>" };

                // send email
                using var smtp = new SmtpClient();
                smtp.Connect("mailhost", 587, SecureSocketOptions.None);
                smtp.Authenticate("mail", "password");
                smtp.Send(email);
                smtp.Disconnect(true);

                return new ResponseModel<string>()
                {
                    Success = true,
                    Data = code
                };
            }
            catch (Exception e)
            {
                return new ResponseModel<string>()
                {
                    Success = false,
                    Message = _configuration["MailServices.SendVerificationMail"]
                };
            }

        }

    }
}
