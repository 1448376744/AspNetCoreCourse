using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionSample2
{
    public interface ILogger : IDisposable
    {
        void Info(string message);
    }
}
