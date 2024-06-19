using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;


namespace BulkyBook.Utility
{
    public class EmailSender : IEmailSender
    {
        public string SendGridSecret { get; set; }
        public string FromEmail { get; set; }

        public EmailSender(IConfiguration _config)
        {
            SendGridSecret = _config.GetValue<string>("SendGrid:SecretKey");
            FromEmail = _config.GetValue<string>("SendGrid:FromEmail");
        }
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // Logic to Send An Email:>
            var client = new SendGridClient(SendGridSecret);
            var from = new EmailAddress(FromEmail, "Bulky Book");
            var to = new EmailAddress(email);
            var message = MailHelper.CreateSingleEmail(from, to, subject, "", htmlMessage);
            return client.SendEmailAsync(message);
        }
    }
}
