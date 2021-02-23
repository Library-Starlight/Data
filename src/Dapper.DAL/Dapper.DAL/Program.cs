using Dapper.DAL.Model;
using Dapper.Data.Context;
using Dapper.Data.Model;
using Dapper.Data.MySql.Context;
using System;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Dapper.DAL
{
    class Program
    {
        /// <summary>
        /// 暂存数据库库连接字符串
        /// </summary>
        private const string ConnectionString = @"Data Source=.;Initial Catalog=tempdb;Integrated Security=True";

        static void Main(string[] args)
        {
            Export();
        }

        #region ADO.NET示例

        private static void ADONET()
        {
            //var sqlFactory = DbProviderFactories.GetFactory("System.Data.SqlClient.SqlClientFactory.Instance");
            var sqlFactory = System.Data.SqlClient.SqlClientFactory.Instance as DbProviderFactory;
            var conn = sqlFactory.CreateConnection();
            conn.ConnectionString = ConnectionString;
            var command = conn.CreateCommand();
            command.CommandText = "SELECT 2";
            var adaper = sqlFactory.CreateDataAdapter();
            var dbSet = new DataSet();
            adaper.SelectCommand = command;
            adaper.Fill(dbSet);

            var table = dbSet.Tables[0];
            var value = (int)table.Rows[0][0];
            System.Console.WriteLine(value.ToString());
            conn.Close();
            conn.Dispose();
            command.Dispose();
        }

        #endregion

        #region Dapper示例

        /// <summary>
        /// C
        /// </summary>
        private static void DapperInsert()
        {
            using (var conn = GetConnection(ConnectionString))
            {
                conn.Execute(@"insert MyTable(colA, colB) values (@a, @b)",
                new[] { new { a = 1, b = 1 }, new { a = 2, b = 2 }, new { a = 3, b = 3 } });
            }
        }

        /// <summary>
        /// R
        /// </summary>
        private static void DapperSelect()
        {
            using (var conn = GetConnection(ConnectionString))
            {
                var data = conn.Query<AirCraftCarrier>("SELECT 1 AS Id, 'The most powerful war mechine in the world!' AS Description");
                Console.WriteLine(data.First().Description);

                var values = conn.Query("SELECT a = 1, 2 AS a, 3 AS A");
                Console.WriteLine(values.First().a);
                Console.WriteLine(values.First().A);

                // Exception: 区分大小写
                values = conn.Query("SELECT a = 1");
                //Console.WriteLine(values.First().A);
                Console.WriteLine(values.First());

                conn.Close();
                conn.Dispose();
            }
        }

        /// <summary>
        /// U
        /// </summary>
        private static void DapperUpdate()
        {
            using (var conn = GetConnection(ConnectionString))
            {
                var effect = conn.Execute($"UPDATE MyTable SET colA = 5");
                Console.WriteLine(effect);
            }
        }

        /// <summary>
        /// D
        /// </summary>
        private static void DapperDelete()
        {
            using (var conn = GetConnection(ConnectionString))
            {
            }
        }

        /// <summary>
        /// LINQ
        /// </summary>
        private static void DapperLINQ()
        {

        }

        /// <summary>
        /// 获取数据库连接
        /// </summary>
        /// <param name="connStr"></param>
        /// <returns></returns>
        private static DbConnection GetConnection(string connStr)
        {
            var sqlFactory = System.Data.SqlClient.SqlClientFactory.Instance as DbProviderFactory;
            var conn = sqlFactory.CreateConnection();
            conn.ConnectionString = connStr;
            return conn;
        }

        #endregion

        #region EFCore示例

        private static void EFCoreSample()
        {
            // 生成SqlServer上下文
            // dotnet ef dbcontext scaffold "Server=.;Database=AdventureWorks2012;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -o Model --context-dir Contaxt

            // 生成SqlServer脚本
            // dotnet ef dbcontext script --output SqlServer.sql

            var sqlContext = new AdventureWorks2012Context();

            var count = sqlContext.Set<Address>().Count();
            Console.WriteLine(count);

            // 生成MySql上下文(Pomelo)
            // dotnet ef dbcontext scaffold "Server=localhost;Database=databasesql;User=root;Password=357592895;TreatTinyAsBoolean=true;" Pomelo.EntityFrameworkCore.MySql -o Model --context-dir Context -c MongoContext

            // 生成MySql脚本(Pomelo)
            // dotnet ef dbcontext script --output MySql.sql

            var mySqlContext = new MongoContext();
            var totalEquip = mySqlContext.Equips.Count();
            Console.WriteLine(totalEquip);

            // 生成MySql上下文(MySql)
            // dotnet ef dbcontext scaffold "Server=localhost;Database=databasesql;User=root;Password=357592895;TreatTinyAsBoolean=true;" MySql.Data.EntityFrameworkCore -o Model --context-dir Context -c MongoContext

            // 生成MySql脚本(MySql)
            // dotnet ef dbcontext script --output MySql.sql

        }

        #endregion

        #region Dapper LINQ示例

        /// <summary>
        /// R
        /// </summary>
        private static void DapperQuery()
        {
            //var 
        }

        #endregion

        #region Excel

        /// <summary>
        /// 导出Excel
        /// </summary>
        private static void Export()
        {
            const string ConnectionString = "Data Source=.;Initial Catalog=IOTDB;Integrated Security=True";

            var sqlFactory = System.Data.SqlClient.SqlClientFactory.Instance as DbProviderFactory;
            var conn = sqlFactory.CreateConnection();
            conn.ConnectionString = ConnectionString;
            var command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Equip";
            var adaper = sqlFactory.CreateDataAdapter();
            var dbSet = new DataSet();
            adaper.SelectCommand = command;
            adaper.Fill(dbSet);

            var table = dbSet.Tables[0];

            conn.Close();
            conn.Dispose();
            command.Dispose();

            table.TableToExcel("Excel.xls");
        }

        #endregion
    }
}
