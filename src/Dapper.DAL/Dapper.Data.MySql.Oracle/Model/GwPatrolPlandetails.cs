using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class GwPatrolPlandetails
    {
        public int? PlanTableId { get; set; }
        public int? RouteId { get; set; }
        public string LocusId { get; set; }
        public int? InspectorId { get; set; }
        public int? State { get; set; }
        public string ExceptionId { get; set; }
    }
}
