using Microsoft.Extensions.Logging;

namespace ConsoleApp;

public class Runner
{
    private readonly ILogger<Runner> _logger;
    private readonly CounterService _counterService;

    public Runner(ILogger<Runner> logger, CounterService counterService)
    {
        _logger = logger;
        _counterService = counterService;
    }

    public async Task RunAsync()
    {
        _logger.LogInformation("Now starting counter service...");
        var task = _counterService.CountUpAsync(5);
        _logger.LogInformation("Now waiting for counter service...");
        _logger.LogInformation("While waiting, I can do something else...");
        _logger.LogInformation("Waiting 2 seconds before i do something hehe...");
        await Task.Delay(TimeSpan.FromSeconds(2));
        var a = Random.Shared.Next(50);
        var b = Random.Shared.Next(50);
        var c = a + b;
        _logger.LogInformation("I calculated {A} + {B} = {C}", a, b, c);
        _logger.LogInformation("Now I really wait for it to finish ...");
        await task;
        _logger.LogInformation("Counter service finished");
    }
}