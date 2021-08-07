using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace EmailApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fromAddress = ConfigurationManager.AppSettings.Get("fromAddress");
            string fromPassword = ConfigurationManager.AppSettings.Get("password");

            Console.WriteLine("Enter To Email Address");
            string toAddress = Console.ReadLine();

            Console.WriteLine("Enter Subject");
            string subject = Console.ReadLine();

            Console.WriteLine("Enter Message");
            string message = Console.ReadLine();

            Console.WriteLine("Sending Mail. To " + toAddress + ".......");

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(fromAddress);
            mailMessage.To.Add(new MailAddress(toAddress));
            mailMessage.Subject = subject;
            mailMessage.Body = message;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress, fromPassword)
            };
            smtp.Send(mailMessage);

            Console.WriteLine("Email Sent");
            smtp.Dispose();
            mailMessage.Dispose();
        }
    }
}
