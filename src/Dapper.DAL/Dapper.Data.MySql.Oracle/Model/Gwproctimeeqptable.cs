using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class Gwproctimeeqptable
    {
        public int Id { get; set; }
        public int? TableId { get; set; }
        public int? EquipNo { get; set; }
        public int? SetNo { get; set; }
        public string Value { get; set; }
    }
}
