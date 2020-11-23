using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwPatrolPatrolgroup
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int? ParentId { get; set; }
    }
}
