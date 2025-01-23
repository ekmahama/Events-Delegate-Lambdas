// See https://aka.ms/new-console-template for more information
// NB: Events are notifcations/messages sent by an object to signal that something has happened
// A delegate is the glue/pipeline that connects the events and an event handlers. 
//It is a type that respresent pointers to method that can be invoked by the event
// Event handlers recieved evartArgs from delegate amd process them. 
var del1 = new WorkPerformedHandler(WorkPerfomed1);
var del2 = new WorkPerformedHandler(WorkPerfomed2);
del1 += del2;

int finalHours = del1(10, WorkType.GenerateReports);


static int WorkPerfomed1(int hours, WorkType workType)
{
    Console.WriteLine($"WorkPerfomed1 called: {workType} done with {hours} hours.");
    return hours + 1;
}

static int WorkPerfomed2(int hours, WorkType workType)
{
    Console.WriteLine($"WorkPerfomed2 called with {hours} hours of {workType}");
    return hours + 2;
}



// 1. Create a delegate
public delegate int WorkPerformedHandler(int hours, WorkType workType);

public enum WorkType
{
    GoToMeetings,
    Golf,
    GenerateReports
}