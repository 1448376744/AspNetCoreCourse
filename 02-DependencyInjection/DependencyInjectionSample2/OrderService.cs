using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionSample2
{
    public class OrderService
    {
        private readonly ILogger _logger;
  
        public OrderService(ILogger logger)
        {
            _logger = logger;
        }
    }
}
