namespace AspWebApplication.Data;

public class TransientService
{
    public int Count { get; private set; }

    public void CountUp() => Count++;
}