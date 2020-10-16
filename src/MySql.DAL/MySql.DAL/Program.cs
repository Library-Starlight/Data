using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql.DAL
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var connStr = "Server=127.0.0.1;Database=databasesql;Uid=root;Port=3306;charset=utf8;allow zero datetime=true;Pwd=357592895";

                //new MySqlDatabase(connStr).SaveByDataAdapter();

                //var sql =
                //    "SELECT '无' AS PlanNo, '' AS Content, '' AS LastEditor, '' AS EditData, NULL AS Reserver1, NULL AS Reserver2, NULL AS Reserver3, 1 AS IsModel " +
                //    "UNION ALL " +
                //    "SELECT * FROM GWPlan WHERE IsModel=1";
                //var sql =
                //    "SELECT * FROM GWPlan WHERE IsModel=1";

                //var sql = 
                //    "select '无' AS PlanNo, '' AS Content, '' AS LastEditor, '' AS EditData, NULL AS Reserver1, NULL AS Reserver2, NULL AS Reserver3, 1 AS IsModel " +
                //    "from GWPlan " +
                //    "WHERE IsModel = 1";

                var sql =
                    "SELECT '无' AS PlanNo, NULL AS Content, NULL AS LastEditor, NULL AS EditDate, NULL AS Reserve1, NULL AS Reserve2, NULL AS Reserve3, 1 AS IsModel " + 
                    "UNION ALL " +
                    "SELECT PlanNo, Content, LastEditor, EditDate, Reserve1, Reserve2, Reserve3, IsModel " +
                    "FROM GWPlan WHERE IsModel=1 ";

                var table = new MySqlDatabase(connStr).GetDataTableFromSQL(sql);
                Console.WriteLine(table.Rows.Count);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadLine();
        }

    }
}
