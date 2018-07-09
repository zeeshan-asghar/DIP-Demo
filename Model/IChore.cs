namespace Model
{
    public interface IChore
    {
        string ChoreName { get; set; }
        double HoursWorked { get; }
        bool IsComplete { get; }
        IPerson Owner { get; set; }

        void CompleteChore();

        void PerformedWork();

        void PerformedWork(double hours);

        void PerformedWork(int hours);
    }
}