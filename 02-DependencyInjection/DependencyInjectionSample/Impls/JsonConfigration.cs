using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionSample.Interfaces;

namespace DependencyInjectionSample.Impls
{
    public class JsonConfigration : IConfigration
    {
        private Dictionary<string, string> _json = new Dictionary<string, string>();
        public JsonConfigration()
        {
            _json = new Dictionary<string, string>()
            {
                { "price","json:50"}
            };
        }
        public string GetSection(string name)
        {
            return _json[name];
        }
    }
}
