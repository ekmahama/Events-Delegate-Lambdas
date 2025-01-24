// 1. Create a custom delegate
public delegate int WorkPerformedHandler(object sender, WorkPerformedEventArgs e);
public class Worker
{
    public event EventHandler? WorkStarted;

    // Using a custom delegate to define the signature of the event handler
    public event WorkPerformedHandler? WorkPerformed;

    // Using a generic event handler and passing custom event args. 
    // NB this is the same as the WorkPerformedHandler but with a generic event args
    public event EventHandler<WorkPerformedEventArgs>? WorkPerformed1;

    // Using a generic event handler
    public event EventHandler? WorkCompleted;

    public void ExecuteWork(int hours, WorkType worktype)
    {
        OnWorkStarted();

        for (int i = 0; i < hours; i++)
        {
            OnWorkPerformed(i + 1, worktype);
            OnWorkPerformed1(i + 1, worktype);
        }
        OnWorkCompleted();
    }

    // This method is responsible for raising the event
    protected virtual void OnWorkPerformed1(int hours, WorkType workType)
    {
        WorkPerformed1?.Invoke(this, new WorkPerformedEventArgs(hours, workType));
    }

    // This method is responsible for raising the event
    protected virtual void OnWorkPerformed(int hours, WorkType workType)
    {
        var result = WorkPerformed?.Invoke(this, new WorkPerformedEventArgs(hours, workType));

    }

    // This method is responsible for raising the event
    protected virtual void OnWorkCompleted()
    {
        WorkCompleted?.Invoke(this, EventArgs.Empty);
    }

    // This method is responsible for raising the event
    public virtual void OnWorkStarted()
    {
        WorkStarted?.Invoke(this, EventArgs.Empty);
    }

}
