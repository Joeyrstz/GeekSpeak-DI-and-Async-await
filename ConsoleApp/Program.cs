// See https://aka.ms/new-console-template for more information

using ConsoleApp;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        services.AddLogging(logger =>
        {
            logger.AddConsole();
            logger.AddDebug();
        });
        services.AddTransient<CounterService>();
        services.AddTransient<Runner>();
    })
    .Build();

var runner = ActivatorUtilities.CreateInstance<Runner>(host.Services);

try
{
    await runner.RunAsync();
}
catch (Exception e)
{

}
finally
{
    Console.ReadKey();
}
