using System.Text.Json.Nodes;

internal class Program
{
    private static void Main(string[] args)
    {
        // We are using lambda expression to instantiate the delegate
        AddHandler addHandler = (a,b) => a + b;
        
        addHandler += (a, b) => 
        {
            System.Console.WriteLine($"The result {a} - {b} : " + (a - b));
            return a + b;
        };

        var a = 2;
        var b = 3;
        int result = addHandler(a, b);

        LogingHandler logingHandler = () =>
        {
            System.Console.WriteLine("This logs a message");
            return true;
        };

        logingHandler();

        var cust = new List<Customer>
        {
            new Customer { Id = 1, Name = "John" },
            new Customer { Id = 2, Name = "Doe" },
            new Customer { Id = 3, Name = "Jane" },
            new Customer { Id = 4, Name = "Eddie" }

        };

        /*
         The lamda expression used to fitler the customers whose name starts with "J" 
         is a predicate that returns a boolean value. 

         NB: Predicate is a function or expression that returns a boolean value
        */

        var D = cust
            .Where(c => c.Name.StartsWith("J"))
            .OrderBy(c => c.Name)
            .ToList();
    }
} 

delegate int AddHandler(int a, int b);
delegate bool LogingHandler();

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
}
