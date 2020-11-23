using System;
using System.Collections.Generic;

namespace Dapper.Data.MySql.Oracle.Model
{
    public partial class GwSpGroup
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public string GroupList { get; set; }
    }
}
