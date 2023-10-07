using System.Net;
using System.Net.Mail;
using BowlHub.BLL.Services.Interfaces;
using Microsoft.Extensions.Configuration;

namespace BowlHub.BLL.Services.Classes;

public class EmailSenderService : IEmailSenderService
{
    private readonly string _fromEmail;
    private readonly string _fromEmailPassword;

    public EmailSenderService(IConfiguration configuration)
    {
        _fromEmail = configuration["EmailSender:FromEmail"]!;
        _fromEmailPassword = configuration["EmailSender:FromEmailPassword"]!;
        
        Console.WriteLine(_fromEmail);
        Console.WriteLine(_fromEmailPassword);
    }

    public async Task SendEmailAsync(string toEmail, string subject, string message)
    {
        try
        {
            using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
            {
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(_fromEmail, _fromEmailPassword);

                MailMessage mailMessage = new MailMessage(_fromEmail, toEmail, subject, message);
                await smtpClient.SendMailAsync(mailMessage);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}