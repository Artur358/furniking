using Furniking.BLL.ConfigurationOptions;
using Furniking.BLL.DTOs.EmailDTOs;
using Furniking.BLL.Exceptions.Email;
using Furniking.BLL.Services.Interfaces;
using Furniking.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;

namespace Furniking.BLL.Services.Implementations
{
    public class EmailService : IEmailService
    {
        private readonly MailOptions _options;
        private readonly UserManager<User> _userManager;

        public EmailService(IOptions<MailOptions> options, UserManager<User> userManager)
        {
            _options = options.Value;
            _userManager = userManager;
        }

        public async Task SendMailAsync(SendEmailDTO dto)
        {
            ArgumentNullException.ThrowIfNull(dto);

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(_options.Mail);
            mailMessage.To.Add(dto.TargetEmail);
            mailMessage.Subject = dto.Subject;
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = dto.Html;
            //msg.Priority = MailPriority.High;

            SmtpClient client = new SmtpClient();
            client.Host = _options.Host;
            client.Port = _options.Port;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(_options.Mail, _options.Password);

            await client.SendMailAsync(mailMessage);
        }
    }
}
