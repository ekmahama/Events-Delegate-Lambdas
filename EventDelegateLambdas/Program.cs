internal class Program
{
    private static void Main(string[] args)
    {
        // NB: Events are notifcations/messages sent by an object to signal that something has happened
        // A delegate is the glue/pipeline that connects the events and an event handlers. 
        //It is a type that respresent pointers to method that can be invoked by the event
        // Event handlers recieved evartArgs from delegate amd process them. 
        var worker = new Worker();

        // this use lambda expression to define the event handler
        worker.WorkStarted += (s, e) => Console.WriteLine($"Logging Work started event");

        //worker.WorkPerformed += new WorkPerformedHandler(WorkPerformed);
        
        // This is the same as the above line but uses delegate inference
        worker.WorkPerformed += WorkPerformed; 

        // this use lambda expression to define the event handler
        worker.WorkCompleted += (s, e) => Console.WriteLine($"Logging Work completed event");
        
        worker.ExecuteWork(8, WorkType.Golf);
    }

    /* 
        This method is the event handler
        Event handlers recieved evartArgs from delegate amd process them. 
    */
    public static int WorkPerformed(Object sender, WorkPerformedEventArgs e)
    {
        Console.WriteLine($" Logging workPerformed event: Work performed for {e.Hours} hours on {e.WorkType}");
        return e.Hours  + 1;
    }
}