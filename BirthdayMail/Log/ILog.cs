using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayMail.Log
{
    public interface ILog
    {
        void Write(string Message);
    }
}
