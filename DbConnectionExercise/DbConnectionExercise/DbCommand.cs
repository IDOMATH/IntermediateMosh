using System;

namespace DbConnectionExercise
{
    public class DbCommand
    {
        public DbConnection Connection { get; set; }
        public string Command { get; set; }
        public DbCommand(DbConnection connection, string command)
        {
            if (connection is null) throw new InvalidOperationException("Connection cannot be null");
            Connection = connection;
            Command = command;
        }

        public void Execute()
        {
            // Open connection
            Connection.Open();

            // Run instruction
            System.Console.WriteLine("Executed:\n{0}", Command);

            // Close connection
            Connection.Close();
        }
    }
}
