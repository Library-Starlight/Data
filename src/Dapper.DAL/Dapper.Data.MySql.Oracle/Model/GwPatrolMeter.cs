using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class GwPatrolMeter
    {
        public int MeterId { get; set; }
        public string MeterNo { get; set; }
        public int? RouteId { get; set; }
    }
}
