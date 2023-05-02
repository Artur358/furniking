using System.Net;
using System.Net.Mail;

namespace Furniking.BLL.Helpers.Email
{
    public static class EmailHelper
    {
        public static async Task SendAsync(string to, string subject, string html)
        {
            MailMessage mailMessage = new MailMessage()
            {

            };
            mailMessage.From = new MailAddress("care@yogihosting.com");
            mailMessage.To.Add(new MailAddress(to));

            mailMessage.Subject = subject;
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = html;

            SmtpClient client = new SmtpClient()
            {
                Credentials = new NetworkCredential("care@yogihosting.com", "yourpassword"),
                Host = "smtp.gmail.com",
                Port = 587
            };
            await client.SendMailAsync(mailMessage);
        }
    }
}
