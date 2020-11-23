using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwPatrolPlantabletimelist
    {
        public int? PlanTableTimeListId { get; set; }
        public int? PlanTableId { get; set; }
        public DateTime? FromTime { get; set; }
        public DateTime? ToTime { get; set; }
        public int? Orders { get; set; }
    }
}
