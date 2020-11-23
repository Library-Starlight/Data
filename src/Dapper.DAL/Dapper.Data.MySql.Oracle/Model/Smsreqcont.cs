using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Smsreqcont
    {
        public int? ReqId { get; set; }
        public string Task { get; set; }
        public string Type { get; set; }
        public int? EquipNo { get; set; }
        public int? YcYxNo { get; set; }
        public string MainInstruction { get; set; }
        public string MinorInstruction { get; set; }
        public string Value { get; set; }
        public string Remark { get; set; }
    }
}
