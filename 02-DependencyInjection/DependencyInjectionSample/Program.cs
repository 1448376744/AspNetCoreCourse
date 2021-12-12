using DependencyInjectionSample;
using DependencyInjectionSample.Impls;
using DependencyInjectionSample.Interfaces;
using Microsoft.Extensions.DependencyInjection;

//配方表(服务集合，服务配置)
IServiceCollection services = new ServiceCollection();
services.AddTransient<ILogger, Log4NetLogger>();
services.AddTransient<IConfigration, JsonConfigration>();
services.AddTransient<OrderService>();

//具体化配方表的实现(实施者，提供者)
//服务提供者
IServiceProvider provider = services.BuildServiceProvider();

//获取订单服务
var order = provider.GetRequiredService<OrderService>();

//调用服务
order.Create();
Console.ReadLine();