using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class GwPatrolRoutesetting
    {
        public int SetId { get; set; }
        public int? RouteId { get; set; }
        public int? LocusId { get; set; }
        public int? StayTime { get; set; }
        public int? Orders { get; set; }
    }
}
