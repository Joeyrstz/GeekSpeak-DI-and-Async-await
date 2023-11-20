namespace AspWebApplication.Data;

public class ScopedService
{
    public int Count { get; private set; }

    public void CountUp() => Count++;
}