using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Gwproctimesystable
    {
        public int Id { get; set; }
        public int? TableId { get; set; }
        public DateTime? Time { get; set; }
        public DateTime? TimeDur { get; set; }
        public int? ProcCode { get; set; }
        public string CmdNm { get; set; }
    }
}
