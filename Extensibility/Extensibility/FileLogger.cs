using System;
using System.IO;

namespace Extensibility
{
    
    public class FileLogger : ILogger
    {
        public enum LogType
        {
            INFO,
            ERROR
        }
        private readonly string _path;
        public FileLogger(string path)
        {
            _path = path;
        }
        public void LogErrors(string message)
        {
            Log(message, (LogType)1);
            
        }

        public void Log(string message, LogType logType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(logType + ": " + message);
            }
        }

        public void LogInfo(string message)
        {
            Log(message, (LogType)0);
        }
    }
}
