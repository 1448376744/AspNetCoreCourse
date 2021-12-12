using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionSample.Interfaces
{
    public interface IConfigration
    {
        string GetSection(string name);
    }
}
