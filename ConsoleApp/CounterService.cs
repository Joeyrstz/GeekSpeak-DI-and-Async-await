using Microsoft.Extensions.Logging;

namespace ConsoleApp;

public class CounterService
{
    private readonly ILogger<CounterService> _logger;
    private int count = 0;

    public CounterService(ILogger<CounterService> logger)
    {
        _logger = logger;
    }

    public async Task CountUpAsync(int times)
    {
        for (var i = 0; i < times; i++)
        {
            count++;
            _logger.LogInformation("Count increased: {Count}", count);
            await Task.Delay(TimeSpan.FromSeconds(1));
        }
    }
}