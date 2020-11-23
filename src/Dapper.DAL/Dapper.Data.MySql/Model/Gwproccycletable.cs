using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Gwproccycletable
    {
        public int TableId { get; set; }
        public int DoOrder { get; set; }
        public string Type { get; set; }
        public int? EquipNo { get; set; }
        public int? SetNo { get; set; }
        public string Value { get; set; }
        public int? ProcCode { get; set; }
        public string CmdNm { get; set; }
        public int? SleepTime { get; set; }
        public string SleepUnit { get; set; }
        public string Reserve1 { get; set; }
        public string Reserve2 { get; set; }
        public string Reserve3 { get; set; }
    }
}
