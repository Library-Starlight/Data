using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwPatrolResult
    {
        public string RouteName { get; set; }
        public string LocusCardNo { get; set; }
        public string LocusName { get; set; }
        public string InspectorName { get; set; }
        public DateTime? BeginTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? ArrivedTime { get; set; }
        public string StateName { get; set; }
        public string ExceptionName { get; set; }
    }
}
