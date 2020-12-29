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
            string Body = "<html><body><img src=\"http://servis.habermetre.com/content/images/dg/dg.jpg\"></body></html>";

            return Body;
        }
    }
}
