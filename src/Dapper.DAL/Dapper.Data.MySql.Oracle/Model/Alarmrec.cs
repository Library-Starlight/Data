using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Alarmrec
    {
        public string ProcName { get; set; }
        public string Administrator { get; set; }
        public string Event { get; set; }
        public string Comment { get; set; }
    }
}
