﻿using Dapper.DAL.Model;
using System;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Dapper.DAL
{
    class Program
    {
        private const string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Sample.KeylessEntityTypes;Integrated Security=True";

        static void Main(string[] args)
        {
            DapperExecution();

            Console.ReadLine();
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

        #region Dapper

        /// <summary>
        /// 执行
        /// </summary>
        private static void DapperExecution()
        {
            var sqlFactory = System.Data.SqlClient.SqlClientFactory.Instance as DbProviderFactory;
            var conn = sqlFactory.CreateConnection();
            conn.ConnectionString = ConnectionString;

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

        /// <summary>
        /// 多插
        /// </summary>
        private static void DapperInsert()
        {
            var sqlFactory = System.Data.SqlClient.SqlClientFactory.Instance as DbProviderFactory;
            var conn = sqlFactory.CreateConnection();
            conn.ConnectionString = ConnectionString;
            var count = conn.Execute(@"insert MyTable(colA, colB) values (@a, @b)",
    new[] { new { a = 1, b = 1 }, new { a = 2, b = 2 }, new { a = 3, b = 3 } };
        }

        #endregion
    }
}
