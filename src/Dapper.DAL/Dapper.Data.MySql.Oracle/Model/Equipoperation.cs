using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Equipoperation
    {
        public string StaNm { get; set; }
        public string EquipId { get; set; }
        public int? OperationId { get; set; }
        public string OperationTitle { get; set; }
    }
}
