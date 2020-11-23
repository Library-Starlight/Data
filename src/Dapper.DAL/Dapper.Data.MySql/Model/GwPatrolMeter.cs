using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwPatrolMeter
    {
        public int MeterId { get; set; }
        public string MeterNo { get; set; }
        public int? RouteId { get; set; }
    }
}
