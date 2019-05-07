using GE.SL.Interfaces;
using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GE.SL.Servives
{
    public class EmailService : IEmailService
    {
        public async Task SendEmailAsync(string email, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Администрация сайта", "andr3ybakiev@yandex.ru"));//"aliona.sauchuk@yandex.by"));// 
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = "Регистрация";
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.yandex.ru", 25, false);
                await client.AuthenticateAsync("andr3ybakiev@yandex.ru", "9521871And0125"); //"aliona.sauchuk@yandex.by", "qwe123.");//
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }
    }
}
