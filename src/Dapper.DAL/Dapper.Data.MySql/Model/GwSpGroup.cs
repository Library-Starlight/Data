using System;
using System.Collections.Generic;

#nullable disable

namespace Dapper.Data.MySql.Model
{
    public partial class GwSpGroup
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public string GroupList { get; set; }
    }
}
