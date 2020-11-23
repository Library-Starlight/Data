using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwPatrolPlandetail
    {
        public int? PlanTableId { get; set; }
        public int? RouteId { get; set; }
        public string LocusId { get; set; }
        public int? InspectorId { get; set; }
        public DateTime? BeginTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? ArrivedTime { get; set; }
        public int? State { get; set; }
        public string ExceptionId { get; set; }
    }
}
