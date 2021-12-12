using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionSample.Interfaces;

namespace DependencyInjectionSample
{
    public class OrderService
    {
        private readonly ILogger _logger;
        private readonly IConfigration _configration;
       
        public OrderService(ILogger logger, IConfigration configration)
        {
            _logger = logger;
            _configration = configration;
        }

        public void Create()
        {
            _logger.Info("订单已创建");
            var price = _configration.GetSection("price");
            _logger.Info(price);
        }
    }
}
