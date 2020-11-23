using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Gwproccycletlist
    {
        public int TableId { get; set; }
        public string TableName { get; set; }
        public int? ZhenDianDo { get; set; }
        public int? ZhidingDo { get; set; }
        public int? CycleMustFinish { get; set; }
        public int? MaxCycleNum { get; set; }
        public string Reserve1 { get; set; }
        public string Reserve2 { get; set; }
        public string Reserve3 { get; set; }
        public string Reference { get; set; }
    }
}
