using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwPatrolRoute
    {
        public int RouteId { get; set; }
        public string RouteName { get; set; }
        public int? ParentId { get; set; }
    }
}
