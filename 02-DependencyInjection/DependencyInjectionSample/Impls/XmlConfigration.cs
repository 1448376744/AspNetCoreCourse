using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionSample.Interfaces;

namespace DependencyInjectionSample.Impls
{
    public class XmlConfigration : IConfigration
    {
        private Dictionary<string, string> _xml = new Dictionary<string, string>();
        public XmlConfigration()
        {
            _xml = new Dictionary<string, string>()
            {
                { "price","xml:50"}
            };
        }
        public string GetSection(string name)
        {
            return _xml[name];
        }
    }
}
