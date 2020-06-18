using System;
using System.Net;
using System.Net.Mail;

namespace Почтовый_клиент
{
    class Program
    {
        static void Main(string[] args)
        {
            MailAddress from = new MailAddress("address@mail.com","NAME");
            MailAddress to = new MailAddress("address@yandex.ru");

            MailMessage objectMail = new MailMessage(from,to);
            objectMail.Subject = "Текст";
            objectMail.Body = "<h2>Письмо-текст работы smp-клиента</h2>";
            objectMail.IsBodyHtml = true;

            SmtpClient smpt = new SmtpClient("smpt.gmail.com", 587);

            smpt.Credentials = new NetworkCredential("address@gmail.com","mypassword");
            smpt.EnableSsl = true;
            smpt.Send(objectMail);
            Console.Read();
        }
    }
}
