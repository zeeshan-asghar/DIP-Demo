using System;

namespace Model
{
    public class Logger : ILogger
    {
        public void Log(string messaqge)
        {
            Console.WriteLine($"write to compelte {messaqge}");
        }
    }
}