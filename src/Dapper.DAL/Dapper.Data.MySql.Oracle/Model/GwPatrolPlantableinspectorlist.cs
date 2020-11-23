using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class GwPatrolPlantableinspectorlist
    {
        public int? PlanTableInspectorListId { get; set; }
        public int? PlanTableId { get; set; }
        public int? InspectorId { get; set; }
        public int? Orders { get; set; }
    }
}
