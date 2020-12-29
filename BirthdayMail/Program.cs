using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BirthdayMail.Template;
using BirthdayMail.Models;
using BirthdayMail.Log;

namespace BirthdayMail
{
    class Program : BirthDayBase
    {
        static void Main(string[] args)
        {
            try
            {
                log.Write("Program Başladı");

                string Subject;
                List<Person> personList = new List<Person>();

                using (PersonDB context = new PersonDB())
                {
                    personList = context.Person.Where(x => x.BirthDate.Day == DateTime.Now.Day && x.BirthDate.Month == DateTime.Now.Month).ToList();
                }

                ITemplate BirthdayMail = new BirthdayTemp();
                TemplateStore tStore = new TemplateStore(BirthdayMail);

                foreach (Person person in personList)
                {
                    log.Write("Kişi bulundu : " + person.Name + " " + person.SurName);
                    Subject = string.Format("İyi ki Doğdun {0} {1}", person.Name, person.SurName);
                    IMessenger Message = new SendMail(person.Mail, person.Name, person.SurName, Subject, tStore.GetTemplate());

                    Notification notification = new Notification(Message);
                    notification.Send();
                }
            }
            catch (Exception ex)
            {
                log.Write("Hata : " + ex.Message.ToString());
            }

            log.Write("Bitti");
            Console.ReadLine();
        }
    }
}
