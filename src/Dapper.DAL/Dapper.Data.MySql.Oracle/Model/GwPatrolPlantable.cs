using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class GwPatrolPlantable
    {
        public int? PlanTableId { get; set; }
        public int? PlanMode { get; set; }
        public int? RouteId { get; set; }
        public int? Permit { get; set; }
        public int? Later { get; set; }
    }
}
