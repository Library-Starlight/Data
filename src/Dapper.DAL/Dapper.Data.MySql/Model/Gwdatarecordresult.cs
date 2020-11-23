using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Gwdatarecordresult
    {
        public DateTime? RecordTime { get; set; }
        public int? EquipNo { get; set; }
        public string DataType { get; set; }
        public int? YcyxNo { get; set; }
        public string DataName { get; set; }
        public string DataValue { get; set; }
    }
}
