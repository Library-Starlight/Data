using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class GwPatrolResult
    {
        public string RouteName { get; set; }
        public string LocusCardNo { get; set; }
        public string LocusName { get; set; }
        public string InspectorName { get; set; }
        public string StateName { get; set; }
        public string ExceptionName { get; set; }
    }
}
