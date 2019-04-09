using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayMail.Template
{
    public class TemplateStore
    {
        private ITemplate _template;
        public TemplateStore(ITemplate template)
        {
            _template = template;
        }

        public string GetTemplate()
        {
            return _template.GetTemplate();
        }
    }
}
