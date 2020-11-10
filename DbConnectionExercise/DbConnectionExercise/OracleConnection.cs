namespace DbConnectionExercise
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        { }

        public override void Close()
        {
            System.Console.WriteLine("Closed Oracle connection");
        }

        public override void Open()
        {
            System.Console.WriteLine("Opened Oracle connection");
        }
    }
}
