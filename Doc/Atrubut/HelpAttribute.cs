using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes

{
    public class HelpAttribute : Attribute
    {
        string _url;
        string _topic;
        public HelpAttribute(string url) => _url = url;
        public string Url => _url;
        public string Topic
        {
            get => _topic;
            set => _topic = value;
        }
    }
}
