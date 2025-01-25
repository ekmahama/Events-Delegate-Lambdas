using System.Text.Json.Nodes;

internal class Program
{
    private static void Main(string[] args)
    {
        var data = new ProcessData();

        // Delegate
        BizRulesDelegate addDel = (x, y) => x + y;
        BizRulesDelegate multiplyDel = (x, y) => x * y;
        data.Process(2, 3, addDel);
        data.Process(2, 3, multiplyDel);

        // Using Action<T>

        Action<int, int> addAction = (x, y) => System.Console.WriteLine(x + y);
        Action<int, int> multiplyAction = (x, y) => System.Console.WriteLine(x * y);
        data.ProcessAction(2, 3, addAction);
        data.ProcessAction(2, 3, multiplyAction);


        // Using Func<T, TResult>
        Func<int, int, int> addFunc = (x, y) => x + y;
        Func<int, int, int> multiplyFunc = (x, y) => x * y;

        data.ProcessFunc(2, 3, addFunc);
        data.ProcessFunc(2, 3, multiplyFunc);

    }
} 

/*
Action<T> - Represents an out of the box c# delegate that takes one or more  parameters and does not return a value.
Func<T, TResult> - Represents an out of the box c# delegate that takes one or more parameters and returns a value.
*/