namespace Members.Core.Logging
{
    public class CompositeLogger : ILogger
    {
        public CompositeLogger(params ILogger[] loggers)
        {
            foreach (ILogger logger in loggers)
            {
                Loggers.Add(logger);
            }
        }

        private IList<ILogger> Loggers { get; } = new List<ILogger>();

        public void Add(ILogger logger)
        {
            Loggers.Add(logger);
        }

        public void Log(string message, params object[] parameters)
        {
            foreach (ILogger logger in Loggers)
            {
                logger.Log(message, parameters);
            }
        }
    }
}
