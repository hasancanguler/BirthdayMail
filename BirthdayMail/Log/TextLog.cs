using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayMail.Log
{
    public class TextLog : ILog
    {
        public void Write(string Message)
        {
            File.AppendAllText("Log.txt", DateTime.Now + " - " + Message + Environment.NewLine);
        }
    }
}
