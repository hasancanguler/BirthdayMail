using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BirthdayMail.Template;

namespace BirthdayMail
{
    class Program
    {
        static void Main(string[] args)
        {
            string Subject;
            //IMessenger sendMail = new SendMail();
            PersonLogic personLogic = new PersonLogic();
            List<Person> personList = new List<Person>();

            personList = personLogic.PersonList().Where(x => x.BirthDate.Day == DateTime.Now.AddDays(-8).Day && x.BirthDate.Month == DateTime.Now.Month).ToList();

            ITemplate BirthdayMail = new BirthdayTemp();
            TemplateStore tStore = new TemplateStore(BirthdayMail);

            foreach (Person person in personList)
            {
                Subject = string.Format("İyi ki Doğdun {0} {1}", person.Name, person.SurName);
                IMessenger Message = new SendMail(person.Mail, person.Name, person.SurName, Subject, tStore.GetTemplate());

                Notification notification = new Notification(Message);
                notification.Send();
            }



            Console.ReadLine();
        }
    }
}
