﻿namespace Members.Core.Logging
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message, params object[] parameters)
        {
            Console.WriteLine(message, parameters);
        }
    }
}
