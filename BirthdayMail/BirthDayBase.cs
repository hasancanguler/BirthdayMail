using BirthdayMail.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayMail
{
    public abstract class BirthDayBase
    {       
        public static ILog log = new TextLog();        
    }
}
