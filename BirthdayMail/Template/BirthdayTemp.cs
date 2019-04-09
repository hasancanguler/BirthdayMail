using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayMail.Template
{
    public class BirthdayTemp : ITemplate
    {
        public string GetTemplate()
        {
            string Body = "<html><body><img src=\"https://exceptionnotfound.net/content/images/2019/04/matthew-headshot-enf-site-4.jpg\"></body></html>";

            return Body;
        }
    }
}
