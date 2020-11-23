using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class GwPatrolRoute
    {
        public int RouteId { get; set; }
        public string RouteName { get; set; }
        public int? ParentId { get; set; }
    }
}
