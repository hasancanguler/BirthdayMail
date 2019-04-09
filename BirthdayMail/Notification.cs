using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayMail
{
    public class Notification
    {
        private IMessenger _messenger;
        public Notification(IMessenger messenger )
        {
            this._messenger = messenger;
        }
        public void Send()
        {
            _messenger.SendMessage();
        }
    }
}
