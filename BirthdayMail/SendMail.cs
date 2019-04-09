using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayMail
{
    public class SendMail : IMessenger
    {
        string From = "INSANKAYNAKLARI@duzey.com.tr";
        private string _To;
        private string _Name;
        private string _SurName;
        private string _Subject { get; set; }
        private string _Body { get; set; }

        public SendMail(string To, string Name, string SurName,string Subject, string Body)
        {
            _To = To;
            _Name = Name;
            _SurName = SurName;
            _Subject = Subject;
            _Body = Body;
        }

        public void SendMessage()
        {
            string Host = "81.8.6.21";
            SmtpClient client = new SmtpClient(Host);
            client.UseDefaultCredentials = true;
            //client.Credentials = new NetworkCredential("username", "password");

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(From);
            mailMessage.To.Add("hasancan.guler@tat.com.tr");

            mailMessage.Body = _Body;
            mailMessage.Subject = _Subject;

            mailMessage.IsBodyHtml = true;
            client.Send(mailMessage);

            Console.WriteLine(_To + " " + _Name + " " + _SurName + " " + " Mail Gönderildi.");
        }

    }
}
