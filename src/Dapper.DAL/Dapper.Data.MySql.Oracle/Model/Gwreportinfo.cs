using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Gwreportinfo
    {
        public int Id { get; set; }
        public string ReportName { get; set; }
        public string Describe { get; set; }
        public string FileName { get; set; }
        public string DllName { get; set; }
    }
}
