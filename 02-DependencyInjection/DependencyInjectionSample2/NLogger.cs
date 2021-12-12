using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionSample2
{
    public class NLogger : ILogger
    {
        public string Name { get; }
        public NLogger()
        {
        }
        public NLogger(string name)
        {
            Name = name;
        }
        public void Info(string message)
        {
            Console.WriteLine(message);
        }

        public void Dispose()
        {
            Console.WriteLine("释放了："+GetHashCode());
        }
    }
}
