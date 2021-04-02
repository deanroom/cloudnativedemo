using System;
using System.IO;
using System.Threading.Tasks;
using Core.Abstractions;
using Core.Implementation;
using Device.Abstractions;
using Device.Implementation;
using Framework.Abstractions;
using Framework.Implementations;
using Microsoft.Extensions.DependencyInjection;
using Runtime.Abstractions;
using Runtime.Implementation;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace App.Terminal
{
    class Program
    {  
        static Task Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();
            
            DoSomethingYouLike(host.Services);
            return host.RunAsync();
        }
        static void DoSomethingYouLike(IServiceProvider services)
        {
            using var serviceScope = services.CreateScope();
            var provider = serviceScope.ServiceProvider;
            
           var core= provider.GetRequiredService<ICore>();
           core.Start();
           core.Do("你好，车床.");
           core.Stop();
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureLogging(logging =>
                {
                    logging.ClearProviders();
                    logging.AddConsole();
                })
                .ConfigureServices((_, services) =>
                    services
                        .AddScoped<ICore, CoreDemo>()
                        .AddScoped<IDevice, DeviceDemo>()
                        .AddScoped<IFramework, FrameworkDemo>()
                        .AddScoped<IRuntime, RuntimeDemo>());

    }
}
