using System;
using System.Collections.Generic;

namespace DbConnectionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var sql = new SqlConnection("12345");
            var oracle = new OracleConnection("54321");
            var commandList = new List<DbCommand>();

            commandList.Add(new DbCommand(sql, "SELECT * FROM ALL_TABLES;"));
            commandList.Add(new DbCommand(oracle, "SELECT * FROM NO_TABLES;"));

            foreach (DbCommand command in commandList)
            {
                command.Execute();
            }
        }
    }
}
