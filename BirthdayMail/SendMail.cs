using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayMail
{
    
    public class SendMail : BirthDayBase, IMessenger
    {
        string From = "sender@mail.com";
        private string _To;
        private string _Name;
        private string _SurName;
        private string _Subject { get; set; }
        private string _Body { get; set; }

        public SendMail(string To, string Name, string SurName, string Subject, string Body)
        {
            _To = To;
            _Name = Name;
            _SurName = SurName;
            _Subject = Subject;
            _Body = Body;
        }

        public void SendMessage()
        {
            try
            {
                string Host = "your.smtp.com";
                SmtpClient client = new SmtpClient(Host);
                client.UseDefaultCredentials = true;
                client.Credentials = new NetworkCredential("user", "pass");

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(From);
                mailMessage.To.Add("test@mail.com");

                mailMessage.Body = _Body;
                mailMessage.Subject = _Subject;

                mailMessage.IsBodyHtml = true;
                client.Send(mailMessage);
                Console.WriteLine(_To + " " + _Name + " " + _SurName + " " + " Mail Gönderildi.");
                log.Write(_To + " " + _Name + " " + _SurName + " " + " Mail Gönderildi.");
            }
            catch (Exception ex)
            {
                log.Write("Hata oluştu : " + ex.Message.ToString());
            }

        }

    }
}
