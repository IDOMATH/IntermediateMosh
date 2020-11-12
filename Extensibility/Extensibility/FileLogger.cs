using System;
using System.IO;

namespace Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;
        public FileLogger(string path)
        {
            _path = path;
        }
        public void LogErrors(string message)
        {
            Log(message, "ERROR");
            
        }

        public void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + ": " + message);
            }
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }
    }
}
