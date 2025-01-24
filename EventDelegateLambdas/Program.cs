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

        // Instaniate the delegate and pass the event handler to it
        worker.WorkPerformed += new WorkPerformedHandler(WorkPerformed);

        //Instaniate the delegate and pass the event handler to it
        worker.WorkPerformed1 += new EventHandler<WorkPerformedEventArgs>(WorkPerformed1);

        // this is the same as above but uses delegate inference (so it will notiffy twice)
        worker.WorkPerformed1 += WorkPerformed1;

        // this is the same as above but uses delegate inference (so it will notiffy twice)
        worker.WorkPerformed += WorkPerformed; 

        // this use lambda expression to define the event handler. These two are the same.
        worker.WorkCompleted += new EventHandler((s, e) => Console.WriteLine($"Logging Work completed event"));
        worker.WorkCompleted += (s, e) => Console.WriteLine($"Logging Work completed event");
        
        worker.ExecuteWork(4, WorkType.Golf);
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

    public static void WorkPerformed1(Object? sender, WorkPerformedEventArgs e)
    {
        Console.WriteLine($" Logging workPerformed1 event: Work performed for {e.Hours} hours on {e.WorkType}");
    }
}