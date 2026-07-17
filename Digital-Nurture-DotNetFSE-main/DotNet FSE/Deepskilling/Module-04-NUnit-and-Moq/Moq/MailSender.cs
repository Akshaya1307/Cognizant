using System.Net;
using System.Net.Mail;

namespace CustomerCommLib
{
    public class MailSender : IMailSender
    {
        public bool SendMail(string toAddress, string message)
        {
            // Real implementation would send an email.
            // For the hands-on, simply return true.
            return true;
        }
    }
}
