public class Worker
{
// 2. Create an event
    //public event WorkPerformedHandler WorkPerformed;
    public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
    public event EventHandler WorkCompleted;

    public void DoWork(int hours, WorkType workType)
    {
        for (int i = 0; i < hours; i++)
        {
            Thread.Sleep(1000);
            OnWorkPerformed(i + 1, workType);
        }

        OnWorkCompleted();
    }
}

protected virtual void OnWorkPerformed(int hours, WorkType workType)
{
    WorkPerformed?.Invoke(this, new WorkPerformedEventArgs(hours, workType));
}


protected virtual void OnWorkCompleted()
{
    WorkCompleted?.Invoke(this, EventArgs.Empty);
}

// 1. Create a delegate
//public delegate int WorkPerformedHandler(int hours, WorkType workType);



