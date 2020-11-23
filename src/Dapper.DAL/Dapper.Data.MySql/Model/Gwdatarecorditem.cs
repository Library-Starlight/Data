using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Gwdatarecorditem
    {
        public int? EquipNo { get; set; }
        public string DataType { get; set; }
        public int? YcyxNo { get; set; }
        public string DataName { get; set; }
        public string UserName { get; set; }
    }
}
