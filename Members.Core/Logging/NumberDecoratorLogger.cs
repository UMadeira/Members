namespace Members.Core.Logging
{
    public class NumberDecoratorLogger : DecoratorLogger
    {
        public NumberDecoratorLogger(ILogger component)
            : base(component)
        {
        }

        private int Counter { get; set; } = 0;

        public override void Log(string message, params object[] parameters)
        {
            Counter++;
            message = $"{Counter} - {message}";
            base.Log(message, parameters);
        }
    }
}
