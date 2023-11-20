namespace AspWebApplication.Data;

public class SingletonService
{
    public int Count { get; private set; }

    public void CountUp() => Count++;
}