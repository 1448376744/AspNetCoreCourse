using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionSample.Interfaces;

namespace DependencyInjectionSample.Impls
{
    internal class Log4NetLogger : ILogger
    {
        public void Info(string message)
        {
            Console.WriteLine("Log4Net:" + message);
        }
    }
}
