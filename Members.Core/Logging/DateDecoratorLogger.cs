namespace Members.Core.Logging
{
    public class DateDecoratorLogger : DecoratorLogger
    {
        public DateDecoratorLogger(ILogger component)
            : base(component)
        {
        }

        public override void Log(string message, params object[] parameters)
        {
            var time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            message = $"{time} - {message}";
            base.Log(message, parameters);
        }
    }
}
