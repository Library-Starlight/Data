using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwPatrolPlantable
    {
        public int? PlanTableId { get; set; }
        public DateTime? ExecuteDate { get; set; }
        public int? PlanMode { get; set; }
        public int? RouteId { get; set; }
        public int? Permit { get; set; }
        public int? Later { get; set; }
    }
}
