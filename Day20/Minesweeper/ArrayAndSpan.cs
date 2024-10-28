using BenchmarkDotNet.Attributes;

namespace DefaultNamespace;

public class ArrayAndSpan
{
    [Benchmark]
    public void TestList()
    {
        var lst = new List<int>();
        for (int i = 0; i < 500; i++)
        {
            lst.Add(i);
        }
    }

    [Benchmark]
    public void TestArray()
    {
        var arr = new int[1000];
        for (int i = 0; i < 1000; i++)
        {
            arr[i] = i;
        }
    }
}