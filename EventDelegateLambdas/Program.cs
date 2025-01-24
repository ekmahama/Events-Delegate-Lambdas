internal class Program
{
    private static void Main(string[] args)
    {
        // NB: Events are notifcations/messages sent by an object to signal that something has happened
        // A delegate is the glue/pipeline that connects the events and an event handlers. 
        //It is a type that respresent pointers to method that can be invoked by the event
        // Event handlers recieved evartArgs from delegate amd process them. 

        var worker = new Worker();
        
        // var workPerformedHandler1 = new WorkPerformedHandler(WorkPerfomed1);
        // var workPerformedHandler2 = new WorkPerformedHandler(WorkPerfomed2);
        // workPerformedHandler1 += workPerformedHandler2;

        // int finalHours = workPerformedHandler1(10, WorkType.GenerateReports);


        // static int WorkPerfomedEventHandler1(int hours, WorkType workType)
        // {
        //     Console.WriteLine($"WorkPerfomed1 called: {workType} done with {hours} hours.");
        //     return hours + 1;
        // }

        // static int WorkPerfomedEventHandler2(int hours, WorkType workType)
        // {
        //     Console.WriteLine($"WorkPerfomed2 called with {hours} hours of {workType}");
        //     return hours + 2;
        // }
    }
}