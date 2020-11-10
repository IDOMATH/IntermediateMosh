using System;

namespace DbConnectionExercise
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan TimeOut { get; set; }
        private readonly DateTime CreatedAt = DateTime.Now;

        // Constructor
        public DbConnection(string connectionString)
        {
            if (connectionString is null) throw new InvalidOperationException("Connection string cannot be null");
            ConnectionString = connectionString;
        }

        // Methods are Open(), Close(), CheckTimeOutWindow()
        public abstract void Open();
        public abstract void Close();

        // CheckTimeOutWindow()
        public void CheckTimeOutWindow()
        {
            if (DateTime.Now > CreatedAt + TimeOut) Close();
        }
    }
}
