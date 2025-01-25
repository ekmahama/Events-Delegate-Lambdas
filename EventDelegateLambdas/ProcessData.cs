
public class ProcessData
{
    public void Process(int x, int y, BizRulesDelegate del)
    {
        var result = del(x, y);
        Console.WriteLine($"biz rules delegate has been processed: {result}");
    }

    public void ProcessAction(int x, int y, Action<int, int> action)
    {
        action(x,y);
        System.Console.WriteLine("Action has been processed");
    }

    public void ProcessFunc(int x, int y, Func<int, int, int> func)
    {
        var result = func(x, y);
        System.Console.WriteLine("Func has been processed");
        System.Console.WriteLine(result);
    }
}

// This is a custom delegate
public delegate int BizRulesDelegate(int x, int y);
