using System;

namespace Extensibility
{
    public class ConsoleLogger : ILogger
    {
        public void LogErrors(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        public void LogInfo(string message)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
    }
    public class DbMigrator
    {
        private readonly ILogger _logger;
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("migration started at " + DateTime.Now);
            // Details of migration

            _logger.LogInfo("Migration finished at {0}" + DateTime.Now);
        }
    }
}
