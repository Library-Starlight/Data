using System;
using System.Data;
using System.Linq;

namespace Dapper.DAL
{
    class Program
    {
        static void Main(string[] args)
        {
            var connStr = "Data Source=.;Initial Catalog=tempdb;Integrated Security=True";

            var provider = System.Data.SqlClient.SqlClientFactory.Instance;
            //var provider = System.Data.Common.DbProviderFactories.GetFactory("System.Data.SqlClient.SqlClientFactory");

            IDbConnection conn = provider.CreateConnection();
            conn.ConnectionString = connStr;
            var values = conn.Query("SELECT a = 1");
            Console.WriteLine(values.First().a);
        }
    }
}
