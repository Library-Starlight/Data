using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.Common;
using ICSharpCode.Core;
using AlarmCenter.Core;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace AlarmCenter.DataCenter
{
    /// <summary>
    /// 监控系统数据库包装类
    /// </summary>
    public class MySqlDatabase : IDatabase
    {
        MySqlConnection conn;

        MySqlCommand cmd;
        MySqlDataReader rd = null;

        MySqlDataAdapter adp = null;
        MySqlCommandBuilder cmdbuild;
        MySqlTransaction trans;

         object olock = true;

         readonly string DatabaseProperty = "AlarmCenter.Gui.OptionPanels.DatabaseOptions";

         public  string Cnnstr
         {
             get
             {
                 return cnnstr;
             }
         }

         public DbDataAdapter DataAdapter
         {
             get
             {              
                 return adp;
             }
         }

          string cnnstr;
          string dbpath;

          public void CompactDB()
          {

              System.Diagnostics.ProcessStartInfo ps = new System.Diagnostics.ProcessStartInfo("msaccess.exe", dbpath + " /compact");
              ps.UseShellExecute = true;
              ps.CreateNoWindow = true;//加这一句 
              //      ps.WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized;
              System.Diagnostics.Process p = System.Diagnostics.Process.Start(ps);
              p.WaitForExit();

          }

        public MySqlDatabase(string csPWD)
        {
            try
            {
                
                Properties properties = PropertyService.Get(DatabaseProperty, new Properties());
    //            cnnstr = "Data Source=192.168.0.20;Initial Catalog=DatabaseSQL;MultipleActiveResultSets=true;Persist Security Info=True;User ID=sa;pwd=8888";

                cnnstr = @"Server="
                                + properties.Get("MySql.IP", "") + ";" + "Database="
                                + properties.Get("MySql.Database", "") + ";" + "Uid="
                                + properties.Get("MySql.UID", "") + ";" +"Port="
                                + properties.Get("MySql.PORT", "3306") + ";" + "charset=utf8;allow zero datetime=true;" + "Pwd="//必须加上charset=utf8; 否则不能显示中文
                                + csPWD;

                if(conn==null)
                    conn = new MySqlConnection(cnnstr);

            }
            catch (Exception e)
            {
            //    MessageService.AddMessage(MessageLevel.Fatal, e.ToString(), 0);
                DataCenter.WriteLogFile(e.ToString());
            }
        }


        public void Dispose()
        {
            if (conn != null)
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
            if (adp != null)
            {
                adp.Dispose();
                adp = null;
            }
            if (cmd != null)
            {
                cmd.Dispose();
                cmd = null;
            }
            if (cmdbuild != null)
            {
                cmdbuild.Dispose();
                cmdbuild = null;
            }

            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// 检查数据库连接状态
        /// </summary>
        void CheckConnectState()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            if (conn.State == ConnectionState.Broken)
            {
                conn.Close();
                conn.Open();
            }
        }

        void CloseConnect()
        {
            if (conn.State != ConnectionState.Closed)
                conn.Close();
        }

        public void GetDataAdapter(string strSQL)
        {
            lock (olock)
            {
                try
                {
                    CheckConnectState();
                    cmd = new MySqlCommand(strSQL, conn);
                    adp = new MySqlDataAdapter(cmd);
                    cmdbuild = new MySqlCommandBuilder(adp);
                }
                catch (Exception e)
                {
                    //      MessageService.AddMessage(MessageLevel.Fatal, e.ToString(), 0);
                    DataCenter.WriteLogFile(e.ToString());
                }
                finally
                {
                    CloseConnect();
                }
                //      return adp;
            }
        }

        public void SaveDataTableWithDataAdapter(DataTable dt)
        {
            lock (olock)
            {
                int k = dt.Columns.Count;
                int k1 = dt.Rows.Count;
                try
                {
                    CheckConnectState();
                    if (adp != null)
                        adp.Update(dt);
                }
                catch (Exception e)
                {
                    //    MessageService.AddMessage(MessageLevel.Fatal, e.ToString(), 0);
                    DataCenter.WriteLogFile(e.ToString());
                }
                finally
                {
                    CloseConnect();
                }
            }
        }

        public void ExecuteSQLsWithTransaction(string[] cmdtext)
        {
            lock (olock)
            {
                //该函数取消事务功能，原因是执行该函数过程中，如果有其它并发的数据库操作，则会出错！典型就是定时任务中的数据抄表功能。
                try
                {
                    CheckConnectState();
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;

                    for (int i = 0; i < cmdtext.Length; i++)
                    {
                //        cmdtext[i] = myAlarmCenterCore.ConvertAccessSQL2SQLServerSQL(cmdtext[i]);
                        cmd.CommandText = cmdtext[i];
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    //    MessageService.AddMessage(MessageLevel.Fatal, e.ToString(), 0);
                    DataCenter.WriteLogFile(e.ToString());
                }
                finally
                {
                    CloseConnect();
                }
            }
        }

        public DataRow GetDataRowOfEquip(int sta_no, int equip_no)
        {
            lock (olock)
            {
                DataTable dt;
                MySqlDataReader rd;
                DataRow dr = null;
                dt = new DataTable();

                try
                {
                    CheckConnectState();
                    string query = string.Format("select * from equip where sta_n = {0} and equip_no = {1}", sta_no, equip_no);

                    cmd = new MySqlCommand(query, conn);
                    rd = cmd.ExecuteReader();
                    dt.Load(rd);
                    dr = dt.Rows[0];
                    rd.Close();
                }
                catch (Exception e)
                {
                    //    MessageService.AddMessage(MessageLevel.Fatal, e.ToString(), 0);
      //              DataCenter.WriteLogFile(e.ToString());
                }
                finally
                {
                    CloseConnect();
                }
                return dr;
            }
        }

        public DataRow GetDataRowOfSetParm(int eqp_no, int set_no)
        {
            lock (olock)
            {
                DataTable dt;
                MySqlDataReader rd;
                DataRow dr = null;
                dt = new DataTable();

                try
                {
                    CheckConnectState();
                    string query = string.Format("select * from SetParm where equip_no = {0} and set_no = {1}", eqp_no, set_no);

                    cmd = new MySqlCommand(query, conn);
                    rd = cmd.ExecuteReader();
                    dt.Load(rd);
                    dr = dt.Rows[0];
                    rd.Close();
                }
                catch (Exception e)
                {
                    //      MessageService.AddMessage(MessageLevel.Fatal, e.ToString(), 0);
                    DataCenter.WriteLogFile(e.ToString());
                }
                finally
                {
                    CloseConnect();
                }
                return dr;
            }
        }

        public DataRow GetDataRowOfZiChan(string ZCID)
        {
            lock (olock)
            {
                DataTable dt;
                MySqlDataReader rd;
                DataRow dr = null;
                dt = new DataTable();

                try
                {
                    CheckConnectState();
                    string query = "Select * From GWZiChanTable where ZiChanID = " + "'" + ZCID + "'";

                    cmd = new MySqlCommand(query, conn);
                    rd = cmd.ExecuteReader();
                    dt.Load(rd);
                    dr = dt.Rows[0];
                    rd.Close();
                }
                catch (Exception e)
                {
                    // MessageService.AddMessage(MessageLevel.Fatal, e.ToString(), 0);
                    DataCenter.WriteLogFile(e.ToString());
                }
                finally
                {
                    CloseConnect();
                }
                return dr;
            }
        }

        public DataTable GetDataTableOfEquip()
        {
            lock (olock)
            {
                DataTable dt;
                MySqlDataReader rd;
                dt = new DataTable();

                try
                {
                    CheckConnectState();
                    string query = string.Format("select * from equip order by equip_no");

                    cmd = new MySqlCommand(query, conn);
                    rd = cmd.ExecuteReader();
                    dt.Load(rd);
                    rd.Close();
                }
                catch (Exception e)
                {
                    //     MessageService.AddMessage(MessageLevel.Fatal, e.ToString(), 0);
                    DataCenter.WriteLogFile(e.ToString());
                    dt = null;
                }
                finally
                {
                    CloseConnect();
                }
                return dt;
            }
        }

        /// <summary>
        /// 得到报警人员列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetAdminsOfAlarm(int iEquip, DateTime time)
        {
            DataTable dt_Spc, dt_Week, dt_Limit, dt_Administrator, dt;
            dt = new DataTable();

            dt_Spc = GetDataTableFromSQL("Select * From SpeAlmReport");
            dt_Week = GetDataTableFromSQL("Select * From WeekAlmReport");
            dt_Limit = GetDataTableFromSQL("Select * From AlmReport");
            dt_Administrator = GetDataTableFromSQL("Select * From Administrator Order By Administrator");

            dt = dt_Administrator.Clone();
            dt.Rows.Clear();

            List<string> AdminsList = new List<string>();
            foreach (DataRow r in dt_Spc.Rows)
            {
                if (time.CompareTo(Convert.ToDateTime(r["begin_time"])) >= 0 && time.CompareTo(Convert.ToDateTime(r["end_time"])) <= 0)
                {
                    if (AdminLimit2EquipNo(Convert.ToString(r["Administrator"]), iEquip))
                    {
                        foreach (DataRow r1 in dt_Administrator.Rows)
                        {
                            if (Convert.ToString(r1["Administrator"]) == Convert.ToString(r["Administrator"]))
                            {
                                if (!AdminsList.Contains(Convert.ToString(r1["Administrator"])))
                                {
                                    dt.ImportRow(r1);
                                    AdminsList.Add(Convert.ToString(r1["Administrator"]));
                                }
                                //  dt.Rows.Add(r1);
                                break;
                            }
                        }
                    }
                }
            }

            if (dt.Rows.Count == 0)//特定日期排表无对应报警处理人员
            {
                foreach (DataRow r in dt_Week.Rows)
                {
                    if (Convert.ToInt32(r["week_day"]) == General.GetDayOfWeek(time) || Convert.ToInt32(r["week_day"]) == 0)
                    {
                        if (time.TimeOfDay >= Convert.ToDateTime(r["begin_time"]).TimeOfDay && time.TimeOfDay <= Convert.ToDateTime(r["end_time"]).TimeOfDay)
                        {
                            if (AdminLimit2EquipNo(Convert.ToString(r["Administrator"]), iEquip))
                            {
                                foreach (DataRow r1 in dt_Administrator.Rows)
                                {
                                    if (Convert.ToString(r1["Administrator"]) == Convert.ToString(r["Administrator"]))
                                    {
                                        if (!AdminsList.Contains(Convert.ToString(r1["Administrator"])))
                                        {
                                            dt.ImportRow(r1);
                                            AdminsList.Add(Convert.ToString(r1["Administrator"]));
                                        }
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (dt.Rows.Count == 0)//周排表无对应报警处理人员
            {
                foreach (DataRow r in StationItem.db_AdminForAlarm.Rows)
                {
                    if (AdminLimit2EquipNo(Convert.ToString(r["Administrator"]), iEquip))
                    {
                        foreach (DataRow r1 in dt_Administrator.Rows)
                        {
                            if (Convert.ToString(r1["Administrator"]) == Convert.ToString(r["Administrator"]))
                            {
                                if (!AdminsList.Contains(Convert.ToString(r1["Administrator"])))
                                {
                                    dt.ImportRow(r1);
                                    AdminsList.Add(Convert.ToString(r1["Administrator"]));
                                }
                                break;
                            }
                        }
                    }
                }
            }
            if (dt.Rows.Count == 0)//无动态添加报警处理人员
            {
                foreach (DataRow r in dt_Limit.Rows)
                {
                    if (AdminLimit2EquipNo(Convert.ToString(r["Administrator"]), iEquip))
                    {
                        foreach (DataRow r1 in dt_Administrator.Rows)
                        {
                            if (Convert.ToString(r1["Administrator"]) == Convert.ToString(r["Administrator"]))
                            {
                                if (!AdminsList.Contains(Convert.ToString(r1["Administrator"])))
                                {
                                    dt.ImportRow(r1);
                                    AdminsList.Add(Convert.ToString(r1["Administrator"]));
                                }
                                break;
                            }
                        }
                    }
                }
            }
            return dt;
        }

        bool AdminLimit2EquipNo(string admin, int iEquip)
        {
            DataTable dt_EquipGroup, dt_Limit;
            dt_Limit = GetDataTableFromSQL("Select * From AlmReport");
            dt_EquipGroup = GetDataTableFromSQL("Select * From EquipGroup");
            foreach (DataRow r in dt_Limit.Rows)
            {
                if (Convert.ToString(r["Administrator"]).Trim() == admin.Trim())
                {
                    foreach (DataRow r1 in dt_EquipGroup.Rows)
                    {
                        if (Convert.ToInt32(r1["group_no"]) == Convert.ToInt32(r["group_no"]))
                        {
                            string strEqp = "#" + iEquip + "#";
                            if (Convert.ToString(r1["equipcomb"]).IndexOf(strEqp) >= 0)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public DataTable GetDataTableOfYCP(int sta_no, int equip_no)
        {
            lock (olock)
            {
                DataTable dt;
                MySqlDataReader rd;
                dt = new DataTable();

                try
                {
                    CheckConnectState();
                    string query = string.Format("select * from ycp where sta_n = {0} and equip_no = {1} order by equip_no,yc_no", sta_no, equip_no);

                    cmd = new MySqlCommand(query, conn);
                    rd = cmd.ExecuteReader();
                    dt.Load(rd);
                    rd.Close();
                }
                catch (Exception e)
                {
                    //     MessageService.AddMessage(MessageLevel.Fatal, e.ToString(), 0);
                    DataCenter.WriteLogFile(e.ToString());
                    dt = null;
                }
                finally
                {
                    CloseConnect();
                }
                return dt;
            }
        }

        public DataTable GetDataTableOfYXP(int sta_no, int equip_no)
        {
            lock (olock)
            {
                DataTable dt;
                MySqlDataReader rd;
                dt = new DataTable();

                try
                {
                    CheckConnectState();
                    string query = string.Format("select * from yxp where sta_n = {0} and equip_no = {1} order by equip_no,yx_no", sta_no, equip_no);

                    cmd = new MySqlCommand(query, conn);
                    rd = cmd.ExecuteReader();
                    dt.Load(rd);
                    rd.Close();
                }
                catch (Exception e)
                {
                    //    MessageService.AddMessage(MessageLevel.Fatal, e.ToString(), 0);
                    DataCenter.WriteLogFile(e.ToString());
                    dt = null;
                }
                finally
                {
                    CloseConnect();
                }
                return dt;
            }
        }

        public DataTable GetDataTableOfSetParm(int sta_no, int equip_no)
        {
            lock (olock)
            {
                DataTable dt;
                MySqlDataReader rd;
                dt = new DataTable();

                try
                {
                    CheckConnectState();
                    string query = string.Format("select * from SetParm where sta_n = {0} and equip_no = {1}", sta_no, equip_no);

                    cmd = new MySqlCommand(query, conn);
                    rd = cmd.ExecuteReader();
                    dt.Load(rd);
                    rd.Close();
                }
                catch (Exception e)
                {
                    //     MessageService.AddMessage(MessageLevel.Fatal, e.ToString(), 0);
                    DataCenter.WriteLogFile(e.ToString());
                    dt = null;
                }
                finally
                {
                    CloseConnect();
                }
                return dt;
            }
        }

        public DataTable GetDataTableFromSQL(string strSQL)
        {
            lock (olock)
            {
                string SQL;
            //    SQL = myAlarmCenterCore.ConvertAccessSQL2SQLServerSQL(strSQL);


                DataTable dt;
                MySqlDataReader rd;
                dt = new DataTable();

                try
                {
                    CheckConnectState();

                    cmd = new MySqlCommand(strSQL, conn);
                    rd = cmd.ExecuteReader();
                    dt.Load(rd);
                    rd.Close();
                    //dt = rd.GetSchemaTable();
                }
                catch (Exception e)
                {
                    //    MessageService.AddMessage(MessageLevel.Fatal, e.ToString(), 0);
                    DataCenter.WriteLogFile(e.ToString() + "---执行SQL语句:" + strSQL);
                    dt = null;
                }
                finally
                {
                    CloseConnect();
                }
                return dt;
            }
        }

        public object GetObjectFromSQL(string strSQL)
        {
            lock (olock)
            {
                object obj = null;
                try
                {
                    CheckConnectState();
                    cmd = new MySqlCommand(strSQL, conn);
                    obj = cmd.ExecuteScalar();
                    ///当某些值为空字符---“”的时候，客户端会出错，可能是wcf并不支持这种类型的传输
                    if (obj == null)
                        return null;
                    string s = obj.ToString();
                    if (string.IsNullOrEmpty(s))
                        obj = null;
                }
                catch (Exception e)
                {
                    //    MessageService.AddMessage(MessageLevel.Fatal, e.ToString(), 0);
                    DataCenter.WriteLogFile(e.ToString() + "---执行SQL语句:" + strSQL);
                }
                finally
                {
                    CloseConnect();
                }
                return obj;
            }
        }


        public int ExecuteSQL(string strSQL)
        {
            lock (olock)
            {
                Int64 startTime = Stopwatch.GetTimestamp();//获取计时器机制中当前时间的最小单位数　可以理解为时钟周期
                string SQL;
              //  SQL = myAlarmCenterCore.ConvertAccessSQL2SQLServerSQL(strSQL);

                int k = 0;
                try
                {
                    CheckConnectState();
                    cmd = new MySqlCommand(strSQL, conn);

                    //if (!rd.IsClosed)
                    //    rd.Close();

                    k = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    //    MessageService.AddMessage(MessageLevel.Fatal, e.ToString(), 0);
                    DataCenter.WriteLogFile(e.ToString() + "---执行SQL语句:" + strSQL);
                }
                finally
                {
                    CloseConnect();
                    double fStoreSecs = (Stopwatch.GetTimestamp() - startTime) / (double)Stopwatch.Frequency;
                    if (fStoreSecs > DataCenter.ExecSQLTipsSec)
                        MessageService.AddMessage(MessageLevel.Warn, $"执行SQL语句【{strSQL}】耗时过长，执行时间{fStoreSecs}秒，可能需要优化整理数据表!", -1, false);
                }
                return k;
            }
        }

        public bool JudgeColumnInTable(string ColumnNm, string TableNm)
        {
            string csSQL = string.Format("select * from {0}", TableNm);
            DataTable dt = GetDataTableFromSQL(csSQL);
            return dt.Columns.Contains(ColumnNm) ? true : false;
        }

    }
}
