using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql.DAL
{
    public class MySqlDatabase
    {
        #region 私有字段

        /// <summary>
        /// 连接实例
        /// </summary>
        private readonly MySqlConnection _conn;

        MySqlCommand cmd;
        MySqlDataReader rd = null;

        MySqlDataAdapter adp = null;
        MySqlCommandBuilder cmdbuild;
        MySqlTransaction trans;

        #endregion

        #region 构造函数

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="connStr"></param>
        public MySqlDatabase(string connStr)
        {
            _conn = new MySqlConnection(connStr);
        }

        #endregion

        #region 公共方法

        public void SaveByDataAdapter()
        {
            var sql = "SELECT * FROM equip ORDER BY equip_no";
            SaveByDataAdapter(sql);

            //sql = "SELECT * FROM ycp WHERE equip_no IN (1,2,3) ORDER BY yc_no";
            //sql = "SELECT equip.equip_nm,ycp.* FROM ycp,equip  WHERE ycp.equip_no=equip.equip_no and ycp.equip_no IN (1,2,3)  ORDER BY ycp.equip_no,yc_no";
            sql = "SELECT * FROM ycp  WHERE equip_no IN (1,2,3)  ORDER BY equip_no,yc_no";

            SaveByDataAdapter(sql);
        }

        /// <summary>
        /// 通过数据适配器保存数据结构
        /// </summary>
        public void SaveByDataAdapter(string sql)
        {

            CheckConnectState();

            var command = new MySqlCommand(sql);
            command.Connection = _conn;

            var adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            var set = new DataSet();
            adapter.Fill(set);

            var table = set.Tables[0];

            //table.Rows[1]["Reserve1"] = $"测点1号{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}";

            // 步骤1
            GetDataAdapter(sql);

            // 步骤2
            SaveDataTableWithDataAdapter(table);
        }

        #endregion

        #region 私有方法

        /// <summary>
        /// 获取数据适配器
        /// </summary>
        /// <param name="sql"></param>
        private void GetDataAdapter(string strSQL)
        {
            CheckConnectState();
            cmd = new MySqlCommand(strSQL, _conn);
            adp = new MySqlDataAdapter(cmd);
            cmdbuild = new MySqlCommandBuilder(adp);

            CloseConnect();
        }

        /// <summary>
        /// 保存数据结构
        /// </summary>
        /// <param name="table"></param>
        private void SaveDataTableWithDataAdapter(DataTable dt)
        {
            int k = dt.Columns.Count;
            int k1 = dt.Rows.Count;

            CheckConnectState();
            if (adp != null)
                adp.Update(dt);

            CloseConnect();
        }


        /// <summary>
        /// 检查数据库连接状态
        /// </summary>
        void CheckConnectState()
        {
            if (_conn.State == ConnectionState.Closed)
                _conn.Open();
            if (_conn.State == ConnectionState.Broken)
            {
                _conn.Close();
                _conn.Open();
            }
        }

        void CloseConnect()
        {
            if (_conn.State != ConnectionState.Closed)
                _conn.Close();
        }

        public DataTable GetDataTableFromSQL(string strSQL)
        {
            string SQL;
            //    SQL = myAlarmCenterCore.ConvertAccessSQL2SQLServerSQL(strSQL);


            DataTable dt;
            MySqlDataReader rd;
            dt = new DataTable();

            try
            {
                CheckConnectState();

                cmd = new MySqlCommand(strSQL, _conn);
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                rd.Close();
                //dt = rd.GetSchemaTable();
            }
            catch (Exception e)
            {
                dt = null;
                Console.WriteLine(e);
            }
            finally
            {
                CloseConnect();
            }
            return dt;
        }

        #endregion
    }
}
