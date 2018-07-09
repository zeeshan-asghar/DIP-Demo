namespace Model
{
    public class Chore : IChore
    {
        private ILogger _logger;
        private IMessageSender _messageSender;

        public Chore(ILogger logger, IMessageSender messageSender)
        {
            _logger = logger;
            _messageSender = messageSender;
        }

        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }

        public double HoursWorked { get; private set; }

        public bool IsComplete { get; private set; }

        public void PerformedWork(int hours)
        {
            HoursWorked += hours;

            _logger.Log($"PErformed wortk on {ChoreName}");
        }

        public void CompleteChore()
        {
            IsComplete = true;
            _logger.Log($"Completed {ChoreName}");

            _messageSender.SendMessage(Owner, $"The chore {ChoreName} is completed.");
        }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;

            _logger.Log($"PErformed wortk on {ChoreName}");
        }

        public void PerformedWork()
        {
            HoursWorked += 1;
            _logger.Log($"PErformed wortk on {ChoreName}");
        }
    }
}