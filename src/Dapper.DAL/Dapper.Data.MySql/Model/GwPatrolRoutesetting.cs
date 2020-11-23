using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwPatrolRoutesetting
    {
        public int SetId { get; set; }
        public int? RouteId { get; set; }
        public int? LocusId { get; set; }
        public DateTime? ArriaveTime { get; set; }
        public int? StayTime { get; set; }
        public int? Orders { get; set; }
    }
}
