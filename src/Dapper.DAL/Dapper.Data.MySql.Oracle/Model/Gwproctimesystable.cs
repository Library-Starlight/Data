using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Gwproctimesystable
    {
        public int Id { get; set; }
        public int? TableId { get; set; }
        public int? ProcCode { get; set; }
        public string CmdNm { get; set; }
    }
}
