using DependencyInjectionSample2;
using Microsoft.Extensions.DependencyInjection;

//菜单
IServiceCollection services = new ServiceCollection();
//通过委托
//Singleton:与IServiceProvider的实列相关，同一个实列创建的相同的服务，相同
//Transient:每次通过IServiceProvider解析的相同的服务都是一个新的实列
//Scoped:同一个scope的ServiceProvider解析的同一个服务都是相同，不同scope之间解析出来的服务的实列不同
services.AddSingleton<ILogger>(sp =>
{
    return new NLogger("nlog");
});
//日志
//通过构造函数
//services.AddSingleton<ILogger, NLogger>();
services.AddSingleton<OrderService>();
//厨师
var provider1 = services.BuildServiceProvider();

//根容器
var provider2 = services.BuildServiceProvider();
//证明他们是否相同
Console.WriteLine("同一个配方构建出来的厨师" + object.ReferenceEquals(provider1, provider2));
//同一个厨师做的菜一样吗


var logger1 = provider1.GetRequiredService<ILogger>();

var logger2 = provider1.GetRequiredService<ILogger>();
var logger3 = provider2.GetRequiredService<ILogger>();
Console.WriteLine("同一个厨师炒的同一个菜" + object.ReferenceEquals(logger1, logger2));
Console.WriteLine("不同的厨师炒的同一个菜" + object.ReferenceEquals(logger2, logger3));
var scope1 = provider1.CreateScope();
var scope2 = provider1.CreateScope();
//子容器
var logger4 = scope1.ServiceProvider.GetRequiredService<ILogger>();
var logger5 = scope1.ServiceProvider.GetRequiredService<ILogger>();
var logger6 = scope2.ServiceProvider.GetRequiredService<ILogger>();
Console.WriteLine("同一个厨师相同的scope炒的同一个菜" + object.ReferenceEquals(logger4, logger5));
Console.WriteLine("同一个厨师不同的scope炒的同一个菜" + object.ReferenceEquals(logger5, logger6));
//释放作用域：由该scope解析的服务都将被释放，除非他是单实例的(单实列的要通过释放serviceProvide来释放)
scope1.Dispose();
scope2.Dispose();
provider1.Dispose();
provider2.Dispose();

Console.ReadKey();