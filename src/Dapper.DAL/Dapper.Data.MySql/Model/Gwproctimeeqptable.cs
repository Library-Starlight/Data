using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class Gwproctimeeqptable
    {
        public int Id { get; set; }
        public int? TableId { get; set; }
        public DateTime? Time { get; set; }
        public DateTime? TimeDur { get; set; }
        public int? EquipNo { get; set; }
        public int? SetNo { get; set; }
        public string Value { get; set; }
    }
}
