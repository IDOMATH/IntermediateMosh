namespace DbConnectionExercise
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            :base(connectionString)
        { }

        public override void Close()
        {
            System.Console.WriteLine("Closed SQL connection");
        }

        public override void Open()
        {
            System.Console.WriteLine("Opened SQL connection");
        }
    }
}
