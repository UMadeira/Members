namespace Members.Core.Logging
{
    public class DecoratorLogger : ILogger
    {
        public DecoratorLogger(ILogger component)
        {
            Component = component;
        }

        protected ILogger Component { get; private set; }

        public virtual void Log(string message, params object[] parameters)
        {
            Component.Log(message, parameters);
        }
    }
}
