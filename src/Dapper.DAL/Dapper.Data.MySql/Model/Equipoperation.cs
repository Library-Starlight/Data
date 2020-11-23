using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Equipoperation
    {
        public string StaNm { get; set; }
        public string EquipId { get; set; }
        public int? OperationId { get; set; }
        public string OperationTitle { get; set; }
    }
}
