public WorkPerformedEventArgs(int hours, WorkType workType)
{
    Hours = hours;
    WorkType = workType;
    
    public WorkPerformedEventArgs(int hours, WorkType workType) => (hours, workType) = (Hours, WorkType);
}