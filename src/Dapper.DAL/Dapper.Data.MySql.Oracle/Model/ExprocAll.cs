using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class ExprocAll
    {
        public int? ProcCode { get; set; }
        public string ProcModule { get; set; }
        public string ProcName { get; set; }
        public string ProcParm { get; set; }
        public string Comment { get; set; }
    }
}
