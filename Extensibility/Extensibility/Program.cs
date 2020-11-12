namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();

            var dbFile = new DbMigrator(new FileLogger("C:\\users\\Unacc\\log.txt"));
            dbFile.Migrate();
            System.Console.WriteLine("FIle logged");
        }
    }
}
