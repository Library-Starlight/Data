using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class GwPatrolPatrolgroup
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int? ParentId { get; set; }
    }
}
